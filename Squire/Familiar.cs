﻿using System;
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

        Spellcaster spellcaster;

        public Familiar()
        {
            this.spellcaster = new Spellcaster();
            InitializeComponent();
        }

        public void addSpell(Spell newSpell, bool preparedSpell)
        {
            if (preparedSpell)
            {
                spellcaster.preparedSpells.Add(newSpell);
            }
            else
            {
                spellcaster.spellBook.Add(newSpell);
            }
        }

        private void addSpellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpell addSpellDialog = new AddSpell(this);
            addSpellDialog.Show();
        }

        private void spellBookGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Reset the box to be blank
            this.spellDescriptionBox.Text = "";

            // If the cell clicked is a header, return
            if (isAHeaderCell(e))
            {
                return;
            }

            var selectedRow = spellBookGrid.Rows[e.RowIndex];
            int columnindex = 0;

            foreach (DataGridViewCell element in selectedRow.Cells)
            {
                // Only desplay label and content if there is something in the cell
                // (ie: some spells don't have a descriptor so don't show an empty [], show nothing.
                // Familiar doesn't check spells, the onus is on the user to properly put in spells.
                if (String.IsNullOrEmpty(element.Value.ToString()))
                {
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
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Components
                    case "spellcomponents":
                        this.spellDescriptionBox.AppendText("Components: ");
                        formatText("Components: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Casting Time
                    case "spellcastingtime":
                        this.spellDescriptionBox.AppendText("Casting Time: ");
                        formatText("Casting Time: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Range
                    case "spellrange":
                        this.spellDescriptionBox.AppendText("Range: ");
                        formatText("Range: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Area
                    case "spellarea":
                        this.spellDescriptionBox.AppendText("Area: ");
                        formatText("Area: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Effect
                    case "spelleffect":
                        this.spellDescriptionBox.AppendText("Effect: ");
                        formatText("Effect: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Target(s)
                    case "spelltargets":
                        this.spellDescriptionBox.AppendText("Target(s): ");
                        formatText("Target(s): ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Duration
                    case "spellduration":
                        this.spellDescriptionBox.AppendText("Duration: ");
                        formatText("Duration: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Saving Throw
                    case "spellsavingthrow":
                        this.spellDescriptionBox.AppendText("Saving Throw: ");
                        formatText("Saving Throw: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Spell Resistance
                    case "spellresistance":
                        this.spellDescriptionBox.AppendText("Spell Resistance: ");
                        formatText("Spell Resistance: ", false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Description
                    case "spelldescription":
                        this.spellDescriptionBox.AppendText(Environment.NewLine + element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;
                }

                columnindex++;
            }

        }

        private bool isAHeaderCell(DataGridViewCellEventArgs cellEvent)
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

                if (title && !label)
                {
                    spellDescriptionBox.SelectionFont = new Font(spellDescriptionBox.Font.FontFamily, 12, FontStyle.Bold & FontStyle.Underline);
                }

                if (title && label)
                {
                    spellDescriptionBox.SelectionFont = new Font(spellDescriptionBox.Font.FontFamily, 12, FontStyle.Bold & FontStyle.Underline);
                    spellDescriptionBox.SelectionFont = new Font(spellDescriptionBox.Font, FontStyle.Bold);
                }

                if (!title && label)
                {
                    spellDescriptionBox.SelectionFont = new Font(spellDescriptionBox.Font, FontStyle.Bold);
                    spellDescriptionBox.SelectionIndent = 10;
                }

                if (!title && !label)
                {
                    spellDescriptionBox.SelectionFont = spellDescriptionBox.Font;
                    spellDescriptionBox.SelectionIndent = 10;
                }

                spellDescriptionBox.SelectionStart = 0;
                spellDescriptionBox.SelectionLength = 0;
            }
        }

        private void saveSpellbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveSpells = new SaveFileDialog();
            saveSpells.DefaultExt = ".fmlr";
            saveSpells.Filter = "Spell Files (*.fmlr)|*fmlr|All files (*.*)|*.*";
            saveSpells.OverwritePrompt = true;
            saveSpells.Title = "Save Spellbook";

            if (saveSpells.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveSpells.FileName);

                foreach (string line in spellcaster.generateSaveContent())
                {
                    file.WriteLine(line);
                }

                file.Close();
            }
        }

        private void openSpellbookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openSpells = new OpenFileDialog();
            openSpells.DefaultExt = ".fmlr";
            openSpells.Filter = "Spell Files (*.fmlr)|*fmlr|All files (*.*)|*.*";
            openSpells.Title = "Open Spellbook";

            if (openSpells.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(openSpells.FileName);

                string currentLine;
                List<String> fileSection = new List<String>();

                    while ((currentLine = file.ReadLine()) != null)
                    {
                        if (currentLine == String.Empty || String.Equals(currentLine, "Spellbook"))
                        {
                            continue;
                        }

                        if (String.Equals(currentLine, "Prepared Spells"))
                        {
                            break;
                        }

                        fileSection.Add(currentLine);
                    }

                    spellcaster.generateSpellbookFromList(fileSection);
                    fileSection = new List<String>();

                    while ((currentLine = file.ReadLine()) != null)
                    {
                        if (currentLine == String.Empty || String.Equals(currentLine, "Spellbook"))
                        {
                            continue;
                        }

                        if (String.Equals(currentLine, "Prepared Spell Settings"))
                        {
                            break;
                        }

                        fileSection.Add(currentLine);
                    }

                    spellcaster.generatePreparedSpellsFromList(fileSection);
                    fileSection = new List<String>();

                    while ((currentLine = file.ReadLine()) != null)
                    {
                        if (currentLine == String.Empty || String.Equals(currentLine, "Spellbook"))
                        {
                            continue;
                        }

                        if (String.Equals(currentLine, "Prepared Spells"))
                        {
                            break;
                        }

                        fileSection.Add(currentLine);
                    }

                    spellcaster.generatePreparedSpellSettingsFromList(fileSection);

                file.Close();
            }
        }

        private void Familiar_Load(object sender, EventArgs e)
        {
            this.spellBookGrid.DataSource = spellcaster.spellBook;
            this.preparedSpellsGrid.DataSource = spellcaster.preparedSpells;
        }
    }
}