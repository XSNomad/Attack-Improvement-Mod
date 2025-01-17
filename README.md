<body>
   <h1 id="AIM4.0">Attack Improvement Mod 4.0.0 Development Alpha</h1>

<p>For BATTLETECH 1.9.1R686(Final) ModTek 8.0 Compatible</p>

<p>This is a Development Build licensed under GNU Affero General Public License, Version 3. </p>

<h1 id="aimattackimprovementmod30development">AIM - Attack Improvement Mod 3.0</h1>

<p>For BATTLETECH 1.2.1</p>

<ul>
<li><a href="#featuresoverview">Features Overview</a></li>

<li><a href="#installation">Installation</a></li>

<li><a href="#configuration">Configuration</a></li>

<li><a href="#settings">Settings</a>


<ul>
<li><a href="#hudsettings">HUD Settings</a></li>

<li><a href="#combatinformationsettings">Combat Information Settings</a></li>

<li><a href="#calledshotsettings">Called Shot Settings</a></li>

<li><a href="#meleeanddfasettings">Melee and DFA Settings</a></li>

<li><a href="#individualmodifiersettings">Individual Modifier Settings</a></li>

<li><a href="#nethitmodifiersettings">Net Hit Modifier Settings</a></li>

<li><a href="#hitrollsettings">Hit Roll Settings</a></li>

<li><a href="#hitchancepreviewsettings">Hit Chance Preview Settings</a></li>

<li><a href="#criticalhitsettings">Critical Hit Settings</a></li>

<li><a href="#hitresolutionsettings">Hit Resolution Settings</a></li>

<li><a href="#attacklogsettings">Attack Log Settings</a></li></ul>
</li>

<li><a href="#compatibilities">Compatibilities</a></li>

<li><a href="#thestoryofaim">The Story of AIM</a></li>

<li><a href="#learntomod">Learn to Mod</a></li>

<li><a href="#credits">Credits</a></li>
</ul>

<p>AIM is a BattleTech mod that fixes, enhances, and customise your combat experience, such as coloured facing rings and targeting lines, tune down roll correction, show target and weapon information, or a detailed attack log.  The default settings aim to preserve the balance of vanilla game.</p>

<p>This mod does <em>not</em> modify game data.  Saves made with this mod on will <em>not</em> be affected by disabling or removing this mod.</p>

<h1 id="featuresoverview">Features Overview</h1>

<p><strong>ALL features can be enabled or disabled individually.</strong></p>

<h2 id="bugfixesandhudenhancements">Bug Fixes and HUD Enhancements</h2>

<ul>
<li>Fix called shot weight and precision, Multi-Target cancelling, and 0 hp unit/locations.</li>

<li>Fix Delta LRM stability, ER PPC debuff, and other minor weapon bugs.</li>

<li>Line of fire fixed and coloured: Dotted = indirect, Cyan = flank, Green = rear.</li>

<li>Press F1 to F4 to select mech. Shift+Tab to reverse select mech. Grey name = acted mech.</li>

<li>Multi-Target mode: Shift+Click / Ctrl+click weapon to reverse/toggle selection.</li>

<li>Coloured nameplate, facing ring, and floating armour bar.</li>

<li>Coloured weapon loadout with individual damage, melee damage, and alpha damage.</li>

<li>See heat, instability, distance, movement numbers, and enemy abilities.</li>

<li>See structural damage through armour. See ammo count in paper doll hover.</li>

<li>See mechwarrior stats in hover/right-click hint. See enemy wounds in names.</li>

<li>See total damage and average damage.  Press Alt to see heat and stability.</li>

<li>See terrain description always.  Bigger, more, and brighter terrain dots.</li>

<li>Enhanced accuracy breakdown and weapon properties popup with fixed sign.</li>

<li>Post-move to-hit penalties and heat factored in action preview.</li>

<li>Miss floatie shows margin of miss.</li>

<li>(Optional) Show Mech Tonnage.</li>

<li>(Optional) Show Corrected Hit chance and Called Shot Chance.</li>
</ul>

<h2 id="mechanicenhancements">Mechanic Enhancements</h2>

<ul>
<li>Unlock hit chance stepping (makes odd Gunnery useful).</li>

<li>Smart indirect fire when direct fire is obstructed.</li>

<li>Called shots cluster around called mech location.</li>

<li>More melee modifiers, and fixes the absent of stood up penalty.</li>

<li>Add flank/rear attack bonus and negative height modifier.</li>

<li>Allow net bonus hit modifiers.</li>

<li>Remove melee position locking.</li>

<li>Ammo loader AI that balance ammo usage to minimise explosion.</li>

<li>Auto jettison useless ammo.</li>
</ul>

<h2 id="newcriticalhitsystem">New Critical Hit System</h2>

<ul>
<li>Skip criting the dead mechs.</li>

<li>Vehicle and turret critical hits.</li>

<li>Critical hits follow damage transfer.</li>

<li>Prevent critical hit on locations with intact structure.</li>

<li>Give normal crit chance to NPC allies.  Enemies adjustable.</li>

<li>(Optional) Adjust normal critical hit chances and mix/max cap.</li>

<li>(Optional) Allow Through Armour Critical hit (TAC).</li>

<li>(Optional) Allow critical hit reroll and location transfer.</li>

<li>(Optional) Allow multiple critical hits per weapon.</li>
</ul>

<h2 id="otheradjustables">Other Adjustables</h2>

<ul>
<li>Tabular attack log that can be opened directly in Excel.</li>

<li>Old attack logs are archived and auto-deleted in background.</li>

<li>Adjustable roll correction strength, default halved.</li>

<li>Adjustable miss streak breaker.</li>

<li>Adjustable base hit chances.</li>

<li>Adjustable hit chance stepping and min/max cap.</li>

<li>Adjustable attack modifier list.</li>

<li>Control display precision of hit chance and called shot chance.</li>
</ul>

<h1 id="installation">Installation</h1>

<ol>
<li>Install <a href="https://github.com/janxious/ModTek/wiki/The-Drop-Dead-Simple-Guide-to-Installing-BTML-&amp;-ModTek-&amp;-ModTek-mods">BTML and ModTek</a>.</li>

<li><a href="https://github.com/Sheep-y/Attack-Improvement-Mod/releases">Download this mod</a>, extract in the mod folder. i.e. You should see <code>BATTLETECH\Mods\AttackImprovementMod\mod.json</code></li>

<li>Launch the game. The mod will creates a "settings.json" and a mod log in the same folder as <code>mod.json</code>.</li>

<li>Open <code>settings.json</code> to see mod settings.  If you want to change it, restart game to apply changes.</li>
</ol>

<h1 id="configuration">Configuration</h1>

<p>When the mod is loaded, it will read <code>settings.json</code> and validate its.
If the setting file does not exist, it will be created.</p>

<p>Several presets are bundled with this mod.  You may copy or rename a setting to <code>settings.json</code> to apply it.</p>

<ul>
<li><code>settings.default.json</code> - Out of box default.  Game is subtly enhanced, such as lower roll correction, hit stepping and melee position unlock, flanking bonus, and critical hit on non-mechs.</li>

<li><code>settings.spartan.json</code> - Enable diminishing modifier, more bonus and penalties, through armour crit, crit reroll, enemy ammo balancing and jettison, and disables roll correction and streak breaker.</li>

<li><code>settings.ui-enhance.json</code> - Only enable game fixes and user interface enhancements.  Game mechanic is not changed beyond bug fixes.</li>

<li><code>settings.fix-only.json</code> - Only enable game fixes for a bug-free, pure vanilla experience.</li>

<li><code>settings.log-only.json</code> - An old preset that should be deleted.  Use fix-only instead.</li>
</ul>

<p>Note that <code>settings.json</code> is auto-managed.  Old settings will be upgraded and removed, out of range settings will be corrected, and the formats and comments cannot be changed.
You can only change setting values.</p>

<p>This mod is designed to run as fast as it can be.
Disabled features won't slow down the game and does not modify any code, and heavy calculations are cached or optimised.</p>

<p>Because of high number of features and flexibility, bugs may slip through tests.
Please report them on <a href="https://github.com/Sheep-y/Attack-Improvement-Mod/issues">GitHub</a> or <a href="https://www.nexusmods.com/battletech/mods/242?tab=bugs">Nexus</a>.</p>

<h1 id="settings">Settings</h1>

<p>These settings can be changed in <code>settings.json</code>.</p>

<h2 id="hudsettings">HUD Settings</h2>

<p><strong>Selections</strong></p>

<blockquote>
  <p>Setting: <code>FunctionKeySelectPC</code>  (true/false, default true)</p>
  
  <p>When true, F1 to F4 keys can be used to select player mechs.</p>
  
  <p>The keys will stop to work if they are already binded.
  Also, because the keys are hard-coded and not keybinds, this will not change game settings or game profile.
  <br></p>
  
  <p>Setting: <code>ShiftKeyReverseSelection</code>  (true/false, default true)</p>
  
  <p>When the Shift key is holded, target selection will be reversed:</p>
  
  <p>Shift+Tab will select the previous target, Shift+Brace will select in the reverse direction,
  while Shift+Click during Multi-Target will goes from C to B, B to A, and A to disable.
  <br></p>
  
  <p>Setting: <code>CtrlClickDisableWeapon</code>  (true/false, default true)</p>
  
  <p>When true, Ctrl+Click a weapon during Multi-Target will disable / enable the weapon.
  The target will be remembered when the weapon is enabled this way, allowing quick evaluation of heat and damage.</p>
