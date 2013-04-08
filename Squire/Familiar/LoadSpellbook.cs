using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Squire
{
    public partial class LoadSpellbook : Form
    {

        BindingList<SpellsToLoad> loadedSpellbook;
        Familiar parentForm;

        public struct SpellsToLoad
        {
            public Spell spellValue;
            public bool load;

            public SpellsToLoad(Spell spell, bool loadstart = false)
            {
                spellValue = spell;
                load = loadstart;
            }
        }

        public LoadSpellbook(Familiar parentForm, List<Spell> spellBook)
        {
            this.parentForm = parentForm;
            this.loadedSpellbook = new BindingList<SpellsToLoad>();

            foreach (Spell spell in spellBook)
            {
                loadedSpellbook.Add(new SpellsToLoad(spell));
            }

            this.spellBookGrid.DataSource = loadedSpellbook;

            InitializeComponent();
        }

        private void loadSpellsButton_Click(object sender, EventArgs e)
        {
            foreach (SpellsToLoad spellstruct in loadedSpellbook)
            {
                if (spellstruct.load)
                {
                    parentForm.addSpell(spellstruct.spellValue, false);
                }
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
