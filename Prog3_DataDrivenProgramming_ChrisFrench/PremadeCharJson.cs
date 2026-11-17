using Prog3_DataDrivenProgramming_ChrisFrench;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
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
    public class PremadeCharJson
    {
        //( HpBPL, atHp, JobAtkBonus, JobManaBonus, maxSL1, maxSL2, magType1, magType2, xp2LMulti, armorType1, armorType2, weaponType1, ArBonus)

        // pally
        public static string? AT1 { get; set; }
        public static string? Name1 { get; set; }
        public static string? Job1 { get; set; }
        public static string? Species1 { get; set; }
        public static int HpBPL_1 { get; set; }
        public static int atHp_1 { get; set; }
        public static int JobAtkBonus_1{ get; set; }
        public static int JobManaBonus_1 { get; set; }
        public static int maxSL1_1 { get; set; }
        public static int maxSL2_1 {get; set; }
        public static int magType1_1 { get; set; }
        public static int magType2_1 { get; set; }
        public static int xp2LMulti_1 { get; set; }
        public static int armorType1_1 { get; set; }
        public static int armorType2_1 { get; set; }
        public static int weaponType1_1 { get; set; }
        public static int ArBonus_1 { get; set; }
        


        // Bard
       
        public static string? AT2 { get; set; }
        public static string? Name2 { get; set; }
        public static string? Job2 { get; set; }
        public static string? Species2 { get; set; }
        public static int HpBPL_2 { get; set; }
        public static int atHp_2 { get; set; }
        public static int JobAtkBonus_2 { get; set; }
        public static int JobManaBonus_2 { get; set; }
        public static int maxSL1_2 { get; set; }
        public static int maxSL2_2 { get; set; }
        public static int magType1_2 { get; set; }
        public static int magType2_2 { get; set; }
        public static int xp2LMulti_2 { get; set; }
        public static int armorType1_2 { get; set; }
        public static int armorType2_2 { get; set; }
        public static int weaponType1_2 { get; set; }
        public static int ArBonus_2 { get; set; }
        // Cleric
        public static string? AT3 { get; set; }
        public static string? Name3 { get; set; }
        public static string? Job3 { get; set; }
        public static string? Species3 { get; set; }
        public static int HpBPL_3 { get; set; }
        public static int atHp_3 { get; set; }
        public static int JobAtkBonus_3 { get; set; }
        public static int JobManaBonus_3 { get; set; }
        public static int maxSL1_3 { get; set; }
        public static int maxSL2_3 { get; set; }
        public static int magType1_3 { get; set; }
        public static int magType2_3 { get; set; }
        public static int xp2LMulti_3 { get; set; }
        public static int armorType1_3 { get; set; }
        public static int armorType2_3 { get; set; }
        public static int weaponType1_3 { get; set; }
        public static int ArBonus_3 { get; set; }

        // Sorcerer 
        public static string? AT4 { get; set; }
        public static string? Name4 { get; set; }
        public static string? Job4 { get; set; }
        public static string? Species4 { get; set; }
        public static int HpBPL_4 { get; set; }
        public static int atHp_4 { get; set; }
        public static int JobAtkBonus_4 { get; set; }
        public static int JobManaBonus_4 { get; set; }
        public static int maxSL1_4 { get; set; }
        public static int maxSL2_4 { get; set; }
        public static int magType1_4 { get; set; }
        public static int magType2_4 { get; set; }
        public static int xp2LMulti_4 { get; set; }
        public static int armorType1_4 { get; set; }
        public static int armorType2_4 { get; set; }
        public static int weaponType1_4 { get; set; }
        public static int ArBonus_4 { get; set; }

        // ranger
        public static string? AT5 { get; set; }
        public static string? Name5 { get; set; }
        public static string? Job5 { get; set; }
        public static string? Species5 { get; set; }
        public static int HpBPL_5 { get; set; }
        public static int atHp_5 { get; set; }
        public static int JobAtkBonus_5 { get; set; }
        public static int JobManaBonus_5 { get; set; }
        public static int maxSL1_5 { get; set; }
        public static int maxSL2_5 { get; set; }
        public static int magType1_5 { get; set; }
        public static int magType2_5 { get; set; }
        public static int xp2LMulti_5 { get; set; }
        public static int armorType1_5 { get; set; }
        public static int armorType2_5 { get; set; }
        public static int weaponType1_5 { get; set; }
        public static int ArBonus_5 { get; set; }

         // rogue
        public static string? AT6 { get; set; }
        public static string? Name6 { get; set; }
        public static string? Job6 { get; set; }
        public static string? Species6 { get; set; }
        public static int HpBPL_6 { get; set; }
        public static int atHp_6 { get; set; }
        public static int JobAtkBonus_6 { get; set; }
        public static int JobManaBonus_6 { get; set; }
        public static int maxSL1_6 { get; set; }
        public static int maxSL2_6 { get; set; }
        public static int magType1_6 { get; set; }
        public static int magType2_6 { get; set; }
        public static int xp2LMulti_6 { get; set; }
        public static int armorType1_6 { get; set; }
        public static int armorType2_6 { get; set; }
        public static int weaponType1_6 { get; set; }
        public static int ArBonus_6 { get; set; }






        public void FetchArctypes()
        {

            var premadeCharJson = new PremadeCharJson
            {
                //pally
                AT1 = "Paladin",
                Name1 = "Medrin",
                Job1 = "Paladin",
                Species1 = "DragonKin",
                HpBPL_1 = 5,
                atHp_1 = 50,
                JobAtkBonus_1 = 5,
                JobManaBonus_1 = 3,
                maxSL1_1 = 3,
                maxSL2_1 = 0,
                magType1_1 = 4,
                magType2_1 = 0,
                xp2LMulti_1 = 13,
                armorType1_1 = 4,
                armorType2_1 = 0,
                weaponType1_1 = 1,
                ArBonus_1 = 5,

                 //bard
                AT2 = "Bard",
                Name2 = "Tessa",
                Job2 = "Bard",
                Species2 = "DaemonKyne",
                HpBPL_2 = 2,
                atHp_2 = 35,
                JobAtkBonus_2 = 2,
                JobManaBonus_2 = 2,
                maxSL1_2 = 3,
                maxSL2_2 = 6,
                magType1_2 = 5,
                magType2_2 = 6,
                xp2LMulti_2 = 11,
                armorType1_2 = 2,
                armorType2_2 = 0,
                weaponType1_2 = 1,
                ArBonus_2 = 2,

               //cleric
                AT3 = "Cleric",
                Name3 = "Fray",
                Job3 = "Cleric",
                Species3 = "Dwarf",
                HpBPL_3 = 4,
                atHp_3 = 40,
                JobAtkBonus_3 = 5,
                JobManaBonus_3 = 5,
                maxSL1_3 = 6,
                maxSL2_3 = 6,
                magType1_3 = 4,
                magType2_3 = 5,
                xp2LMulti_3 = 13,
                armorType1_3 = 3,
                armorType2_3 = 1,
                weaponType1_3 = 1,
                ArBonus_3 = 4,

                //Sorcerer
                AT4 = "Sorcerer",
                Name4 = "Garth",
                Job4 = "Sorcerer",
                Species4 = "Human",
                HpBPL_4 = 1,
                atHp_4 = 10,
                JobAtkBonus_4 = 1,
                JobManaBonus_4 = 8,
                maxSL1_4 = 6,
                maxSL2_4 = 6,
                magType1_4 = 2,
                magType2_4 = 1,
                xp2LMulti_4 = 12,
                armorType1_4 = 1,
                armorType2_4 = 0,
                weaponType1_4 = 1,
                ArBonus_4 = 1,

                //Ranger
                AT5 = "Ranger",
                Name5 = "Nae'O'mii",
                Job5 = "Ranger",
                Species5 = "Elf",
                HpBPL_5 = 3,
                atHp_5 = 30,
                JobAtkBonus_5 = 4,
                JobManaBonus_5 = 2,
                maxSL1_5 = 3,
                maxSL2_5 = 5,
                magType1_5 = 3,
                magType2_5 = 0,
                xp2LMulti_5 = 10,
                armorType1_5 = 2,
                armorType2_5 = 1,
                weaponType1_5 = 2,
                ArBonus_5 = 3,

                // Rogue 
                AT6 = "Rogue",
                Name6 = "Kayleigh",
                Job6 = "Rogue",
                Species6 = "SmallFolk",
                HpBPL_6 = 2,
                atHp_6 = 20,
                JobAtkBonus_6 = 3,
                JobManaBonus_6 = 1,
                maxSL1_6 = 4,
                maxSL2_6 = 0,
                magType1_6 = 6,
                magType2_6 = 0,
                xp2LMulti_6 = 12,
                armorType1_6 = 2,
                armorType2_6 = 0,
                weaponType1_6 = 1,
                ArBonus_6 = 2,
            };


            string fileName = "PregenChars.json";
            string jsonString = JsonSerializer.Serialize(premadeCharJson);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));


        }
    }
}