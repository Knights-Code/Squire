using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Squire
{
    static class Common
    {
        // Basic Strings
        public const string Blank = "";
        public const string LabelEnd = ": ";

        // Spell Sections
        public const string SpellNameVar = "spellname";
        public const string SpellName = "Name";

        public const string SpellSchoolSubschoolVar = "spellschoolandsubschool";
        public const string SpellSchoolSubschool = "School (Subschool)";

        public const string SpellDescriptorVar = "spelldescriptor";
        public const string SpellDescriptor = "Descriptor";

        public const string SpellLevelVar = "spelllevel";
        public const string SpellLevel = "Level";

        public const string SpellComponentsVar = "spellcomponents";
        public const string SpellComponents = "Components";

        public const string SpellCastingTimeVar = "spellcastingtime";
        public const string SpellCastingTime = "Casting Time";

        public const string SpellRangeVar = "spellrange";
        public const string SpellRange = "Range";

        public const string SpellAreaVar = "spellarea";
        public const string SpellArea = "Area";

        public const string SpellEffectVar = "spelleffect";
        public const string SpellEffect = "Effect";

        public const string SpellTargetsVar = "spelltargets";
        public const string SpellTargets = "Target(s)";

        public const string SpellDurationVar = "spellduration";
        public const string SpellDuration = "Duration";

        public const string SpellSavingThrowVar = "spellsavingthrow";
        public const string SpellSavingThrow = "Saving Throw";

        public const string SpellResistanceVar = "spellresistance";
        public const string SpellResistance = "Spell Resistance";

        public const string SpellDescriptionVar = "spelldescription";
        public const string SpellDescription = "Description";

        public const string SpellUsedVar = "spellused";
        public const string SpellUsed = "Used";

        public const string LoadSpellVar = "loadspell";
        public const string LoadSpell = "Load";


        // File Strings

        // File Extensions
        public const string FamiliarExtension = ".fmlr";
        public const string FamiliarExtensionNoDot = "fmlr";
        public const string SpellExtensions = "Spell Files (*" + FamiliarExtension + ")|*" + FamiliarExtensionNoDot;
        public const string AllExtensions = "All files (*.*)|*.*";

        public const string SaveSpellbook = "Save Spellbook";
        public const string SaveSpellcaster = "Save Spellcaster";

        public const string OpenSpellbook = "Open Spellbook";
        public const string OpenSpellcaster =   "Open Spellcaster";

        // File Section Headings
        public const string Spellbook = "Spellbook";
        public const string PreparedSpells = "Prepared Spells";
        public const string PreparedSpellsSettings = "Prepared Spell Settings";

        // File Prepared Spells Settings Labels
        public const string SpontaneousCaster = "Spontaneous Caster?";
        public const string HighestPreparedSpellLevel = "Highest Prepared Spell Level";
        public const string PreparedSpellsCount = "Prepared Spells Count Per Level";
        public const string PreparedSpellsRemaining = "Prepared Spells Remaining Per Level";

        public static void saveFile(String title, List<string> fileContents)
        {
            SaveFileDialog saveSpells = new SaveFileDialog();
            saveSpells.DefaultExt = Common.FamiliarExtension;
            saveSpells.Filter = Common.SpellExtensions + "|" + Common.AllExtensions;
            saveSpells.OverwritePrompt = true;
            saveSpells.Title = title;

            if (saveSpells.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveSpells.FileName);

                foreach (string line in fileContents)
                {
                    file.WriteLine(line);
                }

                file.Close();
            }
        }

        public static List<string> openFile()
        {
            OpenFileDialog openSpells = new OpenFileDialog();
            openSpells.DefaultExt = Common.FamiliarExtension;
            openSpells.Filter = Common.SpellExtensions + "|" + Common.AllExtensions;
            openSpells.Title = Common.OpenSpellbook;

            if (openSpells.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(openSpells.FileName);

                string currentLine;
                List<String> fileContents = new List<String>();

                while ((currentLine = file.ReadLine()) != null)
                {
                    fileContents.Add(currentLine);
                }

                return fileContents;
            }

            return new List<string>();
        }

        public static void changeHeaderNames(DataGridView dataGrid)
        {
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                switch (dataGrid.Columns[i].Name)
                {
                    // Name
                    case Common.SpellNameVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellName;
                        break;

                    // School (Subschool)
                    case Common.SpellSchoolSubschoolVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellSchoolSubschool;
                        break;

                    // [Descriptor]
                    case Common.SpellDescriptorVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellDescriptor;
                        break;

                    // Level
                    case Common.SpellLevelVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellLevel;
                        break;

                    // Components
                    case Common.SpellComponentsVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellComponents;
                        break;

                    // Casting Time
                    case Common.SpellCastingTimeVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellCastingTime;
                        break;

                    // Range
                    case Common.SpellRangeVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellRange;
                        break;

                    // Area
                    case Common.SpellAreaVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellArea;
                        break;

                    // Effect
                    case Common.SpellEffectVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellEffect;
                        break;

                    // Target(s)
                    case Common.SpellTargetsVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellTargets;
                        break;

                    // Duration
                    case Common.SpellDurationVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellDuration;
                        break;

                    // Saving Throw
                    case Common.SpellSavingThrowVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellSavingThrow;

                        break;

                    // Spell Resistance
                    case Common.SpellResistanceVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellResistance;
                        break;

                    // Description
                    case Common.SpellDescriptionVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellDescription;
                        break;

                    // Prepared Spell Used
                    case Common.SpellUsedVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.SpellUsed;
                        dataGrid.Columns[i].Width = 40;
                        break;

                    // Load Spell
                    case Common.LoadSpellVar:
                        dataGrid.Columns[i].HeaderCell.Value = Common.LoadSpell;
                        dataGrid.Columns[i].Width = 40;
                        break;
                }
            }

        }
    }
}
