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

            foreach (DataGridViewCell element in selectedRow.Cells)
            {
                // Only desplay label and content if there is something in the cell
                // (ie: some spells don't have a descriptor so don't show an empty [], show nothing.
                // Familiar doesn't check spells, the onus is on the user to properly put in spells.
                if (String.IsNullOrEmpty(element.Value.ToString())) {
                    columnindex++;
                    continue;
                }

                switch (this.spellBookGrid.Columns[columnindex].Name)
                {
                    // Name
                    case "spellname":
                        this.spellDescriptionBox.AppendText(element.Value.ToString());
                        formatText(element.Value.ToString(), true, false);
                        break;

                    // School (Subschool)
                    case "spellschoolandsubschool":
                        this.spellDescriptionBox.AppendText(Environment.NewLine + element.Value.ToString());
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // [Descriptor]
                    case "spelldescriptor":
                        this.spellDescriptionBox.AppendText(" [" + element.Value.ToString() + "]");
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Level
                    case "spelllevel":
                        this.spellDescriptionBox.AppendText(Environment.NewLine + "Level: ");
                        formatText("Level: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;

                    // Components
                    case "spellcomponents":
                        this.spellDescriptionBox.AppendText("Components: ");
                        formatText("Components: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;

                    // Casting Time
                    case "spellcastingtime":
                        this.spellDescriptionBox.AppendText("Casting Time: ");
                        formatText("Casting Time: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;

                    // Range
                    case "spellrange":
                        this.spellDescriptionBox.AppendText("Range: ");
                        formatText("Range: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;

                    // Area
                    case "spellarea":
                        this.spellDescriptionBox.AppendText("Area: ");
                        formatText("Area: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;

                    // Effect
                    case "spelleffect":
                        this.spellDescriptionBox.AppendText("Effect: ");
                        formatText("Effect: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;

                    // Target(s)
                    case "spelltargets":
                        this.spellDescriptionBox.AppendText("Target(s): ");
                        formatText("Target(s): ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;

                    // Duration
                    case "spellduration":
                        this.spellDescriptionBox.AppendText("Duration: ");
                        formatText("Duration: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;

                    // Saving Throw
                    case "spellsavingthrow":
                        this.spellDescriptionBox.AppendText("Saving Throw)) { ");
                        formatText("Saving Throw)) { ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;

                    // Spell Resistance
                    case "spellresistance":
                        this.spellDescriptionBox.AppendText("Spell Resistance)) { ");
                        formatText("Spell Resistance)) { ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        break;

                    // Description
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
            else
            {
                return false;
            }
        }

        private void formatText(string textToFormat, bool title, bool label)
        {
            int index = spellDescriptionBox.Text.LastIndexOf(textToFormat);
            if (index >= 0)
            {
                spellDescriptionBox.SelectionStart = index;
                spellDescriptionBox.SelectionLength = textToFormat.Length;

                if (title)
                {
                    spellDescriptionBox.SelectionFont = new Font(spellDescriptionBox.Font.FontFamily, 12, FontStyle.Bold & FontStyle.Underline);
                }

                if (!title && label)
                {
                    spellDescriptionBox.SelectionFont = new Font(spellDescriptionBox.Font, FontStyle.Bold);
                    spellDescriptionBox.SelectionIndent = 10;
                }

                if (!title && !label)
                {
                    spellDescriptionBox.SelectionIndent = 10;
                }


                spellDescriptionBox.SelectionStart = 0;
                spellDescriptionBox.SelectionLength = 0;
            }
        }

        private void saveSpellbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveSpells = new SaveFileDialog();
            saveSpells.DefaultExt = ".spl";
            saveSpells.Filter = "Spell Files (*.fmlr)|*fmlr|All files (*.*)|*.*";
            saveSpells.OverwritePrompt = true;
            saveSpells.Title = "Save Spellbook";

            if (saveSpells.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveSpells.FileName);
                if (spellBook != null && spellBook.Count > 0)
                {
                    file.WriteLine("Spellbook" + Environment.NewLine);

                    foreach (Spell currentSpell in spellBook)
                    {
                        // clear string from last spell
                        string spellsavingformat = "";

                        spellsavingformat += currentSpell.spellname;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellschoolandsubschool;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelldescriptor;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelllevel;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellcomponents;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellcastingtime;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellrange;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellarea;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelleffect;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelltargets;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellduration;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellsavingthrow;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellresistance;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelldescription;

                        file.WriteLine(spellsavingformat);
                    }
                }

                if (preparedSpells != null && preparedSpells.Count > 0)
                {
                    file.WriteLine("Prepared Spells" + Environment.NewLine);

                    foreach (Spell currentSpell in preparedSpells)
                    {
                        // clear string from last spell
                        string spellsavingformat = "";

                        spellsavingformat += currentSpell.spellname;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellschoolandsubschool;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelldescriptor;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelllevel;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellcomponents;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellcastingtime;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellrange;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellarea;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelleffect;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelltargets;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellduration;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellsavingthrow;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellresistance;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelldescription;

                        file.WriteLine(spellsavingformat);
                    }
                }
                
                file.Close();
            }
        }

        private void openSpellbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openSpells = new OpenFileDialog();
            openSpells.DefaultExt = ".spl";
            openSpells.Filter = "Spell Files (*.fmlr)|*fmlr|All files (*.*)|*.*";
            openSpells.Title = "Open Spellbook";

            if (openSpells.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(openSpells.FileName);
                if (spellBook != null && spellBook.Count > 0)
                {
                    file.ReadLine("Spellbook" + Environment.NewLine);

                    foreach (Spell currentSpell in spellBook)
                    {
                        // clear string from last spell
                        string spellsavingformat = "";

                        spellsavingformat += currentSpell.spellname;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellschoolandsubschool;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelldescriptor;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelllevel;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellcomponents;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellcastingtime;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellrange;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellarea;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelleffect;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelltargets;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellduration;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellsavingthrow;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellresistance;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelldescription;

                        file.WriteLine(spellsavingformat);
                    }
                }

                if (preparedSpells != null && preparedSpells.Count > 0)
                {
                    file.WriteLine("Prepared Spells" + Environment.NewLine);

                    foreach (Spell currentSpell in preparedSpells)
                    {
                        // clear string from last spell
                        string spellsavingformat = "";

                        spellsavingformat += currentSpell.spellname;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellschoolandsubschool;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelldescriptor;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelllevel;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellcomponents;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellcastingtime;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellrange;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellarea;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelleffect;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelltargets;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellduration;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellsavingthrow;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spellresistance;
                        spellsavingformat += ",";
                        spellsavingformat += currentSpell.spelldescription;

                        file.WriteLine(spellsavingformat);
                    }
                }

                file.Close();
            }
        }
    }
}
