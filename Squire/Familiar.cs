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
    public partial class Familiar : Form
    {
        List<Spell> spellBook = new List<Spell>();
        List<Spell> preparedSpells = new List<Spell>();

        public Familiar()
        {
            InitializeComponent();
        }

        private void addSpellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpell addSpellDialog = new AddSpell();
            addSpellDialog.Show();
        }
    }
}
