using Prog3_DataDrivenProgramming_ChrisFrench;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Prog3DataDrivenProgramming_ChrisFrench.ArchSpecies;
using static Prog3DataDrivenProgramming_ChrisFrench.ArchType;
using static Prog3DataDrivenProgramming_ChrisFrench.Armor;
using static Prog3DataDrivenProgramming_ChrisFrench.EquipmentManager;
using static Prog3DataDrivenProgramming_ChrisFrench.PC;
using static Prog3DataDrivenProgramming_ChrisFrench.Program;
using static Prog3DataDrivenProgramming_ChrisFrench.Weapon;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace Prog3DataDrivenProgramming_ChrisFrench
{
  
    public class ArchType
    {
        //public PremadeCharJson premadeCharJson;
        private static PremadeCharJson DataPremades => PremadeCharJson.CurrentData;
        public string DefaultName { get; set; }
        public string JobTitle { get; set; }
        public ArchSpecies DefaultSpecies { get; set; }

        public int HpBonusPerLevel { get; set; }
        public int AtHp { get; set; }
        public string Species { get; set; }
        public int MaxSpellLevel1 { get; set; }
        public int MaxSpellLevel2 { get; set; }
        public int MagicType1 { get; set; }//0= no magic, 1= Elemental, 2= Arcane, 3= Nature, 4= Holy, 5= Healing, 6= Illusion
        public int MagicType2 { get; set; }//0= no magic, 1= Elemental, 2= Arcane, 3= Nature, 4= Holy, 5= Healing, 6= Illusion
        public int XPtoLevelMultiplier { get; set; }
        public int ArmorType1 { get; set; } //0 = no armor, 1= cloth, 2= leather, 3= chain, 4= plate, all other = default 
        public int ArmorType2 { get; set; } // 0 = no shield, 1 = shield, all other = default
        public int WeaponType1 { get; set; }  // 0 = unarmed, 1= melee, 2 = ranged all else = default
        public int ArmorBonus { get; set; }
        public int AttackBonus { get; set; }
        public int ManaBonus { get; set; }

        public ArchType(string dName, string jobTitle, int HpBPL, int atHp, int JobAtkBonus,int JobManaBonus, ArchSpecies defSpecies, 
            int maxSL1, int maxSL2, int magType1, int magType2, int xp2LMulti, int armorType1, int armorType2, int weaponType1, int ArBonus)
        {

            DefaultName = dName;          
            JobTitle = jobTitle;

            HpBonusPerLevel = HpBPL;
            AtHp = atHp;
            DefaultSpecies = defSpecies;
            MaxSpellLevel1 = maxSL1;
            MaxSpellLevel2 = maxSL2;
            MagicType1 = magType1;
            MagicType2 = magType2;
            XPtoLevelMultiplier = xp2LMulti;


            ArmorType1 = armorType1;
            ArmorType2 = armorType2;
            WeaponType1 = weaponType1;


        ArmorBonus = ArBonus;
            AttackBonus = JobAtkBonus;
            ManaBonus = JobManaBonus;

        }

        public Weapon ReadiedWeapon1 = EquipmentManager.EquippedWeapon1;
        public Armor ReadiedArmor1 = EquipmentManager.EquippedArmor1;
        public Armor ReadiedArmor2 = EquipmentManager.EquippedArmor2;



        // player classes read from Json
        //(defName, jobTitle, HpBPL, atHp, JobAtkBonus, JobManaBonus, defSpecies,maxSL1, maxSL2, magType1, magType2, xp2LMulti, armorType1, armorType2, weaponType1, ArBonus)
        private static ArchSpecies defSpecies(string? speciesName)// redefining the linkage from the stored string for
                                                                  // species tot he archspecies  class function for
                                                                  // species call in the  class variables
        {
            return speciesName switch
            {
                "DragonKin" => DragonKin,
                "DaemonKyne" => DaemonKyne,
                "Dwarf" => Dwarf,
                "Human" => Human,
                "Elf" => Elf,
                "SmallFolk" => SmallFolk,
                "" => Human // default
            };
        }

        public static ArchType Paladin => new ArchType(DataPremades.Name1 ?? "Medrin", DataPremades.Job1 ?? "Paladin", DataPremades.HpBPL_1, DataPremades.atHp_1, DataPremades.JobAtkBonus_1,
            DataPremades.JobManaBonus_1, defSpecies(DataPremades.Species1), DataPremades.maxSL1_1, DataPremades.maxSL2_1, DataPremades.magType1_1, DataPremades.magType2_1,
            DataPremades.xp2LMulti_1, DataPremades.armorType1_1, DataPremades.armorType2_1, DataPremades.weaponType1_1, DataPremades.ArBonus_1);

        public static ArchType Bard => new ArchType(DataPremades.Name2 ?? "Tessa", DataPremades.Job2 ?? "Bard", DataPremades.HpBPL_2, DataPremades.atHp_2, DataPremades.JobAtkBonus_2,
            DataPremades.JobManaBonus_2, defSpecies(DataPremades.Species2), DataPremades.maxSL1_2, DataPremades.maxSL2_2, DataPremades.magType1_2, DataPremades.magType2_2,
            DataPremades.xp2LMulti_2, DataPremades.armorType1_2, DataPremades.armorType2_2, DataPremades.weaponType1_2, DataPremades.ArBonus_2);

        public static ArchType Cleric => new ArchType(DataPremades.Name3 ?? "Fray", DataPremades.Job3 ?? "Cleric", DataPremades.HpBPL_3, DataPremades.atHp_3, DataPremades.JobAtkBonus_3,
            DataPremades.JobManaBonus_3, defSpecies(DataPremades.Species3), DataPremades.maxSL1_3, DataPremades.maxSL2_3, DataPremades.magType1_3, DataPremades.magType2_3,
            DataPremades.xp2LMulti_3, DataPremades.armorType1_3, DataPremades.armorType2_3, DataPremades.weaponType1_3, DataPremades.ArBonus_3);

        public static ArchType Sorcerer => new ArchType(DataPremades.Name4 ?? "Garth", DataPremades.Job4 ?? "Sorcerer", DataPremades.HpBPL_4, DataPremades.atHp_4, DataPremades.JobAtkBonus_4,
            DataPremades.JobManaBonus_4, defSpecies(DataPremades.Species4), DataPremades.maxSL1_4, DataPremades.maxSL2_4, DataPremades.magType1_4, DataPremades.magType2_4,
            DataPremades.xp2LMulti_4, DataPremades.armorType1_4, DataPremades.armorType2_4, DataPremades.weaponType1_4, DataPremades.ArBonus_4);

        public static ArchType Ranger => new ArchType(DataPremades.Name5 ?? "Nae'O'mii", DataPremades.Job5 ?? "Ranger", DataPremades.HpBPL_5, DataPremades.atHp_5, DataPremades.JobAtkBonus_5,
            DataPremades.JobManaBonus_5, defSpecies(DataPremades.Species5), DataPremades.maxSL1_5, DataPremades.maxSL2_5, DataPremades.magType1_5, DataPremades.magType2_5,
            DataPremades.xp2LMulti_5, DataPremades.armorType1_5, DataPremades.armorType2_5, DataPremades.weaponType1_5, DataPremades.ArBonus_5);

        public static ArchType Rogue => new ArchType(DataPremades.Name6 ?? "Kayleigh", DataPremades.Job6 ?? "Rogue", DataPremades.HpBPL_6, DataPremades.atHp_6, DataPremades.JobAtkBonus_6,
            DataPremades.JobManaBonus_6, defSpecies(DataPremades.Species6), DataPremades.maxSL1_6, DataPremades.maxSL2_6, DataPremades.magType1_6, DataPremades.magType2_6,
            DataPremades.xp2LMulti_6, DataPremades.armorType1_6, DataPremades.armorType2_6, DataPremades.weaponType1_6, DataPremades.ArBonus_6);


        //public static ArchType Paladin => new ArchType(premadeCharJson.Name1, premadeCharJson.Job1, premadeCharJson.HpBPL_1, premadeCharJson.atHp_1, premadeCharJson.JobAtkBonus_1, 
        //    premadeCharJson.JobManaBonus_1, premadeCharJson.Species1, premadeCharJson.maxSL1_1, premadeCharJson.maxSL2_1, premadeCharJson.magType1_1, premadeCharJson.magType2_1, 
        //    premadeCharJson.xp2LMulti_1, premadeCharJson.armorType1_1, premadeCharJson.armorType2_1, premadeCharJson.weaponType1_1, premadeCharJson.ArBonus_1);
        //public static ArchType Bard => new ArchType(premadeCharJson.Name2, premadeCharJson.Job2, premadeCharJson.HpBPL_2, premadeCharJson.atHp_2, premadeCharJson.JobAtkBonus_2, 
        //    premadeCharJson.JobManaBonus_2, premadeCharJson.Species2, premadeCharJson.maxSL1_2, premadeCharJson.maxSL2_2, premadeCharJson.magType1_2, premadeCharJson.magType2_2,
        //    premadeCharJson.xp2LMulti_2, premadeCharJson.armorType1_2, premadeCharJson.armorType2_2, premadeCharJson.weaponType1_2, premadeCharJson.ArBonus_2);
        //public static ArchType Cleric => new ArchType(premadeCharJson.Name3, premadeCharJson.Job3, premadeCharJson.HpBPL_3, premadeCharJson.atHp_3, premadeCharJson.JobAtkBonus_3,
        //    premadeCharJson.JobManaBonus_3, premadeCharJson.Species3, premadeCharJson.maxSL1_3, premadeCharJson.maxSL2_3, premadeCharJson.magType1_3, premadeCharJson.magType2_3, 
        //    premadeCharJson.xp2LMulti_3, premadeCharJson.armorType1_3, premadeCharJson.armorType2_3, premadeCharJson.weaponType1_3, premadeCharJson.ArBonus_3);
        //public static ArchType Sorcerer => new ArchType(premadeCharJson.Name4, premadeCharJson.Job4, premadeCharJson.HpBPL_4, premadeCharJson.atHp_4, premadeCharJson.JobAtkBonus_4, 
        //    premadeCharJson.JobManaBonus_4, premadeCharJson.Species4, premadeCharJson.maxSL1_4, premadeCharJson.maxSL2_4, premadeCharJson.magType1_4, premadeCharJson.magType2_4,
        //    premadeCharJson.xp2LMulti_4, premadeCharJson.armorType1_4, premadeCharJson.armorType2_4, premadeCharJson.weaponType1_4, premadeCharJson.ArBonus_4);
        //public static ArchType Ranger => new ArchType(premadeCharJson.Name5, premadeCharJson.Job5, premadeCharJson.HpBPL_5, premadeCharJson.atHp_5, premadeCharJson.JobAtkBonus_5,
        //    premadeCharJson.JobManaBonus_5, premadeCharJson.Species5, premadeCharJson.maxSL1_5, premadeCharJson.maxSL2_5, premadeCharJson.magType1_5, premadeCharJson.magType2_5,
        //    premadeCharJson.xp2LMulti_5, premadeCharJson.armorType1_5, premadeCharJson.armorType2_5, premadeCharJson.weaponType1_5, premadeCharJson.ArBonus_5);
        //public static ArchType Rogue => new ArchType(premadeCharJson.Name6, premadeCharJson.Job6, premadeCharJson.HpBPL_6, premadeCharJson.atHp_6, premadeCharJson.JobAtkBonus_6,
        //    premadeCharJson.JobManaBonus_6, premadeCharJson.Species6, premadeCharJson.maxSL1_6, premadeCharJson.maxSL2_6, premadeCharJson.magType1_6, premadeCharJson.magType2_6, 
        //    premadeCharJson.xp2LMulti_6, premadeCharJson.armorType1_6, premadeCharJson.armorType2_6, premadeCharJson.weaponType1_6, premadeCharJson.ArBonus_6);        
        //// player classes
        ////(defName, jobTitle, HpBPL, atHp, JobAtkBonus, JobManaBonus, defSpecies,maxSL1, maxSL2, magType1, magType2, xp2LMulti, armorType1, armorType2, weaponType1, ArBonus)
        //public static ArchType Paladin => new ArchType("Medrin", "Paladin", 5, 50, 5,3, DragonKin, 3, 0, 4, 0, 13, 4, 0, 1, 5);
        //public static ArchType Bard => new ArchType("Tessa", "Bard", 2, 35, 2,2, DaemonKyne, 3, 6, 5, 6, 11, 2, 0, 1, 2);
        //public static ArchType Cleric => new ArchType("Fray", "Cleric", 4, 40, 5, 5, Dwarf, 6, 6, 4, 5, 13, 3, 1, 1, 4);
        //public static ArchType Sorcerer => new ArchType("Garth", "Sorcerer", 1, 10, 1, 8, Human, 6, 6, 2, 1, 12, 1, 0, 1, 1);
        //public static ArchType Ranger => new ArchType("Nae'O'mii", "Ranger", 3, 30, 4, 2, Elf, 3, 5, 3, 0, 10, 2, 1, 2, 3);
        //public static ArchType Rogue => new ArchType("Kayleigh", "Rogue", 2, 20, 3, 1, SmallFolk, 4, 0, 6, 0, 12, 2, 0, 1, 2);


        //Enemy classes
        //(defName, jobTitle, HpBPL, atHp, JobAtkBonus, JobManaBonus, defSpecies,maxSL1, maxSL2, magType1, magType2, xp2LMulti, Armor, ArBonus)
        public static ArchType Peon => new ArchType("", "Peon", 3, 30, 4, 2, Goblin, 3, 5, 0, 0, 10, 0, 0, 1 , 1);
        public static ArchType Skirmisher => new ArchType("", "Skirmisher", 4, 40, 5, 5, Goblin, 6, 6, 0, 0, 13, 2, 1, 2, 2);
        public static ArchType Warboss => new ArchType("", "WarBoss", 1, 10, 1, 8, HobGoblin, 6, 6, 0, 0, 12, 4, 0, 1, 3);
        public static ArchType Champion => new ArchType("", "Champion", 3, 30, 4, 2, Gnoll, 3, 5, 2, 0, 10, 3, 1, 1, 3);
        public static ArchType Shaman => new ArchType("", "Shaman", 2, 20, 3, 1, Gnoll, 4, 0, 3, 1, 12, 1, 0, 1, 2);
        public static ArchType ClanChief => new ArchType("", "Clan Chief", 2, 20, 3, 1, Orc, 4, 0, 2, 5, 12, 4, 1,1, 4);

        // NPC Classes
        //(defName, jobTitle, HpBPL, atHp, JobAtkBonus, JobManaBonus, defSpecies,maxSL1, maxSL2, magType1, magType2, xp2LMulti, Armor, ArBonus)

        public static ArchType Peasant => new ArchType("", "Peasant", 4, 40, 5, 5, Human, 6, 6, 0, 0, 13, 0, 0, 1, 4);
        public static ArchType Merchant => new ArchType("", "Merchant", 1, 10, 1, 8, Human, 6, 6, 0, 0, 12, 1, 0, 1, 1);
        public static ArchType Noble => new ArchType("", "Nobel", 3, 30, 4, 2, Human, 3, 5, 0, 0, 10, 1, 0, 1, 3);
        public static ArchType Guard => new ArchType("", "Guard", 2, 20, 3, 1, Human, 4, 0, 0, 0, 12, 2, 1, 2, 2);
        public static ArchType Sheriff => new ArchType("", "Sheriff", 3, 30, 4, 2, Human, 3, 5, 6, 0, 10, 3, 1, 1, 3);
        public static ArchType Knight => new ArchType("", "Knight", 2, 20, 3, 1, Human, 4, 0, 2, 5, 12, 4,1 ,1 , 2);

    }
}

