using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Xml.XPath;
using Squire;
using System.Text.RegularExpressions;

namespace Squire
{
    public partial class Squire : Form
    {
        //-----( Custom Controls )-----//
        private Label[] skillNames;
        private NumericUpDown[] skillRanks;
        private NumericTextBox newHP;

        //-----( Normal Variables )-----//
        private Boolean bDataLoaded;
        private Boolean bLoadOK;
        FileStream stream;
        private decimal numberFeatSlots;
        private decimal numberClassFeatureSlots;
        private decimal level;
        private decimal STR;
        private decimal DEX;
        private decimal CON;
        private decimal INT;
        private decimal WIS;
        private decimal CHA;
        private String sourceFile;
        private String sheetType;

        public Squire()
        {
            InitializeComponent();

            //-----( Initialise Variables )-----//
            skillNames = new Label[8] {label1,label2,label3,label4,label5,label6,label7,label8};
            skillRanks = new NumericUpDown[8] { numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8 };
            bDataLoaded = false;
            bLoadOK = true;
            numberFeatSlots = 12;
            numberClassFeatureSlots = 23;

            //-----( Custom Components )-----//
            newHP = new NumericTextBox();
            newHP.Parent = hitPointsPanel;
            newHP.DecimalValue = 0;
            newHP.TextAlign = HorizontalAlignment.Center;
            newHP.Dock = DockStyle.Fill;
            newHP.TabIndex = 5;
            newHP.Enabled = false;

            //-----( Event Handlers )-----//
            classFeatureEntry.KeyPress += new KeyPressEventHandler(classFeatureEntry_KeyPress);
            classFeaturesBox.SelectedValueChanged += new EventHandler(classFeaturesBox_SelectedValueChanged);
            featEntry.KeyPress +=new KeyPressEventHandler(featEntry_KeyPress);
            featBox.SelectedIndexChanged += new EventHandler(featBox_SelectedIndexChanged);
            newHP.KeyPress += new KeyPressEventHandler(newHP_KeyPress);
            createCharacterXML.FileOk += new CancelEventHandler(createCharacterXML_FileOk);
        }

        void createCharacterXML_FileOk(object sender, CancelEventArgs e)
        {
            if (createCharacterXML.FileName == sourceFile)
            {
                e.Cancel = true;
                MessageBox.Show("Level up data must be stored in its own file.", "Error: please select different destination", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void newHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the return key is pressed while editing number in newHP, add number to HP total
            if (e.KeyChar == 13) addHPButton.PerformClick();
        }

        void featBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Only enable the Remove button if there's something selected in the feat list
            removeFeatButton.Enabled = (featBox.SelectedItems.Count > 0);
        }

        private void classFeaturesBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // Only enable the Remove button if there's something selected in the class features list
            removeClassFeatureButton.Enabled = (classFeaturesBox.SelectedItems.Count > 0);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (bDataLoaded) stream.Close(); // unlock character file if one is open
            this.Close();
        }

        private void characterFile_TextChanged(object sender, EventArgs e)
        {
            if (characterFile.TextLength > 0)
                loadButton.Enabled = true;
            else
                loadButton.Enabled = false;
        }


        private void classFeatureEntry_TextChanged(object sender, EventArgs e)
        {
            addClassFeatureButton.Enabled = (classFeatureEntry.TextLength > 0);
        }

        private void featEntry_TextChanged(object sender, EventArgs e)
        {
            addFeatButton.Enabled = (featEntry.TextLength > 0);
        }

