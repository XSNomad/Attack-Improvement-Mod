using BattleTech;
using BattleTech.UI;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sheepy.BattleTechMod.AttackImprovementMod {
   using static Mod;
   using static FiringPreviewManager.TargetAvailability;

   public class RollModifier : BattleModModule {

      private static float BaseHitChanceModifier, MeleeHitChanceModifier, HitChanceStep, MaxFinalHitChance, MinFinalHitChance;

      public override void CombatStartsOnce () {
         BaseHitChanceModifier = (float) Settings.BaseHitChanceModifier;
         MeleeHitChanceModifier = (float) Settings.MeleeHitChanceModifier;
         HitChanceStep = (float) Settings.HitChanceStep;
         MaxFinalHitChance = (float) Settings.MaxFinalHitChance;
         MinFinalHitChance = (float) Settings.MinFinalHitChance;

         Type ToHitType = typeof( ToHit );
         if ( Settings.AllowNetBonusModifier && ! Settings.DiminishingHitChanceModifier )
            Patch( ToHitType, "GetSteppedValue", new Type[]{ typeof( float ), typeof( float ) }, "ProcessNetBonusModifier", null );
         if ( BaseHitChanceModifier != 0 )
            Patch( ToHitType, "GetBaseToHitChance", new Type[]{ typeof( AbstractActor ) }, null, "ModifyBaseHitChance" );
         if ( MeleeHitChanceModifier != 0 )
            Patch( ToHitType, "GetBaseMeleeToHitChance", new Type[]{ typeof( Mech ) }, null, "ModifyBaseMeleeHitChance" );

         if ( Settings.HitChanceStep != 0.05m || Settings.MaxFinalHitChance != 0.95m || Settings.MinFinalHitChance != 0.05m || Settings.DiminishingHitChanceModifier ) {
            if ( ! Settings.DiminishingHitChanceModifier )
               Patch( ToHitType, "GetUMChance", new Type[]{ typeof( float ), typeof( float ) }, "OverrideHitChanceStepNClamp", null );
            else {
               Patch( ToHitType, "GetUMChance", new Type[]{ typeof( float ), typeof( float ) }, "OverrideHitChanceDiminishing", null );
               diminishingBonus = new float[ Settings.DiminishingBonusMax ];
               diminishingPenalty = new float[ Settings.DiminishingPenaltyMax ];
               TryRun( ModLog, FillDiminishingModifiers );
            }
         }

         if ( Settings.SmartIndirectFire ) {
            Patch( typeof( FiringPreviewManager ), "GetPreviewInfo", null, "SmartIndirectFireLoF" );
            if ( Settings.SmartIndirectFireRequiresMultiTarget )
               PilotMultiTarget = new Dictionary<string, bool>();
         }

         if ( Settings.FixSelfSpeedModifierPreview ) {
            Patch( ToHitType, "GetSelfSpeedModifier", new Type[]{ typeof( AbstractActor ) }, null, "Preview_SelfSpeedModifier" );
            Patch( ToHitType, "GetSelfSprintedModifier", new Type[]{ typeof( AbstractActor ) }, null, "Preview_SelfSprintedModifier" );
         }
      }

      public override void CombatStarts () {
         if ( Settings.AllowNetBonusModifier ) {
            CombatResolutionConstantsDef con = CombatConstants.ResolutionConstants;
            con.AllowTotalNegativeModifier = true;
            typeof( CombatGameConstants ).GetProperty( "ResolutionConstants" ).SetValue( CombatConstants, con, null );
         }
         if ( Settings.AllowLowElevationPenalty ) {
            ToHitConstantsDef con = CombatConstants.ToHit;
            con.ToHitElevationApplyPenalties = true;
            typeof( CombatGameConstants ).GetProperty( "ToHit" ).SetValue( CombatConstants, con, null );
         }
         if ( Settings.AllowNetBonusModifier && steppingModifier == null && ! Settings.DiminishingHitChanceModifier )
            TryRun( ModLog, FillSteppedModifiers );
      }

      public override void CombatEnds () {
         PilotMultiTarget?.Clear();
      }

      // ============ Preparations ============

      private static float[] steppingModifier, diminishingBonus, diminishingPenalty;

      private static void FillSteppedModifiers () {
         List<float> mods = new List<float>(22);
         float lastMod = float.NaN;
         for ( int i = 1 ; ; i++ ) {
            float mod = GetSteppedModifier( i );
            if ( float.IsNaN( mod ) || mod == lastMod ) break;
            mods.Add( mod );
            if ( mod == 0 || mod <= -1f ) break;
            lastMod = mod;
         }
         steppingModifier = mods.ToArray();
         Info( "Stepping ToHit Multipliers {0}", steppingModifier );
      }

      internal static float GetSteppedModifier ( float modifier ) {
         int[] Levels = CombatConstants.ToHit.ToHitStepThresholds;
         float[] values = CombatConstants.ToHit.ToHitStepValues;
         int mod = Mathf.RoundToInt( modifier ), lastLevel = int.MaxValue;
         float result = 0;
         for ( int i = Levels.Length - 1 ; i >= 0 ; i-- ) {
            int level = Levels[ i ];
            if ( mod < level ) continue;
            int modInLevel = Mathf.Min( mod - level, lastLevel - level );
            result -= modInLevel * values[ i ];
            lastLevel = level;
         }
         return result;
      }

      private static void FillDiminishingModifiers () {
         double bonusBase = (double) Settings.DiminishingBonusPowerBase, bonusDiv = (double) Settings.DiminishingBonusPowerDivisor;
         double penaltyBase = (double) Settings.DiminishingPenaltyPowerBase, penaltyDiv = (double) Settings.DiminishingPenaltyPowerDivisor;
         for ( int i = 1 ; i <= Settings.DiminishingBonusMax ; i++ )
            diminishingBonus[ i-1 ] = (float) ( 2.0 - Math.Pow( bonusBase, i / bonusDiv ) );
         for ( int i = 1 ; i <= Settings.DiminishingPenaltyMax ; i++ )
            diminishingPenalty[ i-1 ] = (float) Math.Pow( penaltyBase, i / penaltyDiv );
         Info( "Diminishing hit% multipliers (bonus) {0}", diminishingBonus );
         Info( "Diminishing hit% multipliers (penalty) {0}", diminishingPenalty );
      }

      // ============ Fixes ============

      public static void ModifyBaseHitChance ( ref float __result ) {
         __result += BaseHitChanceModifier;
      }

      public static void ModifyBaseMeleeHitChance ( ref float __result ) {
         __result += MeleeHitChanceModifier;
      }

      [ Harmony.HarmonyPriority( Harmony.Priority.Low ) ]
      public static bool ProcessNetBonusModifier ( ref float __result, float originalHitChance, float modifier ) {
         int mod = Mathf.RoundToInt( modifier );
         __result = originalHitChance;
         if ( mod < 0 ) { // Bonus
            mod = Math.Min( -mod, steppingModifier.Length );
            __result -= steppingModifier[ mod - 1 ];
         }  else if ( mod > 0 ) { // Penalty
            mod = Math.Min( mod, steppingModifier.Length );
            __result += steppingModifier[ mod - 1 ];
         }
         //Log( "ProcessNetBonusModifier - Base Hit {0}, Modifier {1}, result {2}", originalHitChance, modifier, __result );
         return false;
      }

      [ Harmony.HarmonyPriority( Harmony.Priority.Low ) ]
      public static bool OverrideHitChanceStepNClamp ( ToHit __instance, ref float __result, float baseChance, float totalModifiers ) {
         // A pretty intense routine that AI use to evaluate attacks, try catch disabled.
         //Log( "OverrideHitChanceStepNClamp - Base Hit {0}, Modifier {1}", baseChance, totalModifiers );
         __result = ClampHitChance( __instance.GetSteppedValue( baseChance, totalModifiers ) );
         return false;
      }

      [ Harmony.HarmonyPriority( Harmony.Priority.Low ) ]
      public static bool OverrideHitChanceDiminishing ( ToHit __instance, ref float __result, float baseChance, float totalModifiers ) { try {
         // A pretty intense routine that AI use to evaluate attacks
         int mod = Mathf.RoundToInt( totalModifiers );
         if ( mod < 0 ) {
            mod = Math.Min( Settings.DiminishingBonusMax, -mod );
            baseChance *= diminishingBonus  [ mod -1 ];
         } else if ( mod > 0 ) {
            mod = Math.Min( Settings.DiminishingPenaltyMax, mod );
            baseChance *= diminishingPenalty[ mod -1 ];
         }
         __result = ClampHitChance( baseChance );
         return false;
      }                 catch ( Exception ex ) { return Error( ex ); } }

      public static float StepHitChance( float chance ) {
         float step = HitChanceStep;
         if ( step > 0f ) {
            chance += step/2f;
            chance -= chance % step;
         }
         return chance;
      }

      public static float ClampHitChance( float chance ) {
         chance = StepHitChance( chance );
         if      ( chance >= MaxFinalHitChance ) return MaxFinalHitChance;
         else if ( chance <= MinFinalHitChance ) return MinFinalHitChance;
         return chance;
      }

      // ============ Smart Indirect Fire ============

      private static Dictionary<string, bool> PilotMultiTarget;

      [ Harmony.HarmonyPriority( Harmony.Priority.High ) ] // Earlier than LineOfSight.SetupLOS
      public static void SmartIndirectFireLoF ( FiringPreviewManager __instance, ref FiringPreviewManager.PreviewInfo __result, ICombatant target ) {
         if ( __result.availability != PossibleDirect ) return;
         AbstractActor actor = HUD?.SelectedActor;
         SelectionState selection = HUD.SelectionHandler.ActiveState;
         float dist = Vector3.Distance( selection.PreviewPos, target.CurrentPosition );
         foreach ( Weapon w in actor.Weapons ) // Don't change LoF if any direct weapon is enabled and can shot
            if ( ! w.IndirectFireCapable && w.IsEnabled && w.MaxRange > dist && w.CanFire ) return;
               //Verbo( "Smart indirect blocked by {0}: {1}, {2}, {3}, {4}, {5}", w, dist, w.MaxRange, w.IsDisabled, w.IsEnabled, w.IndirectFireCapable );
         if ( ! ShouldSmartIndirect( actor, selection.PreviewPos, selection.PreviewRot, target ) ) return;
         __result.availability = PossibleIndirect;
      }

      private static bool ShouldSmartIndirect ( AbstractActor attacker, Vector3 attackPosition, Quaternion attackRotation, ICombatant target ) {
         if ( Combat.ToHit.GetIndirectModifier( attacker ) >= CombatConstants.ToHit.ToHitCoverObstructed ) return false;
         Vector3 targetPos = target.CurrentPosition;
         if ( ! attacker.IsTargetPositionInFiringArc( target, attackPosition, attackRotation, targetPos ) ) return false;
         if ( ! PassMultiTarget( attacker ) ) return false;
         float dist = Vector3.Distance( attackPosition, targetPos );
         foreach ( Weapon w in attacker.Weapons ) // Check that we have any indirect weapon that can shot
            if ( w.IndirectFireCapable && w.IsEnabled && w.MaxRange > dist && w.CanFire ) {
               LineOfFireLevel lof = Combat.LOFCache.GetLineOfFire( attacker, attackPosition, target, target.CurrentPosition, target.CurrentRotation, out _ );
               return lof == LineOfFireLevel.LOFObstructed;
            }
         return false;
      }

      private static bool PassMultiTarget ( AbstractActor attacker ) {
         if ( ! Settings.SmartIndirectFireRequiresMultiTarget ) return true;
         if ( ! PilotMultiTarget.TryGetValue( attacker.GetPilot().GUID, out bool hasMultiTarget ) ) {
            foreach ( Ability ability in attacker.GetPilot().ActiveAbilities )
               if ( ability.Def.Targeting == AbilityDef.TargetingType.MultiFire ) {
                  PilotMultiTarget[ attacker.GetPilot().GUID ] = hasMultiTarget = true;
                  break;
               }
         }
         return hasMultiTarget;
      }

      // ============ Previews ============

      // Set self walked modifier when previewing movement
      public static void Preview_SelfSpeedModifier ( ref float __result, AbstractActor attacker ) {
         if ( __result != 0 || ! ( attacker is Mech mech ) || mech.HasMovedThisRound ) return;
         SelectionState state = HUD?.SelectionHandler?.ActiveState;
         if ( state == null || ! ( state is SelectionStateMoveBase ) ) return;
         float movement = Vector3.Distance( mech.CurrentPosition, state.PreviewPos );
         if ( movement <= 10 ) return;
         switch ( mech.weightClass ) {
            case WeightClass.LIGHT   : __result = CombatConstants.ToHit.ToHitSelfWalkLight  ; break;
            case WeightClass.MEDIUM  : __result = CombatConstants.ToHit.ToHitSelfWalkMedium ; break;
            case WeightClass.HEAVY   : __result = CombatConstants.ToHit.ToHitSelfWalkHeavy  ; break;
            case WeightClass.ASSAULT : __result = CombatConstants.ToHit.ToHitSelfWalkAssault; break;
         }
      }

      // Set self sprint modifier when previewing movement
      public static void Preview_SelfSprintedModifier ( ref float __result, AbstractActor attacker ) {
         if ( __result != 0 || ! ( attacker is Mech mech ) || mech.HasSprintedThisRound ) return;
         SelectionState state = HUD?.SelectionHandler?.ActiveState;
         if ( state == null || ! ( state is SelectionStateSprint sprint ) ) return;
         __result = CombatConstants.ToHit.ToHitSelfSprinted;
      }

      public static float GetJumpedModifier ( AbstractActor attacker ) {
         float movement = -1;
         if ( attacker.HasMovedThisRound && attacker.JumpedLastRound ) {
            movement = attacker.DistMovedThisRound;
         } else if ( Settings.FixSelfSpeedModifierPreview ) {
            SelectionState state = HUD?.SelectionHandler?.ActiveState;
            if ( state != null && state is SelectionStateJump jump )
               movement = 100; // Vector3.Distance( attacker.CurrentPosition, jump.PreviewPos );
         }
         if ( movement <= 0 ) return 0;
         return Settings.ToHitSelfJumped;
      }
   }
}