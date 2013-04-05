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
        public BindingList<Spell> preparedSpells;

        bool preparedSpellsSet = false;

        bool spontaneousCaster { get; set; }
        uint highestSpellLevel { get; set; }

        uint[] preparedSpellCount;
        uint[] preparedSpellsRemaining;


        public Spellcaster()
        {
            this.spellBook = new BindingList<Spell>();
            this.preparedSpells = new BindingList<Spell>();
        }

        public List<String> generateSaveContent()
        {
            List<String> saveContent = new List<String>();

            saveContent.Add("Spellbook" + Environment.NewLine);
            if (spellBook != null && spellBook.Count > 0)
            {
                foreach (Spell currentSpell in spellBook)
                {
                    saveContent.Add(currentSpell.ToString());
                }
            }

            saveContent.Add(Environment.NewLine);
            saveContent.Add("Prepared Spells" + Environment.NewLine);

            if (preparedSpells != null && preparedSpells.Count > 0)
            {
                foreach (Spell currentSpell in preparedSpells)
                {
                    saveContent.Add(currentSpell.ToString());
                }
            }

            saveContent.Add(Environment.NewLine);

            saveContent.Add("Prepared Spell Settings" + Environment.NewLine);
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

        public void generateSpellbookFromList(List<String> providedList)
        {
            foreach (string line in providedList)
            {
                spellBook.Add(new Spell(line.Split('\t')));
            }
        }

        public void generatePreparedSpellsFromList(List<String> providedList)
        {
            foreach (string line in providedList)
            {
                preparedSpells.Add(new Spell(line.Split('\t')));
            }
        }

        public void generatePreparedSpellSettingsFromList(List<String> providedList)
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