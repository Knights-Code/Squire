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

        // Main Class Functions
        public Familiar()
        {
            this.spellcaster = new Spellcaster();
            InitializeComponent();
        }

        private void Familiar_Load(object sender, EventArgs e)
        {
            this.spellBookGrid.DataSource = spellcaster.spellBook;
            this.preparedSpellsGrid.DataSource = spellcaster.preparedSpells;

            changeHeaderNames(this.spellBookGrid);
            changeHeaderNames(this.preparedSpellsGrid);
        }

        // Add Spells
        private void addSingleSpell(object sender, EventArgs e)
        {
            NewSpell addSpellDialog = new NewSpell(this);
            addSpellDialog.Show();
        }

        public void addSpelltoSpellcaster(Spell newSpell, bool preparedSpell)
        {
            if (preparedSpell)
            {
                spellcaster.preparedSpells.Add(new PreparedSpell(newSpell));
            }
            else
            {
                spellcaster.spellBook.Add(newSpell);
            }
        }

        // DataGrid Functions
        private void spellBookGridSpellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the cell clicked is a header, return
            if (isAHeaderCell(e))
            {
                return;
            }

            displaySpellInformation(e);
        }

        private void displaySpellInformation(DataGridViewCellEventArgs e)
        {
            // Reset the box to be blank
            this.spellDescriptionBox.Text = Common.Blank;

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
                    case Common.SpellNameVar:
                        this.spellDescriptionBox.AppendText(element.Value.ToString());
                        formatText(element.Value.ToString(), true, false);
                        break;

                    // School (Subschool)
                    case Common.SpellSchoolSubschoolVar:
                        this.spellDescriptionBox.AppendText(Environment.NewLine + element.Value.ToString());
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // [Descriptor]
                    case Common.SpellDescriptorVar:
                        this.spellDescriptionBox.AppendText(" [" + element.Value.ToString() + "]");
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Level
                    case Common.SpellLevelVar:
                        this.spellDescriptionBox.AppendText(Environment.NewLine + Common.SpellLevel + Common.LabelEnd);
                        formatText(Common.SpellLevel + Common.LabelEnd, false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Components
                    case Common.SpellComponentsVar:
                        this.spellDescriptionBox.AppendText(Common.SpellComponents + Common.LabelEnd);
                        formatText(Common.SpellComponents + Common.LabelEnd, false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Casting Time
                    case Common.SpellCastingTimeVar:
                        this.spellDescriptionBox.AppendText(Common.SpellCastingTime + Common.LabelEnd);
                        formatText(Common.SpellCastingTime + Common.LabelEnd, false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Range
                    case Common.SpellRangeVar:
                        this.spellDescriptionBox.AppendText(Common.SpellRange + Common.LabelEnd);
                        formatText(Common.SpellRange + Common.LabelEnd, false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Area
                    case Common.SpellAreaVar:
                        this.spellDescriptionBox.AppendText(Common.SpellArea + Common.LabelEnd);
                        formatText(Common.SpellArea + Common.LabelEnd, false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Effect
                    case Common.SpellEffectVar:
                        this.spellDescriptionBox.AppendText(Common.SpellEffect + Common.LabelEnd);
                        formatText(Common.SpellEffect + Common.LabelEnd, false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Target(s)
                    case Common.SpellTargetsVar:
                        this.spellDescriptionBox.AppendText(Common.SpellTargets + Common.LabelEnd);
                        formatText(Common.SpellTargets + Common.LabelEnd, false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Duration
                    case Common.SpellDurationVar:
                        this.spellDescriptionBox.AppendText(Common.SpellDuration + Common.LabelEnd);
                        formatText(Common.SpellDuration + Common.LabelEnd, false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Saving Throw
                    case Common.SpellSavingThrowVar:
                        this.spellDescriptionBox.AppendText(Common.SpellSavingThrow + Common.LabelEnd);
                        formatText(Common.SpellSavingThrow + Common.LabelEnd, false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Spell Resistance
                    case Common.SpellResistanceVar:
                        this.spellDescriptionBox.AppendText(Common.SpellResistance + Common.LabelEnd);
                        formatText(Common.SpellResistance + Common.LabelEnd, false, true);
                        this.spellDescriptionBox.AppendText(element.Value.ToString() + Environment.NewLine);
                        formatText(element.Value.ToString(), false, false);
                        break;

                    // Description
                    case Common.SpellDescriptionVar:
                        this.spellDescriptionBox.AppendText(Environment.NewLine + element.Value.ToString());
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


        // Open and Save Files

        private void saveSpellcaster(object sender, EventArgs e)
        {
            Common.saveFile(Common.SaveSpellbook, spellcaster.getSpellcasterSaveContent());
        }

        private void openSpellcaster(object sender, EventArgs e)
        {
            List<string> fileContents = Common.openFile();
            string fileSection = "";

            List<Spell> spellBook = new List<Spell>();
            List<PreparedSpell> preparedSpells = new List<PreparedSpell>();
            List<string> preparedSpellSettings = new List<string>();

            foreach (string line in fileContents)
            {
                if (line == String.Empty)
                {
                    continue;
                }

                if (String.Equals(line, Common.Spellbook))
                {
                    fileSection = Common.Spellbook;
                    continue;
                }

                if (String.Equals(line, Common.PreparedSpells))
                {
                    fileSection = Common.PreparedSpells;
                    continue;
                }

                if (String.Equals(line, Common.PreparedSpellsSettings))
                {
                    fileSection = Common.PreparedSpellsSettings;
                    continue;
                }

                if (String.Equals(fileSection, Common.Spellbook))
                {
                    spellBook.Add(new Spell(line.Split('~')));
                }

                if (String.Equals(fileSection, Common.PreparedSpells))
                {
                    preparedSpells.Add(new PreparedSpell(line.Split('~')));
                }

                if (String.Equals(fileSection, Common.PreparedSpellsSettings))
                {
                    preparedSpellSettings.Add(line);
                }
            }

            if (spellBook.Count != 0)
            {
                spellcaster.setSpellbook(spellBook);
            }

            if (preparedSpells.Count != 0)
            {
                spellcaster.setPreparedSpells(preparedSpells);
            }

            if (preparedSpellSettings.Count != 0)
            {
                spellcaster.setPreparedSpellSettings(preparedSpellSettings);
            }
        }

        private void saveSpellbook(object sender, EventArgs e)
        {
            Common.saveFile(Common.SaveSpellbook, spellcaster.getSpellbookSaveContent());
        }

        private void openSpellsFromSpellbook(object sender, EventArgs e)
        {
            List<string> fileContent = Common.openFile();
            List<Spell> loadedSpellbook = new List<Spell>();

            foreach (string line in fileContent)
            {
                if (line.Split('~').Length == 14)
                {
                    loadedSpellbook.Add(new Spell(line.Split('~')));
                }
            }

            LoadSpellbook loadSpellbookDialog = new LoadSpellbook(this, loadedSpellbook);
            loadSpellbookDialog.Show();
        }
    }

}
