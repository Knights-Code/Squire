using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squire
{
    class PreparedSpell : Spell
    {
        public bool spellused { get; set; }

        public PreparedSpell(string name)
        {
            this.spellname = name;
        }

        public PreparedSpell(string[] spellproperties)
        {
            if (spellproperties.Length >= 15)
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
                this.spellused = Boolean.Parse(desanitiseString(spellproperties[14]));
            }
        }

        public PreparedSpell(Spell spell, bool used = false)
        {
            this.spellname = spell.spellname;
            this.spellschoolandsubschool = spell.spellschoolandsubschool;
            this.spelldescriptor = spell.spelldescriptor;
            this.spelllevel = spell.spelllevel;
            this.spellcomponents = spell.spellcomponents;
            this.spellcastingtime = spell.spellcastingtime;
            this.spellrange = spell.spellrange;
            this.spellarea = spell.spellarea;
            this.spelleffect = spell.spelleffect;
            this.spelltargets = spell.spelltargets;
            this.spellduration = spell.spellduration;
            this.spellsavingthrow = spell.spellsavingthrow;
            this.spellresistance = spell.spellresistance;
            this.spelldescription = spell.spelldescription;
            this.spellused = used;
        }
    }
}
