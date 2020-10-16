namespace CurePlease
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    #region "== Form2"

    public partial class OptionsForm : Form
    {
        #region "== Settings Class"
        public class JobTitles : List<JobTitles>
        {
            public int job_number
            {
                get; set;
            }

            public string job_name
            {
                get; set;
            }
        }

        [Serializable]
        public class MySettings
        {
            // BASE NEEDED FOR CONFIRMATION
            public bool settingsSet
            {
                get; set;
            }

            // HEALING SPELLS TAB
            public bool cure1enabled
            {
                get; set;
            }

            public int cure1amount
            {
                get; set;
            }

            public bool cure2enabled
            {
                get; set;
            }

            public int cure2amount
            {
                get; set;
            }

            public bool cure3enabled
            {
                get; set;
            }

            public int cure3amount
            {
                get; set;
            }

            public bool cure4enabled
            {
                get; set;
            }

            public int cure4amount
            {
                get; set;
            }

            public bool cure5enabled
            {
                get; set;
            }

            public int cure5amount
            {
                get; set;
            }

            public bool cure6enabled
            {
                get; set;
            }

            public int cure6amount
            {
                get; set;
            }

            public bool curagaEnabled
            {
                get; set;
            }

            public int curagaAmount
            {
                get; set;
            }

            public bool curaga2enabled
            {
                get; set;
            }

            public int curaga2Amount
            {
                get; set;
            }

            public bool curaga3enabled
            {
                get; set;
            }

            public int curaga3Amount
            {
                get; set;
            }

            public bool curaga4enabled
            {
                get; set;
            }

            public int curaga4Amount
            {
                get; set;
            }

            public bool curaga5enabled
            {
                get; set;
            }

            public int curaga5Amount
            {
                get; set;
            }

            public int curePercentage
            {
                get; set;
            }

            public int priorityCurePercentage
            {
                get; set;
            }

            public int monitoredCurePercentage
            {
                get; set;
            }

            public int curagaCurePercentage
            {
                get; set;
            }

            public int curagaTargetType
            {
                get; set;
            }

            public string curagaTargetName
            {
                get; set;
            }

            public decimal curagaRequiredMembers
            {
                get; set;
            }

            // ENHANCING MAGIC TAB / BASIC
            public decimal autoHasteMinutes
            {
                get; set;
            }

            public decimal autoAdloquiumMinutes
            {
                get; set;
            }

            public decimal autoPhalanxIIMinutes
            {
                get; set;
            }

            public decimal autoStormspellMinutes
            {
                get; set;
            }

            public decimal autoRefresh_Minutes
            {
                get; set;
            }

            public int autoRefresh_Spell
            {
                get; set;
            }

            public decimal autoRegen_Minutes
            {
                get; set;
            }

            public int autoRegen_Spell
            {
                get; set;
            }

            public decimal autoProtect_Minutes
            {
                get; set;
            }

            public int autoProtect_Spell
            {
                get; set;
            }

            public decimal autoShellMinutes
            {
                get; set;
            }

            public int autoShell_Spell
            {
                get; set;
            }
            public int autoStorm_Spell
            {
                get; set;
            }

            public bool plShellra
            {
                get; set;
            }

            public decimal plShellra_Level
            {
                get; set;
            }

            public bool plProtectra
            {
                get; set;
            }

            public decimal plProtectra_Level
            {
                get; set;
            }

            public bool plGainBoost
            {
                get; set;
            }

            public int plGainBoost_Spell
            {
                get; set;
            }

            public bool plBarElement
            {
                get; set;
            }

            public int plBarElement_Spell
            {
                get; set;
            }

            public bool AOE_Barelemental
            {
                get; set;
            }

            public bool plBarStatus
            {
                get; set;
            }

            public int plBarStatus_Spell
            {
                get; set;
            }

            public bool AOE_Barstatus
            {
                get; set;
            }

            public bool plAuspice
            {
                get; set;
            }

            public bool plRegen
            {
                get; set;
            }

            public int plRegen_Level
            {
                get; set;
            }

            public bool plReraise
            {
                get; set;
            }

            public int plReraise_Level
            {
                get; set;
            }

            public bool plRefresh
            {
                get; set;
            }

            public int plRefresh_Level
            {
                get; set;
            }

            public bool plProtect
            {
                get; set;
            }

            public bool plShell
            {
                get; set;
            }

            public bool plBlink
            {
                get; set;
            }

            public bool plPhalanx
            {
                get; set;
            }

            public bool plStoneskin
            {
                get; set;
            }

            public bool plTemper
            {
                get; set;
            }

            public int plTemper_Level
            {
                get; set;
            }

            public bool plEnspell
            {
                get; set;
            }

            public int plEnspell_Spell
            {
                get; set;
            }

            public bool plStormSpell
            {
                get; set;
            }

            public int plStormSpell_Spell
            {
                get; set;
            }

            public bool plAdloquium
            {
                get; set;
            }

            public bool plKlimaform
            {
                get; set;
            }

            public bool plAquaveil
            {
                get; set;
            }

            public bool plHaste
            {
                get; set;
            }

            public int plHaste_Level
            {
                get; set;
            }

            public bool plSpikes
            {
                get; set;
            }

            public int plSpikes_Spell
            {
                get; set;
            }

            public bool plUtsusemi
            {
                get; set;
            }

            // ENHANCING MAGIC TAB / SCHOLAR

            public bool accessionCure
            {
                get; set;
            }

            public bool accessionProShell
            {
                get; set;
            }

            public bool AccessionRegen
            {
                get; set;
            }

            public bool PerpetuanceRegen
            {
                get; set;
            }


            public bool regenPerpetuance
            {
                get; set;
            }

            public bool regenAccession
            {
                get; set;
            }




            public bool refreshPerpetuance
            {
                get; set;
            }

            public bool refreshAccession
            {
                get; set;
            }

            public bool blinkPerpetuance
            {
                get; set;
            }

            public bool blinkAccession
            {
                get; set;
            }

            public bool phalanxPerpetuance
            {
                get; set;
            }

            public bool phalanxAccession
            {
                get; set;
            }

            public bool stoneskinPerpetuance
            {
                get; set;
            }

            public bool stoneskinAccession
            {
                get; set;
            }

            public bool enspellPerpetuance
            {
                get; set;
            }

            public bool enspellAccession
            {
                get; set;
            }

            public bool stormspellPerpetuance
            {
                get; set;
            }

            public bool stormspellAccession
            {
                get; set;
            }

            public bool adloquiumPerpetuance
            {
                get; set;
            }

            public bool adloquiumAccession
            {
                get; set;
            }

            public bool aquaveilPerpetuance
            {
                get; set;
            }

            public bool aquaveilAccession
            {
                get; set;
            }

            public bool barspellPerpetuance
            {
                get; set;
            }

            public bool barspellAccession
            {
                get; set;
            }

            public bool barstatusPerpetuance
            {
                get; set;
            }

            public bool barstatusAccession
            {
                get; set;
            }

            public bool EnlightenmentReraise
            {
                get; set;
            }

            // GEOMANCY MAGIC TAB
            public bool EnableGeoSpells
            {
                get; set;
            }

            public bool IndiWhenEngaged
            {
                get; set;
            }

            public bool EnableLuopanSpells
            {
                get; set;
            }

            public bool GeoWhenEngaged
            {
                get; set;
            }

            public bool specifiedEngageTarget
            {
                get; set;
            }

            public int IndiSpell_Spell
            {
                get; set;
            }

            public int GeoSpell_Spell
            {
                get; set;
            }

            public int EntrustedSpell_Spell
            {
                get; set;
            }

            public string LuopanSpell_Target
            {
                get; set;
            }

            public string EntrustedSpell_Target
            {
                get; set;
            }

            // SINGING MAGIC TAB
            public bool enableSinging
            {
                get; set;
            }

            public bool recastSongs_Monitored
            {
                get; set;
            }

            public bool SongsOnlyWhenNear
            {
                get; set;
            }

            public int song1
            {
                get; set;
            }

            public int song2
            {
                get; set;
            }

            public int song3
            {
                get; set;
            }

            public int song4
            {
                get; set;
            }

            public int dummy1
            {
                get; set;
            }

            public int dummy2
            {
                get; set;
            }

            public decimal recastSongTime
            {
                get; set;
            }

            // JOB ABILITIES

            // SCH
            public bool LightArts
            {
                get; set;
            }

            public bool Sublimation
            {
                get; set;
            }

            public bool AddendumWhite
            {
                get; set;
            }

            public bool Celerity
            {
                get; set;
            }

            public bool Accession
            {
                get; set;
            }

            public bool Perpetuance
            {
                get; set;
            }

            public bool Penury
            {
                get; set;
            }

            public bool Rapture
            {
                get; set;
            }
            public bool DarkArts
            {
                get; set;
            }

            public bool AddendumBlack
            {
                get; set;
            }

            // WHM
            public bool AfflatusSolace
            {
                get; set;
            }

            public bool AfflatusMisery
            {
                get; set;
            }

            public bool DivineSeal
            {
                get; set;
            }

            public bool Devotion
            {
                get; set;
            }

            public bool DivineCaress
            {
                get; set;
            }

            // RDM
            public bool Composure
            {
                get; set;
            }

            public bool Convert
            {
                get; set;
            }

            // GEO
            public bool Entrust
            {
                get; set;
            }

            public bool FullCircle
            {
                get; set;
            }

            public bool Dematerialize
            {
                get; set;
            }

            public bool BlazeOfGlory
            {
                get; set;
            }

            public bool RadialArcana
            {
                get; set;
            }

            public bool EclipticAttrition
            {
                get; set;
            }

            public bool LifeCycle
            {
                get; set;
            }

            // BRD
            public bool Pianissimo
            {
                get; set;
            }

            public bool Nightingale
            {
                get; set;
            }

            public bool Troubadour
            {
                get; set;
            }

            public bool Marcato
            {
                get; set;
            }

            // DEBUFF REMOVAL
            public bool plDebuffEnabled
            {
                get; set;
            }

            public bool monitoredDebuffEnabled
            {
                get; set;
            }

            public bool enablePartyDebuffRemoval
            {
                get; set;
            }

            public bool SpecifiednaSpellsenable
            {
                get; set;
            }

            public bool PrioritiseOverLowerTier
            {
                get; set;
            }

            public bool plSilenceItemEnabled
            {
                get; set;
            }

            public int plSilenceItem
            {
                get; set;
            }

            public bool plDoomEnabled
            {
                get; set;
            }

            public int plDoomitem
            {
                get; set;
            }

            public bool wakeSleepEnabled
            {
                get; set;
            }

            public int wakeSleepSpell
            {
                get; set;
            }

            // PARTY DEBUFFS
            public bool naBlindness
            {
                get; set;
            }

            public bool naCurse
            {
                get; set;
            }

            public bool naDisease
            {
                get; set;
            }

            public bool naParalysis
            {
                get; set;
            }

            public bool naPetrification
            {
                get; set;
            }

            public bool naPlague
            {
                get; set;
            }

            public bool naPoison
            {
                get; set;
            }

            public bool naSilence
            {
                get; set;
            }

            public bool naErase
            {
                get; set;
            }

            public bool Esuna
            {
                get;
                set;
            }

            public bool EsunaOnlyAmnesia
            {
                get;
                set;
            }

            // PL DEBUFFS
            public bool plAgiDown
            {
                get; set;
            }

            public bool plAccuracyDown
            {
                get; set;
            }

            public bool plAddle
            {
                get; set;
            }

            public bool plAttackDown
            {
                get; set;
            }

            public bool plBane
            {
                get; set;
            }

            public bool plBind
            {
                get; set;
            }

            public bool plBio
            {
                get; set;
            }

            public bool plBlindness
            {
                get; set;
            }

            public bool plBurn
            {
                get; set;
            }

            public bool plChrDown
            {
                get; set;
            }

            public bool plChoke
            {
                get; set;
            }

            public bool plCurse
            {
                get; set;
            }

            public bool plCurse2
            {
                get; set;
            }

            public bool plDexDown
            {
                get; set;
            }

            public bool plDefenseDown
            {
                get; set;
            }

            public bool plDia
            {
                get; set;
            }

            public bool plDisease
            {
                get; set;
            }

            public bool plDoom
            {
                get; set;
            }

            public bool plDrown
            {
                get; set;
            }

            public bool plElegy
            {
                get; set;
            }

            public bool plEvasionDown
            {
                get; set;
            }

            public bool plFlash
            {
                get; set;
            }

            public bool plFrost
            {
                get; set;
            }

            public bool plHelix
            {
                get; set;
            }

            public bool plIntDown
            {
                get; set;
            }

            public bool plMndDown
            {
                get; set;
            }

            public bool plMagicAccDown
            {
                get; set;
            }

            public bool plMagicAtkDown
            {
                get; set;
            }

            public bool plMaxHpDown
            {
                get; set;
            }

            public bool plMaxMpDown
            {
                get; set;
            }

            public bool plMaxTpDown
            {
                get; set;
            }

            public bool plParalysis
            {
                get; set;
            }

            public bool plPlague
            {
                get; set;
            }

            public bool plPoison
            {
                get; set;
            }

            public bool plRasp
            {
                get; set;
            }

            public bool plRequiem
            {
                get; set;
            }

            public bool plStrDown
            {
                get; set;
            }

            public bool plShock
            {
                get; set;
            }

            public bool plSilence
            {
                get; set;
            }

            public bool plSlow
            {
                get; set;
            }

            public bool plThrenody
            {
                get; set;
            }

            public bool plVitDown
            {
                get; set;
            }

            public bool plWeight
            {
                get; set;
            }

            public bool plAmnesia
            {
                get;
                set;
            }

            // MONITORED DEBUFFS
            public bool monitoredAgiDown
            {
                get; set;
            }

            public bool monitoredAccuracyDown
            {
                get; set;
            }

            public bool monitoredAddle
            {
                get; set;
            }

            public bool monitoredAttackDown
            {
                get; set;
            }

            public bool monitoredBane
            {
                get; set;
            }

            public bool monitoredBind
            {
                get; set;
            }

            public bool monitoredBio
            {
                get; set;
            }

            public bool monitoredBlindness
            {
                get; set;
            }

            public bool monitoredBurn
            {
                get; set;
            }

            public bool monitoredChrDown
            {
                get; set;
            }

            public bool monitoredChoke
            {
                get; set;
            }

            public bool monitoredCurse
            {
                get; set;
            }

            public bool monitoredCurse2
            {
                get; set;
            }

            public bool monitoredDexDown
            {
                get; set;
            }

            public bool monitoredDefenseDown
            {
                get; set;
            }

            public bool monitoredDia
            {
                get; set;
            }

            public bool monitoredDisease
            {
                get; set;
            }

            public bool monitoredDoom
            {
                get; set;
            }

            public bool monitoredDrown
            {
                get; set;
            }

            public bool monitoredElegy
            {
                get; set;
            }

            public bool monitoredEvasionDown
            {
                get; set;
            }

            public bool monitoredFlash
            {
                get; set;
            }

            public bool monitoredFrost
            {
                get; set;
            }

            public bool monitoredHelix
            {
                get; set;
            }

            public bool monitoredIntDown
            {
                get; set;
            }

            public bool monitoredMndDown
            {
                get; set;
            }

            public bool monitoredMagicAccDown
            {
                get; set;
            }

            public bool monitoredMagicAtkDown
            {
                get; set;
            }

            public bool monitoredMaxHpDown
            {
                get; set;
            }

            public bool monitoredMaxMpDown
            {
                get; set;
            }

            public bool monitoredMaxTpDown
            {
                get; set;
            }

            public bool monitoredParalysis
            {
                get; set;
            }

            public bool monitoredPetrification
            {
                get; set;
            }

            public bool monitoredPlague
            {
                get; set;
            }

            public bool monitoredPoison
            {
                get; set;
            }

            public bool monitoredRasp
            {
                get; set;
            }

            public bool monitoredRequiem
            {
                get; set;
            }

            public bool monitoredStrDown
            {
                get; set;
            }

            public bool monitoredShock
            {
                get; set;
            }

            public bool monitoredSilence
            {
                get; set;
            }

            public bool monitoredSleep
            {
                get; set;
            }

            public bool monitoredSleep2
            {
                get; set;
            }

            public bool monitoredSlow
            {
                get; set;
            }

            public bool monitoredThrenody
            {
                get; set;
            }

            public bool monitoredVitDown
            {
                get; set;
            }

            public bool monitoredWeight
            {
                get; set;
            }

            public bool monitoredAmnesia
            {
                get;
                set;
            }

            // NA SPECIFICATION CHECKBOXES

            public bool na_Weight
            {
                get; set;
            }

            public bool na_VitDown
            {
                get; set;
            }

            public bool na_Threnody
            {
                get; set;
            }

            public bool na_Slow
            {
                get; set;
            }

            public bool na_Shock
            {
                get; set;
            }

            public bool na_StrDown
            {
                get; set;
            }

            public bool na_Requiem
            {
                get; set;
            }

            public bool na_Rasp
            {
                get; set;
            }

            public bool na_MaxTpDown
            {
                get; set;
            }

            public bool na_MaxMpDown
            {
                get; set;
            }

            public bool na_MaxHpDown
            {
                get; set;
            }

            public bool na_MagicAttackDown
            {
                get; set;
            }

            public bool na_MagicAccDown
            {
                get; set;
            }

            public bool na_MagicDefenseDown
            {
                get; set;
            }

            public bool na_MndDown
            {
                get; set;
            }

            public bool na_IntDown
            {
                get; set;
            }

            public bool na_Helix
            {
                get; set;
            }

            public bool na_Frost
            {
                get; set;
            }

            public bool na_EvasionDown
            {
                get; set;
            }

            public bool na_Elegy
            {
                get; set;
            }

            public bool na_Drown
            {
                get; set;
            }

            public bool na_Dia
            {
                get; set;
            }

            public bool na_DefenseDown
            {
                get; set;
            }

            public bool na_DexDown
            {
                get; set;
            }

            public bool na_Choke
            {
                get; set;
            }

            public bool na_ChrDown
            {
                get; set;
            }

            public bool na_Burn
            {
                get; set;
            }

            public bool na_Bio
            {
                get; set;
            }

            public bool na_Bind
            {
                get; set;
            }

            public bool na_AttackDown
            {
                get; set;
            }

            public bool na_Addle
            {
                get; set;
            }

            public bool na_AccuracyDown
            {
                get; set;
            }

            public bool na_AgiDown
            {
                get; set;
            }

            // OTHER SETTINGS

            // MP OPTIONS
            public decimal mpMinCastValue
            {
                get; set;
            }

            public bool lowMPcheckBox
            {
                get; set;
            }

            public bool healLowMP
            {
                get; set;
            }

            public decimal healWhenMPBelow
            {
                get; set;
            }

            public bool standAtMP
            {
                get; set;
            }

            public decimal standAtMP_Percentage
            {
                get; set;
            }

            // CONVERT SETTINGS
            public decimal convertMP
            {
                get; set;
            }

            // SUBLIMATION SETTINGS
            public decimal sublimationMP
            {
                get; set;
            }

            // FULL CIRCLE SETTINGS
            public bool Fullcircle_DisableEnemy
            {
                get; set;
            }
            public bool Fullcircle_GEOTarget
            {
                get; set;
            }

            // RADIAL ARCANA SETTINGS
            public decimal RadialArcanaMP
            {
                get; set;
            }

            public int RadialArcana_Spell
            {
                get; set;
            }

            // DEVOTION SETTINGS
            public decimal DevotionMP
            {
                get; set;
            }

            public int DevotionTargetType
            {
                get; set;
            }

            public string DevotionTargetName
            {
                get; set;
            }

            public bool DevotionWhenEngaged
            {
                get; set;
            }

            //AUTO CASTING SPELLS OPTIONS
            public bool autoTarget
            {
                get; set;
            }

            public int Hate_SpellType
            {
                get; set;
            }

            public string autoTargetSpell
            {
                get; set;
            }

            public string autoTarget_Target
            {
                get; set;
            }

            public bool AssistSpecifiedTarget
            {
                get; set;
            }

            // DISABLE CANCEL TARGETTING
            public bool DisableTargettingCancel
            {
                get; set;
            }

            // DELAY BEFORE REMOVING TARGET
            public decimal TargetRemoval_Delay
            {
                get; set;
            }

            // RAISE SETTINGS
            public bool AcceptRaise
            {
                get; set;
            }

            public bool AcceptRaiseOnlyWhenNotInCombat
            {
                get; set;
            }

            // CURING OPTIONS
            public bool Overcure
            {
                get; set;
            }

            public bool Undercure
            {
                get; set;
            }

            public bool enableMonitoredPriority
            {
                get; set;
            }

            public bool enableOutOfPartyHealing
            {
                get; set;
            }

            public bool OvercureOnHighPriority
            {
                get; set;
            }

            public bool EnableAddOn
            {
                get; set;
            }

            // PROGRAM OPTIONS

            // PAUSE OPTIONS
            public bool pauseOnZoneBox
            {
                get; set;
            }

            public bool pauseOnStartBox
            {
                get; set;
            }

            public bool pauseOnKO
            {
                get; set;
            }

            public bool MinimiseonStart
            {
                get; set;
            }

            // AUTO FOLLOW OPTIONS
            public string autoFollowName
            {
                get; set;
            }

            public decimal autoFollowDistance
            {
                get; set;
            }

            public bool autoFollow_Warning
            {
                get; set;
            }

            public bool FFXIDefaultAutoFollow
            {
                get; set;
            }
            public bool enableHotKeys
            {
                get; set;
            }

            // FAST CAST MODE
            public bool enableFastCast_Mode
            {
                get; set;
            }

            // trackCastingPacketsMODE
            public bool trackCastingPackets
            {
                get; set;
            }

            // ADD ON OPTIONS
            public string ipAddress
            {
                get; set;
            }

            public string listeningPort
            {
                get; set;
            }
        }

        #endregion "== Settings Class"

        public static MySettings config = new MySettings();
        public List<JobTitles> JobNames = new List<JobTitles>();
        public int runOnce = 0;

        public OptionsForm ( )
        {
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent ( );

            JobNames.Add ( new JobTitles
            {
                job_number = 1,
                job_name = "WAR",
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 2,
                job_name = "MNK"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 3,
                job_name = "WHM"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 4,
                job_name = "BLM"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 5,
                job_name = "RDM"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 6,
                job_name = "THF"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 7,
                job_name = "PLD"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 8,
                job_name = "DRK"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 9,
                job_name = "BST"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 10,
                job_name = "BRD"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 11,
                job_name = "RNG"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 12,
                job_name = "SAM"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 13,
                job_name = "NIN"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 14,
                job_name = "DRG"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 15,
                job_name = "SMN"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 16,
                job_name = "BLU"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 17,
                job_name = "COR"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 18,
                job_name = "PUP"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 19,
                job_name = "DNC"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 20,
                job_name = "SCH"
            } );

            JobNames.Add ( new JobTitles
            {
                job_number = 21,
                job_name = "GEO"
            } );
            JobNames.Add ( new JobTitles
            {
                job_number = 22,
                job_name = "RUN"
            } );

            if ( config.settingsSet != true )
            {
                // HEALING MAGIC
                config.cure1enabled = false;
                config.cure2enabled = false;
                config.cure3enabled = true;
                config.cure4enabled = true;
                config.cure5enabled = true;
                config.cure6enabled = true;
                config.cure1amount = 10;
                config.cure2amount = 60;
                config.cure3amount = 130;
                config.cure4amount = 270;
                config.cure5amount = 450;
                config.cure6amount = 600;
                config.curePercentage = 75;
                config.monitoredCurePercentage = 85;
                config.priorityCurePercentage = 95;

                config.curagaEnabled = false;
                config.curaga2enabled = false;
                config.curaga3enabled = false;
                config.curaga4enabled = false;
                config.curaga5enabled = false;
                config.curagaAmount = 20;
                config.curaga2Amount = 70;
                config.curaga3Amount = 165;
                config.curaga4Amount = 330;
                config.curaga5Amount = 570;
                config.curagaCurePercentage = 75;
                config.curagaTargetType = 0;
                config.curagaTargetName = "";
                config.curagaRequiredMembers = 3;

                // ENHANCING MAGIC

                // BASIC ENHANCING
                config.autoHasteMinutes = 2;
                config.autoAdloquiumMinutes = 2;
                config.autoProtect_Minutes = 29;
                config.autoShellMinutes = 29;
                config.autoPhalanxIIMinutes = 2;
                config.autoStormspellMinutes = 3;
                config.autoRefresh_Minutes = 2;
                config.autoRegen_Minutes = 1;
                config.autoRefresh_Minutes = 2;
                config.plProtect = false;
                config.plShell = false;
                config.plBlink = false;
                config.plReraise = false;
                config.autoRegen_Spell = 3;
                config.autoRefresh_Spell = 1;
                config.autoShell_Spell = 4;
                config.autoStorm_Spell = 0;
                config.autoProtect_Spell = 4;
                config.plRegen = false;
                config.plRegen_Level = 4;
                config.plReraise = false;
                config.plReraise_Level = 2;
                config.plRefresh = false;
                config.plRefresh_Level = 2;
                config.plStoneskin = false;
                config.plPhalanx = false;
                config.plProtectra = false;
                config.plShellra = false;
                config.plProtectra_Level = 5;
                config.plShellra_Level = 5;
                config.plTemper = false;
                config.plTemper_Level = 0;
                config.plEnspell = false;
                config.plEnspell_Spell = 0;
                config.plGainBoost = false;
                config.plGainBoost_Spell = 0;
                config.plBarElement = false;
                config.plBarElement_Spell = 0;
                config.AOE_Barelemental = false;
                config.plBarStatus = false;
                config.plBarStatus_Spell = 0;
                config.AOE_Barstatus = false;
                config.plStormSpell = false;
                config.plAdloquium = false;
                config.plKlimaform = false;
                config.plStormSpell_Spell = 0;
                config.plAuspice = false;
                config.plAquaveil = false;
                config.plHaste = false;
                config.plHaste_Level = 0;
                config.plSpikes = false;
                config.plSpikes_Spell = 0;

                config.plUtsusemi = false;

                // SCHOLAR STRATAGEMS
                config.AccessionRegen = false;
                config.PerpetuanceRegen = false;
                config.accessionCure = false;
                config.accessionProShell = false;

                config.regenPerpetuance = false;
                config.regenAccession = false;
                config.refreshPerpetuance = false;
                config.refreshAccession = false;
                config.blinkPerpetuance = false;
                config.blinkAccession = false;
                config.phalanxPerpetuance = false;
                config.phalanxAccession = false;
                config.stoneskinPerpetuance = false;
                config.stoneskinAccession = false;
                config.enspellPerpetuance = false;
                config.enspellAccession = false;
                config.stormspellPerpetuance = false;
                config.stormspellAccession = false;
                config.adloquiumPerpetuance = false;
                config.adloquiumAccession = false;
                config.aquaveilPerpetuance = false;
                config.aquaveilAccession = false;
                config.barspellPerpetuance = false;
                config.barspellAccession = false;
                config.barstatusPerpetuance = false;
                config.barstatusAccession = false;

                config.EnlightenmentReraise = false;

                // GEOMANCER
                config.EnableGeoSpells = false;
                config.GeoWhenEngaged = false;
                config.GeoSpell_Spell = 0;
                config.LuopanSpell_Target = "";
                config.IndiSpell_Spell = 0;
                config.EntrustedSpell_Spell = 0;
                config.EntrustedSpell_Target = "";
                config.EnableLuopanSpells = false;
                config.GeoWhenEngaged = false;

                config.specifiedEngageTarget = false;

                // SINGING
                config.enableSinging = false;
                config.song1 = 0;
                config.song2 = 0;
                config.song3 = 0;
                config.song4 = 0;
                config.dummy1 = 0;
                config.dummy2 = 0;
                config.recastSongTime = 2;
                config.enableSinging = false;
                config.recastSongs_Monitored = false;
                config.SongsOnlyWhenNear = false;

                // JOB ABILITIES
                config.AfflatusSolace = false;
                config.AfflatusMisery = false;
                config.LightArts = false;
                config.Composure = false;
                config.Convert = false;
                config.DivineSeal = false;
                config.AddendumWhite = false;
                config.Sublimation = false;
                config.Celerity = false;
                config.Accession = false;
                config.Perpetuance = false;
                config.Penury = false;
                config.Rapture = false;
                config.EclipticAttrition = false;
                config.LifeCycle = false;
                config.Entrust = false;
                config.Dematerialize = false;
                config.FullCircle = false;
                config.BlazeOfGlory = false;
                config.RadialArcana = false;
                config.Troubadour = false;
                config.Nightingale = false;
                config.Marcato = false;
                config.Devotion = false;
                config.DivineCaress = false;
                config.DarkArts = false;
                config.AddendumBlack = false;

                // DEBUFF REMOVAL
                config.plSilenceItemEnabled = false;
                config.plSilenceItem = 0;
                config.wakeSleepEnabled = false;
                config.wakeSleepSpell = 2;
                config.plDoomEnabled = false;
                config.plDoomitem = 0;

                config.plDebuffEnabled = false;
                config.plAgiDown = false;
                config.plAccuracyDown = false;
                config.plAddle = false;
                config.plAttackDown = false;
                config.plBane = false;
                config.plBind = false;
                config.plBio = false;
                config.plBlindness = false;
                config.plBurn = false;
                config.plChrDown = false;
                config.plChoke = false;
                config.plCurse = false;
                config.plCurse2 = false;
                config.plDexDown = false;
                config.plDefenseDown = false;
                config.plDia = false;
                config.plDisease = false;
                config.plDoom = false;
                config.plDrown = false;
                config.plElegy = false;
                config.plEvasionDown = false;
                config.plFlash = false;
                config.plFrost = false;
                config.plHelix = false;
                config.plIntDown = false;
                config.plMndDown = false;
                config.plMagicAccDown = false;
                config.plMagicAtkDown = false;
                config.plMaxHpDown = false;
                config.plMaxMpDown = false;
                config.plMaxTpDown = false;
                config.plParalysis = false;
                config.plPlague = false;
                config.plPoison = false;
                config.plRasp = false;
                config.plRequiem = false;
                config.plStrDown = false;
                config.plShock = false;
                config.plSilence = false;
                config.plSlow = false;
                config.plThrenody = false;
                config.plVitDown = false;
                config.plWeight = false;
                config.plAmnesia = false;

                config.enablePartyDebuffRemoval = false;
                config.SpecifiednaSpellsenable = false;
                config.naBlindness = false;
                config.naCurse = false;
                config.naDisease = false;
                config.naParalysis = false;
                config.naPetrification = false;
                config.naPlague = false;
                config.naPoison = false;
                config.naSilence = false;
                config.naErase = false;
                config.Esuna = false;
                config.EsunaOnlyAmnesia = false;

                config.PrioritiseOverLowerTier = false;

                config.monitoredDebuffEnabled = false;
                config.monitoredAgiDown = false;
                config.monitoredAccuracyDown = false;
                config.monitoredAddle = false;
                config.monitoredAttackDown = false;
                config.monitoredBane = false;
                config.monitoredBind = false;
                config.monitoredBio = false;
                config.monitoredBlindness = false;
                config.monitoredBurn = false;
                config.monitoredChrDown = false;
                config.monitoredChoke = false;
                config.monitoredCurse = false;
                config.monitoredCurse2 = false;
                config.monitoredDexDown = false;
                config.monitoredDefenseDown = false;
                config.monitoredDia = false;
                config.monitoredDisease = false;
                config.monitoredDoom = false;
                config.monitoredDrown = false;
                config.monitoredElegy = false;
                config.monitoredEvasionDown = false;
                config.monitoredFlash = false;
                config.monitoredFrost = false;
                config.monitoredHelix = false;
                config.monitoredIntDown = false;
                config.monitoredMndDown = false;
                config.monitoredMagicAccDown = false;
                config.monitoredMagicAtkDown = false;
                config.monitoredMaxHpDown = false;
                config.monitoredMaxMpDown = false;
                config.monitoredMaxTpDown = false;
                config.monitoredParalysis = false;
                config.monitoredPetrification = false;
                config.monitoredPlague = false;
                config.monitoredPoison = false;
                config.monitoredRasp = false;
                config.monitoredRequiem = false;
                config.monitoredStrDown = false;
                config.monitoredShock = false;
                config.monitoredSilence = false;
                config.monitoredSleep = false;
                config.monitoredSleep2 = false;
                config.monitoredSlow = false;
                config.monitoredThrenody = false;
                config.monitoredVitDown = false;
                config.monitoredWeight = false;
                config.monitoredAmnesia = false;

                config.na_Weight = false;
                config.na_VitDown = false;
                config.na_Threnody = false;
                config.na_Slow = false;
                config.na_Shock = false;
                config.na_StrDown = false;
                config.na_Requiem = false;
                config.na_Rasp = false;
                config.na_MaxTpDown = false;
                config.na_MaxMpDown = false;
                config.na_MaxHpDown = false;
                config.na_MagicAttackDown = false;
                config.na_MagicDefenseDown = false;
                config.na_MagicAccDown = false;
                config.na_MndDown = false;
                config.na_IntDown = false;
                config.na_Helix = false;
                config.na_Frost = false;
                config.na_EvasionDown = false;
                config.na_Elegy = false;
                config.na_Drown = false;
                config.na_Dia = false;
                config.na_DefenseDown = false;
                config.na_DexDown = false;
                config.na_Choke = false;
                config.na_ChrDown = false;
                config.na_Burn = false;
                config.na_Bio = false;
                config.na_Bind = false;
                config.na_AttackDown = false;
                config.na_Addle = false;
                config.na_AccuracyDown = false;
                config.na_AgiDown = false;

                // OTHER OPTIONS

                config.lowMPcheckBox = false;
                config.mpMinCastValue = 100;

                config.autoTarget = false;
                config.autoTargetSpell = "Dia";
                config.AssistSpecifiedTarget = false;

                config.DisableTargettingCancel = false;
                config.TargetRemoval_Delay = 3;

                config.AcceptRaise = false;
                config.AcceptRaiseOnlyWhenNotInCombat = false;

                config.Fullcircle_DisableEnemy = false;
                config.Fullcircle_GEOTarget = false;

                config.RadialArcana_Spell = 0;
                config.RadialArcanaMP = 300;

                config.convertMP = 300;

                config.DevotionMP = 200;

                config.DevotionTargetType = 1;
                config.DevotionTargetName = "";
                config.DevotionWhenEngaged = false;

                config.Hate_SpellType = 0;
                config.autoTarget_Target = "";

                config.healWhenMPBelow = 5;
                config.healLowMP = false;

                config.standAtMP_Percentage = 99;
                config.standAtMP = false;

                config.Overcure = true;
                config.Undercure = true;
                config.enableMonitoredPriority = false;
                config.enableOutOfPartyHealing = true;
                config.OvercureOnHighPriority = false;

                config.EnableAddOn = false;

                config.sublimationMP = 100;

                // PROGRAM OPTIONS

                config.pauseOnZoneBox = false;
                config.pauseOnStartBox = false;
                config.pauseOnKO = false;
                config.MinimiseonStart = false;

                config.autoFollowName = "";
                config.autoFollowDistance = 5;
                config.autoFollow_Warning = false;
                config.FFXIDefaultAutoFollow = false;
                config.enableHotKeys = false;

                config.ipAddress = "127.0.0.1";
                config.listeningPort = "19769";

                config.enableFastCast_Mode = false;
                config.trackCastingPackets = false;

                // OTHERS

                config.settingsSet = true;
            }

            updateForm ( config );

            string path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Settings");
            if ( loadJobSettings.Checked == false && System.IO.File.Exists ( path + "/loadSettings" ) )
            {
                loadJobSettings.Checked = true;
            }
            else
            {
                loadJobSettings.Checked = false;
            }
        }

        #endregion "== Form2"

        #region "== Cure Percentage's Changed"

        private void curePercentage_ValueChanged ( object sender, EventArgs e )
        {
            curePercentageValueLabel.Text = curePercentage.Value.ToString ( );
        }

        private void priorityCurePercentage_ValueChanged ( object sender, EventArgs e )
        {
            priorityCurePercentageValueLabel.Text = priorityCurePercentage.Value.ToString ( );
        }

        private void curagaPercentage_ValueChanged ( object sender, EventArgs e )
        {
            curagaPercentageValueLabel.Text = curagaCurePercentage.Value.ToString ( );
        }

        private void monitoredPercentage_ValueChanged ( object sender, EventArgs e )
        {
            monitoredCurePercentageValueLabel.Text = monitoredCurePercentage.Value.ToString ( );
        }

        #endregion "== Cure Percentage's Changed"

        #region "== All Settings Saved"

        public void button4_Click ( object sender, EventArgs e )
        {
            // HEALING MAGIC
            config.cure1enabled = cure1enabled.Checked;
            config.cure2enabled = cure2enabled.Checked;
            config.cure3enabled = cure3enabled.Checked;
            config.cure4enabled = cure4enabled.Checked;
            config.cure5enabled = cure5enabled.Checked;
            config.cure6enabled = cure6enabled.Checked;
            config.cure1amount = Convert.ToInt32 ( cure1amount.Value );
            config.cure2amount = Convert.ToInt32 ( cure2amount.Value );
            config.cure3amount = Convert.ToInt32 ( cure3amount.Value );
            config.cure4amount = Convert.ToInt32 ( cure4amount.Value );
            config.cure5amount = Convert.ToInt32 ( cure5amount.Value );
            config.cure6amount = Convert.ToInt32 ( cure6amount.Value );
            config.curePercentage = curePercentage.Value;
            config.priorityCurePercentage = priorityCurePercentage.Value;
            config.monitoredCurePercentage = monitoredCurePercentage.Value;

            config.curagaEnabled = curagaEnabled.Checked;
            config.curaga2enabled = curaga2Enabled.Checked;
            config.curaga3enabled = curaga3Enabled.Checked;
            config.curaga4enabled = curaga4Enabled.Checked;
            config.curaga5enabled = curaga5Enabled.Checked;
            config.curagaAmount = Convert.ToInt32 ( curagaAmount.Value );
            config.curaga2Amount = Convert.ToInt32 ( curaga2Amount.Value );
            config.curaga3Amount = Convert.ToInt32 ( curaga3Amount.Value );
            config.curaga4Amount = Convert.ToInt32 ( curaga4Amount.Value );
            config.curaga5Amount = Convert.ToInt32 ( curaga5Amount.Value );
            config.curagaCurePercentage = curagaCurePercentage.Value;
            config.curagaTargetType = curagaTargetType.SelectedIndex;
            config.curagaTargetName = curagaTargetName.Text;
            config.curagaRequiredMembers = requiredCuragaNumbers.Value;

            // ENHANCING MAGIC

            // BASIC ENHANCING
            config.autoHasteMinutes = autoHasteMinutes.Value;
            config.autoAdloquiumMinutes = autoAdloquium_Minutes.Value;
            config.autoProtect_Minutes = autoProtect_Minutes.Value;
            config.autoShellMinutes = autoShell_Minutes.Value;
            config.autoPhalanxIIMinutes = autoPhalanxIIMinutes.Value;
            config.autoStormspellMinutes = autoStormspellMinutes.Value;
            config.autoRegen_Minutes = autoRegen_Minutes.Value;
            config.autoRefresh_Minutes = autoRefresh_Minutes.Value;
            config.plProtect = plProtect.Checked;
            config.plShell = plShell.Checked;
            config.plBlink = plBlink.Checked;
            config.plReraise = plReraise.Checked;
            if ( plReraiseLevel1.Checked )
            {
                config.plReraise_Level = 1;
            }
            else if ( plReraiseLevel2.Checked )
            {
                config.plReraise_Level = 2;
            }
            else if ( plReraiseLevel3.Checked )
            {
                config.plReraise_Level = 3;
            }
            else if ( plReraiseLevel4.Checked )
            {
                config.plReraise_Level = 4;
            }
            config.plRegen = plRegen.Checked;
            if ( plRegenLevel1.Checked )
            {
                config.plRegen_Level = 1;
            }
            else if ( plRegenLevel2.Checked )
            {
                config.plRegen_Level = 2;
            }
            else if ( plRegenLevel3.Checked )
            {
                config.plRegen_Level = 3;
            }
            else if ( plRegenLevel4.Checked )
            {
                config.plRegen_Level = 4;
            }
            else if ( plRegenLevel5.Checked )
            {
                config.plRegen_Level = 5;
            }
            config.plStoneskin = plStoneskin.Checked;
            config.plPhalanx = plPhalanx.Checked;
            config.plShellra = plShellra.Checked;
            config.plProtectra = plProtectra.Checked;
            config.plProtectra_Level = plProtectralevel.Value;
            config.plShellra_Level = plShellralevel.Value;
            config.autoRegen_Spell = autoRegen.SelectedIndex;
            config.autoRefresh_Spell = autoRefresh.SelectedIndex;
            config.autoShell_Spell = autoShell.SelectedIndex;
            config.autoStorm_Spell = autoStorm.SelectedIndex;
            config.autoProtect_Spell = autoProtect.SelectedIndex;
            config.plTemper = plTemper.Checked;
            if ( plTemperLevel1.Checked )
            {
                config.plTemper_Level = 1;
            }
            else if ( plTemperLevel2.Checked )
            {
                config.plTemper_Level = 2;
            }
            config.plEnspell = plEnspell.Checked;
            config.plEnspell_Spell = plEnspell_spell.SelectedIndex;
            config.plGainBoost = plGainBoost.Checked;
            config.plGainBoost_Spell = plGainBoost_spell.SelectedIndex;
            config.plBarElement = plBarElement.Checked;
            config.plBarElement_Spell = plBarElement_Spell.SelectedIndex;
            config.AOE_Barelemental = AOE_Barelemental.Checked;
            config.plBarStatus = plBarStatus.Checked;
            config.plBarStatus_Spell = plBarStatus_Spell.SelectedIndex;
            config.plStormSpell = plStormSpell.Checked;
            config.plAdloquium = plAdloquium.Checked;
            config.AOE_Barstatus = AOE_Barstatus.Checked;
            config.plStormSpell_Spell = plStormSpell_Spell.SelectedIndex;
            config.plKlimaform = plKlimaform.Checked;
            config.plAuspice = plAuspice.Checked;
            config.plAquaveil = plAquaveil.Checked;

            config.plHaste = plHaste.Checked;
            if ( plHasteLevel1.Checked )
            {
                config.plHaste_Level = 1;
            }
            else if ( plHasteLevel2.Checked )
            {
                config.plHaste_Level = 2;
            }

            config.plSpikes = plSpikes.Checked;
            config.plSpikes_Spell = plSpikes_Spell.SelectedIndex;

            config.plUtsusemi = plUtsusemi.Checked;
            config.plRefresh = plRefresh.Checked;
            if ( plRefreshLevel1.Checked )
            {
                config.plRefresh_Level = 1;
            }
            else if ( plRefreshLevel2.Checked )
            {
                config.plRefresh_Level = 2;
            }
            else if ( plRefreshLevel3.Checked )
            {
                config.plRefresh_Level = 3;
            }

            // SCHOLAR STRATAGEMS
            config.accessionCure = accessionCure.Checked;
            config.AccessionRegen = accessionRegen.Checked;
            config.PerpetuanceRegen = perpetuanceRegen.Checked;
            config.accessionProShell = accessionProShell.Checked;

            config.regenPerpetuance = regenPerpetuance.Checked;
            config.regenAccession = regenAccession.Checked;
            config.refreshPerpetuance = refreshPerpetuance.Checked;
            config.refreshAccession = refreshAccession.Checked;
            config.blinkPerpetuance = blinkPerpetuance.Checked;
            config.blinkAccession = blinkAccession.Checked;
            config.phalanxPerpetuance = phalanxPerpetuance.Checked;
            config.phalanxAccession = phalanxAccession.Checked;
            config.stoneskinPerpetuance = stoneskinPerpetuance.Checked;
            config.stoneskinAccession = stoneskinAccession.Checked;
            config.enspellPerpetuance = enspellPerpetuance.Checked;
            config.enspellAccession = enspellAccession.Checked;
            config.stormspellPerpetuance = stormspellPerpetuance.Checked;
            config.stormspellAccession = stormspellAccession.Checked;
            config.adloquiumPerpetuance = adloquiumPerpetuance.Checked;
            config.adloquiumAccession = adloquiumAccession.Checked;
            config.aquaveilPerpetuance = aquaveilPerpetuance.Checked;
            config.aquaveilAccession = aquaveilAccession.Checked;
            config.barspellPerpetuance = barspellPerpetuance.Checked;
            config.barspellAccession = barstatusAccession.Checked;
            config.barstatusPerpetuance = barstatusPerpetuance.Checked;
            config.barstatusAccession = barstatusAccession.Checked;

            config.EnlightenmentReraise = EnlightenmentReraise.Checked;

            // GEOMANCER
            config.EnableGeoSpells = EnableGeoSpells.Checked;
            config.IndiWhenEngaged = GEO_engaged.Checked;
            config.EnableLuopanSpells = EnableLuopanSpells.Checked;
            config.GeoSpell_Spell = GEOSpell.SelectedIndex;
            config.LuopanSpell_Target = GEOSpell_target.Text;
            config.IndiSpell_Spell = INDISpell.SelectedIndex;
            config.EntrustedSpell_Spell = entrustINDISpell.SelectedIndex;
            config.EntrustedSpell_Target = entrustSpell_target.Text;
            config.GeoWhenEngaged = GeoAOE_Engaged.Checked;

            config.specifiedEngageTarget = false;

            // SINGING
            config.enableSinging = enableSinging.Checked;

            config.song1 = song1.SelectedIndex;
            config.song2 = song2.SelectedIndex;
            config.song3 = song3.SelectedIndex;
            config.song4 = song4.SelectedIndex;

            config.dummy1 = dummy1.SelectedIndex;
            config.dummy2 = dummy2.SelectedIndex;

            config.recastSongTime = recastSong.Value;

            config.recastSongs_Monitored = recastSongs_monitored.Checked;
            config.SongsOnlyWhenNear = SongsOnlyWhenNearEngaged.Checked;

            // JOB ABILITIES

            config.AfflatusSolace = afflatusSolace.Checked;
            config.AfflatusMisery = afflatusMisery.Checked;
            config.LightArts = lightArts.Checked;
            config.AddendumWhite = addWhite.Checked;
            config.Sublimation = sublimation.Checked;
            config.Celerity = celerity.Checked;
            config.Accession = accession.Checked;
            config.Perpetuance = perpetuance.Checked;
            config.Penury = penury.Checked;
            config.Rapture = rapture.Checked;
            config.DarkArts = darkArts.Checked;
            config.AddendumBlack = addBlack.Checked;

            config.Composure = composure.Checked;
            config.Convert = convert.Checked;

            config.DivineSeal = divineSealBox.Checked;
            config.Devotion = DevotionBox.Checked;
            config.DivineCaress = DivineCaressBox.Checked;

            config.Entrust = EntrustBox.Checked;
            config.Dematerialize = DematerializeBox.Checked;
            config.BlazeOfGlory = BlazeOfGloryBox.Checked;

            config.RadialArcana = RadialArcanaBox.Checked;
            config.RadialArcana_Spell = RadialArcanaSpell.SelectedIndex;
            config.FullCircle = FullCircleBox.Checked;
            config.EclipticAttrition = EclipticAttritionBox.Checked;
            config.LifeCycle = LifeCycleBox.Checked;

            config.Troubadour = troubadour.Checked;
            config.Nightingale = nightingale.Checked;
            config.Marcato = marcato.Checked;

            // DEBUFF REMOVAL
            config.plSilenceItemEnabled = plSilenceItemEnabled.Checked;
            config.plSilenceItem = plSilenceItem.SelectedIndex;
            config.wakeSleepEnabled = wakeSleepEnabled.Checked;
            config.wakeSleepSpell = wakeSleepSpell.SelectedIndex;
            config.plDebuffEnabled = plDebuffEnabled.Checked;
            config.monitoredDebuffEnabled = monitoredDebuffEnabled.Checked;

            config.plAgiDown = plAgiDown.Checked;
            config.plAccuracyDown = plAccuracyDown.Checked;
            config.plAddle = plAddle.Checked;
            config.plAttackDown = plAttackDown.Checked;
            config.plBane = plBane.Checked;
            config.plBind = plBind.Checked;
            config.plBio = plBio.Checked;
            config.plBlindness = plBlindness.Checked;
            config.plBurn = plBurn.Checked;
            config.plChrDown = plChrDown.Checked;
            config.plChoke = plChoke.Checked;
            config.plCurse = plCurse.Checked;
            config.plCurse2 = plCurse2.Checked;
            config.plDexDown = plDexDown.Checked;
            config.plDefenseDown = plDefenseDown.Checked;
            config.plDia = plDia.Checked;
            config.plDisease = plDisease.Checked;
            config.plDoom = plDoom.Checked;
            config.plDrown = plDrown.Checked;
            config.plElegy = plElegy.Checked;
            config.plEvasionDown = plEvasionDown.Checked;
            config.plFlash = plFlash.Checked;
            config.plFrost = plFrost.Checked;
            config.plHelix = plHelix.Checked;
            config.plIntDown = plIntDown.Checked;
            config.plMndDown = plMndDown.Checked;
            config.plMagicAccDown = plMagicAccDown.Checked;
            config.plMagicAtkDown = plMagicAtkDown.Checked;
            config.plMaxHpDown = plMaxHpDown.Checked;
            config.plMaxMpDown = plMaxMpDown.Checked;
            config.plMaxTpDown = plMaxTpDown.Checked;
            config.plParalysis = plParalysis.Checked;
            config.plPlague = plPlague.Checked;
            config.plPoison = plPoison.Checked;
            config.plRasp = plRasp.Checked;
            config.plRequiem = plRequiem.Checked;
            config.plStrDown = plStrDown.Checked;
            config.plShock = plShock.Checked;
            config.plSilence = plSilence.Checked;
            config.plSlow = plSlow.Checked;
            config.plThrenody = plThrenody.Checked;
            config.plVitDown = plVitDown.Checked;
            config.plWeight = plWeight.Checked;
            config.plAmnesia = plAmnesia.Checked;
            config.plDoomEnabled = plDoomEnabled.Checked;
            config.plDoomitem = plDoomitem.SelectedIndex;

            config.enablePartyDebuffRemoval = naSpellsenable.Checked;
            config.SpecifiednaSpellsenable = SpecifiednaSpellsenable.Checked;
            config.PrioritiseOverLowerTier = PrioritiseOverLowerTier.Checked;
            config.naBlindness = naBlindness.Checked;
            config.naCurse = naCurse.Checked;
            config.naDisease = naDisease.Checked;
            config.naParalysis = naParalysis.Checked;
            config.naPetrification = naPetrification.Checked;
            config.naPlague = naPlague.Checked;
            config.naPoison = naPoison.Checked;
            config.naSilence = naSilence.Checked;
            config.naErase = naErase.Checked;
            config.Esuna = Esuna.Checked;
            config.EsunaOnlyAmnesia = EsunaOnlyAmnesia.Checked;

            config.na_Weight = na_Weight.Checked;
            config.na_VitDown = na_VitDown.Checked;
            config.na_Threnody = na_Threnody.Checked;
            config.na_Slow = na_Slow.Checked;
            config.na_Shock = na_Shock.Checked;
            config.na_StrDown = na_StrDown.Checked;
            config.na_Requiem = na_Requiem.Checked;
            config.na_Rasp = na_Rasp.Checked;
            config.na_MaxTpDown = na_MaxTpDown.Checked;
            config.na_MaxMpDown = na_MaxMpDown.Checked;
            config.na_MaxHpDown = na_MaxHpDown.Checked;
            config.na_MagicAttackDown = na_MagicAttackDown.Checked;
            config.na_MagicDefenseDown = na_MagicDefenseDown.Checked;
            config.na_MagicAccDown = na_MagicAccDown.Checked;
            config.na_MndDown = na_MndDown.Checked;
            config.na_IntDown = na_IntDown.Checked;
            config.na_Helix = na_Helix.Checked;
            config.na_Frost = na_Frost.Checked;
            config.na_EvasionDown = na_EvasionDown.Checked;
            config.na_Elegy = na_Elegy.Checked;
            config.na_Drown = na_Drown.Checked;
            config.na_Dia = na_Dia.Checked;
            config.na_DefenseDown = na_DefenseDown.Checked;
            config.na_DexDown = na_DexDown.Checked;
            config.na_Choke = na_Choke.Checked;
            config.na_ChrDown = na_ChrDown.Checked;
            config.na_Burn = na_Burn.Checked;
            config.na_Bio = na_Bio.Checked;
            config.na_Bind = na_Bind.Checked;
            config.na_AttackDown = na_AttackDown.Checked;
            config.na_Addle = na_Addle.Checked;
            config.na_AccuracyDown = na_AccuracyDown.Checked;
            config.na_AgiDown = na_AgiDown.Checked;

            config.monitoredAgiDown = monitoredAgiDown.Checked;
            config.monitoredAccuracyDown = monitoredAccuracyDown.Checked;
            config.monitoredAddle = monitoredAddle.Checked;
            config.monitoredAttackDown = monitoredAttackDown.Checked;
            config.monitoredBane = monitoredBane.Checked;
            config.monitoredBind = monitoredBind.Checked;
            config.monitoredBio = monitoredBio.Checked;
            config.monitoredBlindness = monitoredBlindness.Checked;
            config.monitoredBurn = monitoredBurn.Checked;
            config.monitoredChrDown = monitoredChrDown.Checked;
            config.monitoredChoke = monitoredChoke.Checked;
            config.monitoredCurse = monitoredCurse.Checked;
            config.monitoredCurse2 = monitoredCurse2.Checked;
            config.monitoredDexDown = monitoredDexDown.Checked;
            config.monitoredDefenseDown = monitoredDefenseDown.Checked;
            config.monitoredDia = monitoredDia.Checked;
            config.monitoredDisease = monitoredDisease.Checked;
            config.monitoredDoom = monitoredDoom.Checked;
            config.monitoredDrown = monitoredDrown.Checked;
            config.monitoredElegy = monitoredElegy.Checked;
            config.monitoredEvasionDown = monitoredEvasionDown.Checked;
            config.monitoredFlash = monitoredFlash.Checked;
            config.monitoredFrost = monitoredFrost.Checked;
            config.monitoredHelix = monitoredHelix.Checked;
            config.monitoredIntDown = monitoredIntDown.Checked;
            config.monitoredMndDown = monitoredMndDown.Checked;
            config.monitoredMagicAccDown = monitoredMagicAccDown.Checked;
            config.monitoredMagicAtkDown = monitoredMagicAtkDown.Checked;
            config.monitoredMaxHpDown = monitoredMaxHpDown.Checked;
            config.monitoredMaxMpDown = monitoredMaxMpDown.Checked;
            config.monitoredMaxTpDown = monitoredMaxTpDown.Checked;
            config.monitoredParalysis = monitoredParalysis.Checked;
            config.monitoredPetrification = monitoredPetrification.Checked;
            config.monitoredPlague = monitoredPlague.Checked;
            config.monitoredPoison = monitoredPoison.Checked;
            config.monitoredRasp = monitoredRasp.Checked;
            config.monitoredRequiem = monitoredRequiem.Checked;
            config.monitoredStrDown = monitoredStrDown.Checked;
            config.monitoredShock = monitoredShock.Checked;
            config.monitoredSilence = monitoredSilence.Checked;
            config.monitoredSleep = monitoredSleep.Checked;
            config.monitoredSleep2 = monitoredSleep2.Checked;
            config.monitoredSlow = monitoredSlow.Checked;
            config.monitoredThrenody = monitoredThrenody.Checked;
            config.monitoredVitDown = monitoredVitDown.Checked;
            config.monitoredWeight = monitoredWeight.Checked;
            config.monitoredAmnesia = monitoredAmnesia.Checked;

            // OTHER OPTIONS

            config.lowMPcheckBox = lowMPcheckBox.Checked;
            config.mpMinCastValue = mpMinCastValue.Value;

            config.autoTarget = autoTarget.Checked;
            config.autoTargetSpell = autoTargetSpell.Text;
            config.Hate_SpellType = Hate_SpellType.SelectedIndex;
            config.autoTarget_Target = autoTarget_target.Text;
            config.AssistSpecifiedTarget = AssistSpecifiedTarget.Checked;

            config.DisableTargettingCancel = DisableTargettingCancel.Checked;
            config.TargetRemoval_Delay = TargetRemoval_Delay.Value;

            config.AcceptRaise = acceptRaise.Checked;
            config.AcceptRaiseOnlyWhenNotInCombat = acceptRaiseOnlyWhenNotInCombat.Checked;


            config.Fullcircle_DisableEnemy = Fullcircle_DisableEnemy.Checked;
            config.Fullcircle_GEOTarget = Fullcircle_GEOTarget.Checked;

            config.RadialArcanaMP = RadialArcanaMP.Value;

            config.convertMP = ConvertMP.Value;

            config.sublimationMP = sublimationMP.Value;

            config.DevotionMP = DevotionMP.Value;
            config.DevotionTargetType = DevotionTargetType.SelectedIndex;
            config.DevotionTargetName = DevotionTargetName.Text;
            config.DevotionWhenEngaged = DevotionWhenEngaged.Checked;

            config.healLowMP = healLowMP.Checked;
            config.standAtMP = standAtMP.Checked;
            config.specifiedEngageTarget = specifiedEngageTarget.Checked;
            config.standAtMP_Percentage = standAtMP_Percentage.Value;
            config.healWhenMPBelow = healWhenMPBelow.Value;

            config.Overcure = Overcure.Checked;
            config.Undercure = Undercure.Checked;
            config.enableMonitoredPriority = enableMonitoredPriority.Checked;
            config.enableOutOfPartyHealing = enableOutOfPartyHealing.Checked;
            config.OvercureOnHighPriority = OvercureOnHighPriority.Checked;
            config.EnableAddOn = enableAddOn.Checked;

            // PROGRAM OPTIONS

            config.pauseOnZoneBox = pauseOnZoneBox.Checked;
            config.pauseOnStartBox = pauseOnStartBox.Checked;
            config.pauseOnKO = pauseOnKO.Checked;
            config.MinimiseonStart = MinimiseonStart.Checked;

            config.autoFollowName = autoFollowName.Text;
            config.autoFollowDistance = autoFollowDistance.Value;
            config.autoFollow_Warning = autoFollow_Warning.Checked;
            config.FFXIDefaultAutoFollow = FFXIDefaultAutoFollow.Checked;
            config.enableHotKeys = enableHotKeys.Checked;

            config.ipAddress = ipAddress.Text;
            config.listeningPort = listeningPort.Text;

            config.enableFastCast_Mode = enableFastCast_Mode.Checked;
            config.trackCastingPackets = trackCastingPackets.Checked;

            // OTHERS

            string path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Settings");

            if ( loadJobSettings.Checked == true )
            {
                string fileName = "loadSettings";
                FileStream stream = File.Create(path + "/" + fileName);
                stream.Close ( );
                stream.Dispose ( );
            }
            else if ( loadJobSettings.Checked == false && System.IO.File.Exists ( path + "/loadSettings" ) )
            {
                try
                {
                    System.IO.File.Delete ( path + "/loadSettings" );
                }
                catch ( System.IO.IOException )
                {
                    //Console.WriteLine(e.Message);
                    return;
                }
            }

            Close ( );
            //MessageBox.Show("Saved!", "All Settings");
        }

        #endregion "== All Settings Saved"

        #region "== PL Debuff Check Boxes"

        private void plDebuffEnabled_CheckedChanged ( object sender, EventArgs e )
        {
            if ( plDebuffEnabled.Checked )
            {
                plAgiDown.Checked = true;
                plAgiDown.Enabled = true;
                plAccuracyDown.Checked = true;
                plAccuracyDown.Enabled = true;
                plAddle.Checked = true;
                plAddle.Enabled = true;
                plAttackDown.Checked = true;
                plAttackDown.Enabled = true;
                plBane.Checked = true;
                plBane.Enabled = true;
                plBind.Checked = true;
                plBind.Enabled = true;
                plBio.Checked = true;
                plBio.Enabled = true;
                plBlindness.Checked = true;
                plBlindness.Enabled = true;
                plBurn.Checked = true;
                plBurn.Enabled = true;
                plChrDown.Checked = true;
                plChrDown.Enabled = true;
                plChoke.Checked = true;
                plChoke.Enabled = true;
                plCurse.Checked = true;
                plCurse.Enabled = true;
                plCurse2.Checked = true;
                plCurse2.Enabled = true;
                plDexDown.Checked = true;
                plDexDown.Enabled = true;
                plDefenseDown.Checked = true;
                plDefenseDown.Enabled = true;
                plDia.Checked = true;
                plDia.Enabled = true;
                plDisease.Checked = true;
                plDisease.Enabled = true;
                plDoom.Checked = true;
                plDoom.Enabled = true;
                plDrown.Checked = true;
                plDrown.Enabled = true;
                plElegy.Checked = true;
                plElegy.Enabled = true;
                plEvasionDown.Checked = true;
                plEvasionDown.Enabled = true;
                plFlash.Checked = true;
                plFlash.Enabled = true;
                plFrost.Checked = true;
                plFrost.Enabled = true;
                plHelix.Checked = true;
                plHelix.Enabled = true;
                plIntDown.Checked = true;
                plIntDown.Enabled = true;
                plMndDown.Checked = true;
                plMndDown.Enabled = true;
                plMagicAccDown.Checked = true;
                plMagicAccDown.Enabled = true;
                plMagicAtkDown.Checked = true;
                plMagicAtkDown.Enabled = true;
                plMaxHpDown.Checked = true;
                plMaxHpDown.Enabled = true;
                plMaxMpDown.Checked = true;
                plMaxMpDown.Enabled = true;
                plMaxTpDown.Checked = true;
                plMaxTpDown.Enabled = true;
                plParalysis.Checked = true;
                plParalysis.Enabled = true;
                plPlague.Checked = true;
                plPlague.Enabled = true;
                plPoison.Checked = true;
                plPoison.Enabled = true;
                plRasp.Checked = true;
                plRasp.Enabled = true;
                plRequiem.Checked = true;
                plRequiem.Enabled = true;
                plStrDown.Checked = true;
                plStrDown.Enabled = true;
                plShock.Checked = true;
                plShock.Enabled = true;
                plSilence.Checked = true;
                plSilence.Enabled = true;
                plSlow.Checked = true;
                plSlow.Enabled = true;
                plThrenody.Checked = true;
                plThrenody.Enabled = true;
                plVitDown.Checked = true;
                plVitDown.Enabled = true;
                plWeight.Checked = true;
                plWeight.Enabled = true;
                plAmnesia.Checked = true;
                plAmnesia.Enabled = true;
            }
            else if ( plDebuffEnabled.Checked == false )
            {
                plAgiDown.Checked = false;
                plAgiDown.Enabled = false;
                plAccuracyDown.Checked = false;
                plAccuracyDown.Enabled = false;
                plAddle.Checked = false;
                plAddle.Enabled = false;
                plAttackDown.Checked = false;
                plAttackDown.Enabled = false;
                plBane.Checked = false;
                plBane.Enabled = false;
                plBind.Checked = false;
                plBind.Enabled = false;
                plBio.Checked = false;
                plBio.Enabled = false;
                plBlindness.Checked = false;
                plBlindness.Enabled = false;
                plBurn.Checked = false;
                plBurn.Enabled = false;
                plChrDown.Checked = false;
                plChrDown.Enabled = false;
                plChoke.Checked = false;
                plChoke.Enabled = false;
                plCurse.Checked = false;
                plCurse.Enabled = false;
                plCurse2.Checked = false;
                plCurse2.Enabled = false;
                plDexDown.Checked = false;
                plDexDown.Enabled = false;
                plDefenseDown.Checked = false;
                plDefenseDown.Enabled = false;
                plDia.Checked = false;
                plDia.Enabled = false;
                plDisease.Checked = false;
                plDisease.Enabled = false;
                plDoom.Checked = false;
                plDoom.Enabled = false;
                plDrown.Checked = false;
                plDrown.Enabled = false;
                plElegy.Checked = false;
                plElegy.Enabled = false;
                plEvasionDown.Checked = false;
                plEvasionDown.Enabled = false;
                plFlash.Checked = false;
                plFlash.Enabled = false;
                plFrost.Checked = false;
                plFrost.Enabled = false;
                plHelix.Checked = false;
                plHelix.Enabled = false;
                plIntDown.Checked = false;
                plIntDown.Enabled = false;
                plMndDown.Checked = false;
                plMndDown.Enabled = false;
                plMagicAccDown.Checked = false;
                plMagicAccDown.Enabled = false;
                plMagicAtkDown.Checked = false;
                plMagicAtkDown.Enabled = false;
                plMaxHpDown.Checked = false;
                plMaxHpDown.Enabled = false;
                plMaxMpDown.Checked = false;
                plMaxMpDown.Enabled = false;
                plMaxTpDown.Checked = false;
                plMaxTpDown.Enabled = false;
                plParalysis.Checked = false;
                plParalysis.Enabled = false;
                plPlague.Checked = false;
                plPlague.Enabled = false;
                plPoison.Checked = false;
                plPoison.Enabled = false;
                plRasp.Checked = false;
                plRasp.Enabled = false;
                plRequiem.Checked = false;
                plRequiem.Enabled = false;
                plStrDown.Checked = false;
                plStrDown.Enabled = false;
                plShock.Checked = false;
                plShock.Enabled = false;
                plSilence.Checked = false;
                plSilence.Enabled = false;
                plSlow.Checked = false;
                plSlow.Enabled = false;
                plThrenody.Checked = false;
                plThrenody.Enabled = false;
                plVitDown.Checked = false;
                plVitDown.Enabled = false;
                plWeight.Checked = false;
                plWeight.Enabled = false;
                plAmnesia.Checked = false;
                plAmnesia.Enabled = false;
            }
        }

        #endregion "== PL Debuff Check Boxes"

        #region "== Na spell check boxes"

        private void naSpellsenable_CheckedChanged ( object sender, EventArgs e )
        {
            if ( naSpellsenable.Checked )
            {
                naBlindness.Checked = true;
                naBlindness.Enabled = true;
                naCurse.Checked = true;
                naCurse.Enabled = true;
                naDisease.Checked = true;
                naDisease.Enabled = true;
                naBlindness.Checked = true;
                naBlindness.Enabled = true;
                naParalysis.Checked = true;
                naParalysis.Enabled = true;
                naPetrification.Checked = true;
                naPetrification.Enabled = true;
                naPlague.Checked = true;
                naPlague.Enabled = true;
                naPoison.Checked = true;
                naPoison.Enabled = true;
                naSilence.Checked = true;
                naSilence.Enabled = true;
                naErase.Enabled = true;
                Esuna.Enabled = true;
            }
            else if ( naSpellsenable.Checked == false )
            {
                naBlindness.Checked = false;
                naBlindness.Enabled = false;
                naCurse.Checked = false;
                naCurse.Enabled = false;
                naDisease.Checked = false;
                naDisease.Enabled = false;
                naBlindness.Checked = false;
                naBlindness.Enabled = false;
                naParalysis.Checked = false;
                naParalysis.Enabled = false;
                naPetrification.Checked = false;
                naPetrification.Enabled = false;
                naPlague.Checked = false;
                naPlague.Enabled = false;
                naPoison.Checked = false;
                naPoison.Enabled = false;
                naSilence.Checked = false;
                naSilence.Enabled = false;
                naErase.Checked = false;
                naErase.Enabled = false;
                Esuna.Checked = false;
                Esuna.Enabled = false;
            }
        }

        #endregion "== Na spell check boxes"

        #region "== Monitored Player Debuff Check Boxes"

        private void monitoredDebuffEnabled_CheckedChanged ( object sender, EventArgs e )
        {
            if ( monitoredDebuffEnabled.Checked )
            {
                monitoredAgiDown.Checked = true;
                monitoredAgiDown.Enabled = true;
                monitoredAccuracyDown.Checked = true;
                monitoredAccuracyDown.Enabled = true;
                monitoredAddle.Checked = true;
                monitoredAddle.Enabled = true;
                monitoredAttackDown.Checked = true;
                monitoredAttackDown.Enabled = true;
                monitoredBane.Checked = true;
                monitoredBane.Enabled = true;
                monitoredBind.Checked = true;
                monitoredBind.Enabled = true;
                monitoredBio.Checked = true;
                monitoredBio.Enabled = true;
                monitoredBlindness.Checked = true;
                monitoredBlindness.Enabled = true;
                monitoredBurn.Checked = true;
                monitoredBurn.Enabled = true;
                monitoredChrDown.Checked = true;
                monitoredChrDown.Enabled = true;
                monitoredChoke.Checked = true;
                monitoredChoke.Enabled = true;
                monitoredCurse.Checked = true;
                monitoredCurse.Enabled = true;
                monitoredCurse2.Checked = true;
                monitoredCurse2.Enabled = true;
                monitoredDexDown.Checked = true;
                monitoredDexDown.Enabled = true;
                monitoredDefenseDown.Checked = true;
                monitoredDefenseDown.Enabled = true;
                monitoredDia.Checked = true;
                monitoredDia.Enabled = true;
                monitoredDisease.Checked = true;
                monitoredDisease.Enabled = true;
                monitoredDoom.Checked = true;
                monitoredDoom.Enabled = true;
                monitoredDrown.Checked = true;
                monitoredDrown.Enabled = true;
                monitoredElegy.Checked = true;
                monitoredElegy.Enabled = true;
                monitoredEvasionDown.Checked = true;
                monitoredEvasionDown.Enabled = true;
                monitoredFlash.Checked = true;
                monitoredFlash.Enabled = true;
                monitoredFrost.Checked = true;
                monitoredFrost.Enabled = true;
                monitoredHelix.Checked = true;
                monitoredHelix.Enabled = true;
                monitoredIntDown.Checked = true;
                monitoredIntDown.Enabled = true;
                monitoredMndDown.Checked = true;
                monitoredMndDown.Enabled = true;
                monitoredMagicAccDown.Checked = true;
                monitoredMagicAccDown.Enabled = true;
                monitoredMagicAtkDown.Checked = true;
                monitoredMagicAtkDown.Enabled = true;
                monitoredMaxHpDown.Checked = true;
                monitoredMaxHpDown.Enabled = true;
                monitoredMaxMpDown.Checked = true;
                monitoredMaxMpDown.Enabled = true;
                monitoredMaxTpDown.Checked = true;
                monitoredMaxTpDown.Enabled = true;
                monitoredParalysis.Checked = true;
                monitoredParalysis.Enabled = true;
                monitoredPetrification.Checked = true;
                monitoredPetrification.Enabled = true;
                monitoredPlague.Checked = true;
                monitoredPlague.Enabled = true;
                monitoredPoison.Checked = true;
                monitoredPoison.Enabled = true;
                monitoredRasp.Checked = true;
                monitoredRasp.Enabled = true;
                monitoredRequiem.Checked = true;
                monitoredRequiem.Enabled = true;
                monitoredStrDown.Checked = true;
                monitoredStrDown.Enabled = true;
                monitoredShock.Checked = true;
                monitoredShock.Enabled = true;
                monitoredSilence.Checked = true;
                monitoredSilence.Enabled = true;
                monitoredSleep.Checked = true;
                monitoredSleep.Enabled = true;
                monitoredSleep2.Checked = true;
                monitoredSleep2.Enabled = true;
                monitoredSlow.Checked = true;
                monitoredSlow.Enabled = true;
                monitoredThrenody.Checked = true;
                monitoredThrenody.Enabled = true;
                monitoredVitDown.Checked = true;
                monitoredVitDown.Enabled = true;
                monitoredWeight.Checked = true;
                monitoredWeight.Enabled = true;
                monitoredAmnesia.Checked = true;
                monitoredAmnesia.Enabled = true;
            }
            else if ( monitoredDebuffEnabled.Checked == false )
            {
                monitoredAgiDown.Checked = false;
                monitoredAgiDown.Enabled = false;
                monitoredAccuracyDown.Checked = false;
                monitoredAccuracyDown.Enabled = false;
                monitoredAddle.Checked = false;
                monitoredAddle.Enabled = false;
                monitoredAttackDown.Checked = false;
                monitoredAttackDown.Enabled = false;
                monitoredBane.Checked = false;
                monitoredBane.Enabled = false;
                monitoredBind.Checked = false;
                monitoredBind.Enabled = false;
                monitoredBio.Checked = false;
                monitoredBio.Enabled = false;
                monitoredBlindness.Checked = false;
                monitoredBlindness.Enabled = false;
                monitoredBurn.Checked = false;
                monitoredBurn.Enabled = false;
                monitoredChrDown.Checked = false;
                monitoredChrDown.Enabled = false;
                monitoredChoke.Checked = false;
                monitoredChoke.Enabled = false;
                monitoredCurse.Checked = false;
                monitoredCurse.Enabled = false;
                monitoredCurse2.Checked = false;
                monitoredCurse2.Enabled = false;
                monitoredDexDown.Checked = false;
                monitoredDexDown.Enabled = false;
                monitoredDefenseDown.Checked = false;
                monitoredDefenseDown.Enabled = false;
                monitoredDia.Checked = false;
                monitoredDia.Enabled = false;
                monitoredDisease.Checked = false;
                monitoredDisease.Enabled = false;
                monitoredDoom.Checked = false;
                monitoredDoom.Enabled = false;
                monitoredDrown.Checked = false;
                monitoredDrown.Enabled = false;
                monitoredElegy.Checked = false;
                monitoredElegy.Enabled = false;
                monitoredEvasionDown.Checked = false;
                monitoredEvasionDown.Enabled = false;
                monitoredFlash.Checked = false;
                monitoredFlash.Enabled = false;
                monitoredFrost.Checked = false;
                monitoredFrost.Enabled = false;
                monitoredHelix.Checked = false;
                monitoredHelix.Enabled = false;
                monitoredIntDown.Checked = false;
                monitoredIntDown.Enabled = false;
                monitoredMndDown.Checked = false;
                monitoredMndDown.Enabled = false;
                monitoredMagicAccDown.Checked = false;
                monitoredMagicAccDown.Enabled = false;
                monitoredMagicAtkDown.Checked = false;
                monitoredMagicAtkDown.Enabled = false;
                monitoredMaxHpDown.Checked = false;
                monitoredMaxHpDown.Enabled = false;
                monitoredMaxMpDown.Checked = false;
                monitoredMaxMpDown.Enabled = false;
                monitoredMaxTpDown.Checked = false;
                monitoredMaxTpDown.Enabled = false;
                monitoredParalysis.Checked = false;
                monitoredParalysis.Enabled = false;
                monitoredPetrification.Checked = false;
                monitoredPetrification.Enabled = false;
                monitoredPlague.Checked = false;
                monitoredPlague.Enabled = false;
                monitoredPoison.Checked = false;
                monitoredPoison.Enabled = false;
                monitoredRasp.Checked = false;
                monitoredRasp.Enabled = false;
                monitoredRequiem.Checked = false;
                monitoredRequiem.Enabled = false;
                monitoredStrDown.Checked = false;
                monitoredStrDown.Enabled = false;
                monitoredShock.Checked = false;
                monitoredShock.Enabled = false;
                monitoredSilence.Checked = false;
                monitoredSilence.Enabled = false;
                monitoredSleep.Checked = false;
                monitoredSleep.Enabled = false;
                monitoredSleep2.Checked = false;
                monitoredSleep2.Enabled = false;
                monitoredSlow.Checked = false;
                monitoredSlow.Enabled = false;
                monitoredThrenody.Checked = false;
                monitoredThrenody.Enabled = false;
                monitoredVitDown.Checked = false;
                monitoredVitDown.Enabled = false;
                monitoredWeight.Checked = false;
                monitoredAmnesia.Checked = false;
                monitoredAmnesia.Enabled = false;
                monitoredWeight.Enabled = false;
            }
        }

        #endregion "== Monitored Player Debuff Check Boxes"

        #region "== Geomancy Check Boxes"

        private void EnableGeoSpells_CheckedChanged ( object sender, EventArgs e )
        {
            if ( EnableGeoSpells.Checked )
            {
                INDISpell.Enabled = true;
                entrustINDISpell.Enabled = true;
                entrustSpell_target.Enabled = true;
            }
            else if ( EnableGeoSpells.Checked == false )
            {
                INDISpell.Enabled = false;
                entrustINDISpell.Enabled = false;
                entrustSpell_target.Enabled = false;
            }
        }

        private void EnableLuopanSpells_CheckedChanged ( object sender, EventArgs e )
        {
            if ( EnableLuopanSpells.Checked )
            {
                GEOSpell.Enabled = true;
                GEOSpell_target.Enabled = true;
            }
            else if ( EnableLuopanSpells.Checked == false )
            {
                GEOSpell.Enabled = false;
                GEOSpell_target.Enabled = false;
            }
        }

        #endregion "== Geomancy Check Boxes"

        private void saveAsButton_Click ( object sender, EventArgs e )
        {
            button4_Click ( sender, e );

            SaveFileDialog savefile = new SaveFileDialog();

            if ( CurePleaseForm._ELITEAPIPL != null )
            {
                if ( CurePleaseForm._ELITEAPIPL.Player.MainJob != 0 )
                {
                    if ( CurePleaseForm._ELITEAPIPL.Player.SubJob != 0 )
                    {
                        JobTitles mainJob = JobNames.Where(c => c.job_number == CurePleaseForm._ELITEAPIPL.Player.MainJob).FirstOrDefault();
                        JobTitles subJob = JobNames.Where(c => c.job_number == CurePleaseForm._ELITEAPIPL.Player.SubJob).FirstOrDefault();
                        savefile.FileName = mainJob.job_name + "_" + subJob.job_name + ".xml";
                    }
                    else
                    {
                        JobTitles mainJob = JobNames.Where(c => c.job_number == CurePleaseForm._ELITEAPIPL.Player.MainJob).FirstOrDefault();
                        savefile.FileName = mainJob + ".xml";
                    }
                }
            }
            else
            {
                savefile.FileName = "Settings.xml";
            }
            savefile.Filter = " Extensible Markup Language (*.xml)|*.xml";
            savefile.FilterIndex = 2;
            savefile.InitialDirectory = System.IO.Path.Combine ( System.AppDomain.CurrentDomain.BaseDirectory, "Settings" );

            if ( savefile.ShowDialog ( ) == DialogResult.OK )
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(MySettings));
                StreamWriter myWriter = new StreamWriter(savefile.FileName);
                mySerializer.Serialize ( myWriter, config );
                myWriter.Close ( );
                myWriter.Dispose ( );
            }
        }

        private void loadButton_Click ( object sender, EventArgs e )
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = " Extensible Markup Language (*.xml)|*.xml",
                FilterIndex = 2,
                InitialDirectory = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Settings")
            };

            if ( openFileDialog1.ShowDialog ( ) == DialogResult.OK )
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(MySettings));

                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                config = ( MySettings ) mySerializer.Deserialize ( reader );

                reader.Close ( );
                reader.Dispose ( );
                updateForm ( config );
                button4_Click ( sender, e );
            }
        }

        public void updateForm ( MySettings config )
        {
            // HEALING MAGIC
            cure1enabled.Checked = config.cure1enabled;
            cure2enabled.Checked = config.cure2enabled;
            cure3enabled.Checked = config.cure3enabled;
            cure4enabled.Checked = config.cure4enabled;
            cure5enabled.Checked = config.cure5enabled;
            cure6enabled.Checked = config.cure6enabled;
            cure1amount.Value = config.cure1amount;
            cure2amount.Value = config.cure2amount;
            cure3amount.Value = config.cure3amount;
            cure4amount.Value = config.cure4amount;
            cure5amount.Value = config.cure5amount;
            cure6amount.Value = config.cure6amount;
            curePercentage.Value = config.curePercentage;
            curePercentageValueLabel.Text = config.curePercentage.ToString ( CultureInfo.InvariantCulture );
            priorityCurePercentage.Value = config.priorityCurePercentage;
            priorityCurePercentageValueLabel.Text = config.priorityCurePercentage.ToString ( CultureInfo.InvariantCulture );
            monitoredCurePercentage.Value = config.monitoredCurePercentage;
            monitoredCurePercentageValueLabel.Text = config.monitoredCurePercentage.ToString ( CultureInfo.InvariantCulture );

            curagaEnabled.Checked = config.curagaEnabled;
            curaga2Enabled.Checked = config.curaga2enabled;
            curaga3Enabled.Checked = config.curaga3enabled;
            curaga4Enabled.Checked = config.curaga4enabled;
            curaga5Enabled.Checked = config.curaga5enabled;

            curagaAmount.Value = config.curagaAmount;
            curaga2Amount.Value = config.curaga2Amount;
            curaga3Amount.Value = config.curaga3Amount;
            curaga4Amount.Value = config.curaga4Amount;
            curaga5Amount.Value = config.curaga5Amount;

            curagaCurePercentage.Value = config.curagaCurePercentage;
            curagaPercentageValueLabel.Text = config.curagaCurePercentage.ToString ( CultureInfo.InvariantCulture );
            curagaTargetType.SelectedIndex = config.curagaTargetType;
            curagaTargetName.Text = config.curagaTargetName;
            requiredCuragaNumbers.Value = config.curagaRequiredMembers;

            // ENHANCING MAGIC

            // BASIC ENHANCING
            autoHasteMinutes.Value = config.autoHasteMinutes;
            if ( config.autoAdloquiumMinutes != 0 )
            {
                autoAdloquium_Minutes.Value = config.autoAdloquiumMinutes;
            }
            else
            {
                config.autoAdloquiumMinutes = 2;
                autoAdloquium_Minutes.Value = 2;
            }
            autoProtect_Minutes.Value = config.autoProtect_Minutes;
            autoShell_Minutes.Value = config.autoShellMinutes;
            autoPhalanxIIMinutes.Value = config.autoPhalanxIIMinutes;
            if ( config.autoStormspellMinutes == 0 )
            {
                autoStormspellMinutes.Value = 3;
            }
            else
            {
                autoStormspellMinutes.Value = config.autoStormspellMinutes;
            }
            autoRefresh_Minutes.Value = config.autoRefresh_Minutes;
            autoRegen_Minutes.Value = config.autoRegen_Minutes;
            autoRefresh_Minutes.Value = config.autoRefresh_Minutes;
            plBlink.Checked = config.plBlink;

            autoRegen.SelectedIndex = config.autoRegen_Spell;
            autoRefresh.SelectedIndex = config.autoRefresh_Spell;
            autoShell.SelectedIndex = config.autoShell_Spell;
            autoStorm.SelectedIndex = config.autoStorm_Spell;
            autoProtect.SelectedIndex = config.autoProtect_Spell;
            plProtect.Checked = config.plProtect;
            plShell.Checked = config.plProtect;




            plRegen.Checked = config.plRegen;
            if ( config.plRegen_Level == 1 && plRegen.Checked == true )
            {
                plRegenLevel1.Checked = true;
            }
            else if ( config.plRegen_Level == 2 && plRegen.Checked == true )
            {
                plRegenLevel2.Checked = true;
            }
            else if ( config.plRegen_Level == 3 && plRegen.Checked == true )
            {
                plRegenLevel3.Checked = true;
            }
            else if ( config.plRegen_Level == 4 && plRegen.Checked == true )
            {
                plRegenLevel4.Checked = true;
            }
            else if ( config.plRegen_Level == 5 && plRegen.Checked == true )
            {
                plRegenLevel5.Checked = true;
            }

            plReraise.Checked = config.plReraise;
            if ( config.plReraise_Level == 1 && plReraise.Checked == true )
            {
                plReraiseLevel1.Checked = true;
            }
            else if ( config.plReraise_Level == 2 && plReraise.Checked == true )
            {
                plReraiseLevel2.Checked = true;
            }
            else if ( config.plReraise_Level == 3 && plReraise.Checked == true )
            {
                plReraiseLevel3.Checked = true;
            }
            else if ( config.plReraise_Level == 4 && plReraise.Checked == true )
            {
                plReraiseLevel4.Checked = true;
            }
            plRefresh.Checked = config.plRefresh;
            if ( config.plRefresh_Level == 1 && plRefresh.Checked == true )
            {
                plRefreshLevel1.Checked = true;
            }
            else if ( config.plRefresh_Level == 2 && plRefresh.Checked == true )
            {
                plRefreshLevel2.Checked = true;
            }
            else if ( config.plRefresh_Level == 3 && plRefresh.Checked == true )
            {
                plRefreshLevel3.Checked = true;
            }
            plStoneskin.Checked = config.plStoneskin;
            plPhalanx.Checked = config.plPhalanx;
            plTemper.Checked = config.plTemper;
            if ( config.plTemper_Level == 1 && plTemper.Checked == true )
            {
                plTemperLevel1.Checked = true;
            }
            else if ( config.plTemper_Level == 2 && plTemper.Checked == true )
            {
                plTemperLevel2.Checked = true;
            }

            plHaste.Checked = config.plHaste;
            if ( config.plHaste_Level == 1 && plHaste.Checked == true )
            {
                plHasteLevel1.Checked = true;
            }
            else if ( config.plHaste_Level == 2 && plHaste.Checked == true )
            {
                plHasteLevel2.Checked = true;
            }

            plSpikes.Checked = config.plSpikes;
            plSpikes_Spell.SelectedIndex = config.plSpikes_Spell;


            plEnspell.Checked = config.plEnspell;
            plEnspell_spell.SelectedIndex = config.plEnspell_Spell;
            plGainBoost.Checked = config.plGainBoost;
            plGainBoost_spell.SelectedIndex = config.plGainBoost_Spell;
            EntrustBox.Checked = config.Entrust;
            DematerializeBox.Checked = config.Dematerialize;
            plBarElement.Checked = config.plBarElement;
            if ( config.plBarElement_Spell > 5 )
            {
                plBarElement_Spell.SelectedIndex = 0;
                config.plBarElement_Spell = 0; ;
            }
            else
            {
                plBarElement_Spell.SelectedIndex = config.plBarElement_Spell;
            }
            AOE_Barelemental.Checked = config.AOE_Barelemental;
            plBarStatus.Checked = config.plBarStatus;
            if ( config.plBarStatus_Spell > 8 )
            {
                plBarStatus_Spell.SelectedIndex = 0;
                config.plBarStatus_Spell = 0; ;
            }
            else
            {
                plBarStatus_Spell.SelectedIndex = config.plBarStatus_Spell;
            }
            AOE_Barstatus.Checked = config.AOE_Barstatus;
            plStormSpell.Checked = config.plStormSpell;
            plKlimaform.Checked = config.plKlimaform;
            plStormSpell_Spell.SelectedIndex = config.plStormSpell_Spell;
            plAdloquium.Checked = config.plAdloquium;
            plAuspice.Checked = config.plAuspice;
            plAquaveil.Checked = config.plAquaveil;
            plUtsusemi.Checked = config.plUtsusemi;

            // SCHOLAR STRATAGEMS
            accessionCure.Checked = config.accessionCure;
            accessionProShell.Checked = config.accessionProShell;
            perpetuanceRegen.Checked = config.PerpetuanceRegen;
            accessionRegen.Checked = config.AccessionRegen;

            regenPerpetuance.Checked = config.regenPerpetuance;
            regenAccession.Checked = config.regenAccession;
            refreshPerpetuance.Checked = config.refreshPerpetuance;
            refreshAccession.Checked = config.refreshAccession;
            blinkPerpetuance.Checked = config.blinkPerpetuance;
            blinkAccession.Checked = config.blinkPerpetuance;
            phalanxPerpetuance.Checked = config.phalanxPerpetuance;
            phalanxAccession.Checked = config.phalanxAccession;
            stoneskinPerpetuance.Checked = config.stoneskinPerpetuance;
            stoneskinAccession.Checked = config.stoneskinAccession;
            enspellPerpetuance.Checked = config.enspellPerpetuance;
            enspellAccession.Checked = config.enspellAccession;
            stormspellPerpetuance.Checked = config.stormspellPerpetuance;
            stormspellAccession.Checked = config.stormspellAccession;
            adloquiumAccession.Checked = config.adloquiumAccession;
            adloquiumPerpetuance.Checked = config.adloquiumPerpetuance;
            aquaveilPerpetuance.Checked = config.aquaveilPerpetuance;
            aquaveilAccession.Checked = config.aquaveilAccession;
            barspellPerpetuance.Checked = config.barspellPerpetuance;
            barspellAccession.Checked = config.barspellAccession;
            barstatusPerpetuance.Checked = config.barstatusPerpetuance;
            barstatusAccession.Checked = config.barstatusAccession;

            EnlightenmentReraise.Checked = config.EnlightenmentReraise;

            // GEOMANCER
            EnableGeoSpells.Checked = config.EnableGeoSpells;
            GEO_engaged.Checked = config.IndiWhenEngaged;
            GEOSpell.SelectedIndex = config.GeoSpell_Spell;
            GEOSpell_target.Text = config.LuopanSpell_Target;
            INDISpell.SelectedIndex = config.IndiSpell_Spell;
            entrustINDISpell.SelectedIndex = config.EntrustedSpell_Spell;
            entrustSpell_target.Text = config.EntrustedSpell_Target;
            EnableLuopanSpells.Checked = config.EnableLuopanSpells;
            specifiedEngageTarget.Checked = config.specifiedEngageTarget;
            GeoAOE_Engaged.Checked = config.GeoWhenEngaged;

            // SINGING
            song1.SelectedIndex = config.song1;
            song2.SelectedIndex = config.song2;
            song3.SelectedIndex = config.song3;
            song4.SelectedIndex = config.song4;
            dummy1.SelectedIndex = config.dummy1;
            dummy2.SelectedIndex = config.dummy2;
            recastSong.Value = config.recastSongTime;
            enableSinging.Checked = config.enableSinging;
            recastSongs_monitored.Checked = config.recastSongs_Monitored;
            SongsOnlyWhenNearEngaged.Checked = config.SongsOnlyWhenNear;

            //JOB ABILITIES
            afflatusSolace.Checked = config.AfflatusSolace;
            afflatusMisery.Checked = config.AfflatusMisery;
            divineSealBox.Checked = config.DivineSeal;
            DevotionBox.Checked = config.Devotion;
            DivineCaressBox.Checked = config.DivineCaress;

            lightArts.Checked = config.LightArts;
            addWhite.Checked = config.AddendumWhite;
            sublimation.Checked = config.Sublimation;
            celerity.Checked = config.Celerity;
            accession.Checked = config.Accession;
            perpetuance.Checked = config.Perpetuance;
            penury.Checked = config.Penury;
            rapture.Checked = config.Rapture;
            darkArts.Checked = config.DarkArts;
            addBlack.Checked = config.AddendumBlack;

            composure.Checked = config.Composure;
            convert.Checked = config.Convert;

            BlazeOfGloryBox.Checked = config.BlazeOfGlory;
            FullCircleBox.Checked = config.FullCircle;
            EclipticAttritionBox.Checked = config.EclipticAttrition;
            LifeCycleBox.Checked = config.LifeCycle;

            troubadour.Checked = config.Troubadour;
            nightingale.Checked = config.Nightingale;
            marcato.Checked = config.Marcato;

            //DEBUFF REMOVAL
            plSilenceItemEnabled.Checked = config.plSilenceItemEnabled;
            plSilenceItem.SelectedIndex = config.plSilenceItem;
            wakeSleepEnabled.Checked = config.wakeSleepEnabled;
            wakeSleepSpell.SelectedIndex = config.wakeSleepSpell;
            plDoomEnabled.Checked = config.plDoomEnabled;
            plDoomitem.SelectedIndex = config.plDoomitem;

            plDebuffEnabled.Checked = config.plDebuffEnabled;
            plAgiDown.Checked = config.plAgiDown;
            plAccuracyDown.Checked = config.plAccuracyDown;
            plAddle.Checked = config.plAddle;
            plAttackDown.Checked = config.plAttackDown;
            plBane.Checked = config.plBane;
            plBind.Checked = config.plBind;
            plBio.Checked = config.plBio;
            plBlindness.Checked = config.plBlindness;
            plBurn.Checked = config.plBurn;
            plChrDown.Checked = config.plChrDown;
            plChoke.Checked = config.plChoke;
            plCurse.Checked = config.plCurse;
            plCurse2.Checked = config.plCurse2;
            plDexDown.Checked = config.plDexDown;
            plDefenseDown.Checked = config.plDefenseDown;
            plDia.Checked = config.plDia;
            plDisease.Checked = config.plDisease;
            plDoom.Checked = config.plDoom;
            plDrown.Checked = config.plDrown;
            plElegy.Checked = config.plElegy;
            plEvasionDown.Checked = config.plEvasionDown;
            plFlash.Checked = config.plFlash;
            plFrost.Checked = config.plFrost;
            plHelix.Checked = config.plHelix;
            plIntDown.Checked = config.plIntDown;
            plMndDown.Checked = config.plMndDown;
            plMagicAccDown.Checked = config.plMagicAccDown;
            plMagicAtkDown.Checked = config.plMagicAtkDown;
            plMaxHpDown.Checked = config.plMaxHpDown;
            plMaxMpDown.Checked = config.plMaxMpDown;
            plMaxTpDown.Checked = config.plMaxTpDown;
            plParalysis.Checked = config.plParalysis;
            plPlague.Checked = config.plPlague;
            plPoison.Checked = config.plPoison;
            plRasp.Checked = config.plRasp;
            plRequiem.Checked = config.plRequiem;
            plStrDown.Checked = config.plStrDown;
            plShock.Checked = config.plShock;
            plSilence.Checked = config.plSilence;
            plSlow.Checked = config.plSlow;
            plThrenody.Checked = config.plThrenody;
            plVitDown.Checked = config.plVitDown;
            plWeight.Checked = config.plWeight;
            plAmnesia.Checked = config.plAmnesia;

            monitoredDebuffEnabled.Checked = config.monitoredDebuffEnabled;
            plProtectra.Checked = config.plProtectra;
            plShellra.Checked = config.plShellra;
            plProtectralevel.Value = config.plProtectra_Level;
            plShellralevel.Value = config.plShellra_Level;
            monitoredAgiDown.Checked = config.monitoredAgiDown;
            monitoredAccuracyDown.Checked = config.monitoredAccuracyDown;
            monitoredAddle.Checked = config.monitoredAddle;
            monitoredAttackDown.Checked = config.monitoredAttackDown;
            monitoredBane.Checked = config.monitoredBane;
            monitoredBind.Checked = config.monitoredBind;
            monitoredBio.Checked = config.monitoredBio;
            monitoredBlindness.Checked = config.monitoredBlindness;
            monitoredBurn.Checked = config.monitoredBurn;
            monitoredChrDown.Checked = config.monitoredChrDown;
            monitoredChoke.Checked = config.monitoredChoke;
            monitoredCurse.Checked = config.monitoredCurse;
            monitoredCurse2.Checked = config.monitoredCurse2;
            monitoredDexDown.Checked = config.monitoredDexDown;
            monitoredDefenseDown.Checked = config.monitoredDefenseDown;
            monitoredDia.Checked = config.monitoredDia;
            monitoredDisease.Checked = config.monitoredDisease;
            monitoredDoom.Checked = config.monitoredDoom;
            monitoredDrown.Checked = config.monitoredDrown;
            monitoredElegy.Checked = config.monitoredElegy;
            monitoredEvasionDown.Checked = config.monitoredEvasionDown;
            monitoredFlash.Checked = config.monitoredFlash;
            monitoredFrost.Checked = config.monitoredFrost;
            monitoredHelix.Checked = config.monitoredHelix;
            monitoredIntDown.Checked = config.monitoredIntDown;
            monitoredMndDown.Checked = config.monitoredMndDown;
            monitoredMagicAccDown.Checked = config.monitoredMagicAccDown;
            monitoredMagicAtkDown.Checked = config.monitoredMagicAtkDown;
            monitoredMaxHpDown.Checked = config.monitoredMaxHpDown;
            monitoredMaxMpDown.Checked = config.monitoredMaxMpDown;
            monitoredMaxTpDown.Checked = config.monitoredMaxTpDown;
            monitoredParalysis.Checked = config.monitoredParalysis;
            monitoredPetrification.Checked = config.monitoredPetrification;
            monitoredPlague.Checked = config.monitoredPlague;
            monitoredPoison.Checked = config.monitoredPoison;
            monitoredRasp.Checked = config.monitoredRasp;
            monitoredRequiem.Checked = config.monitoredRequiem;
            monitoredStrDown.Checked = config.monitoredStrDown;
            monitoredShock.Checked = config.monitoredShock;
            monitoredSilence.Checked = config.monitoredSilence;
            monitoredSleep.Checked = config.monitoredSleep;
            monitoredSleep2.Checked = config.monitoredSleep2;
            monitoredSlow.Checked = config.monitoredSlow;
            monitoredThrenody.Checked = config.monitoredThrenody;
            monitoredVitDown.Checked = config.monitoredVitDown;
            monitoredWeight.Checked = config.monitoredWeight;
            monitoredAmnesia.Checked = config.monitoredAmnesia;

            naSpellsenable.Checked = config.enablePartyDebuffRemoval;
            SpecifiednaSpellsenable.Checked = config.SpecifiednaSpellsenable;
            PrioritiseOverLowerTier.Checked = config.PrioritiseOverLowerTier;
            naBlindness.Checked = config.naBlindness;
            naCurse.Checked = config.naCurse;
            naDisease.Checked = config.naDisease;
            naParalysis.Checked = config.naParalysis;
            naPetrification.Checked = config.naPetrification;
            naPlague.Checked = config.naPlague;
            naPoison.Checked = config.naPoison;
            naSilence.Checked = config.naSilence;
            naErase.Checked = config.naErase;
            Esuna.Checked = config.Esuna;
            EsunaOnlyAmnesia.Checked = config.EsunaOnlyAmnesia;

            na_Weight.Checked = config.na_Weight;
            na_VitDown.Checked = config.na_VitDown;
            na_Threnody.Checked = config.na_Threnody;
            na_Slow.Checked = config.na_Slow;
            na_Shock.Checked = config.na_Shock;
            na_StrDown.Checked = config.na_StrDown;
            na_Requiem.Checked = config.na_Requiem;
            na_Rasp.Checked = config.na_Rasp;
            na_MaxTpDown.Checked = config.na_MaxTpDown;
            na_MaxMpDown.Checked = config.na_MaxMpDown;
            na_MaxHpDown.Checked = config.na_MaxHpDown;
            na_MagicAttackDown.Checked = config.na_MagicAttackDown;
            na_MagicDefenseDown.Checked = config.na_MagicDefenseDown;
            na_MagicAccDown.Checked = config.na_MagicAccDown;
            na_MndDown.Checked = config.na_MndDown;
            na_IntDown.Checked = config.na_IntDown;
            na_Helix.Checked = config.na_Helix;
            na_Frost.Checked = config.na_Frost;
            na_EvasionDown.Checked = config.na_EvasionDown;
            na_Elegy.Checked = config.na_Elegy;
            na_Drown.Checked = config.na_Drown;
            na_Dia.Checked = config.na_Dia;
            na_DefenseDown.Checked = config.na_DefenseDown;
            na_DexDown.Checked = config.na_DexDown;
            na_Choke.Checked = config.na_Choke;
            na_ChrDown.Checked = config.na_ChrDown;
            na_Burn.Checked = config.na_Burn;
            na_Bio.Checked = config.na_Bio;
            na_Bind.Checked = config.na_Bind;
            na_AttackDown.Checked = config.na_AttackDown;
            na_Addle.Checked = config.na_Addle;
            na_AccuracyDown.Checked = config.na_AccuracyDown;
            na_AgiDown.Checked = config.na_AgiDown;

            // OTHER OPTIONS
            lowMPcheckBox.Checked = config.lowMPcheckBox;
            mpMinCastValue.Value = config.mpMinCastValue;

            autoTarget.Checked = config.autoTarget;
            autoTargetSpell.Text = config.autoTargetSpell;
            Hate_SpellType.SelectedIndex = config.Hate_SpellType;
            autoTarget_target.Text = config.autoTarget_Target;

            AssistSpecifiedTarget.Checked = config.AssistSpecifiedTarget;

            DisableTargettingCancel.Checked = config.DisableTargettingCancel;
            TargetRemoval_Delay.Value = config.TargetRemoval_Delay;

            acceptRaise.Checked = config.AcceptRaise;
            acceptRaiseOnlyWhenNotInCombat.Checked = config.AcceptRaiseOnlyWhenNotInCombat;

            RadialArcanaBox.Checked = config.RadialArcana;



            Fullcircle_DisableEnemy.Checked = config.Fullcircle_DisableEnemy;
            Fullcircle_GEOTarget.Checked = config.Fullcircle_GEOTarget;

            RadialArcanaSpell.SelectedIndex = config.RadialArcana_Spell;
            RadialArcanaMP.Value = config.RadialArcanaMP;

            ConvertMP.Value = config.convertMP;

            DevotionMP.Value = config.DevotionMP;
            DevotionTargetType.SelectedIndex = config.DevotionTargetType;
            DevotionTargetName.Text = config.DevotionTargetName;
            DevotionWhenEngaged.Checked = config.DevotionWhenEngaged;

            sublimationMP.Value = config.sublimationMP;

            healLowMP.Checked = config.healLowMP;
            healWhenMPBelow.Value = config.healWhenMPBelow;

            standAtMP.Checked = config.standAtMP;
            standAtMP_Percentage.Value = config.standAtMP_Percentage;

            Overcure.Checked = config.Overcure;
            Undercure.Checked = config.Undercure;
            enableMonitoredPriority.Checked = config.enableMonitoredPriority;
            enableOutOfPartyHealing.Checked = config.enableOutOfPartyHealing;
            OvercureOnHighPriority.Checked = config.OvercureOnHighPriority;

            enableAddOn.Checked = config.EnableAddOn;

            // PROGRAM OPTIONS

            pauseOnZoneBox.Checked = config.pauseOnZoneBox;
            pauseOnStartBox.Checked = config.pauseOnStartBox;
            pauseOnKO.Checked = config.pauseOnKO;
            MinimiseonStart.Checked = config.MinimiseonStart;

            autoFollowName.Text = config.autoFollowName;
            autoFollowDistance.Value = config.autoFollowDistance;
            autoFollow_Warning.Checked = config.autoFollow_Warning;
            FFXIDefaultAutoFollow.Checked = config.FFXIDefaultAutoFollow;
            enableHotKeys.Checked = config.enableHotKeys;

            ipAddress.Text = config.ipAddress;
            listeningPort.Text = config.listeningPort;

            enableFastCast_Mode.Checked = config.enableFastCast_Mode;
            trackCastingPackets.Checked = config.trackCastingPackets;
        }

        private void autoAdjust_Cure_Click ( object sender, EventArgs e )
        {
            //decimal level = this.cureLevel.Value;
            double potency = System.Convert.ToDouble(curePotency.Value);

            if ( CurePleaseForm._ELITEAPIPL != null )
            {
                // First calculate default potency

                double MND = CurePleaseForm._ELITEAPIPL.Player.Stats.Mind;
                double VIT = CurePleaseForm._ELITEAPIPL.Player.Stats.Vitality;

                ushort Healing = CurePleaseForm._ELITEAPIPL.Player.CombatSkills.Healing.Skill;

                // Now grab calculations for each tier

                double MND_B = Math.Floor(MND / 2);
                double VIT_B = Math.Floor(VIT / 4);

                double Power = MND_B + VIT_B + Healing;

                double Cure = 0;

                if ( Power >= 0 && Power < 20 )
                {
                    Cure = ( 0 + Power ) - 0;
                    Cure /= 1;
                    Cure = Math.Floor ( Cure + 10 );
                }
                else if ( Power >= 20 && Power < 40 )
                {
                    Cure = ( 0 + Power ) - 20;
                    Cure /= 1.33;
                    Cure = Math.Floor ( Cure + 15 );
                }
                else if ( Power >= 40 && Power < 125 )
                {
                    Cure = ( 0 + Power ) - 40;
                    Cure /= 8.5;
                    Cure = Math.Floor ( Cure + 30 );
                }
                else if ( Power >= 125 && Power < 200 )
                {
                    Cure = ( 0 + Power ) - 125;
                    Cure /= 8.5;
                    Cure = Math.Floor ( Cure + 40 );
                }
                else if ( Power >= 200 && Power < 600 )
                {
                    Cure = ( 0 + Power ) - 200;
                    Cure /= 20;
                    Cure = Math.Floor ( Cure + 45 );
                }
                else if ( Power >= 600 )
                {
                    Cure = 65;
                }

                double Cure_pot = Cure * 00.01;
                Cure_pot *= potency;

                double Cure_mathed = Math.Round(Cure + Cure_pot);
                Cure_mathed -= ( Cure_mathed * 0.10 );

                double Cure2 = 0;

                if ( Power >= 40 && Power < 70 )
                {
                    Cure2 = ( 0 + Power ) - 40;
                    Cure2 /= 1;
                    Cure2 = Math.Floor ( Cure2 + 60 );
                }
                else if ( Power >= 70 && Power < 125 )
                {
                    Cure2 = ( 0 + Power ) - 70;
                    Cure2 /= 5.5;
                    Cure2 = Math.Floor ( Cure2 + 90 );
                }
                else if ( Power >= 125 && Power < 200 )
                {
                    Cure2 = ( 0 + Power ) - 125;
                    Cure2 /= 7.5;
                    Cure2 = Math.Floor ( Cure2 + 100 );
                }
                else if ( Power >= 200 && Power < 400 )
                {
                    Cure2 = ( 0 + Power ) - 200;
                    Cure2 /= 10;
                    Cure2 = Math.Floor ( Cure2 + 110 );
                }
                else if ( Power >= 400 && Power < 700 )
                {
                    Cure2 = ( 0 + Power ) - 400;
                    Cure2 /= 20;
                    Cure2 = Math.Floor ( Cure2 + 130 );
                }
                else if ( Power >= 700 )
                {
                    Cure2 = 145;
                }

                double Cure2_pot = Cure2 * 00.01;
                Cure2_pot *= potency;

                double Cure2_mathed = Math.Round(Cure2 + Cure2_pot);
                Cure2_mathed -= ( Cure2_mathed * 0.10 );

                double Cure3 = 0;

                if ( Power >= 70 && Power < 125 )
                {
                    Cure3 = ( 0 + Power ) - 70;
                    Cure3 /= 2.2;
                    Cure3 = Math.Floor ( Cure3 + 130 );
                }
                else if ( Power >= 125 && Power < 200 )
                {
                    Cure3 = ( 0 + Power ) - 125;
                    Cure3 /= 1.15;
                    Cure3 = Math.Floor ( Cure3 + 155 );
                }
                else if ( Power >= 200 && Power < 300 )
                {
                    Cure3 = ( 0 + Power ) - 200;
                    Cure3 /= 2.5;
                    Cure3 = Math.Floor ( Cure3 + 220 );
                }
                else if ( Power >= 300 && Power < 700 )
                {
                    Cure3 = ( 0 + Power ) - 300;
                    Cure3 /= 5;
                    Cure3 = Math.Floor ( Cure3 + 260 );
                }
                else if ( Power >= 700 )
                {
                    Cure3 = 340;
                }

                double Cure3_pot = Cure3 * 00.01;
                Cure3_pot *= potency;

                double Cure3_mathed = Math.Round(Cure3 + Cure3_pot);
                Cure3_mathed -= ( Cure3_mathed * 0.10 );

                double Cure4 = 0;

                if ( Power >= 70 && Power < 200 )
                {
                    Cure4 = ( 0 + Power ) - 70;
                    Cure4 /= 1;
                    Cure4 = Math.Floor ( Cure4 + 270 );
                }
                else if ( Power >= 200 && Power < 300 )
                {
                    Cure4 = ( 0 + Power ) - 200;
                    Cure4 /= 2;
                    Cure4 = Math.Floor ( Cure4 + 400 );
                }
                else if ( Power >= 300 && Power < 400 )
                {
                    Cure4 = ( 0 + Power ) - 300;
                    Cure4 /= 1.43;
                    Cure4 = Math.Floor ( Cure4 + 450 );
                }
                else if ( Power >= 400 && Power < 700 )
                {
                    Cure4 = ( 0 + Power ) - 400;
                    Cure4 /= 2.5;
                    Cure4 = Math.Floor ( Cure4 + 520 );
                }
                else if ( Power >= 700 )
                {
                    Cure4 = 640;
                }

                double Cure4_pot = Cure4 * 00.01;
                Cure4_pot *= potency;

                double Cure4_mathed = Math.Round(Cure4 + Cure4_pot);
                Cure4_mathed -= ( Cure4_mathed * 0.10 );

                double Cure5 = 0;

                if ( Power >= 80 && Power < 150 )
                {
                    Cure5 = ( 0 + Power ) - 80;
                    Cure5 /= 0.7;
                    Cure5 = Math.Floor ( Cure5 + 450 );
                }
                else if ( Power >= 150 && Power < 190 )
                {
                    Cure5 = ( 0 + Power ) - 150;
                    Cure5 /= 1.25;
                    Cure5 = Math.Floor ( Cure5 + 550 );
                }
                else if ( Power >= 190 && Power < 260 )
                {
                    Cure5 = ( 0 + Power ) - 190;
                    Cure5 /= 1.84;
                    Cure5 = Math.Floor ( Cure5 + 582 );
                }
                else if ( Power >= 260 && Power < 300 )
                {
                    Cure5 = ( 0 + Power ) - 260;
                    Cure5 /= 2;
                    Cure5 = Math.Floor ( Cure5 + 620 );
                }
                else if ( Power >= 300 && Power < 500 )
                {
                    Cure5 = ( 0 + Power ) - 300;
                    Cure5 /= 2.5;
                    Cure5 = Math.Floor ( Cure5 + 640 );
                }
                else if ( Power >= 500 && Power < 700 )
                {
                    Cure5 = ( 0 + Power ) - 500;
                    Cure5 /= 3.33;
                    Cure5 = Math.Floor ( Cure5 + 720 );
                }
                else if ( Power >= 700 )
                {
                    Cure5 = 780;
                }

                double Cure5_pot = Cure5 * 00.01;
                Cure5_pot *= potency;

                double Cure5_mathed = Math.Round(Cure5 + Cure5_pot);
                Cure5_mathed -= ( Cure5_mathed * 0.10 );

                double Cure6 = 0;

                if ( Power >= 90 && Power < 210 )
                {
                    Cure6 = ( 0 + Power ) - 90;
                    Cure6 /= 1.5;
                    Cure6 = Math.Floor ( Cure6 + 600 );
                }
                else if ( Power >= 210 && Power < 300 )
                {
                    Cure6 = ( 0 + Power ) - 210;
                    Cure6 /= 0.9;
                    Cure6 = Math.Floor ( Cure6 + 680 );
                }
                else if ( Power >= 300 && Power < 400 )
                {
                    Cure6 = ( 0 + Power ) - 300;
                    Cure6 /= 1.43;
                    Cure6 = Math.Floor ( Cure6 + 780 );
                }
                else if ( Power >= 400 && Power < 500 )
                {
                    Cure6 = ( 0 + Power ) - 400;
                    Cure6 /= 2.5;
                    Cure6 = Math.Floor ( Cure6 + 850 );
                }
                else if ( Power >= 500 && Power < 700 )
                {
                    Cure6 = ( 0 + Power ) - 500;
                    Cure6 /= 1.67;
                    Cure6 = Math.Floor ( Cure6 + 890 );
                }
                else if ( Power >= 700 )
                {
                    Cure6 = 1010;
                }

                double Cure6_pot = Cure6 * 00.01;
                Cure6_pot *= potency;

                double Cure6_mathed = Math.Round(Cure6 + Cure6_pot);
                Cure6_mathed -= ( Cure6_mathed * 0.10 );

                cure1amount.Value = Convert.ToDecimal ( Cure_mathed );
                cure2amount.Value = Convert.ToDecimal ( Cure2_mathed );
                cure3amount.Value = Convert.ToDecimal ( Cure3_mathed );
                cure4amount.Value = Convert.ToDecimal ( Cure4_mathed );
                cure5amount.Value = Convert.ToDecimal ( Cure5_mathed );
                cure6amount.Value = Convert.ToDecimal ( Cure6_mathed );

                curagaAmount.Value = Convert.ToDecimal ( Cure2_mathed );
                curaga2Amount.Value = Convert.ToDecimal ( Cure3_mathed );
                curaga3Amount.Value = Convert.ToDecimal ( Cure4_mathed );
                curaga4Amount.Value = Convert.ToDecimal ( Cure5_mathed );
                curaga5Amount.Value = Convert.ToDecimal ( Cure6_mathed );
            }
            else
            {
                MessageBox.Show ( "Select a PL from the main screen before running this." );
            }
        }

        protected override bool ProcessCmdKey ( ref Message msg, Keys keyData )
        {
            if ( keyData == ( Keys.Control | Keys.S ) )
            {
                loadButton.PerformClick ( );
            }
            else if ( keyData == ( Keys.Control | Keys.O ) )
            {
                saveAsButton.PerformClick ( );
            }
            else if ( keyData == ( Keys.Escape ) )
            {
                button4.PerformClick ( );
            }
            return base.ProcessCmdKey ( ref msg, keyData );
        }

        private void naErase_CheckedChanged ( object sender, EventArgs e )
        {
            if ( naErase.Checked == true )
            {
                na_Weight.Enabled = true;
                na_VitDown.Enabled = true;
                na_Threnody.Enabled = true;
                na_Slow.Enabled = true;
                na_Shock.Enabled = true;
                na_StrDown.Enabled = true;
                na_Requiem.Enabled = true;
                na_Rasp.Enabled = true;
                na_MaxTpDown.Enabled = true;
                na_MaxMpDown.Enabled = true;
                na_MaxHpDown.Enabled = true;
                na_MagicAttackDown.Enabled = true;
                na_MagicDefenseDown.Enabled = true;
                na_MagicAccDown.Enabled = true;
                na_MndDown.Enabled = true;
                na_IntDown.Enabled = true;
                na_Helix.Enabled = true;
                na_Frost.Enabled = true;
                na_EvasionDown.Enabled = true;
                na_Elegy.Enabled = true;
                na_Drown.Enabled = true;
                na_Dia.Enabled = true;
                na_DefenseDown.Enabled = true;
                na_DexDown.Enabled = true;
                na_Choke.Enabled = true;
                na_ChrDown.Enabled = true;
                na_Burn.Enabled = true;
                na_Bio.Enabled = true;
                na_Bind.Enabled = true;
                na_AttackDown.Enabled = true;
                na_Addle.Enabled = true;
                na_AccuracyDown.Enabled = true;
                na_AgiDown.Enabled = true;

                na_Weight.Checked = true;
                na_VitDown.Checked = true;
                na_Threnody.Checked = true;
                na_Slow.Checked = true;
                na_Shock.Checked = true;
                na_StrDown.Checked = true;
                na_Requiem.Checked = true;
                na_Rasp.Checked = true;
                na_MaxTpDown.Checked = true;
                na_MaxMpDown.Checked = true;
                na_MaxHpDown.Checked = true;
                na_MagicAttackDown.Checked = true;
                na_MagicDefenseDown.Checked = true;
                na_MagicAccDown.Checked = true;
                na_MndDown.Checked = true;
                na_IntDown.Checked = true;
                na_Helix.Checked = true;
                na_Frost.Checked = true;
                na_EvasionDown.Checked = true;
                na_Elegy.Checked = true;
                na_Drown.Checked = true;
                na_Dia.Checked = true;
                na_DefenseDown.Checked = true;
                na_DexDown.Checked = true;
                na_Choke.Checked = true;
                na_ChrDown.Checked = true;
                na_Burn.Checked = true;
                na_Bio.Checked = true;
                na_Bind.Checked = true;
                na_AttackDown.Checked = true;
                na_Addle.Checked = true;
                na_AccuracyDown.Checked = true;
                na_AgiDown.Checked = true;
            }
            else
            {
                na_Weight.Checked = false;
                na_VitDown.Checked = false;
                na_Threnody.Checked = false;
                na_Slow.Checked = false;
                na_Shock.Checked = false;
                na_StrDown.Checked = false;
                na_Requiem.Checked = false;
                na_Rasp.Checked = false;
                na_MaxTpDown.Checked = false;
                na_MaxMpDown.Checked = false;
                na_MaxHpDown.Checked = false;
                na_MagicAttackDown.Checked = false;
                na_MagicDefenseDown.Checked = false;
                na_MagicAccDown.Checked = false;
                na_MndDown.Checked = false;
                na_IntDown.Checked = false;
                na_Helix.Checked = false;
                na_Frost.Checked = false;
                na_EvasionDown.Checked = false;
                na_Elegy.Checked = false;
                na_Drown.Checked = false;
                na_Dia.Checked = false;
                na_DefenseDown.Checked = false;
                na_DexDown.Checked = false;
                na_Choke.Checked = false;
                na_ChrDown.Checked = false;
                na_Burn.Checked = false;
                na_Bio.Checked = false;
                na_Bind.Checked = false;
                na_AttackDown.Checked = false;
                na_Addle.Checked = false;
                na_AccuracyDown.Checked = false;
                na_AgiDown.Checked = false;

                na_Weight.Enabled = false;
                na_VitDown.Enabled = false;
                na_Threnody.Enabled = false;
                na_Slow.Enabled = false;
                na_Shock.Enabled = false;
                na_StrDown.Enabled = false;
                na_Requiem.Enabled = false;
                na_Rasp.Enabled = false;
                na_MaxTpDown.Enabled = false;
                na_MaxMpDown.Enabled = false;
                na_MaxHpDown.Enabled = false;
                na_MagicAttackDown.Enabled = false;
                na_MagicDefenseDown.Enabled = false;
                na_MagicAccDown.Enabled = false;
                na_MndDown.Enabled = false;
                na_IntDown.Enabled = false;
                na_Helix.Enabled = false;
                na_Frost.Enabled = false;
                na_EvasionDown.Enabled = false;
                na_Elegy.Enabled = false;
                na_Drown.Enabled = false;
                na_Dia.Enabled = false;
                na_DefenseDown.Enabled = false;
                na_DexDown.Enabled = false;
                na_Choke.Enabled = false;
                na_ChrDown.Enabled = false;
                na_Burn.Enabled = false;
                na_Bio.Enabled = false;
                na_Bind.Enabled = false;
                na_AttackDown.Enabled = false;
                na_Addle.Enabled = false;
                na_AccuracyDown.Enabled = false;
                na_AgiDown.Enabled = false;
            }
        }
    }
}
