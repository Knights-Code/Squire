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
    public partial class General : Form
    {
        HPBar combatantHPBar;

        public General()
        {
            InitializeComponent();
            combatantHPBar = new HPBar();
            combatantHPBar.Parent = tableLayoutPanel12;
            combatantHPBar.Dock = DockStyle.Fill;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCombatantButton_Click(object sender, EventArgs e)
        {
            AddCombatant addDialog = new AddCombatant(this);
            addDialog.Show();
        }

        private void combatantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Local combatant variable to store the currently selected combatant
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
            
            // Load in all the combatant's data and unlock the controls.

            // Players don't have HP shown
            if (!selectedCombatant.isPlayer())
            {
                combatantHPBar.Visible = true;
                combatantHPBar.Maximum = selectedCombatant.getMaxHP();
                combatantHPBar.Minimum = 0;
                combatantHPBar.Value = selectedCombatant.getCurrentHP();

                remainingHP.Visible = true;
                remainingHP.Text = selectedCombatant.getCurrentHP() + " / " + selectedCombatant.getMaxHP();

                HPChange.Visible = true;
                HPChange.Enabled = true;
                healButton.Visible = true;
                healButton.Enabled = true;
                damageButton.Visible = true;
                damageButton.Enabled = true;
            }
            else
            {
                combatantHPBar.Visible = false;
                HPChange.Visible = true;
                healButton.Visible = true;
                damageButton.Visible = true;
            }

            labelCombatantName.Text = selectedCombatant.getName();

            attackBonus1.IntValue = selectedCombatant.getAttack(1);
            damage1.Text = selectedCombatant.getDamage(1);
            attackBonus1.Enabled = true;
            damage1.Enabled = true;
            incrementAttack1.Enabled = true;
            decrementAttack1.Enabled = true;
            incrementDamage1.Enabled = true;
            decrementDamage1.Enabled = true;

            attackBonus2.IntValue = selectedCombatant.getAttack(2);
            damage2.Text = selectedCombatant.getDamage(2);
            attackBonus2.Enabled = true;
            damage2.Enabled = true;
            incrementAttack2.Enabled = true;
            decrementAttack2.Enabled = true;
            incrementDamage2.Enabled = true;
            decrementDamage2.Enabled = true;

            attackBonus3.IntValue = selectedCombatant.getAttack(3);
            damage3.Text = selectedCombatant.getDamage(3);
            attackBonus3.Enabled = true;
            damage3.Enabled = true;
            incrementAttack3.Enabled = true;
            decrementAttack3.Enabled = true;
            incrementDamage3.Enabled = true;
            decrementDamage3.Enabled = true;
        }

        private void healButton_Click(object sender, EventArgs e)
        {
            // Local combatant variable to store the currently selected combatant
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            if (selectedCombatant.getCurrentHP() + HPChange.IntValue > selectedCombatant.getMaxHP()) selectedCombatant.setCurrentHP(selectedCombatant.getMaxHP());
            else selectedCombatant.setCurrentHP(selectedCombatant.getCurrentHP() + HPChange.IntValue);

            HPChange.IntValue = 0;

            combatantHPBar.Value = selectedCombatant.getCurrentHP(); // update the HP bar

            remainingHP.Text = selectedCombatant.getCurrentHP() + " / " + selectedCombatant.getMaxHP(); // update HP label
        }

        private void damageButton_Click(object sender, EventArgs e)
        {
            // Local combatant variable to store the currently selected combatant
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            selectedCombatant.setCurrentHP(selectedCombatant.getCurrentHP() - HPChange.IntValue);

            HPChange.IntValue = 0;

            combatantHPBar.Value = selectedCombatant.getCurrentHP(); // update the HP bar
            remainingHP.Text = selectedCombatant.getCurrentHP() + " / " + selectedCombatant.getMaxHP(); // update HP label
        }

        private void incrementAttack1_Click(object sender, EventArgs e)
        {
            attackBonus1.IntValue++;
        }

        private void decrementAttack1_Click(object sender, EventArgs e)
        {
            attackBonus1.IntValue--;
        }

        private void incrementDamage1_Click(object sender, EventArgs e)
        {
            updateDamage(damage1, true);
        }

        /**
         * Updates the damage string with a new bonus to damage.
         * @param damage The text box with the damage string to update.
         * @param bUp If true, increments the damage bonus. If false, decrements the damage bonus.
         */
        private void updateDamage(TextBox damage, Boolean bUp)
        {
            int bonus = 0; // variable to store the damage bonus to change
            int dieCount = 1; // variable to store the number of dice
            int dieType = 4; // variable to store the type of die
            Regex damageFormat = new Regex(@"(\d*).(\d*)\+(\d*)"); // regular expression to catch digits in a string
            Match match = damageFormat.Match(damage.Text);

            Console.WriteLine(match.Success ? "Match successful." : "No match found.");

            if (match.Success)
            {
                try
                {
                    for (int i = 1; i < 4; i++)
                    {
                        Console.WriteLine("Match reads: " + match.Groups[i].Value);
                    }
                    dieCount = Convert.ToInt32(match.Groups[1].Value);
                    dieType = Convert.ToInt32(match.Groups[2].Value);
                    bonus = Convert.ToInt32(match.Groups[3].Value);

                    bonus += (bUp ? 1 : -1); // update the bonus

                    damage.Text = (dieCount + "d" + dieType + "+" + bonus); // update the damage string
                }
                catch (Exception e)
                {
                    MessageBox.Show("Damage format must be [number of dice]d[die type]+[bonus], for example \"1d8+4\".", "Incorrect Damage Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void decrementDamage1_Click(object sender, EventArgs e)
        {
            updateDamage(damage1, false);
        }

        private void damage1_TextChanged(object sender, EventArgs e)
        {
            // Local combatant variable to store the currently selected combatant
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            selectedCombatant.setDamage(1, damage1.Text); // update combatant's first attack's damage string
        }

        private void attackBonus1_TextChanged(object sender, EventArgs e)
        {
            // Local combatant variable to store the currently selected combatant
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            selectedCombatant.setAttack(1, attackBonus1.IntValue);
        }

        private void damage2_TextChanged(object sender, EventArgs e)
        {
            // Local combatant variable to store the currently selected combatant
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            selectedCombatant.setDamage(2, damage2.Text); // update combatant's first attack's damage string
        }

        private void incrementDamage2_Click(object sender, EventArgs e)
        {
            updateDamage(damage2, true);
        }

        private void decrementDamage2_Click(object sender, EventArgs e)
        {
            updateDamage(damage2, false);
        }

        private void attackBonus2_TextChanged(object sender, EventArgs e)
        {
            // Local combatant variable to store the currently selected combatant
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            selectedCombatant.setAttack(2, attackBonus2.IntValue);
        }

        private void incrementAttack2_Click(object sender, EventArgs e)
        {
            attackBonus2.IntValue++;
        }

        private void decrementAttack2_Click(object sender, EventArgs e)
        {
            attackBonus2.IntValue--;
        }

        private void incrementAttack3_Click(object sender, EventArgs e)
        {
            attackBonus3.IntValue++;
        }

        private void decrementAttack3_Click(object sender, EventArgs e)
        {
            attackBonus3.IntValue--;
        }

        private void attackBonus3_TextChanged(object sender, EventArgs e)
        {
            // Local combatant variable to store the currently selected combatant
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            selectedCombatant.setAttack(3, attackBonus3.IntValue);
        }

        private void damage3_TextChanged(object sender, EventArgs e)
        {
            // Local combatant variable to store the currently selected combatant
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            selectedCombatant.setDamage(3, damage3.Text); // update combatant's first attack's damage string
        }

        private void incrementDamage3_Click(object sender, EventArgs e)
        {
            updateDamage(damage3, true);
        }

        private void decrementDamage3_Click(object sender, EventArgs e)
        {
            updateDamage(damage3, false);
        }

        private void moveCombatantUp_Click(object sender, EventArgs e)
        {
            // Used to store the selected combatant for quick reference
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
            int currentIndex = combatantList.Items.IndexOf(combatantList.SelectedItem);
            
            // Check that the selected combatant isn't at the top of the list already
            if (currentIndex!=0)
            {
                Combatant previousCombatant = (Combatant)combatantList.Items[currentIndex - 1]; // get data from combatant above current one
                
                // Swap combatants in the list
                combatantList.Items[currentIndex] = previousCombatant;
                combatantList.Items[currentIndex - 1] = selectedCombatant;
            }
        }
    }
}
