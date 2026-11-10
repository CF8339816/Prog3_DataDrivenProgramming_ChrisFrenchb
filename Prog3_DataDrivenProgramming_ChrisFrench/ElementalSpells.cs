using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Prog3DataDrivenProgramming_ChrisFrench.ElementalSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.HealingSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.HolySpells;
using static Prog3DataDrivenProgramming_ChrisFrench.ArcaneSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.IllusionSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.NatureSpells;
using static Prog3DataDrivenProgramming_ChrisFrench.Spells;


namespace Prog3DataDrivenProgramming_ChrisFrench
{
    public class ElementalSpells : Spells
    {
        public int Diameter { get; set; }

        public int Targets { get; set; }

        //public int SpellTargetX { get; set; }  
        //public int SpellTargetY { get; set; }  

        //public (int min, int max) SpellArea_x {  get; set; }
        //public (int min, int max) SpellArea_y { get; set; } 

        public ElementalSpells(string type, string name, int level, int castingTime, int failurePercent, int DmgMultiplier, int diceType, int spellAtk, int manaCost, char targSymbol, ConsoleColor targColor, int diameter, int _targets) //, int spellTargetX, int spellTargetY, (int,int) spellArea_x, (int,int) spellArea_y)
        : base(type, name, level, castingTime, failurePercent, DmgMultiplier, diceType, spellAtk, manaCost, targSymbol, targColor)

        {
            Diameter = diameter;
            Targets = _targets;
            //SpellTargetX = spellTargetX;
            //SpellTargetY = spellTargetY;
            //SpellArea_x = spellArea_x;
            //SpellArea_y = spellArea_y;
        }

        public static ElementalSpells Sparks => new ElementalSpells("Elemental", "Sparks", 1, 1, 5, 1, 2, 0, 1, '@', ConsoleColor.Cyan, 1, 1); //, spellTargetX, spellTargetY, ((spellTargetX - 0), (spellTargetX + 0)), ((spellTargetY - 0), (spellTargetY + 0)));
        public static ElementalSpells FrostFire => new ElementalSpells("Elemental", "Frost Fire", 2, 1, 5, 1, 4, 1, 2, '@', ConsoleColor.Cyan, 1, 1); //, spellTargetX, spellTargetY, ((spellTargetX - 0), (spellTargetX + 0)), ((spellTargetY - 0), (spellTargetY + 0)));
        public static ElementalSpells Frozen => new ElementalSpells("Elemental", "Frozen", 3, 1, 15, 2, 6, 2, 4, '@', ConsoleColor.Cyan, 1, 1); //, spellTargetX, spellTargetY, ((spellTargetX - 0), (spellTargetX + 0)), ((spellTargetY - 0), (spellTargetY + 0)));
        public static ElementalSpells Fireball => new ElementalSpells("Elemental", "Fireball", 4, 2, 20, 4, 8, 3, 8, '@', ConsoleColor.Cyan, 5, 25); //, spellTargetX, spellTargetY, ((spellTargetX - 2), (spellTargetX + 2)), ((spellTargetY - 2),( spellTargetY + 2)));
        public static ElementalSpells Blizzard => new ElementalSpells("Elemental", "Blizzard", 5, 4, 25, 8, 10, 4, 16, '@', ConsoleColor.Cyan, 9, 81); //, spellTargetX, spellTargetY, (spellTargetX - 4, spellTargetX + 4), (spellTargetY - 4, spellTargetY + 4));
        public static ElementalSpells MeteorStrike => new ElementalSpells("Elemental", "Meteor Strike", 6, 8, 35, 16, 12, 5, 32, '@', ConsoleColor.Cyan, 21, 441); //, spellTargetX, spellTargetY, (spellTargetX - 10, spellTargetX + 10), (spellTargetY - 10, spellTargetY + 10));

    }
}

