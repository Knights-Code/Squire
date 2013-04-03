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
        BindingList<Spell> spellBook = new BindingList<Spell>();
        BindingList<Spell> preparedSpells = new BindingList<Spell>();

        public Familiar()
        {
            InitializeComponent();
        }

        private void addSpellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpell addSpellDialog = new AddSpell(this);
            addSpellDialog.Show();
        }

        public void addSpelltoSpellbook(Spell newSpell)
        {
            spellBook.Add(newSpell);
        }

        public void getSpellbookSource()
        {
            this.spellBookGrid.DataSource = spellBook;
        }

        private void spellBookGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = spellBookGrid.Rows[e.RowIndex];
            int columnindex = 0;

            this.spellDescriptionBox.Text = "";

            foreach (DataGridViewCell element in selectedRow.Cells)
            {
                if (!String.IsNullOrEmpty(element.Value.ToString()))
                {
                    string columnname = this.spellBookGrid.Columns[columnindex].Name;
                    this.spellDescriptionBox.AppendText(columnname + ": " + element.Value.ToString() + Environment.NewLine);
                }
                columnindex++;
            }
        }
    }
}
