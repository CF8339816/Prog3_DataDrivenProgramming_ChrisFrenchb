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
    public class Enemy : Character
    {

        public int EnHp = 100;
                   
        public int EnLevel = 0;

        public int EnArmorClass { get; }
        public int EnMaxHP { get; }

        public ArchType EnArcJob;
        public ArchSpecies EnArcSpecies;



        public Enemy(string _type, string name, int strength, int speed, int dex, int baseAC, int baseHp, int baseAtk, int baseMana, char symbol, ConsoleColor color, ArchType enArcJob, ArchSpecies enArcSpecies, int maxEnHP, int maxEnAC, int levelEn)
            : base("PC", name, strength, speed, dex, baseAC, baseHp, baseAtk, baseMana, symbol, color)



        {

            EnArcJob = enArcJob;
            EnArcSpecies = enArcSpecies;
            EnArmorClass = maxEnAC;
            EnMaxHP = maxEnHP;
               
            EnLevel = levelEn;
        }

    }
 }

