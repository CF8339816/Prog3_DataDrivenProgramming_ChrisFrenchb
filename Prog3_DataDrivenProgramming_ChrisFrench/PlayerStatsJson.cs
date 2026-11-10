using Prog3DataDrivenProgramming_ChrisFrench;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Prog3DataDrivenProgramming_ChrisFrench.ArcaneSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.ArchSpecies;
using static Prog3DataDrivenProgramming_ChrisFrench.ArchType;
using static Prog3DataDrivenProgramming_ChrisFrench.ElementalSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.HealingSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.HolySpells;
using static Prog3DataDrivenProgramming_ChrisFrench.IllusionSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.MapLoader;
using static Prog3DataDrivenProgramming_ChrisFrench.NatureSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.PC;
using static Prog3DataDrivenProgramming_ChrisFrench.Program;

namespace Prog3_DataDrivenProgramming_ChrisFrench
{
    public class PlayerStatsJson
    {

        // from Character
        public static int PlayerHp { get; set; }
        public static int PlayerAC { get; set; }
        public static int PlayerATK { get; set; }
        public static int PlayerMP { get; set; }
        public static int MagicACBonus { get; set; }
        public ArchType _ArchType = HUD.jobType;
        public ArchSpecies _ArchSpecies = HUD.SpeciesChoice;

        //from ArchType

        public string DefaultName { get; }
        public string JobTitle { get; }
        public ArchSpecies DefaultSpecies { get; }
        public int HpBonusPerLevel { get; }
        public int AtHp { get; }
        public string Species { get; }
        public int MaxSpellLevel1 { get; }
        public int MaxSpellLevel2 { get; }
        public int MagicType1 { get; } //0= no magic, 1= Elemental, 2= Arcane, 3= Nature, 4= Holy, 5= Healing, 6= Illusion
        public int MagicType2 { get; }//0= no magic, 1= Elemental, 2= Arcane, 3= Nature, 4= Holy, 5= Healing, 6= Illusion
        public int XPtoLevelMultiplier { get; }
        public int ArmorType1 { get; set; } //0 = no armor, 1= cloth, 2= leather, 3= chain, 4= plate, all other = default 
        public int ArmorType2 { get; set; } // 0 = no shield, 1 = shield, all other = default
        public int WeaponType1 { get; set; }  // 0 = unarmed, 1= melee, 2 = ranged all else = default
        public int ArmorBonus { get; }
        public int AttackBonus { get; }
        public int ManaBonus { get; }

        // from ArchSpecies

        public string Vision { get; }
        public string SpeciesTitle { get; }
        public int HpBonusSpecies { get; }
        public string BonusSpellsSpecies1 { get; }
        public string BonusSpellsSpecies2 { get; }
        public int ACbonusSpecies { get; }
        public int ManaBonusSpecies { get; }


        public static void FetchPlayerStats()
        {

            //var playerStatsJson = new playerStatsJson
            //{
            //    Date = DateTime.Parse("2019-08-01"),
            //    TemperatureCelsius = 25,
            //    Summary = "Hot"
            //};


            //string fileName = "PlayerStats.json";
            //string jsonString = JsonSerializer.Serialize(playerStatsJson);
            //File.WriteAllText(fileName, jsonString);

            //Console.WriteLine(File.ReadAllText(fileName));




        }
    }
}