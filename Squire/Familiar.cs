using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace Squire
{
    public partial class Familiar : Form
    {
        BindingList<Spell> spellBook = new BindingList<Spell>();
        BindingList<Spell> preparedSpells = new BindingList<Spell>();
        PrivateFontCollection pfc = new PrivateFontCollection();

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
            // Reset the box to be blank
            this.spellDescriptionBox.Text = "";

            // If the cell clicked is a header, return
            if (IsAHeaderCell(e)) { return; }

            var selectedRow = spellBookGrid.Rows[e.RowIndex];
            int columnindex = 0;

            // Basic for loop for populating box
            /*
            foreach (DataGridViewCell element in selectedRow.Cells)
            {
                if (!String.IsNullOrEmpty(element.Value.ToString()))
                {
                    string columnname = this.spellBookGrid.Columns[columnindex].Name;
                    this.spellDescriptionBox.AppendText(columnname + ": ");
                    this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                }
                columnindex++;
            }
             */

            foreach (DataGridViewCell element in selectedRow.Cells)
            {
                if (String.IsNullOrEmpty(element.Value.ToString())) { continue; }
                
                switch (this.spellBookGrid.Columns[columnindex].Name)
                {
                    case "spellname":
                        this.spellDescriptionBox.AppendText(element.Value.ToString());
                        break;

                    case "spellschoolandsubschool":
                        this.spellDescriptionBox.AppendText(Environment.NewLine + element.Value.ToString());
                        break;
                    
                    case "spelldescriptor":
                        this.spellDescriptionBox.AppendText(" [" + element.Value.ToString() + "]");
                        break;
                    
                    case "spelllevel":
                        this.spellDescriptionBox.AppendText(Environment.NewLine + element.Value.ToString() + Environment.NewLine);
                        break;
                    
                    case "spellcomponents":
                        this.spellDescriptionBox.AppendText("Components: ");
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;
                    
                    case "spellcastingtime":
                        this.spellDescriptionBox.AppendText("Casting Time: ");
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;
                    
                    case "spellrange":
                        this.spellDescriptionBox.AppendText("Range: ");
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;
                    
                    case "spellarea":
                        this.spellDescriptionBox.AppendText("Area: ");
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;
                    
                    case "spelleffect":
                        this.spellDescriptionBox.AppendText("Effect: ");
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;
                    
                    case "spelltargets":
                        this.spellDescriptionBox.AppendText("Target(s): ");
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;
                    
                    case "spellduration":
                        this.spellDescriptionBox.AppendText("Duration: ");
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;
                    
                    case "spellsavingthrow":
                        this.spellDescriptionBox.AppendText("Saving Throw: ");
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;
                    
                    case "spellresistance":
                        this.spellDescriptionBox.AppendText("Spell Resistance: ");
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;
                    
                    case "spelldescription":
                        this.spellDescriptionBox.AppendText(Environment.NewLine + element.Value.ToString() + Environment.NewLine);
                        break;
                }

                columnindex++;
            }

        }

        private bool IsAHeaderCell(DataGridViewCellEventArgs cellEvent)
        {
            if (cellEvent.RowIndex == -1)
            {
                return true;
            }
            else {
                return false;
            }
        }

        private void Familiar_Load(object sender, EventArgs e)
        {

            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("embedfont.Alphd___.ttf");

            byte[] fontdata = new byte[fontStream.Length];
            fontStream.Read(fontdata, 0, (int)fontStream.Length);
            fontStream.Close();
            unsafe
            {
                fixed (byte* pFontData = fontdata)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                }
            }

        }

    }
}