        private void addClassFeatureButton_Click(object sender, EventArgs e)
        {
            if (classFeaturesBox.Items.Count < numberClassFeatureSlots)
            {
                classFeaturesBox.Items.Add(" " + classFeatureEntry.Text);
                classFeatureEntry.Clear();
            }
            else
            {
                MessageBox.Show("The sheet type only has room for "+numberClassFeatureSlots+" class features. You will need a character sheet with more class feature slots to add more class features.", "Error: no space for new class feature", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openCharacterXML.ShowDialog() == DialogResult.OK) characterFile.Text = openCharacterXML.FileName;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            // If there is already data loaded, ask user if they want to overwrite existing data with new data.
            if (bDataLoaded)
            {
                if (MessageBox.Show("Loading new data will overwrite existing data. Proceed?", "Existing Data",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK) bLoadOK = true;
                else bLoadOK = false;
            }

            if (bLoadOK)
            {
                // Lock file for editing
                stream = File.Open(characterFile.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                // Load file
                using (XmlReader reader = XmlReader.Create(characterFile.Text))
                {
                    // The load sequence may seem to be in a strange order, but that's because XML Reader has forward-only access to the data.
                    // This means data must be accessed in the order it appears in the data file.
                    //try
                    //{
                        int skillIndex = 0;
                        reader.MoveToContent();

                    // Determine sheet type
                        reader.ReadToDescendant("ClassAndLevel");
                        determineSheetType(reader.ReadElementContentAsString());

                        // Record ability scores
                        reader.ReadToNextSibling("STR");
                        STR = reader.ReadElementContentAsDecimal();
                        reader.ReadToNextSibling("DEX");
                        DEX = reader.ReadElementContentAsDecimal();
                        reader.ReadToNextSibling("CON");
                        CON = reader.ReadElementContentAsDecimal();
                        reader.ReadToNextSibling("INT");
                        INT = reader.ReadElementContentAsDecimal();
                        reader.ReadToNextSibling("WIS");
                        WIS = reader.ReadElementContentAsDecimal();
                        reader.ReadToNextSibling("CHA");
                        CHA = reader.ReadElementContentAsDecimal();

                        reader.ReadToNextSibling("HP");
                        upDownHP.Value = reader.ReadElementContentAsDecimal();
                        upDownHP.Enabled = true;
                        newHP.Enabled = true;
                        addHPButton.Enabled = true;

                        reader.ReadToNextSibling("FortBase");
                        upDownFort.Value = reader.ReadElementContentAsDecimal();
                        upDownFort.Enabled = true;

                        reader.ReadToNextSibling("RefBase");
                        upDownRef.Value = reader.ReadElementContentAsDecimal();
                        upDownRef.Enabled = true;

                        reader.ReadToNextSibling("WillBase");
                        upDownWill.Value = reader.ReadElementContentAsDecimal();
                        upDownWill.Enabled = true;

                        reader.ReadToNextSibling("BAB");
                        if (!reader.IsEmptyElement)
                        {
                            upDownBAB.Value = reader.ReadElementContentAsDecimal();
                            
                            // If we couldn't determine the sheet type earlier, we'll use the BAB to generate the level.
                            if (level == 0)
                            {
                                characterLevel.Value = (upDownBAB.Value + 1);
                            }
                            upDownBAB.Enabled = true;
                        }

                        reader.ReadToNextSibling("ClimbRanks");
                        if (!reader.IsEmptyElement)
                        {
                            skillNames[skillIndex].Text = "Climb";
                            skillNames[skillIndex].Visible = true;
                            skillRanks[skillIndex].Value = reader.ReadElementContentAsDecimal();
                            skillRanks[skillIndex].Visible = true;
                            skillIndex++;
                        }

                        reader.ReadToNextSibling("IntimidateRanks");
                        if (!reader.IsEmptyElement)
                        {
                            skillNames[skillIndex].Text = "Intimidate";
                            skillNames[skillIndex].Visible = true;
                            skillRanks[skillIndex].Value = reader.ReadElementContentAsDecimal();
                            skillRanks[skillIndex].Visible = true;
                            skillIndex++;
                        }

                        reader.ReadToNextSibling("JumpRanks");
                        if (!reader.IsEmptyElement)
                        {
                            skillNames[skillIndex].Text = "Jump";
                            skillNames[skillIndex].Visible = true;
                            skillRanks[skillIndex].Value = reader.ReadElementContentAsDecimal();
                            skillRanks[skillIndex].Visible = true;
                            skillIndex++;
                        }

                        reader.ReadToNextSibling("RideRanks");
                        if (!reader.IsEmptyElement)
                        {
                            skillNames[skillIndex].Text = "Ride";
                            skillNames[skillIndex].Visible = true;
                            skillRanks[skillIndex].Value = reader.ReadElementContentAsDecimal();
                            skillRanks[skillIndex].Visible = true;
                            skillIndex++;
                        }

                        reader.ReadToNextSibling("SwimRanks");
                        if (!reader.IsEmptyElement)
                        {
                            skillNames[skillIndex].Text = "Swim";
                            skillNames[skillIndex].Visible = true;
                            skillRanks[skillIndex].Value = reader.ReadElementContentAsDecimal();
                            skillRanks[skillIndex].Visible = true;
                            skillIndex++;
                        }

                        reader.ReadToNextSibling("Knowledge1Ranks");
                        if (!reader.IsEmptyElement)
                        {
                            skillNames[skillIndex].Text = "Knowledge (Nobility and Royalty)";
                            skillNames[skillIndex].Visible = true;
                            skillRanks[skillIndex].Value = reader.ReadElementContentAsDecimal();
                            skillRanks[skillIndex].Visible = true;
                            skillIndex++;
                        }

                        // Process feats -- iterate through all feat slots on the sheet.
                        reader.ReadToNextSibling("Feats");
                        for (int i = 0; i < numberFeatSlots; i++)
                        {
                            if (!reader.IsEmptyElement)
                            {
                                String item = reader.ReadElementContentAsString();
                                if (item != String.Empty) // don't add blank entries to the feat list. That would be silly.
                                    featBox.Items.Add(item);
                            }
                            else
                            {
                                reader.ReadString(); // If slot is empty, skip to next node
                            }
                        }
                        featEntry.Enabled = true;

                        reader.ReadToNextSibling("HandleAnimalRanks");
                        if (!reader.IsEmptyElement)
                        {
                            skillNames[skillIndex].Text = "Handle Animal";
                            skillNames[skillIndex].Visible = true;
                            skillRanks[skillIndex].Value = reader.ReadElementContentAsDecimal();
                            skillRanks[skillIndex].Visible = true;
                            skillIndex++;
                        }

                        reader.ReadToNextSibling("DiplomacyRanks");
                        if (!reader.IsEmptyElement)
                        {
                            skillNames[skillIndex].Text = "Diplomacy";
                            skillNames[skillIndex].Visible = true;
                            skillRanks[skillIndex].Value = reader.ReadElementContentAsDecimal();
                            skillRanks[skillIndex].Visible = true;
                            skillIndex++;
                        }

                        // Process class features -- iterate through the 23 class feature slots on the sheet.
                        reader.ReadToNextSibling("SpecialAbilities");
                        for (int i = 0; i < numberClassFeatureSlots; i++)
                        {
                            if (!reader.IsEmptyElement) classFeaturesBox.Items.Add(reader.ReadElementContentAsString());
                            else reader.ReadString(); // Skip to next node
                        }
                        classFeatureEntry.Enabled = true;

                        // Unlock controls
                        bDataLoaded = true;
                        bLoadOK = false;
                        characterLevel.Enabled = true;
                        generateButton.Enabled = true;
                        sourceFile = characterFile.Text;

                        // Change title bar to indicate the file we're working on
                        this.Text = ( this.Text + " [" + openCharacterXML.FileName + "]" );
                    //}
                    //catch (Exception ex)
                    //{
                      //  MessageBox.Show("Squire encountered an error while reading the character file. Please check the file (or designate a new one) and try again.", "Bad File", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    //}
                }
            }
        }

        /**
         * Uses data in the class and level field to determine what kind of character sheet the user is using and what level they're
         * levelling to.
         * @param classAndLevel The class and level of the sheet e.g. "Knight 16"
         */
        private void determineSheetType(string classAndLevel)
        {
            
            // Determine sheet type
            if (classAndLevel.Contains("Knight"))
            {
                sheetType = "Knight";
                numberFeatSlots = 12;
                numberClassFeatureSlots = 23;
            }
            else if (classAndLevel.Contains("Fighter"))
            {
                sheetType = "Fighter";
                numberFeatSlots = 35;
                numberClassFeatureSlots = 0;
            }
            else
            {
                sheetType = "None";
                numberClassFeatureSlots = 12;
                numberClassFeatureSlots = 23;
            }

            // Determine level (only works for straight classes)
            if (sheetType != "None")
            {
                classAndLevel = classAndLevel.Replace(sheetType, null); // remove the "class" part of "class and level"
                level = Convert.ToDecimal(classAndLevel.Trim()); // convert what's left of the string (whitespace trimmed off) to decimal
                level++; // increment the number (we're levelling up)
            }
            else
            {
                // If there's no listing for the sheet type, temporarily set level to 0. We'll just use the BAB +1 (which we'll read later)
                level = 0;
            }

            characterLevel.Value = level; // set the character level component to read the new level
        }

        private void classFeatureEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) addClassFeatureButton.PerformClick();
        }

        private void featEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) addFeatButton.PerformClick();
        }