</blockquote>

<p><strong>Actions</strong></p>

<blockquote>
  <p>Setting: <code>SmartIndirectFire</code>  (true/false, default true)</p>
  
  <p>When true, indirect fire will be used for indirect-fire-capable weapons,
  if line of fire is obstructed and indirect penalty is less than obstructed penalty.</p>
  
  <p>This setting applies equally to both players and enemies.
  <br></p>
  
  <p>Setting: <code>FixMultiTargetBackout</code>  (true/false, default true)</p>
  
  <p>The game's Muti-Target back out (escape/right click) is bugged
  Backing out from first target will cancel the action, and second back out will always cancel the whole thing (regardless of target).</p>
  
  <p>When true, this mod will make Multi-Target back out from selected targets one by one as expected.
  <br></p>
  
  <p>Setting: <code>AggressiveMultiTargetAssignment</code>  (true/false, default true)</p>
  
  <p>When you select a new target with the Multi-Target skill, all enabled weapons will be reassigned.
  Each weapon will reset to the target with highest hit chance, or the earlier target when hit chances are the same
  (A before B, B before C).
  <br></p>
  
  <p>Setting: <code>ShowMissMargin</code>  (true/false, default true)</p>
  
  <p>When true, the "MISS" floaties will be appended with a % of how much the shot missed.</p>
  
  <p>For example, "Miss 12%" means the shot was 12% from hitting.
  If the shot had a 80% hit chance, then the attack roll was 92 (after roll correction).</p>
</blockquote>

<p><strong>Terrain Dots</strong></p>

<blockquote>
  <p>Setting: <code>SpecialTerrainDotSize</code>  (small positive number, default 2)<br>
  Setting: <code>NormalTerrainDotSize</code>   (small positive number, default 1.25)<br></p>
  
  <p>Change the size of terrain dots.  1 is default size, 2 doubles the diameter, 0.5 halves.
  <br></p>
  
  <p>Setting: <code>BoostTerrainDotColor</code>  (true/false, default true)</p>
  
  <p>When true, strengthen the colour of special terrain dots to make them easier to see.
  <br></p>
  
  <p>Setting: <code>MovementPreviewRadius</code>  (small positive integer, default 6)</p>
  
  <p>When non-zero, dots within this grid radius will be displayed during movement preview.</p>
  
  <p>This setting simply override <code>MoveConstants.ExperimentalHexRadius</code> in <code>CombatConstants.json</code>.</p>
  
  <p>Because settings this too high will overflow the game's dot buffer, it is hard-caped to 16.
  The exact crash point will depends on terrain and mech.</p>
</blockquote>

<p><strong>Terrain Descriptions And Effects</strong></p>

<blockquote>
  <p>Setting: <code>ShowDangerousTerrain</code>  (true/false, default true)</p>
  
  <p>When true, dangerous terrain will show both terrain description and danger description,
  instead of danger description overriding terrain description.
  <br></p>
  
  <p>Setting: <code>ShowMeleeTerrain</code>  (true/false, default true)</p>
  
  <p>When true, terrain description will be displayed in melee and DFA preview,
  and the terrain reticle will be labeled with the action.
  <br></p>
  
  <p>Setting: <code>FixHeatPreview</code>  (true/false, default true)</p>
  
  <p>When true, previewed move destination's terrain will be factored in heat preview, plus any heat effects en-route.
  For example, moving into water will predict more cooldown and vice versa.
  <br></p>
  
  <p>Setting: <code>FixLosPreviewHeight</code>  (true/false, default true)</p>
  
  <p>Walk and Jump will sometimes predicts different Line of Sight, because their preview height is slightly different from each other.
  When true, they will be made the same.</p>
</blockquote>

<p><strong>Nameplates</strong></p>

<blockquote>
  <p>Setting: <code>NameplateColourPlayer</code>  (color string, default "#CFC")<br>
  Setting: <code>NameplateColourEnemy</code>  (color string, default "#FBB")<br>
  Setting: <code>NameplateColourAlly</code>  (color string, default "#8FF")<br>
  Setting: <code>FloatingArmorColourPlayer</code>  (color string, default "#CFC")<br>
  Setting: <code>FloatingArmorColourEnemy</code>  (color string, default "#FBB")<br>
  Setting: <code>FloatingArmorColourAlly</code>  (color string, default "#8FF")<br></p>
  
  <p>When non-empty, change colours of nameplate text and armour bars, making it easier to tell friends from foes.
  <br></p>
  
  <p>Setting: <code>ShowPlayerHealth</code>  (format string, default ", HP {2}/{3}")<br>
  Setting: <code>ShowEnemyWounds</code>  (format string, default ", Wounds {1}")<br>
  Setting: <code>ShowAllyHealth</code>  (format string, default ", HP {2}/{3}")<br></p>
  
  <p>When non-empty, units that are wounded will have its injuries or health displayed after pilot name.
  {0} is pilot name, {1} is injury, {2} is (health - injury), and {3} is health.</p>
  
  <p>The wounds or health only display when the unit is wounded.
  Note that enemy's health is unknown to players by design.  {2} and {3} will show "?" when used.</p>
</blockquote>

<p><strong>Facing Rings Colours</strong></p>

<blockquote>
  <p>Setting: <code>FacingMarkerPlayerColors</code>  (default "#FFFA,#CFCA,#CFCA,#AFAC,#FF8A")<br>
  Setting: <code>FacingMarkerEnemyColors</code>  (default "#FFFA,#FCCA,#FCCA,#FAAC,#FF8A")<br>
  Setting: <code>FacingMarkerTargetColors</code>  (default "#F41F,#F41F,#F41F,#F41F,#F41F")<br></p>
  
  <p>When non-empty, change the colours of each arc for friends, foes, and targeted arc during attack.  The colours are for Front, Left, Right, Rear, and Prone.</p>
</blockquote>

<p><strong>Line of Sight/Fire Style</strong></p>

<blockquote>
  <p>Setting: <code>LOSIndirectDotted</code>  (default true, game default false)<br>
  Setting: <code>LOSNoAttackDotted</code>  (default true)<br>
  Setting: <code>LOSMeleeDotted</code>  (default false)<br>
  Setting: <code>LOSClearDotted</code>  (default false)<br>
  Setting: <code>LOSBlockedPreDotted</code>   (default false)<br>
  Setting: <code>LOSBlockedPostDotted</code>  (default false)<br></p>
  
  <p>When true, the line(s) will be dotted.  When false, the line(s) will be solid.
  <br></p>
  
  <p>Setting: <code>LOSMeleeColors</code>  (default "#F00,#0FF,#0FF,#0F8,#F00")<br>
  Setting: <code>LOSClearColors</code>  (default "#F00,#0FF,#0FF,#0F8,#F00")<br>
  Setting: <code>LOSBlockedPreColors</code>   (default "#D0F,#D0F,#D0F,#D0F,#D0F")<br>
  Setting: <code>LOSBlockedPostColors</code>  (default "#C8E,#C8E,#C8E,#C8E,#C8E")<br>
  Setting: <code>LOSIndirectColors</code>  (default "#F00,#0FF,#0FF,#0F8,#F00")<br>
  Setting: <code>LOSNoAttackColors</code>  (default "")<br></p>
  
  <p>When non-empty, set the colour and style of various targeting lines.
  Obstructed lines has two parts. The part before obstruction is Pre, and the part after is Post.</p>
  
  <p>Colours are either empty or in HTML hash syntax.  For example <code>"#F00"</code> = red, <code>"#0F0"</code> = green, <code>"#00F"</code> = blue, <code>"#FFF"</code> = white, <code>"#888"</code> = grey, <code>"#000"</code> = black.
  Four parts means RGBA, while three parts mean full opacity RGB.  Supports full and short form. e.g. #28B = #2288BB = #2288BBFF.</p>
  
  <p>Colours and only colours can also vary by attack direction, separated by comma.  The directions are Front, Left, Right, Rear, and Prone, in this order.
  If less colours are specified than direction, the missing directions will use the last colour.
  For example "red,cyan,cyan,green" will result in front red, side cyan, and back/prone green.
  <br></p>
  
  <p>Setting: <code>LOSHueDeviation</code>  (0 to 0.5, default 0.04) <br>
  Setting: <code>LOSHueHalfCycleMS</code>  (0 to 300k, default 2048) <br>
  Setting: <code>LOSBrightnessDeviation</code>  (0 to 0.5, default 0.1) <br>
  Setting: <code>LOSBrightnessHalfCycleMS</code>  (0 to 300k, default 1024) <br></p>
  
  <p>When non-zero, the targeting lines will have animated colour, such as dimming and brightening.</p>
  
  <p>"Deviation" is the range of animation. For example cyan has a hue value of "0.5",
  and a hue deviation of "0.1" will causes it to animate between "0.4" and "0.6",
  or a cycle of green &lt;> cyan &lt;> blue.
  Thus, a high hue deviation can cause line colours to mix up and lost their meanings.</p>
  
  <p>Brightness also works on a scale of 0 (black) to 1 (brightest) with the animation range
  determined by the colour and deviation setting.</p>
  
  <p>"HalfCycleMS" is the milliseconds needed for hue or brightness to complete a half cycle.
  In the above example, that would be the time it takes to go from green to blue.</p>
  
  <p>The default cycles are power of two for faster modulo calculation, but you can use any integer.
  <br></p>
  
  <p>When the mod "<a href="https://www.nexusmods.com/battletech/mods/135">Firing Line Improvement</a>" is used,
  it will override the game's code with its own, effectivelly disabling these colour and animation settings.</p>
