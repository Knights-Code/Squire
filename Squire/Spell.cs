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

        public Spell(string[] spellproperties)
        {
            this.spellname = spellproperties[0];
            this.spellschoolandsubschool = spellproperties[1];
            this.spelldescriptor = spellproperties[2];
            this.spelllevel = spellproperties[3];
            this.spellcomponents = spellproperties[4];
            this.spellcastingtime = spellproperties[5];
            this.spellrange = spellproperties[6];
            this.spellarea = spellproperties[7];
            this.spelleffect = spellproperties[8];
            this.spelltargets = spellproperties[9];
            this.spellduration = spellproperties[10];
            this.spellsavingthrow = spellproperties[11];
            this.spellresistance = spellproperties[12];
            this.spelldescription = spellproperties[13];
        }

        public override string ToString()
        {
            string toString = spellname;
            toString += "\t";
            toString += spellschoolandsubschool;
            toString += "\t";
            toString += spelldescriptor;
            toString += "\t";
            toString += spelllevel;
            toString += "\t";
            toString += spellcomponents;
            toString += "\t";
            toString += spellcastingtime;
            toString += "\t";
            toString += spellrange;
            toString += "\t";
            toString += spellarea;
            toString += "\t";
            toString += spelleffect;
            toString += "\t";
            toString += spelltargets;
            toString += "\t";
            toString += spellduration;
            toString += "\t";
            toString += spellsavingthrow;
            toString += "\t";
            toString += spellresistance;
            toString += "\t";
            toString += spelldescription;

            return toString;
        }
    }
}
