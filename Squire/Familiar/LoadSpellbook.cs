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

        BindingList<LoadedSpell> loadedSpellbook;
        Familiar parentForm;

        public LoadSpellbook(Familiar parentForm, List<Spell> spellBook)
        {
            this.parentForm = parentForm;
            InitializeComponent();

            this.loadedSpellbook = new BindingList<LoadedSpell>();

            foreach (Spell spell in spellBook)
            {
                loadedSpellbook.Add(new LoadedSpell(spell));
            }

            this.spellBookGrid.DataSource = loadedSpellbook;
        }

        private void loadSpellsButton_Click(object sender, EventArgs e)
        {
            foreach (LoadedSpell spell in loadedSpellbook)
            {
                if (spell.loadspell)
                {
                    parentForm.addSpelltoSpellcaster(spell, false);
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
