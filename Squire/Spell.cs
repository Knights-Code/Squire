using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squire
{
    // TODO(sschaffer): convert enums to all caps
    public enum School
    {
        Abjuration,
        Conjuration,
        Calling,
        Divination,
        Scrying,
        Enchantment,
        Charm,
        Evocation,
        Illusion,
        Necromancy,
        Transmutation,
        Universal
    };

    public enum Subschool
    {
        Creation, Healing, Summoning, Teleportation, Compulsion,
        Figment, Glamer, Pattern, Phantasm, Shadow
    };

    public enum Descriptor
    {
        Acid,
        Air,
        Chaotic,
        Cold,
        Darkness,
        Death,
        Earth,
        Electricity,
        Evil,
        Good,
        Fear,
        Fire,
        Force,
        LanguageDependent,
        Lawful,
        LightEffect,
        MindAffecting,
        Sleep,
        Sonic,
        Water
    };

    public struct SpellType
    {
        public School school;
        public Subschool subschool;
        public Descriptor descriptor;
        public SpellType(School school, Subschool subschool, Descriptor descriptor)
        {
            this.school = school;
            this.subschool = subschool;
            this.descriptor = descriptor;
        }
        public SpellType(School school, Subschool subschool)
        {
            this.school = school;
            this.subschool = subschool;
            this.descriptor = 0;
        }
        public SpellType(School school)
        {
            this.school = school;
            this.subschool = 0;
            this.descriptor = 0;
        }
    };

    public enum LevelType
    {
        // Classes
        Clr,
        Drd,
        Pal,
        Rgr,
        Sor,
        Wiz,

        // Domains
        Air,
        Animal,
        Chaos,
        Death,
        Destruction,
        Earth,
        Evil,
        Fire,
        Good,
        Healing,
        Knowledge,
        Law,
        Luck,
        Magic,
        Plant,
        Protection,
        Strength,
        Sun,
        Travel,
        Trickery,
        War,
        Water
    };

    public enum Component
    {
        Verbal,
        Somatic,
        Material,
        Focus,
        DivineFocus,
        XPCost
    };

    public enum Range
    {
        other,
        personal,
        touch,
        close,
        medium,
        LONG,
        unlimited
    };

    class Spell
    {
        string name;
        SpellType spellType;
        int[] level = new int[10];
        bool[] components = new bool[10];
        string castingTime;
        Range range;
        string Target;
        string Area;
        string Effect;
        string Duration;
        bool savingThrow;
        bool spellResistance;

        public Spell(string name)
        {
            this.name = name;
            this.attackBonus = new int[3] { 0, 0, 0 };
            this.damage = new string[3] { "+0", "+0", "+0" };
        }

        public string getName()
        {
            return name;
        }

        public void setName(string newName)
        {
            this.name = newName;
        }

        public int getMaxHP()
        {
            return maxHP;
        }

        public int getCurrentHP()
        {
            return currentHP;
        }

        public void setCurrentHP(int newHP)
        {
            this.currentHP = newHP;
        }

        public int getAttack(int index)
        {
            return attackBonus[(index - 1)];
        }

        public void setAttack(int index, int newBonus)
        {
            this.attackBonus[(index - 1)] = newBonus;
        }

        public string getDamage(int index)
        {
            return damage[(index - 1)];
        }

        public void setDamage(int index, string newDamage)
        {
            this.damage[(index - 1)] = newDamage;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
