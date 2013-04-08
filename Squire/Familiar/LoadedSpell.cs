using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squire
{
    class LoadedSpell : Spell
    {
        public bool loadspell { get; set; }

        public LoadedSpell(Spell spell, bool load = false)
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
            this.loadspell = load;
        }
    }
}