        private void removeClassFeatureButton_Click(object sender, EventArgs e)
        {
            // Remove each selected item from the ListBox
            for (int i = classFeaturesBox.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = classFeaturesBox.SelectedIndices[i];
                classFeaturesBox.Items.RemoveAt(index);
            }
        }

        private void addFeatButton_Click(object sender, EventArgs e)
        {
            // Make sure we don't have more feats than can be saved back to the character sheet.
            if (featBox.Items.Count < numberFeatSlots)
            {
                featBox.Items.Add(" " + featEntry.Text); // add the feat to the feat list
                featEntry.Clear(); // clear the entry field for new input
            }
            else
            {
                MessageBox.Show("The sheet type only has room for "+numberFeatSlots+" feats. You will need a character sheet with more feat slots to add more feats.", "Error: no space for new feat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeFeatButton_Click(object sender, EventArgs e)
        {
            // Remove each selected item from the ListBox
            for (int i = featBox.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = featBox.SelectedIndices[i];
                featBox.Items.RemoveAt(index);
            }
        }

        private void characterLevel_ValueChanged(object sender, EventArgs e)
        {
            // If the character's new level is a multiple of 4, enable ability score increase.
            if (characterLevel.Value % 4 == 0) comboBoxAbilityScore.Enabled = true;
            else comboBoxAbilityScore.Enabled = false;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // Determine default file name
            Regex suffix = new Regex("_lv(.+).xml"); // define a regular expression to check file name format and 
            if (suffix.Match(sourceFile).Value != null) // if the source file is already properly formatted ...
            {
                if (Convert.// check that the filename doesn't end with something stupid like "_lvONEHUNDREDYO.xml"
            }
            createCharacterXML.FileName = sourceFile.Replace(".xml", "_lv" + level + ".xml");

            if (createCharacterXML.ShowDialog() == DialogResult.OK)
            {
                //try
                //{
                    // Generate file from source
                    File.Copy(sourceFile, createCharacterXML.FileName, true);

                    // Create an environment for manipulating the data in the destination file
                    XmlDocument destFile = new XmlDocument(); // this object is required to manipulate XML data
                    destFile.PreserveWhitespace = true; // stops any formatting changes (they would make the file unreadable by Squire)
                    destFile.Load(createCharacterXML.FileName); // load in the data from our destination data file
                    XmlNode root = destFile.DocumentElement; // locate the start of the data
                    XmlNode cursor = root.SelectSingleNode("descendant::Skin"); // used to step through file to locate nodes
                    XPathNavigator editor = cursor.CreateNavigator(); // used to edit the node that the cursor has located

                // Handle class and level
                    cursor = root.SelectSingleNode("descendant::ClassAndLevel");
                    editor = cursor.CreateNavigator();
                    if (sheetType != "None")
                    {
                        editor.SetValue(sheetType + " " + level);
                    }
                    else
                    {
                        editor.SetValue(level.ToString());
                    }

                    // Handle ability score increase
                    if (comboBoxAbilityScore.Text != String.Empty)
                    {
                        // Position cursor on the relative node.
                        cursor = root.SelectSingleNode("descendant::" + comboBoxAbilityScore.Text);

                        // Match the selected node to the correct ability score and overwrite the old score with the new one
                        switch (comboBoxAbilityScore.Text)
                        {
                            case "STR":
                                decimal newSTR = (STR + 1); // why not use STR++? If the user generates multiple times the score will keep incrementing.
                                editor = cursor.CreateNavigator();
                                editor.SetTypedValue(newSTR); // overwrite old score with new value
                                break;
                            case "DEX":
                                decimal newDEX = (DEX + 1);
                                editor = cursor.CreateNavigator();
                                editor.SetTypedValue(newDEX);
                                break;
                            case "CON":
                                decimal newCON = (CON + 1);
                                editor = cursor.CreateNavigator();
                                editor.SetTypedValue(newCON);
                                break;
                            case "INT":
                                decimal newINT = (INT + 1);
                                editor = cursor.CreateNavigator();
                                editor.SetTypedValue(newINT);
                                break;
                            case "WIS":
                                decimal newWIS = (WIS + 1);
                                editor = cursor.CreateNavigator();
                                editor.SetTypedValue(newWIS);
                                break;
                            case "CHA":
                                decimal newCHA = (CHA + 1);
                                editor = cursor.CreateNavigator();
                                editor.SetTypedValue(newCHA);
                                break;
                        }
                    }

                    // Update HP
                    cursor = root.SelectSingleNode("descendant::HP");
                    editor = cursor.CreateNavigator();
                    editor.SetTypedValue(upDownHP.Value);

                    // Update saving throws
                    cursor = root.SelectSingleNode("descendant::FortBase");
                    editor = cursor.CreateNavigator();
                    editor.SetTypedValue(upDownFort.Value);

                    cursor = root.SelectSingleNode("descendant::RefBase");
                    editor = cursor.CreateNavigator();
                    editor.SetTypedValue(upDownRef.Value);

                    cursor = root.SelectSingleNode("descendant::WillBase");
                    editor = cursor.CreateNavigator();
                    editor.SetTypedValue(upDownWill.Value);

                    // Update BAB
                    cursor = root.SelectSingleNode("descendant::BAB");
                    editor = cursor.CreateNavigator();
                    editor.SetTypedValue(upDownBAB.Value);

                    // Update skill ranks
                    int knowledgeCount = 1; // used for the pesky knowledge skill

                    for (int i = 0; i < skillNames.Length; i++)
                    {
                        Console.WriteLine("Processing the " + skillNames[i].Text + " skill.");
                        // Most skills have an element name of "[skillname]Ranks", but knowledges don't. Instead the first knowledge is
                        // "Knowledge1Ranks", the second is "Knowledge2Ranks" and so on.
                        if (skillNames[i].Text.Contains("Knowledge"))
                        {
                            cursor = root.SelectSingleNode("descendant::" + "Knowledge" + knowledgeCount + "Ranks");
                        } else if (skillNames[i].Text == "Handle Animal") // Also bloody Handle Animal. That's got a space in it. <_<
                        {
                            cursor = root.SelectSingleNode("descendant::HandleAnimalRanks");
                        } else if (skillNames[i].Text.Contains("label")) // We also have -invisible- skills to check for. >:|
                        {
                            break; // just skip out of this iteration. There won't be any elements called "labelxRanks" and if there are God help us.
                        } else 
                        {
                            cursor = root.SelectSingleNode("descendant::" + skillNames[i].Text + "Ranks");
                        }

                        editor = cursor.CreateNavigator();
                        editor.SetTypedValue(skillRanks[i].Value);
                    }

                // Update feats (a little different because the "Feats" element tags are identical for every feat)
                int count = 0; // used to reference featBox

                    for (XmlNode i = root.SelectSingleNode("descendant::Feats"); i.NextSibling.Name == "Feats"; i = i.NextSibling)
                    {
                        // Check to make sure we still have feats to add from the feat box
                        if (count < featBox.Items.Count)
                        {
                            editor = i.CreateNavigator();
                            editor.SetValue(featBox.Items[count].ToString());
                            count++;
                        }
                        else // If we've run out of feats, clear the remaining feat slots
                        {
                            editor = i.CreateNavigator();
                            editor.SetValue(String.Empty);
                        }
                    }

                    /*
                    // Process feats -- iterate through all feat slots on the sheet.
                    reader.ReadToNextSibling("Feats");
                    for (int i = 0; i < 12; i++)
                    {
                        if (!reader.IsEmptyElement) featBox.Items.Add(reader.ReadElementContentAsString());
                        else reader.ReadString(); // If slot is empty, skip to next node
                    }
                    featEntry.Enabled = true;

                    reader.ReadToNextSibling("HandleAnimalRanks");
                    if (!reader.IsEmptyElement)
                    {
                        skillNames[skillIndex].Text = "Handle Animal";
                        skillNames[skillIndex].Visible = true;
                        skillRanks[skillIndex].Value = reader.ReadElementContentAsDecimal();
                        skillRanks[skillIndex].Visible = true;
                        skillIndex++;
                    }

                    reader.ReadToNextSibling("DiplomacyRanks");
                    if (!reader.IsEmptyElement)
                    {
                        skillNames[skillIndex].Text = "Diplomacy";
                        skillNames[skillIndex].Visible = true;
                        skillRanks[skillIndex].Value = reader.ReadElementContentAsDecimal();
                        skillRanks[skillIndex].Visible = true;
                        skillIndex++;
                    }

                    // Process class features -- iterate through the 23 feat slots on the sheet.
                    reader.ReadToNextSibling("SpecialAbilities");
                    for (int i = 0; i < 23; i++)
                    {
                        if (!reader.IsEmptyElement) classFeaturesBox.Items.Add(reader.ReadElementContentAsString());
                        else reader.ReadString(); // Skip to next node
                    }*/
                    destFile.Save(createCharacterXML.FileName);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("The file could not be created. Please check that you have write access to the destination folder and try again.", "File Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void addHPButton_Click(object sender, EventArgs e)
        {
            upDownHP.Value += newHP.DecimalValue;
            newHP.DecimalValue = 0;
        }
    }
}
