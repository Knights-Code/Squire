using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Squire
{
    class Spellcaster
    {
        public BindingList<Spell> spellBook;
        public BindingList<PreparedSpell> preparedSpells;

        bool preparedSpellsSet = false;

        bool spontaneousCaster { get; set; }
        uint highestSpellLevel { get; set; }

        uint[] preparedSpellCount;
        uint[] preparedSpellsRemaining;


        public Spellcaster()
        {
            this.spellBook = new BindingList<Spell>();
            this.preparedSpells = new BindingList<PreparedSpell>();
        }

        public List<String> getSaveContent()
        {
            List<String> saveContent = new List<String>();

            saveContent.Add(Common.Spellbook + Environment.NewLine);
            if (spellBook != null && spellBook.Count > 0)
            {
                foreach (Spell currentSpell in spellBook)
                {
                    saveContent.Add(currentSpell.ToString());
                }
            }

            saveContent.Add(Environment.NewLine);

            saveContent.Add(Common.PreparedSpells + Environment.NewLine);

            if (preparedSpells != null && preparedSpells.Count > 0)
            {
                foreach (Spell currentSpell in preparedSpells)
                {
                    saveContent.Add(currentSpell.ToString());
                }
            }

            saveContent.Add(Environment.NewLine);

            saveContent.Add(Common.PreparedSpellsSettings + Environment.NewLine);
            if (preparedSpellsSet)
            {
                saveContent.Add("Spontaneous Caster?");
                saveContent.Add(spontaneousCaster.ToString());
                saveContent.Add("Highest Spell Level");
                saveContent.Add(highestSpellLevel.ToString());

                int spellCountIndex = 0;

                saveContent.Add("Prepared Spell Count Per Level");
                foreach (uint spellCountPerLevel in preparedSpellCount)
                {
                    saveContent.Add(spellCountIndex.ToString());
                    saveContent.Add(spellCountPerLevel.ToString());
                    spellCountIndex++;
                }


                spellCountIndex = 0;
                saveContent.Add("Prepared Spells Remaining Per Level");
                foreach (uint spellsRemainingPerLevel in preparedSpellsRemaining)
                {
                    saveContent.Add(spellCountIndex.ToString());
                    saveContent.Add(spellsRemainingPerLevel.ToString());
                    spellCountIndex++;
                }
            }

            return saveContent;
        }

        public void setSpellbook(List<Spell> spellList)
        {
            foreach (Spell spell in spellList)
            {
                spellBook.Add(spell);
            }
        }

        public void setPreparedSpells(List<PreparedSpell> spellList)
        {
            foreach (PreparedSpell spell in spellList)
            {
                preparedSpells.Add(spell);
            }
        }

        public void setPreparedSpellSettings(List<String> providedList)
        {
            int index = 0;

            foreach (string line in providedList)
            {
                if (String.Equals(line, "Spontaneous Caster?"))
                {
                    spontaneousCaster = Boolean.Parse(providedList[++index]);
                }

                if (String.Equals(line, "Highest Spell Level"))
                {
                    highestSpellLevel = Convert.ToUInt32(providedList[++index]);
                }

                if (String.Equals(line, "Prepared Spell Count Per Level"))
                {
                    preparedSpellCount = new uint[highestSpellLevel + 1];
                    for (int i = 0; i <= highestSpellLevel; i++)
                    {
                        preparedSpellCount[i] = Convert.ToUInt32(providedList[++index]);
                    }
                }

                if (String.Equals(line, "Prepared Spells Remaining Per Level"))
                {
                    preparedSpellsRemaining = new uint[highestSpellLevel + 1];
                    for (int i = 0; i <= highestSpellLevel; i++)
                    {
                        preparedSpellsRemaining[i] = Convert.ToUInt32(providedList[++index]);
                    }
                }
            }

        }
    }
}