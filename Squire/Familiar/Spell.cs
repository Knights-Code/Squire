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

        protected Spell() { }

        public Spell(string name)
        {
            this.spellname = name;
        }

        public Spell(string[] spellproperties)
        {
            if (spellproperties.Length >= 14)
            {
                this.spellname = desanitiseString(spellproperties[0]);
                this.spellschoolandsubschool = desanitiseString(spellproperties[1]);
                this.spelldescriptor = desanitiseString(spellproperties[2]);
                this.spelllevel = desanitiseString(spellproperties[3]);
                this.spellcomponents = desanitiseString(spellproperties[4]);
                this.spellcastingtime = desanitiseString(spellproperties[5]);
                this.spellrange = desanitiseString(spellproperties[6]);
                this.spellarea = desanitiseString(spellproperties[7]);
                this.spelleffect = desanitiseString(spellproperties[8]);
                this.spelltargets = desanitiseString(spellproperties[9]);
                this.spellduration = desanitiseString(spellproperties[10]);
                this.spellsavingthrow = desanitiseString(spellproperties[11]);
                this.spellresistance = desanitiseString(spellproperties[12]);
                this.spelldescription = desanitiseString(spellproperties[13]);
            }
        }

        public override string ToString()
        {
            string toString = sanitiseString(spellname);
            toString += "~";
            toString += sanitiseString(spellschoolandsubschool);
            toString += "~";
            toString += sanitiseString(spelldescriptor);
            toString += "~";
            toString += sanitiseString(spelllevel);
            toString += "~";
            toString += sanitiseString(spellcomponents);
            toString += "~";
            toString += sanitiseString(spellcastingtime);
            toString += "~";
            toString += sanitiseString(spellrange);
            toString += "~";
            toString += sanitiseString(spellarea);
            toString += "~";
            toString += sanitiseString(spelleffect);
            toString += "~";
            toString += sanitiseString(spelltargets);
            toString += "~";
            toString += sanitiseString(spellduration);
            toString += "~";
            toString += sanitiseString(spellsavingthrow);
            toString += "~";
            toString += sanitiseString(spellresistance);
            toString += "~";
            toString += sanitiseString(spelldescription);

            return toString;
        }

        protected string sanitiseString(string stringToBeSanatised)
        {
            stringToBeSanatised = stringToBeSanatised.Replace(Environment.NewLine, "///n");
            stringToBeSanatised = stringToBeSanatised.Replace("~", "");
            return stringToBeSanatised;
        }

        protected string desanitiseString(string stringToBeDesanatised)
        {
            stringToBeDesanatised = stringToBeDesanatised.Replace("///n", Environment.NewLine);
            return stringToBeDesanatised;
        }

    }
}
