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
        public General()
        {
            InitializeComponent();
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
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
            combatantHPBar.Maximum = selectedCombatant.getMaxHP();
            combatantHPBar.Minimum = 0;
            combatantHPBar.Value = selectedCombatant.getCurrentHP();

            remainingHP.Text = selectedCombatant.getCurrentHP() + " / " + selectedCombatant.getMaxHP();
            labelCombatantName.Text = selectedCombatant.getName();
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
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine("Match reads: " + match.Groups[i].Value);
                }
                dieCount = Convert.ToInt32(match.Groups[1].Value);
                dieType = Convert.ToInt32(match.Groups[2].Value);
                bonus = Convert.ToInt32(match.Groups[3].Value);

                bonus+=(bUp?1:-1); // increase the bonus

                damage.Text = (dieCount + "d" + dieType + "+" + bonus); // update the damage string
            }
        }

        private void decrementDamage1_Click(object sender, EventArgs e)
        {
            updateDamage(damage1, false);
        }
    }
}
