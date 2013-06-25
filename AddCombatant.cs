using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Squire
{
    public partial class AddCombatant : Form
    {
        General parentForm;

        public AddCombatant()
        {
            InitializeComponent();
        }

        public AddCombatant(General parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();

            combatantName.Focus();
        }

        private void checkboxIsPlayer_CheckedChanged(object sender, EventArgs e)
        {
            combatantHP.Enabled = !checkboxIsPlayer.Checked;
        }

        private void addOK_Click(object sender, EventArgs e)
        {
            // If we're adding a batch of combatants ...
            if (useBatch.Checked)
            {
                //Regex damageFormat = new Regex(@"(\d*).(\d*)(.)(\d*)"); // regular expression to catch digits in a string
                Regex batchFormat = new Regex(@"(\d+.\d+.\d+)"); // regular expression to find instances of the damage format
                Regex damageFormat = new Regex(@"(\d+).(\d+)(.)(\d+)"); // regular expression to catch digits in a string
                MatchCollection matches = batchFormat.Matches(batchExpression.Text);

                if (matches.Count > 0)
                {
                    try
                    {
                        // Create a means of generating random numbers. Use GUID for seed
                        // because the default system time seed doesn't use enough decimal
                        // places and therefore generating multiple random numbers in a row
                        // will result in the same number multiple times.
                        Random dieRoller = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));

                        // For each combatant to be batch created ...
                        for (int c = 1; c < (int)batchNumber.Value + 1; c++)
                        {
                            string combatantName = batchName.Text + " #" + c;
                            decimal CR = batchCR.Value;
                            int HP = 0;

                            for (int i = 0; i < matches.Count; i++)
                            {
                                Match damageMatch = damageFormat.Match(matches[i].Value);

                                if (damageMatch.Success)
                                {
                                    int dieCount = Convert.ToInt32(damageMatch.Groups[1].Value);
                                    int dieType = Convert.ToInt32(damageMatch.Groups[2].Value);
                                    int bonus = Convert.ToInt32(damageMatch.Groups[4].Value);
                                    bonus *= (string)damageMatch.Groups[3].Value == "-" ? -1 : 1;

                                    // "Roll" Hit Dice and add them to the total one at a time.
                                    for (int HD = 0; HD < dieCount; HD++)
                                    {
                                        int roll = dieRoller.Next(1, dieType);

                                        if (useGenerousHP.Checked)
                                        {
                                            decimal modRoll = (roll + dieType) / 2; // super secret balancing feature
                                            modRoll = Math.Floor(modRoll);
                                            roll = (int)modRoll;
                                        }

                                        HP += roll;
                                    }

                                    HP += bonus; // add Constitution modifier
                                }
                            }

                            Combatant newCombatant = new Combatant(combatantName, HP, CR);

                            // These two variables are used by RollInitiative to help handle multiple combatants acting on the
                            // same initiative count.
                            newCombatant.setBatchRoot(batchName.Text);
                            newCombatant.setBatchTotal((int)batchNumber.Value + 1);

                            parentForm.combatantList.Items.Add(newCombatant);
                        }

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HP expression format must be [number of dice]d[die type]+/-[bonus], for example \"1d8+4\".", "Incorrect HP Expression Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (this.combatantName.Text != String.Empty)
                {
                    Combatant newCombatant = null;
                    if (combatantHP.Enabled && combatantHP.IntValue != 0)
                    {
                        if (combatantLevel.Enabled && combatantLevel.Value != 0)
                            newCombatant = new Combatant(combatantName.Text, combatantHP.IntValue, combatantLevel.Value);
                        else
                            MessageBox.Show("You must enter a level for the combatant.", "Error: No Level", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //newCombatant = new Combatant(combatantName.Text, combatantHP.IntValue);
                    }
                    else
                    {
                        if (combatantLevel.Enabled && combatantLevel.Value != 0)
                            newCombatant = new Combatant(combatantName.Text, combatantLevel.Value);
                        else
                            MessageBox.Show("You must enter a level for the combatant.", "Error: No Level", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (newCombatant != null)
                    {
                        parentForm.combatantList.Items.Add(newCombatant);

                        // If there's no selected combatant in the list, select the recently added one.
                        if (parentForm.combatantList.SelectedIndex == -1) parentForm.combatantList.SelectedIndex = (parentForm.combatantList.Items.Count - 1);
                        this.Close();
                    }
                }
            }
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void useBatch_CheckedChanged(object sender, EventArgs e)
        {
            if (useBatch.Checked)
            {
                combatantHP.Enabled = false;
                combatantName.Enabled = false;
                combatantLevel.Enabled = false;

                batchExpression.Enabled = true;
                batchName.Enabled = true;
                batchNumber.Enabled = true;
                batchCR.Enabled = true;
                useGenerousHP.Enabled = true;
            }
            else
            {
                combatantHP.Enabled = true;
                combatantName.Enabled = true;
                combatantLevel.Enabled = true;

                batchExpression.Enabled = false;
                batchName.Enabled = false;
                batchNumber.Enabled = false;
                batchCR.Enabled = false;
                useGenerousHP.Enabled = false;
            }
        }
    }
}
