using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squire
{
    public class Spell
    {
        public string name;
        public string schoolandSubschool;
        public string descriptor;
        public string level;
        public string components;
        public string castingTime;
        public string range;
        public string effect;
        public string targets;
        public string duration;
        public string savingThrow;
        public string spellResistence;
        public string description;
        
        public Spell(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
