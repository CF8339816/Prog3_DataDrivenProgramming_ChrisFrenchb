using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Prog3DataDrivenProgramming_ChrisFrench.ArchSpecies;
using static Prog3DataDrivenProgramming_ChrisFrench.ArchType;
using static Prog3DataDrivenProgramming_ChrisFrench.PC;
using static Prog3DataDrivenProgramming_ChrisFrench.Program;
using static Prog3DataDrivenProgramming_ChrisFrench.ElementalSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.ArcaneSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.HolySpells;
using static Prog3DataDrivenProgramming_ChrisFrench.HealingSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.NatureSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.IllusionSpells;
using System.Text.Json;


namespace Prog3DataDrivenProgramming_ChrisFrench
{

    public class PC : Character
    {

       public int PcHp = 100;
       
        public int plXP = 0;
        public int plLevel = 0;


        public int ArmorClass { get; }
        public int MaxHP { get; }


        public ArchType ArcJob = HUD.jobType;
        public ArchSpecies ArcSpecies = HUD.SpeciesChoice;



        public PC(string type, string name, int strength, int speed, int dex, int baseAC, int baseHp, int baseAtk, int baseMana, char symbol, ConsoleColor color, ArchType arcJob, ArchSpecies arcSpecies, int maxHP, int maxAC, int level, int XP)
           : base("PC", name, strength, speed, dex, baseAC, baseHp, baseAtk, baseMana, symbol, color)

      

        {
          
            ArcJob = arcJob;
            ArcSpecies = arcSpecies;
            ArmorClass = maxAC; 
            MaxHP = maxHP;
            plXP = XP;
            plLevel = level;
        }

    }
}
