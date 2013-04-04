using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squire
{
    public class Spell
    {
        public string spellname { get; set; }
        public string spellschoolandsubschool { get; set; }
        public string spelldescriptor { get; set; }
        public string spelllevel { get; set; }
        public string spellcomponents { get; set; }
        public string spellcastingtime { get; set; }
        public string spellrange { get; set; }
        public string spellarea { get; set; }
        public string spelleffect { get; set; }
        public string spelltargets { get; set; }
        public string spellduration { get; set; }
        public string spellsavingthrow { get; set; }
        public string spellresistance { get; set; }
        public string spelldescription { get; set; }

        public Spell(string name)
        {
            this.spellname = name;
        }

        public override string ToString()
        {
            return spellname;
        }
    }
}