</blockquote>

<p><strong>Line of Sight/Fire Width</strong></p>

<blockquote>
  <p>Setting: <code>LOSWidth</code>  (0 to 10, default 2, game default 1)</p>
  
  <p>Set width of all targeting lines (direct, indirect, blocked, can't attack etc.).  Game default is 1  Mod default is 2.
  <br></p>
  
  <p>Setting: <code>LOSWidthBlocked</code>  (0 to 10, default 1.5, game default 0.75)</p>
  
  <p>Set width of obstructed part of an obstructed targeting lines, which is normally thinner than other lines by default.  Game default is 0.75.  Mod default is 1.5.
  <br></p>
  
  <p>When the mod "<a href="https://www.nexusmods.com/battletech/mods/135">Firing Line Improvement</a>" is used, it will override this mod's widths.</p>
</blockquote>

<p><strong>Widths of Obstruction Marker</strong></p>

<blockquote>
  <p>Setting: <code>LOSMarkerBlockedMultiplier</code>  (0 to 10, default 1.5)</p>
  
  <p>Scale the obstruction marker of targeting lines, the "light dot" that split the obstructed line into two. 2 means double width and height, 0.5 means half-half.
  Set to 1 to leave at game default.  Set to 0 will not remove them from game but will effectively hide them.</p>
  
  <p>When the mod "Firing Line Improvement" is detected, this setting will be disabled to avoid conflicts.</p>
</blockquote>

<p><strong>Refine or Roughen Fire Arc and Jump Arc</strong></p>

<blockquote>
  <p>Setting: <code>ArcLinePoints</code>  (2 to 127, default 48, game default 18)</p>
  
  <p>To some sharp eyes, it is easy to see the hard corners of the arc of indirect targeting lines.
  Lines are quick to draw, so this mod will happily improves their qualities for you.
  Set to 2 to make them flat like other lines.  Set to 18 to leave at game default.</p>
  
  <p>When the mod "<a href="https://www.nexusmods.com/battletech/mods/135">Firing Line Improvement</a>" is used, the indirect fire arc cannot be modified.</p>
</blockquote>

<h2 id="combatinformationsettings">Combat Information Settings</h2>

<p><strong>Paper Dolls</strong></p>

<blockquote>
  <p>Setting: <code>LabelPaperDollSide</code>  (true/false, default true)</p>
  
  <p>When true, add L and R around the Front/Rear labels.
  The exact position slightly differs depending on where the paper doll occurs.
  <br></p>
  
  <p>Setting: <code>FixPaperDollRearStructure</code>  (true/false, default true)</p>
  
  <p>The rear structures of the paper dolls are displayed incorrectly because of a typo in game code.
  When true, fix the bug.
  <br></p>
  
  <p>Setting: <code>ShowUnderArmourDamage</code>  (true/false, default true)</p>
  
  <p>When true, armour of damaged location will have a striped pattern instead of solid.
  <br></p>
  
  <p>Both settings apply to all paper dolls: selection panel, target panel, called shot popup, mech bay, deploy, post-mission report etc.
  <br></p>
  
  <p>Setting: <code>ShowAmmoInTooltip</code>  (true/false, default true)<br>
  Setting: <code>ShowEnemyAmmoInTooltip</code>  (true/false, default false)<br></p>
  
  <p>When true, show ammo count in the component lists when you mouseover a location on the paper doll in combat.
  Also, non-exploding (half-empty) ammo bin will be dimmed on the list.</p>
  
  <p>The main purpose is to allow you to see the state of each ammo bin and tell whether they are at risk of exploding.</p>
</blockquote>

<p><strong>Mech and MechWarrior</strong></p>

<blockquote>
  <p>Setting: <code>MechTrayGreyActedPilot</code>  (true/false, default true)</p>
  
  <p>When true, Mechwarrior who have acted this round will have their names in grey in the mech tray.
  <br></p>
  
  <p>Setting: <code>ShowNumericInfo</code>  (true/false, default true)</p>
  
  <p>When true, display heat, stability, movement, and distance numbers in the selection panel (bottom left) and targeting panel (top center), and predicts post action numbers.
  Prediction numbers are supplied by the game and is subject to all its quirks and bugs and mods, such as <code>FixHeatPreview</code>.</p>
  
  <p>When callout mode is enabled (default Left Alt key), pilot skills will be displayed instead.
  <br></p>
  
  <p>Setting: <code>ShowUnitTonnage</code>  (true/false, default false)</p>
  
  <p>When true, show mech and vehicle tonnage in selection and target panel.</p>
  
  <p>Duplicates with Extended Information, but AIM override it and use a shorter form for mechs to fit <code>ShowNumericInfo</code>.
  Default false because the short form may overwhelm inexperienced players.
  <br></p>
  
  <p>Setting: <code>ShortPilotHint</code>  (format string, default "G:{3} P:{4} G:{5} T:{6}")</p>
  
  <p>When non-empty, replace mechwarrior's summary hint. The parameters are: <br>
  {0}, {1}, {2} - Wound, Health - Wound, and Health. <br>
  {3}, {4}, {5}, {6} - Gunnery, Piloting, Gut, and Tactic.</p>
  
  <p>This only applies to the one-line hint that pops up on mouseover and right-click.
  The original hint, which shows only wounds and health, will be preserved when the hint is fully expanded (i.e. when no mech is selected).</p>
  
  <p>If the line is too long, for example when HP is included, the line will wrap.
  <br></p>
  
  <p>Setting: <code>ConsolidateWeaponCheevons</code>  (true/false, default true)</p>
  
  <p>When true, weapon cheevons around enemies will be grouped by type.</p>
</blockquote>

<p><strong>Weapons Loadout</strong></p>

<blockquote>
  <p>Setting: <code>SaturationOfLoadout</code>  (0 to 1, default 0.5)</p>
  
  <p>When non-zero, weapon loadout list will be coloured, based on the weapon colour configurated by the game.
  A high number will make the colour stronger, while a low number will make them more washed out.
  <br></p>
  
  <p>Setting: <code>ShowDamageInLoadout</code>  (true/false, default true)</p>
  
  <p>When true, loadout list of the targeting computer will be coloured by weapon type and postfixed with weapon damage.
  <br></p>
  
  <p>Setting: <code>ShowAlphaDamageInLoadout</code>  (format string, default "Damage {2} + Long {3}")</p>
  
  <p>When non-empty, loadout list label of the targeting computer will be changed to show total weapon damage.</p>
  
  <p>Parameters: <br>
  <code>{0}</code> - Sum of damage of all ranged weapons.
  <code>{1}</code> - Sum of damage of all support-range weapons. (Range &lt;= 90)
  <code>{2}</code> - Sum of damage of all close-range weapons. (Range 91 to 360)
  <code>{3}</code> - Sum of damage of all long-range weapons. (Range > 360)
  <code>{4}</code> - Sum of damage of close and long range weapons. (Range > 90)
  <br></p>
  
  <p>Setting: <code>ShowMeleeDamageInLoadout</code>  (true/false, default true)</p>
  
  <p>When true, loadout list of the targeting computer will have melee and dfa entry.
  Their damage will always be displayed regardless of <code>ShowDamageInLoadout</code>.</p>
</blockquote>

<p><strong>Weapon Panel</strong></p>

<blockquote>
  <p>Setting: <code>ShowReducedWeaponDamage</code>  (true/false, default true)</p>
  
  <p>When true, the damage displayed in weapon panel will take terrain cover and Guarded status into account.
  The number should match the floating damage when the attack hit the enemy, unless damage variant is used.</p>
  
  <p>This setting is compatible with Joel Meador's <a href="https://github.com/janxious/BT-WeaponRealizer">WeaponRealizer</a>.
  Non-random variances from that mod should be factored in displayed damage.</p>
  
  <p>Despite the name, if weapon damage is somehow boosted by terrain (such as by a mod), the displayed numbers will go up.
  <br></p>
  
  <p>Setting: <code>ShowTotalWeaponDamage</code>  (true/false, default true)</p>
  
  <p>When true, a new "Total" slot will be displayed at the bottom of the weapon list, above melee and DFA.
  It will show the total damage of all enabled weapons, or all weapon that will fire at selected target.
  The damage column shows max damage, while the accuracy column shows average damage given current accuracy.</p>
  
  <p>If <code>ShowReducedWeaponDamage</code> is true, the total damage will reflect terrain and status effects.
  <br></p>
  
  <p>Setting: <code>CalloutWeaponStability</code>  (true/false, default true)</p>
  
  <p>When true, pressing the game's callout toggle button (default LeftAlt) will cause the weapon list to 
  display stability damage instead of normal damage.</p>
  
  <p>If <code>ShowReducedWeaponDamage</code> is true, the numbers will be affected by status such as Entrenched.
  If <code>ShowTotalWeaponDamage</code> is true, total stability damage will be displayed.</p>
</blockquote>

<p><strong>Weapon Mouseover Hint</strong></p>

<blockquote>
  <p>Setting: <code>ShowWeaponProp</code>  (true/false, default true)<br>
  Setting: <code>WeaponRangeFormat</code>  (string, default "Min {0} : Long {2} : Max {4}")<br></p>
  
  <p>These two settings override the weapon information displayed when you mouseover a weapon in combat.</p>
  
  <p><code>ShowWeaponProp</code> overrides the full weapon name with weapon properties, if the weapon is rare (+ to +++).
  For example, an "M Laser++" may display "+1 ACC, +25% CRIT" instead of "MEDIUM LASER".</p>
  
  <p><code>WeaponRangeFormat</code> replaces the weapon range with actual meters when non-empty.
  The string {0} to {4} will be replaced by a weapon's MinRange, ShortRange, MediumRange, LongRange, and MaxRange.
  Most of them are unused by vanilla game, so this mod use MinRange, MediumRange, and MaxRange by default.
  But if a mod is installed that make use of them, the range display can be customised, such as "{0}:{1}:{2}:{3}:{4}".</p>
</blockquote>

<h2 id="calledshotsettings">Called Shot Settings</h2>

<p><strong>Fix Grey Head Disease</strong></p>

<blockquote>
  <p>Setting: <code>FixBossHeadCalledShotDisplay</code>  (true/false, default true)</p>
  
  <p>When true, boss head will be unselectable in called shot.</p>
  
  <p>Before game version 1.3, any attack on an important NPC (which is headshot immune) will remove the head from the global hit table.
  As a result, after a few rounds no one's head can be hit.  They will be greyed out in the called shot popup.
  This was called the grey head disease by some and can only be cured by loading game or using an earlier version of AIM.</p>
  
  <p>This is fixed in patch 1.3, by cloning the hit table in every hit.  Slow, but a working fix nonetheless.
  But this also mean boss head can now be called, when in fact you will never hit the head.  This setting fix that.</p>
</blockquote>

<p><strong>Enable Clustering Called Shot</strong></p>

<blockquote>
  <p>Setting: <code>CalledShotUseClustering</code> (true/false, default true)</p>
  
  <p>When true, called shot has a higher chance to hit adjacent locations.</p>
  
  <p>For example, head called shot would bias the head, but also the three torsos to a lesser degree.</p>
  
  <p>This is the default behaviour on and before game version 1.0.4, which was bugged and caused very low called head shot chances since head is excluded from clustering.
  The bug is one of the driving forces of this mod's initial creation.  This mod can recreate the clustering effect without the bug.</p>
  
  <p>Note that this does not apply to Vehicle called shot; vehicles have too few locations to have meaningful clustering.</p>
</blockquote>

<p><strong>Adjust Called Shot Weight</strong></p>

<blockquote>
  <p>Setting: <code>FixCalledShotMultiplierSquare</code>  (true/false, default true)</p>
  
  <p>When true, called shot weight will be fixed if it is detected to have been squared.</p>
  
  <p>This happens to some saves and the cause is unknown.  For me it happened after a game patch.
  It is unlikely to be caused by this mod, and certainly can't be fixed by removing this mod.
  This mod changes the weight on the fly and does not change save data;
  without this mod, restarting the mission will restore the weight to normal.
  <br></p>
  
  <p>Setting: <code>MechCalledShotMultiplier</code>  (0 to 1024.0, default 0.33)</p>
  
  <p>When clustering called shot is enabled, chance to hit called locations will be amplified by clustering weight.  This setting let you tune called shot's weight multipliers.
  Default is 0.33 to counter the effect of CalledShotClusterStrength.  Set to 1.0 would leave original multiplier unchanged, while 0.0 will removing it leaving only clustering effect (if enabled).
  <br></p>
  
  <p>Setting: <code>VehicleCalledShotMultiplier</code>  (0 to 1024.0, default 0.75)</p>
  
  <p>Unmodified called shot is pretty powerful on vehicles because of its low number of locations.  This setting tries to balance that.</p>
</blockquote>

<p><strong>Update and Format Called Shot Display</strong></p>

<blockquote>
  <p>Setting: <code>ShowRealMechCalledShotChance</code>  (true/false, default true)<br>
  Setting: <code>ShowRealVehicleCalledShotChance</code>  (true/false, default true)</p>
  
  <p>When true, the popups will reflect modded hit distribution such as clustering and multiplier effect.
  <br></p>
  
  <p>Setting: <code>CalledChanceFormat</code>  (string, default "")</p>
  
  <p>Use Microsoft C# <a href="https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/0c899ak8(v=vs.90">String.Format</a> syntax to format called shot location chances.</p>
  
  <p>Set to "{0:0.0}%" to always show one decimal, or "{0:0.00}%" for two decimals.
  Leave empty to round them to nearest integer.</p>
  
  <p>Replace the old "ShowDecimalCalledChance" setting in mod version 1.0.</p>
</blockquote>

<h2 id="meleeanddfasettings">Melee and DFA Settings</h2>

<p><strong>Unlock Melee and DFA Positioning</strong></p>

<blockquote>
  <p>Setting: <code>IncreaseMeleePositionChoice</code>  (true/false, default true)<br>
  Setting: <code>IncreaseDFAPositionChoice</code>  (true/false, default true)</p>
  
  <p>When true, melee and DFA can use all available positions, instead of nearest three.
  Compatible with the mod "<a href="https://www.nexusmods.com/battletech/mods/226">MeleeMover</a>".
  <br></p>
  
  <p>Setting: <code>UnlockMeleePositioning</code>  (true/false, default true)</p>
  
  <p>When true, player units may move to another melee position when target is already in melee range.
  When the mod "<a href="https://www.nexusmods.com/battletech/mods/226">MeleeMover</a>" is used, a warning will be logged but otherwise fully compatible.</p>
</blockquote>

<p><strong>Adjust Max Height Offset</strong></p>

<blockquote>
  <p>Settings: MaxMeleeVerticalOffsetByClass  (comma separated positive number, default "8,11,14,17")</p>
  
  <p>When non-empty, adjust <code>MaxMeleeVerticalOffset</code> by the class of the attacker or target, whoever is at the lower ground.
  Value is for Light, Medium, Heavy, and Assault mechs.  Non-mechs are considered Light for the purpose of this setting.</p>
  
  <p>Game default is all 8.  Mod default allows bigger mechs to hit and be hit across higher height differences.</p>
  
  <p>This setting applies to both Melee and DFA.
  If a value is missing or invalid, it will be set to the same as lighter class, or "8" if it is the first value.</p>
</blockquote>

<h2 id="individualmodifiersettings">Individual Modifier Settings</h2>

<p><strong>Base Hit Chance</strong></p>

<blockquote>
  <p>Setting: <code>BaseHitChanceModifier</code> (-10.0 to 10.0, default 0)<br>
  Setting: <code>MeleeHitChanceModifier</code> (-10.0 to 10.0, default 0)</p>
  
  <p>Increase or decrease base hit chance of ranged/melee attacks.
  e.g. -0.05 to lower base accuracy by 5%, 0.1 to increase it 10%.</p>
</blockquote>

<p><strong>Directional Modifiers</strong></p>

<blockquote>
  <p>Setting: <code>ToHitMechFromFront</code>  (-20 to 20, default 0)<br>
  Setting: <code>ToHitMechFromSide</code>  (-20 to 20, default -1)<br>
  Setting: <code>ToHitMechFromRear</code>  (-20 to 20, default -2)<br>
  Setting: <code>ToHitVehicleFromFront</code>  (-20 to 20, default 0)<br>
  Setting: <code>ToHitVehicleFromSide</code>  (-20 to 20, default -1)<br>
  Setting: <code>ToHitVehicleFromRear</code>  (-20 to 20, default -2)<br></p>
  
  <p>Determine the modifier for attacking from side or rear.
  Effective only if "Direction" is in the modifier lists.</p>
</blockquote>

<p><strong>Height Modifier</strong></p>

<blockquote>
  <p>Setting: <code>AllowLowElevationPenalty</code>  (true/false, default true)</p>
  
  <p>When true, attacking from low ground to high ground will incur an accuracy penalty that is the exact reverse of attacking from high ground to low.
  Game default is false.</p>
</blockquote>

<p><strong>Jumped Modifier</strong></p>

<blockquote>
  <p>Settings: <code>ToHitSelfJumped</code> (-20 to 20, default 0)</p>
  
  <p>The game has self moved modifier and self sprint modifier in <code>CombatGameConstants.json</code>, but not self jumped modifier.
  You may set it with this mod if you want to.  It will be factored in attack preview.</p>
  
  <p>Effective only if "Jumped" is in the modifier lists.</p>
</blockquote>

<h2 id="nethitmodifiersettings">Net Hit Modifier Settings</h2>

<p><strong>Allow Net Bonus Modifier</strong></p>

<blockquote>
  <p>Setting: <code>AllowNetBonusModifier</code>  (true/false, default true)</p>
  
  <p>When true, total modifier of an attack can be a net bonus that increases the hit chance beyond the attacker's base hit chance
  (but still subjects to 95% cap unless lifted by the <code>MaxFinalHitChance</code> settings).
  Game default is false.</p>
  
  <p>When the net modifier is a bonus, it will use the same handling as penalty but reversed.
  Default is stepped, which means first 10 modifiers are ±5% each, and subsequence modifiers are ±2.5% each.</p>
</blockquote>

<p><strong>Unlock Modifier Stepping and Range</strong></p>

<blockquote>
  <p>Setting: <code>HitChanceStep</code>  (0.0 to 1.0, default 0)</p>
  
  <p>The game will round down final hit chance to lower 5% by default.
  This affects some calculations, such as rendering odd gunnery stats and piloting stats less effective then they should be.
  Set this to 0 to remove all stepping.  Set it to 0.005 will step the accuracy by 0.5%, and so on.
  <br></p>
  
  <p>Setting: <code>MaxFinalHitChance</code>  (0.1 to 1.0, default 0.95)<br>
  Setting: <code>MinFinalHitChance</code>  (0.0 to 1.0, default 0.0)</p>
  
  <p>Use this to set max and min hit chance after all modifiers but before roll correction.
  Note that 100% hit chance may still miss if roll correction is enabled.</p>
</blockquote>

<p><strong>Diminishing Hit Chance Modifier</strong></p>

<blockquote>
  <p>Setting: <code>DiminishingHitChanceModifier</code>  (true/false, default false)</p>
  
  <p>Set this to true to enable diminishing return of modifiers, instead of simple add and subtract.
  As a result, small penalties have a bigger effect, but very large penalties become more bearable.
  <br></p>
  
  <p>Setting: <code>DiminishingBonusPowerBase</code>  (default 0.8)<br>
  Setting: <code>DiminishingBonusPowerDivisor</code>  (default 6)<br>
  Setting: <code>DiminishingPenaltyPowerBase</code>  (default 0.8)<br>
  Setting: <code>DiminishingPenaltyPowerDivisor</code>  (default 3.3)<br></p>
  
  <p>Bonus formula is "2-Base^(Modifier/Divisor)". <br>
  Example: +3 Bonus = 0.8^(3/6) = -1.1055728 = 110%. <br>
  Thus +3 Bonus @ 80% To Hit = 80% x 110% = 88% final to hit.</p>
  
  <p>Penalty formula is "Base^(Modifier/Divisor)". <br>
  Penalty Example: +6 Penalty = 0.8^(6/3.3) = 0.6665 = 66.7%. <br>
  Thus +6 Penalty @ 80% To Hit = 80% x 66.7% = 53% final to hit.
  <br></p>
  
  <p>Setting: <code>DiminishingBonusMax</code>  (default 16)
  Setting: <code>DiminishingPenaltyMax</code>  (default 32)</p>
  
  <p>The modifiers are pre-calculated to run faster.  These settings determine how many results are cached.
  Modifiers beyond the max will be regarded as same as max.</p>
</blockquote>

<p><strong>Change Modifiers List</strong></p>

<blockquote>
  <p>Setting: <code>RangedAccuracyFactors</code>  (comma separated value)<br>
  Setting: <code>MeleeAccuracyFactors</code>  (comma separated value)<br></p>
  
  <p>A list of hit modifiers of ranged / melee and DFA attacks.  Leave empty to keep unchanged.  Order and letter case does not matter.</p>
  
  <p>Since this feature will override both mouseover display and actual modifier calculation, this will fix the bug that SelfStoodUp is displayed in melee mouseover but not counted in net modifier.</p>
  
  <p>Ranged default is "ArmMounted, Direction, Height, Indirect, Inspired, Jumped, LocationDamage, Obstruction, Precision, Range, Refire, SelfHeat, SelfStoodUp, SelfTerrain, SensorImpaired, SensorLock, Sprint, TargetEffect, TargetEvasion, TargetProne, TargetShutdown, TargetSize, TargetTerrain, Walked, WeaponAccuracy, WeaponDamage".
  Melee default is "Direction, DFA, Height, Inspired, Jumped, SelfChassis, SelfHeat, SelfStoodUp, SelfTerrainMelee, Sprint, TargetEffect, TargetEvasion, TargetProne, TargetShutdown, TargetSize, TargetTerrainMelee, Walked, WeaponAccuracy".</p>
  
  <p>Options:<br>
  <strong>ArmMounted</strong> - (Ranged) Apply arm mounted modifier if weapon is mounted on an arm. (Melee) Apply arm mount bonus if the punching arm is intact and the attack is not DFA and not against prone mech or vehicle. <br>
  <strong>Direction</strong> - Apply bonus if attack is made from the target's side or rear. <br>
  <strong>DFA</strong> - (Melee) Apply DFA penalty if attack is DFA. <br>
  <strong>Height</strong> - (Ranged) Apply height modifier.  (DFA) Height is measured from pre-flight attacker position to target position.  (Melee) Apply one level of height modifier if height different is at least half of melee reach (medium if MaxMeleeVerticalOffsetByClass is used).<br>
  <strong>Indirect</strong> - (Ranged) Apply indirect fire penalty. <br>
  <strong>Inspired</strong> - Apply inspired bonus. <br>
  <strong>Jumped</strong> - Apply jumped penalty after jump, if any. <br>
  <strong>LocationDamage</strong> - (Ranged) Apply location damage penalty, if any. <br>
  <strong>Obstruction</strong> - Apply obstructed penalty. <br>
  <strong>Precision</strong> - (Ranged) Apply Precision Strike bonus. <br>
  <strong>Range</strong> - (Ranged) Apply range penalty. <br>
  <strong>Refire</strong> - Apply refire penalty.  (Melee) Should be 0 by default but can be changed in weapon data files. <br>
  <strong>SelfChassis</strong> - (Melee) Apply chassis modifier. <br>
  <strong>SelfHeat</strong> - Apply overheat penalty. <br>
  <strong>SelfStoodUp</strong> - Apply stood up penalty. <br>
  <strong>SelfTerrain</strong> - Apply self terrain penalty as if this is a ranged attack. <br>
  <strong>SelfTerrainMelee</strong> - Apply self terrain penalty as if this is a melee attack. <br>
  <strong>SensorImpaired</strong> - Apply sensor impaired penalty. <br>
  <strong>SensorLock</strong> - Apply sensor lock bonus. <br>
  <strong>Sprint</strong> - Apply sprint penalty, if somehow you can attack after sprint. <br>
  <strong>TargetEffect</strong> - Apply target effect penalty such as gyro. <br>
  <strong>TargetEvasion</strong> - Apply target evasion penalty.  Melee attacks ignore up to 4 evasion by default. <br>
  <strong>TargetProne</strong> - Apply target prone penalty. <br>
  <strong>TargetShutdown</strong> - Apply target shutdown bonus. <br>
  <strong>TargetSize</strong> - Apply target size penalty. <br>
  <strong>TargetTerrain</strong> - Apply target terrain's ranged penalty. <br>
  <strong>TargetTerrainMelee</strong> - Apply target terrain's melee penalty. <br>
  <strong>Walked</strong> - Apply self walked penalty, default 0 but can be changed in game configuration file. <br>
  <strong>WeaponAccuracy</strong> - Apply weapon accuracy, TTS, and mod bonus. <br>
  <strong>WeaponDamage</strong> - (Ranged) Apply weapon damaged penalty.</p>
  
  <p>The modifier system is designed to be moddable.
  Patch <code>ModifierList.GetCommonModifierFactor</code>, <code>ModifierList..GetRangedModifierFactor</code>, and/or <code>ModifierList.GetMeleeModifierFactor</code> to add new modifiers.</p>
</blockquote>

<h2 id="hitrollsettings">Hit Roll Settings</h2>

<p><strong>Adjust Roll Correction</strong></p>

<blockquote>
  <p>Setting: <code>RollCorrectionStrength</code>  (0.0 to 2.0, default 0.5)</p>
  
  <p>It is no secret that the game fudge all hit rolls, called a "correction".
  As a result, real hit chances are shifted away from 50%, for example 75% becomes 84% while 25% becomes 16%.
  This can create a rift between what you see and what you get, especially on low chance shots.</p>
  
  <p>This mod does not aim to completely disable roll adjustment, and thus default to half its strength.
  You can set the strength to 0 to disable it, 1 to use original formula, 2 to amplify it, or any value between 0 and 2.</p>
  
  <p>If the "True RNG Hit Rolls" mod is detected, this setting will be switched to 0 for consistency.</p>
</blockquote>

<p>(Advanced) <strong>Adjust Miss Streak Threshold</strong></p>

<blockquote>
  <p>Setting: <code>MissStreakBreakerThreshold</code>  (0.0 to 1.0, default 0.5)</p>
  
  <p>In addition to roll adjustment, the game also has a "miss streak breaker".
  Whenever you miss an attack of which uncorrected hit chance > 50%, the streak breaker will adjust your hit chance up on top of roll correction.
  The bonus accumulates until you land a hit (regards of hit chance), at which point it resets to 0.</p>
  
  <p>This setting let you adjust the threshold.  0.75 means it applies to attack of which hit chance > 75% (excluding 75%).
  Set to 0 enable it for all attacks, or set to 1 to disable it.  Default is 0.5 which is the game's default.</p>
  
  <p>If the "True RNG Hit Rolls" mod is detected, this setting will be switched to 1 for consistency.</p>
</blockquote>

<p>(Advanced) <strong>Adjust Miss Streak Bonus</strong></p>

<blockquote>
  <p>Setting: <code>MissStreakBreakerDivider</code>  (-100.0 to 100.0, default 5.0)</p>
  
  <p>For every miss that crosses the streak breaker threshold, the threshold is deduced from hit chance, then divided by 5.
  The result is then added as streak breaker bonus.</p>
  
  <p>Set this setting to a positive number to override the divider.
  For example at threshold 0.5 and divider 3, a 95% miss result in (95%-0.5)/3 = 15% bonus to subsequence shots until hit.
  Default is 5 which is the game's default.</p>
  
  <p>Set this setting to zero or negative integer to replace it with a constant value.
  For example -5 means each triggering miss adds 5% bonus, and -100 will make sure the next shot always hit.</p>
</blockquote>

<h2 id="hitchancepreviewsettings">Hit Chance Preview Settings</h2>

<blockquote>
  <p>Setting: <code>ShowBaseHitchance</code>  (true/false, default true)</p>
  
  <p>Show the mechwarrior's base hit chance in modifier tooltip.</p>
  
  <p>Setting: <code>ShowNeutralRangeInBreakdown</code>  (true/false, default false)</p>
  
  <p>When true, show range category in modifier tooltip even the range has no modifiers.
  In unmodded vanilla this will be the "Short Range".
  Because this differs from "Optimal Range" used in vanilla mech bay, this setting is disabled by default.</p>
  
  <p>Setting: <code>FixSelfSpeedModifierPreview</code>  (true/false, default true)</p>
  
  <p>If moved/sprint/jumped modifier is non-zero, this mod can patch the game to factor them in during action planning.</p>
</blockquote>

<p>(Advanced) <strong>Show Corrected Hit Chance</strong></p>

<blockquote>
  <p>Setting: <code>ShowCorrectedHitChance</code>  (true/false, default false)</p>
  
  <p>It's one thing to fudge the rolls.  It is another to let you know.
  Set this to true to show the corrected hit chance in weapon panel.</p>
  
  <p>When the "Real Hit Chance" mod is detected, this settings will be switched to on and overrides that mods.</p>
</blockquote>

<p><strong>Format Hit Chance</strong> (default "")</p>

<blockquote>
  <p>Setting: <code>HitChanceFormat</code>  (free string, default "")</p>
  
  <p>Use Microsoft C# <a href="https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/0c899ak8(v=vs.90">String.Format</a> syntax to format weapon hit chances.</p>
  
  <p>Set to "{0:0.0}%" to always show one decimal, or "{0:0.00}%" for two decimals.
  When empty AND HitChanceStep is 0, will use "{0:0.#}%" to optionally show hit chance to one decimal point.</p>
  
  <p>Replace the old "ShowDecimalHitChance" setting in mod version 1.0.</p>
</blockquote>

<h2 id="criticalhitsettings">Critical Hit Settings</h2>

<p><strong>Skip Criting the Dead Mech</strong></p>

<blockquote>
  <p>Setting: <code>SkipBeatingDeadMech</code>  ("", "critical", or "damage", default "critical")</p>
  
  <p>When set to "critical", critical hits are not rolled for dead units.
  This is mainly designed to prevent crit messages from flooding over cause of death.
  As a side effect, slightly more components will be salvageable instead of being destroyed.</p>
  
  <p>When set to "damage", damage is not applied to dead units.
  This means as soon as a target is removed from play, it won't take any more damage or crits.</p>
</blockquote>

<p><strong>NPC Crit Multipliers</strong></p>

<blockquote>
  <p>Setting: <code>CritChanceEnemy</code> (0 or above, default 0.2) <br>
  Setting: <code>CritChanceAlly</code> (0 or above, default 1) <br></p>
  
  <p>Override the crit chance set by AICritChanceBaseMultiplier in CombatGameConstants.json.
  Game default is 0.2 which lowers all NPCs' crit chance to 20% of original.</p>
  
  <p>Set to 1 for same crit chance as players, or set to 0 to prevent enemies or allies from dealing crit.</p>
</blockquote>

<p><strong>Non-Mech Critical Hit</strong></p>

<blockquote>
  <p>Setting: <code>CriChanceVsVehicle</code> (0 or above, default 0.75) <br>
  Setting: <code>CritChanceVsTurret</code> (0 or above, default 0.6) <br></p>
  
  <p>When non-zero, enable critical hit on vehicles and turrets.
  The numbers are multipliers of crit chance, e.g. 0.5 to set to half normal crit chance.</p>
  
  <p>Because of the very high armour to structure ration of vehicles and especially turrets,
  The numbers will not matter much unless <code>CritChanceFullArmor</code> is higher than zero.</p>
  
  <p>In case of that, the default chance is lower than normal,
  for a more consistent crit level relative to mech since vehicles and turrets do not have empty slots to blunt crits.
  <br></p>
  
  <p>Setting: <code>AmmoExplosionKillTurret</code>  (true/false, default true) <br>
  Setting: <code>AmmoExplosionKillVehicle</code>  (true/false, default true) <br></p>
  
  <p>When true, turrets and vehicles will be destroyed when any of their ammo explodes.
  Otherwise, the game does not expects this to happen and has no code to kill the unit.</p>
  
  <p>As a bonus, "XXX Ammo Destroyed" message will be suppressed when ammo explosion happens, if either option is on.
  (Mech ammo explosion included, if one of the crit system replacing options is enabled.)</p>
</blockquote>

<p><strong>Crit Follows Damage Transfer</strong></p>

<blockquote>
  <p>Setting: <code>CritFollowDamageTransfer</code>  (true/false, default true)</p>
  
  <p>When true, critical hits will be rolled on last damaged location, i.e. they follows damage transfer.</p>
  
  <p>In un-modded game, critical hit is checked only on the rolled hit location and does not follow damage transfer.
  For example, when a laser hits a destroyed arm and damages a side torso, crit is not rolled since the arm is already destroyed.</p>
</blockquote>

<p><strong>Fix False Positive Crits</strong></p>

<blockquote>
  <p>Setting: <code>FixFullStructureCrit</code>  (true/false, default true)</p>
  
  <p>When true, critical hit does not happens on locations with intact structure.</p>
  
  <p>In un-modded game, critical hit is rolled on all location that is hit and has zero armour.
  This means crit is rolled even if the weapon reduces the armour to exactly zero and did not do any structural damage.
  When this happens, a crit slot will be rolled half the time, since minimal crit chance is 50%!</p>
  
  <p>This setting is off when through armour critical (below) is on, in which case zero armour uses the through armour rules.</p>
</blockquote>

<p><strong>Through Armour Critical Hits</strong></p>

<blockquote>
  <p>Setting: <code>ThroughArmorCritThreshold</code>  (0 to 1000, default 9)</p>
  
  <p>Each weapon must deal this much damage to a location in an attack for through armour critical hit to be checked.</p>
  
  <p>Default is 9 which is 3 MG hits, 3 LRM hits, or 2 SRM hits to the same location when un-braced and un-covered.</p>
  
  <p>If the number is between 0 and 1 (exclusive), the threshold is a fraction of the max armour of the location.
  e.g. 0.2 means a weapon must do as much damage as 20% of the max armour of the location.</p>
  
  <p>If the number is between 0 and -1 (inclusive), the threshold is a fraction of the current armour of the location.
  e.g. 0.2 means a weapon must do as much damage as 20% of the current armour of the location.</p>
  
  <p>Note: If <code>CritFollowDamageTransfer</code> is false, damage transfer will not be counted on the final damaged location,
  and may cause a multi-shot weapon to fail to reach threshold when it actually did.
  (Single-shot weapon won't even check for crit when damage transfer happens - that is what the settings do.)</p>
  
  <p>Also, in order to keep the code simple, fraction of armour is not exact.
  Shots with partially transferred damage are counted in full and can more easily meet the threshold.
  Fraction of current armour is also more easily skewed when damage is partially transferred.
  But generally speaking, the imprecision has limited impact and align with the spirit of through armour crit.
  <br></p>
  
  <p>Setting: <code>CritChanceZeroArmor</code>  (0 to 2, default 0)<br>
  Setting: <code>CritChanceFullArmor</code>  (-1 to 1, default 0)<br></p>
  
  <p>The two settings together determine the range of through armour base critical chance.
  <code>CritChanceZeroArmor</code> is the max chance, and <code>CritChanceFullArmor</code> is the min chance.
  When <code>CritChanceZeroArmor</code> is 0, through armour critical hit is disabled.</p>
  
  <p>For a fixed crit chance, set both numbers to same.
  Classic BattleTech has the chance at around 3%, or 0.03.</p>
  
  <p>When the numbers are different, the crit chance increases in proportion to armour damage.<br>
  Example: When zero = 0.4 and Full = 0, a location with half armour has a 20% base crit chance.<br>
  Example: When zero = 0.2 and Full = -0.1, crit may happens after armour is reduced to 2/3 or below.<br></p>
  
  <p>When through armour critical hit happens and it is logged by this mod's Attack Log,
  the Max HP column logs the max armour of the location instead of max structure.</p>
</blockquote>

<p><strong>Normal Crit Chance</strong></p>

<blockquote>
  <p>Setting: <code>CritChanceZeroStructure</code> (0 to 2, default 1)<br>
  Setting: <code>CritChanceFullStructure</code> (-1 to 1, default 0)<br>
  Setting: <code>CritChanceMin</code> (0 to 1, default 0.5)<br>
  Setting: <code>CritChanceMax</code> (0 to 1, default 1)<br></p>
  
  <p>These settings can be used to change the normal critical hit chance on structurally damaged locations.
  CritChanceZeroStructure and CritChanceFullStructure decides the base range relative to structure%,
  then CritChanceMin and CritChanceMax is applied to cap the chance.</p>
  
  <p>The default values are the same as game's default.
  Using defaults, a location with 75/100 structure has 25% crit chance, raised to 50% by <code>CritChanceMin</code>.
  This becomes the base crit chance of the location, to be modified by crit multipliers.</p>
</blockquote>

<p><strong>Critical Hit Reroll</strong></p>

<blockquote>
  <p>Setting: <code>CritIgnoreDestroyedComponent</code> (true or false, default false)<br>
  Setting: <code>CritIgnoreEmptySlots</code> (true or false, default false)<br></p>
  
  <p>When true, a successful critical hit will ignore destroyed components and/or empty slots.
  These settings simulate Classic BattleTech's crit reroll that happens when the crit slot is invalid.</p>
</blockquote>

<p><strong>Critical Hit Location Transfer</strong></p>

<blockquote>
  <p>Setting: <code>CritLocationTransfer</code> (true or false, default false)</p>
  
  <p>When true and a successful critical hit happens on a location that has nothing to crit,
  the crit will transfer to the next location using damage transfer rule.
  It is strongly advised to also set <code>CritFollowDamageTransfer</code> to true.</p>
  
  <p>In AIM 2.5, this transfer is checked after factoring <code>CritIgnoreDestroyedComponent</code> and <code>CritIgnoreEmptySlots</code>.
  Since AIM 3.0, this transfer always ignore destroyed components and empty slots, regardless of those settings.</p>
</blockquote>

<p><strong>Multiple Critical Hits from Single Shot</strong></p>

<blockquote>
  <p>Setting: <code>MultipleCrits</code> (true or false, default false)</p>
  
  <p>In Classic BattleTech, critical hits may damage multiple components.
  This setting recreate that feel in the context of BattleTech's crit system.</p>
  
  <p>When true, a successful crit roll is deduced from the crit chance.
  This leftover crit chance is then rolled again, and repeated until a crit roll fails.
  Note that successful crit rolls do not guarantee crits, since they often land on empty slots.</p>
  
  <p>The attack log of this mod only logs one line per attack.
  Only the first crit roll and the first crit'ed component (and its slot roll) will be logged.
  (They will be different when the first roll get an empty slot and a subsequence roll crits.)</p>
</blockquote>

<h2 id="hitresolutionsettings">Hit Resolution Settings</h2>

<p><strong>Balance Ammo Consumption</strong></p>

<blockquote>
  <p>Setting: <code>BalanceAmmoConsumption</code>  (true/false, default true)<br>
  Setting: <code>BalanceEnemyAmmoConsumption</code>  (true/false, default false)</p>
  
  <p>When true, mechs will draw ammo in an intelligent way to minimise chance of ammo explosion.
  After that is done, the AI will then minimise risk of losing ammo to crits and destroyed locations.</p>
  
  <p>The AI is pretty smart, but it can't shift ammo, so manually spreading ammo around can help it does its job.</p>
</blockquote>

<p><strong>Auto Jettison Ammo</strong></p>

<blockquote>
  <p>Setting: <code>AutoJettisonAmmo</code>  (true/false, default true)<br>
  Setting: <code>AutoJettisonEnemyAmmo</code>  (true/false, default false)</p>
  
  <p>When true, mechs will jettison useless ammo at end of its turn,
  provided it has not moved, is not prone, and is not shutdown.
  (The jettison doors are at the rear, so no prone jettisons.)</p>
  
  <p>This can happens if all weapons that use that kind of ammo are destroyed mid-fight,
  or if the mech was deployed with new ammo installed but not the weapon yet.
  Jettisoning the ammo will make sure they won't explode when hit.</p>
</blockquote>

<p><strong>Precise Hit Location Distribution</strong></p>

<blockquote>
  <p>Setting: <code>FixHitDistribution</code>  (true/false, default true)</p>
  
  <p>Set to true to increase hit location precision, specifically to improve the hit distribution of SRM and MG called shots.</p>
  
  <p>Game version 1.1 introduced degrading called shot effect for SRM and MG,
  but because the code that determine hit distribution is not designed for fraction called shot weight, the actual distribution is slightly bugged.
  <br></p>
</blockquote>

<p><strong>Kill Zombies</strong></p>

<blockquote>
  <p>Setting: <code>KillZeroHpLocation</code>  (true/false, default true)</p>
  
  <p>Set to true to prevent locations and units from surviving at 0 HP.</p>
  
  <p>Some units have non-integer hp (usually turrets), and an attack may dealt non-integer damage (e.g. cover).  As a result, this may result in zombie locations and units that are at 0 structure but not dead.</p>
  
  <p>This mod can detect these cases and boosts the final damage just enough to finish the job.</p>
</blockquote>

<h2 id="attacklogsettings">Attack Log Settings</h2>

<p><strong>Log Level</strong></p>

<blockquote>
  <p>Setting: <code>AttackLogLevel</code>  ("None", "Attack", "Shot", "Location", "Damage", "Critical", or "All", default "All")</p>
  
  <p>When not "None", the mod will writes an attack log in the mod's folder, called <code>Log_Attack.csv</code> by default.</p>
  
  <p>The levels are progressive.  Attack info is fully included by Shot level, Shot info is fully included by Location level, etc.
  The deeper the level, the more the mod needs to eavesdrops and the higher the chance things will go wrong because of game update or interference from other mods.</p>
  
  <p><strong>None</strong> - It is a bug if you see a log file at this log level.  That or the file is a ghost that comes back to haunt you, in which case you should seek the church.</p>
  
  <p><strong>Attack</strong> - Time, Attacker (team, pilot, mech), Target (team, pilot, mech), Direction, Range, Combat Id, and Action Id. The Ids can be used to consolidate data by-combat or by-action.
  For example a Multi-Target attack will log two or three different targets with the same Action Id.</p>
  
  <p><strong>Shot</strong> - For each shot, log the Weapons, Weapon Template, Weapon Id, Attack Roll, Hit Chance, related info, and either Hit or Miss.
  Weapon Id is unique <em>per mech</em>, and can be combined to consolidate data by weapon.  This level and above also logs overheat damage and DFA self-damage.</p>
  
  <p><strong>Location</strong> - Location Roll, Hit Table, Called Shot, and the Hit Location.</p>
  
  <p><strong>Damage</strong> - Damage, Final Damaged Location, and Armor/HP of this location. 
  Damage is determined in a different phase from hit and location, and is a rather complicated info to log.</p>
  
  <p><strong>Critical</strong> - Crit Location, Crit Roll, Crit Slot, Crit Component, and the result of the crit.
  Crit is determined in yet another phase, so the log code is <em>very fun</em> to write.</p>
  
  <p><strong>All</strong> - same as Critical for now.  More info may be added in the future, though I am not sure I wouldn't go crazy.
  Would you believe logging is the most complicated feature of this mod?</p>
  
  <p>Default was "None" in mod version 1.0 and 2.0, but mod 2.1 switched to a multi-thread logging system so it now defaults to "All".</p>
</blockquote>

<p>(Advanced) <strong>Log Options</strong></p>

<blockquote>
  <p>Setting: <code>AttackLoFormat</code>  ("csv", "tsv", "txt", default "csv")</p>
  
  <p>Set the format and extension of attack log.  Default is "csv" which can be opened directly by Excel.
  <br></p>
  
  <p>Setting: <code>AttackLogArchiveMaxMB</code>  (0 to 1 million, default 4)</p>
  
  <p>When the game first enter combat every launch, old attack log is archived through rename.
  Then log exceeding this size limit will be deleted in the background.
  <br></p>
  
  <p>Setting: <code>LogFolder</code>  (string, default "")</p>
  
  <p>Set path of mod log and attack log.  Default is empty which will use mod folder.</p>
</blockquote>

<h2 id="othersettings">Other Settings</h2>

<blockquote>
  <p>Setting: <code>FixWeaponStats</code>  (true/false, default true)</p>
  
  <p>Fix several known bugs of weapon stats:</p>
  
  <h1 id="deltalrmsextrainstability">Delta LRM's extra instability</h1>
  
  <h1 id="hollysrmsextraaccuracy">Holly SRM's extra accuracy</h1>
  
  <h1 id="erppcsmissingdebuff">ER PPC's missing debuff</h1>
  
  <h1 id="erlaserssmissingbonusdescription">ER lasers's missing bonus description</h1>
</blockquote>

<h1 id="compatibilities">Compatibilities</h1>

<ul>
<li>BattleTech 1.0 - AIM 1.0.1.</li>

<li>BattleTech 1.1 - AIM 1.0.1 to 2.1.2.</li>

<li>BattleTech 1.2 - AIM 2.2 to 3.1.</li>

<li>BattleTech 1.3 - AIM 3.1.</li>
</ul>

<p>Because of the <em>extensive</em> patching, this mod is sensitive to version updates.
I did my best to defensively code it given my limited free time.</p>

<p>AIM is aware of some other mods and will behave differently in their present to meet player expectations.</p>

<p>Mod settings changed by these behaviours are not saved.  If you want to replace them with AIM, you may need to change AIM settings.</p>

<p><strong><a href="https://www.nexusmods.com/battletech/mods/90">Real Hit Chance</a></strong>
AIM will enable corrected hit chance display and override this mod, since it does not support AIM features such as adjustable correction strength.</p>

<p><strong><a href="https://www.nexusmods.com/battletech/mods/100">True RNG Hit Rolls</a></strong>
AIM will disable its own adjustable roll correction and miss streak breaker.</p>

<p><strong><a href="https://github.com/McFistyBuns/CBTMovement">CBT Movement</a></strong>
AIM will log a warning that jumping modifier feature is duplicated and one of them should be zero.</p>

<p><strong><a href="https://github.com/CptMoore/MechEngineer">MechEngineer</a></strong>
AIM will bridge crit code with MechEngineer for component crit immunity and multi-stage crit components to work as expected.</p>

<p>The first thing to check when you suspect any compatibility problems with the game or with other mods is to remove or disable the mods.</p>

<p>You can also check the mod log (<code>BATTLETECH\Mods\AttackImprovementMod\Log_AIMAttackImprovementMod.log</code>), BTML log (<code>BATTLETECH\Mods\*.log</code>), and the game's own log (<code>BATTLETECH\</code>).
The keyword is "Exception".  It is almost always followed by lots of code.
If you see <em>any</em> exception with "AttackImprovementMod" in the code below it, please <a href="https://github.com/Sheep-y/Attack-Improvement-Mod/issues/new">file an issue</a> and attach the log.</p>

<h1 id="thestoryofaim">The Story of AIM</h1>

<p>If you asked me whether I would play a hardcore mech game like BattleTech, a month before I started doing this mod, my answer would be no.</p>

<p>This is my first serious game modding attempt, and is totally unexpected.</p>

<p>One day in summer 2018 when I pay the online game shops a visit, I noticed that one single game is is on the top of top sellers on GOG, Humble Store, and Steam.
The game is BATTLETECH.  It is not exactly my cup of tea, but I don't see that happens often either.
The game has just been launched, and Steam has a pretty big discount in my local currency.</p>

<p>By the time I finished the campaign, I have written a <a href="https://gamefaqs.gamespot.com/pc/205058-battletech/faqs/75955">GameFAQ guide</a> and a <a href="https://github.com/Sheep-y/Sheep-y.github.io/tree/dev/battletech/parser">data miner</a> in Node.js.</p>

<p>That is <em>almost</em> the end.</p>

<p>Except that I can't shake the feeling that the called hit chance is wrong.</p>

<p>So, I modded LRM and SRM to fire 500 shots and did some light testing, for the guide.
The first few tests fails my own testing standard, but the result is obvious: the numbers are VERY wrong, in game version 1.0.x.</p>

<p>After I improved my methodology, I did some <a href="https://steamcommunity.com/app/637090/discussions/0/1697176044370891096/">large scale tests</a> totaling over 60k missiles against live King Crabs.  For a while it was a hot topic on Steam.</p>

<p>The result is not pretty.  And I don't mean to the crabs.</p>

<p>Called shot at the head not only has lower chance to hit the head than non-called shots, but the head is biased in virtually all attacks and has double chance to be hit than intended by normal attacks.</p>

<p>Baffled by the result, I learned how to use programing tools to see game code.  Finding the bugs is the easy part.
Fixing it is the hard part, since I knew <em>nothing</em> about BattleTech, paper or code, and I <em>never</em> hijacked any code before.</p>

<p>I started by injecting loggings into the system, to learn the process.
These logs later become the Attack Log feature.
How about the roll correction?  A mod kills it.  Can I tune it down instead? (Play with formulas in Excel.) Ok, let's do that.
Hmm, now I need to show the modified hit chance. (Re-learn algebra and coded perhaps the most complicated formula in all BattleTech mods.)</p>

<p>Eventually I fixed the two bugs I intended to fix, plus fixing vehicle called shot. (Fixed in 1.2.0 beta, two months after AIM is released.)
When I am mostly done, game updates 1.1 landed just the day before I plan to release, and it changed how called shot works.
Took me two days to update the mod, before I went back to enjoy the game.</p>

<p>Or so I hoped.</p>

<p>In reality, I now see game bugs everywhere, and many many ways to improve the game.
I want to fix Multi-Target back out.  I want to fix the paper doll.  I want to see more information.  I want to colour the lines and open source it.
LadyAlekto of RogueTech also <em>helpfully</em> reported more game bugs in form of feature wishes.</p>

<p>All the bug fixes and new features and enhancements is much bigger than what I originally envisioned.
Even as I tie up AIM version 2.0, the ever expanding idea list grow at an even greater pace.
If there is an end in sight, it is an abrupt one when a game that I like better come out, such as Phoenix Point.</p>

<p>This is the story of how I went from "stay away from BattleTech" to "wrote 3500 lines of BattleTech mod" in three month's time.
Hey Paradox, are you hiring remote freelancer? Baby need nappies. ;)</p>

<h1 id="learntomod">Learn to Mod</h1>

<p>The <a href="https://github.com/Sheep-y/Attack-Improvement-Mod/">source code</a> of this mod is open and free.
You can take it, modify it, and even release it, provided that you include <em>your</em> code when you distribute your work, and don't claim my work as yours.
License: <a href="https://www.gnu.org/licenses/agpl-3.0.en.html">AGPL v3</a></p>

<p>Follow these steps to see game code and learn how BATTLETECH mod works:</p>

<ol>
<li>Install <a href="https://www.visualstudio.com/downloads/">Visual Studio</a> which is free.  This mod is developed with VS 2017 Community Edition.  You only need the ".NET desktop development" workload.</li>

<li>Down and Run <a href="https://github.com/0xd4d/dnSpy/releases">DnSpy</a></li>

<li>Select File > Open, and find <code>BATTLETECH\BattleTech_Data\Managed\Assembly-CSharp.dll</code>.  This will load the assembly.  It contains most BATTLETECH code.</li>

<li>You may now search and browse the assembly!  For example in Edit > Search you can type "GetCorrectedRoll" to find the method.  Clicking on it will show you the roll correction code.</li>

<li>Right click on method name (or any identifier) and click "Analyse".  It'll help you find where and how the method is called, or its override hierarchy.</li>

<li>Analyse is very fast because it works with compiled code.  It is not 100% accurate, though, sometimes you'll want to exported code and search there instead.</li>

<li>Left click the assembly, then File > Export to Project.  This will decompile all code which you can browse with other editor or IDE.</li>

<li>Head to the <a href="https://github.com/janxious/ModTek/wiki/">ModTek wiki</a> to learn how to make a mod.  For a code mode like this one, you need to compile a <a href="https://github.com/janxious/ModTek/wiki/Writing-ModTek-DLL-mods">dll</a> and perhaps a <a href="https://github.com/janxious/ModTek/wiki/The-mod.json-Format"><code>mod.json</code></a>.</li>

<li>The code of this mod is available on GitHub: https://github.com/Sheep-y/Attack-Improvement-Mod/ and you can also find other people's mods such as <a href="https://github.com/janxious/BTMLColorLOSMod">Firing Line Improvement</a> or <a href="https://github.com/Morphyum/MeleeMover">MeleeMover</a> and we all use different licenses.</li>

<li>You may notice that this patch manually calls Harmony to patch things, instead of using annotations.  This gives me much finer control.  Read <a href="https://github.com/pardeike/Harmony/wiki">Harmony wiki</a> to learn how it works.</li>
</ol>

<h1 id="credits">Credits</h1>

<ul>
<li>Many Thanks to Sheep-y, it was amazing to be able to spend time on your BattleMod, Modual Mod Loader :). </li>

<li>Thanks Mpstark (Michael Starkweather) for making BTML and ModTek and various mods and release them to the public domain.</li>

<li>Thanks LadyAlekto for various feature requests and cool proposals such as melee modifiers and ammo jettison.</li>

<li>Thanks CptMoore for GUI log code, which helps a lot in finding and adjusting GUI components.</li>

<li>And many more players on the BattleTechGame discord that gave comments and ideas.</li>
</ul>

<p>Despite feature overlap with some mods, this mod does not reference or use their code due to lack of license, and in most cases the approaches are different.</p></html>
