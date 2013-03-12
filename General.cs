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

            //combatantList.DrawItem += combatantList_DrawItem;
        }

        /**
         * Custom draw code for the combatant list that draws injured combatants differently.
         * THIS CODE IS INCOMPLETE. IT SHOULDN'T BE USED AS IT IS.
         * @param sender The origin of the event (usually the listbox).
         * @param e The details of the event.
         */
        void combatantList_DrawItem(object sender, DrawItemEventArgs e)
        {
            

            e.DrawBackground();
            Graphics g = e.Graphics;
            Font f = e.Font;
            PointF p = new PointF(e.Bounds.X, e.Bounds.Y);
            ListBox list = (ListBox)sender;
            Boolean bSelected = (e.Index == list.SelectedIndex);
            Combatant currentCombatant = (Combatant)list.Items[e.Index];
            SolidBrush brush = new SolidBrush(e.ForeColor);

            // Decide on default font style and colour
            switch (currentCombatant.status())
            {
                case "healthy":
                    f = e.Font;
                    brush = new SolidBrush(e.ForeColor);
                    break;
                case "injured":
                    f = new Font(e.Font, FontStyle.Bold);
                    brush = new SolidBrush(Color.Yellow);
                    break;
                case "critical":
                    f = new Font(e.Font, FontStyle.Bold);
                    brush = new SolidBrush(Color.Red);
                    break;
                case "player":
                    f = e.Font;
                    brush = new SolidBrush(e.ForeColor);
                    break;
            }

            // if combatant is selected override colour with white and add selection bar
            if (bSelected)
            {
                brush = new SolidBrush(Color.White);
                g.FillRectangle(new SolidBrush(Color.Navy), e.Bounds);
            }
            else
            {
                g.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            }

            g.DrawString(list.Items[e.Index].ToString(), f, brush, p);

            e.DrawFocusRectangle();
        }

        /*
         * Listens to keyboard for shortcuts and then acts accordingly.
         * @param msg No idea. VS created this one automatically.
         * @param keyData Contains the binary data of the key combination pressed.
         * @return Returns true when a key combination is recognised and successfully processed.
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.L))
            {
                if (tabPlayer.SelectedTab == tabPC) listCombatants.Focus();
                else combatantList.Focus();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D))
            {
                if (tabPlayer.SelectedTab == tabDM) delayList.Focus();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Right))
            {
                if (tabPlayer.SelectedTab == tabDM) delayButton.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Left))
            {
                if (tabPlayer.SelectedTab == tabDM) undelayButton.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Up))
            {
                if (tabPlayer.SelectedTab == tabDM) moveCombatantUp.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Down))
            {
                if (tabPlayer.SelectedTab == tabDM) moveCombatantDown.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.U))
            {
                if (tabPlayer.SelectedTab == tabDM) dyingList.Focus();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.K))
            {
                if (tabPlayer.SelectedTab == tabDM) killButton.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                if (tabPlayer.SelectedTab == tabDM) liveButton.PerformClick();
                return true;
            }
            // Ctrl + W (Wound). Opens the Wound Combatant dialog.
            else if (keyData == (Keys.Control | Keys.W))
            {
                if (tabPlayer.SelectedTab == tabDM)
                {
                    WoundCombatant woundDialog = new WoundCombatant(this);
                    woundDialog.Show();
                }
            }
            // Ctrl + N (New round). Increments the round number and selects the topmost combatant.
            else if (keyData == (Keys.Control | Keys.N))
            {
                if (tabPlayer.SelectedTab == tabDM)
                {
                    roundNumber.Value++; // increment the round number
                    combatantList.SelectedIndex = 0; // select the first combatant in the initiative order
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: battle file export. Probably a basically File stream that prints to a
            // file in basic unicode with custom delimiters. The file will need to store all data
            // for all combatants, their condition (fighting, delaying, or dying), their order in
            // these lists, and of course the round number.
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
            // Make sure a combatant is selected
            if (combatantList.SelectedIndex != -1)
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
                    if (selectedCombatant.getCurrentHP() < 0) combatantHPBar.Value = 0;
                    else combatantHPBar.Value = selectedCombatant.getCurrentHP();

                    remainingHP.Visible = true;
                    remainingHP.Text = selectedCombatant.getCurrentHP() + " / " + selectedCombatant.getMaxHP();

                    HPChange.Visible = true;
                    HPChange.Enabled = true;
                    healButton.Visible = true;
                    healButton.Enabled = true;
                    damageButton.Visible = true;
                    damageButton.Enabled = true;
                    HPLabel.Visible = true;
                }
                else
                {
                    combatantHPBar.Visible = false;
                    HPChange.Visible = false;
                    healButton.Visible = false;
                    damageButton.Visible = false;
                    remainingHP.Visible = false;
                    HPLabel.Visible = false;
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

                //combatantList_DrawItem(combatantList, null); // redraw listBox
            }
            else
            {
                // Otherwise deactivate controls
                combatantHPBar.Visible = false;
                HPChange.Visible = false;
                healButton.Visible = false;
                damageButton.Visible = false;
                remainingHP.Visible = false;
                HPLabel.Visible = false;

                labelCombatantName.Text = String.Empty;

                attackBonus1.IntValue = 0;
                damage1.Text = String.Empty;
                attackBonus1.Enabled = false;
                damage1.Enabled = false;
                incrementAttack1.Enabled = false;
                decrementAttack1.Enabled = false;
                incrementDamage1.Enabled = false;
                decrementDamage1.Enabled = false;

                attackBonus2.IntValue = 0;
                damage2.Text = String.Empty;
                attackBonus2.Enabled = false;
                damage2.Enabled = false;
                incrementAttack2.Enabled = false;
                decrementAttack2.Enabled = false;
                incrementDamage2.Enabled = false;
                decrementDamage2.Enabled = false;

                attackBonus3.IntValue = 0;
                damage3.Text = String.Empty;
                attackBonus3.Enabled = false;
                damage3.Enabled = false;
                incrementAttack3.Enabled = false;
                decrementAttack3.Enabled = false;
                incrementDamage3.Enabled = false;
                decrementDamage3.Enabled = false;
            }
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

            if (selectedCombatant.getCurrentHP() < 0) combatantHPBar.Value = 0;
            else combatantHPBar.Value = selectedCombatant.getCurrentHP(); // update the HP bar
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
            // If a combatant is selected...
            if (combatantList.SelectedIndex != -1)
            {
                // Local combatant variable to store the currently selected combatant
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

                selectedCombatant.setDamage(1, damage1.Text); // update combatant's first attack's damage string
            }
        }

        private void attackBonus1_TextChanged(object sender, EventArgs e)
        {
            // If a combatant is selected...
            if (combatantList.SelectedIndex != -1)
            {
                // Local combatant variable to store the currently selected combatant
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

                selectedCombatant.setAttack(1, attackBonus1.IntValue);
            }
        }

        private void damage2_TextChanged(object sender, EventArgs e)
        {
            // If a combatant is selected...
            if (combatantList.SelectedIndex != -1)
            {
                // Local combatant variable to store the currently selected combatant
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

                selectedCombatant.setDamage(2, damage2.Text); // update combatant's first attack's damage string
            }
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
            // If a combatant is selected...
            if (combatantList.SelectedIndex != -1)
            {
                // Local combatant variable to store the currently selected combatant
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

                selectedCombatant.setAttack(2, attackBonus2.IntValue);
            }
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
            // If a combatant is selected...
            if (combatantList.SelectedIndex != -1)
            {
                // Local combatant variable to store the currently selected combatant
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

                selectedCombatant.setAttack(3, attackBonus3.IntValue);
            }
        }

        private void damage3_TextChanged(object sender, EventArgs e)
        {
            // If a combatant is selected...
            if (combatantList.SelectedIndex != -1)
            {
                // Local combatant variable to store the currently selected combatant
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

                selectedCombatant.setDamage(3, damage3.Text); // update combatant's first attack's damage string
            }
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
            // Make sure a combatant is selected
            if (combatantList.SelectedIndex != -1)
            {
                // Used to store the selected combatant for quick reference
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
                int currentIndex = combatantList.Items.IndexOf(combatantList.SelectedItem);

                // Check that the selected combatant isn't at the top of the list already
                if (currentIndex != 0)
                {
                    // Swap combatants in the list
                    combatantList.Items.RemoveAt(currentIndex);
                    combatantList.Items.Insert((currentIndex - 1), selectedCombatant);
                    combatantList.SelectedIndex = (currentIndex - 1); // re-select the moved combatant
                }
            }
        }

        private void moveCombatantDown_Click(object sender, EventArgs e)
        {
            // Make sure a combatant is selected
            if (combatantList.SelectedIndex != -1)
            {
                // Used to store the selected combatant for quick reference
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
                int currentIndex = combatantList.Items.IndexOf(combatantList.SelectedItem);

                // Check that the selected combatant isn't at the bottom of the list already
                if (currentIndex != (combatantList.Items.Count - 1))
                {
                    // Swap combatants in the list
                    combatantList.Items.RemoveAt(currentIndex);
                    combatantList.Items.Insert((currentIndex + 1), selectedCombatant);
                    combatantList.SelectedIndex = (currentIndex + 1); // re-select the moved combatant
                }
            }
        }

        private void delayButton_Click(object sender, EventArgs e)
        {
            // Make sure a combatant is selected
            if (combatantList.SelectedIndex != -1)
            {
                // Used to store the selected combatant for quick reference
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
                int currentIndex = combatantList.Items.IndexOf(combatantList.SelectedItem);

                // Pull selected combatant from combatant list into delay list
                combatantList.Items.RemoveAt(currentIndex);
                delayList.Items.Add(selectedCombatant);
                
                // If there's no combatant selected in the delay list, select the most recently added one.
                if (delayList.SelectedIndex == -1) delayList.SelectedIndex = (delayList.Items.Count - 1);
                
                // If there's a combatant directly after the delaying one, select it. Select the last combatant in the list otherwise.
                if (currentIndex <= (combatantList.Items.Count - 1)) combatantList.SelectedIndex = currentIndex;
                else combatantList.SelectedIndex = (combatantList.Items.Count - 1);
            }
        }

        private void undelayButton_Click(object sender, EventArgs e)
        {
            // Make sure a combatant is selected
            if (delayList.SelectedIndex != -1)
            {
                // Used to store the selected combatant for quick reference
                Combatant selectedCombatant = (Combatant)delayList.SelectedItem;
                int currentIndex;
                if (combatantList.SelectedIndex != -1) currentIndex = combatantList.Items.IndexOf(combatantList.SelectedItem);
                else currentIndex = 0;
                int delayIndex = delayList.Items.IndexOf(delayList.SelectedItem);

                // Push selected from delay list into combatant list
                combatantList.Items.Insert(currentIndex, selectedCombatant);
                delayList.Items.RemoveAt(delayIndex);
                combatantList.SelectedIndex = (currentIndex); // select the combatant that just un-delayed
                
                // If there's a combatant below the one we just removed in the delay list, select it. Select that last combatant in the delay list otherwise.
                if (delayIndex < delayList.Items.Count) delayList.SelectedIndex = delayIndex;
                else delayList.SelectedIndex = (delayList.Items.Count - 1);
            }
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            // Make sure a combatant is selected
            if (combatantList.SelectedIndex != -1)
            {
                // Used to store the selected combatant for quick reference
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
                int currentIndex = combatantList.Items.IndexOf(combatantList.SelectedItem);

                // Pull selected combatant from combatant list into dying list
                combatantList.Items.RemoveAt(currentIndex);
                dyingList.Items.Add(selectedCombatant);

                // If there's no combatant selected in the dying list, select the most recently added one.
                if (dyingList.SelectedIndex == -1) dyingList.SelectedIndex = (dyingList.Items.Count - 1);

                // If there's a combatant directly after the dying one, select it. Select the last combatant in the list otherwise.
                if (currentIndex <= (combatantList.Items.Count - 1)) combatantList.SelectedIndex = currentIndex;
                else combatantList.SelectedIndex = (combatantList.Items.Count - 1);
            }
        }

        private void liveButton_Click(object sender, EventArgs e)
        {
            // Make sure a combatant is selected
            if (dyingList.SelectedIndex != -1)
            {
                // Used to store the selected combatant for quick reference
                Combatant selectedCombatant = (Combatant)dyingList.SelectedItem;
                int currentIndex;
                if (combatantList.SelectedIndex != -1) currentIndex = combatantList.Items.IndexOf(combatantList.SelectedItem);
                else currentIndex = 0;
                int dyingIndex = dyingList.Items.IndexOf(dyingList.SelectedItem);

                // Push selected from dying list into combatant list
                combatantList.Items.Insert(currentIndex, selectedCombatant);
                dyingList.Items.RemoveAt(dyingIndex);
                combatantList.SelectedIndex = (currentIndex); // select the combatant that just regained consciousness

                // If there's a combatant below the one we just removed in the dying list, select it. Select that last combatant in the dying list otherwise.
                if (dyingIndex < dyingList.Items.Count) dyingList.SelectedIndex = dyingIndex;
                else dyingList.SelectedIndex = (dyingList.Items.Count - 1);
            }
        }
    }
}
