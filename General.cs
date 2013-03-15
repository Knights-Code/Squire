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
        ContextMenuStrip dyingListContextMenu;
        decimal currentRound;
        ToolTip generalToolTip;
        Combatant toolTipCombatant;
        Point toolTipLocation;

        public General()
        {
            InitializeComponent();

            //-----( Initialise Components )-----\\
            combatantHPBar = new HPBar();
            combatantHPBar.Parent = tableLayoutPanel12;
            combatantHPBar.Dock = DockStyle.Fill;
            dyingListContextMenu = new ContextMenuStrip();
            dyingListContextMenu.RenderMode = generalMenu.RenderMode;
            dyingListContextMenu.Opening += new CancelEventHandler(dyingListContextMenu_Opening);
            generalToolTip = new ToolTip();
            //generalToolTip.Draw += new DrawToolTipEventHandler(generalToolTip_Draw);
            generalToolTip.Active = false;
            dyingList.MouseMove += new MouseEventHandler(initiative_MouseMove);
            delayList.MouseMove += new MouseEventHandler(initiative_MouseMove);
            this.MouseMove += new MouseEventHandler(General_MouseMove);
            //dyingList.MouseLeave += new EventHandler(initiative_MouseLeave);

            //-----( Initialise Variables )-----\\
            currentRound = roundNumber.Value;

            //-----( Event Handlers )-----\\
            dyingList.MouseDown += new MouseEventHandler(dyingList_MouseDown);
            dyingList.DrawItem += new DrawItemEventHandler(initiative_DrawItem);
            combatantList.DrawItem += initiative_DrawItem;
            delayList.DrawItem += initiative_DrawItem;
        }

        void General_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(((dyingList.Bounds.X < e.Location.X) && (e.Location.X < dyingList.Bounds.X + dyingList.Bounds.Width)) && ((dyingList.Bounds.Y < e.Location.Y) && (e.Location.Y < dyingList.Bounds.Y + dyingList.Bounds.Height))))
            {
                generalToolTip.Active = false;
            }
        }

        void initiative_MouseLeave(object sender, EventArgs e)
        {
            ListBox focalList = (ListBox)sender;

            // Has the mouse -really- left?
            //if (toolTipCombatant == null)
            //{
                generalToolTip.Active = false;
                toolTipCombatant = null;
                Console.WriteLine("Mouse leaving " + sender.ToString());
            //}
        }

        public void initiative_MouseMove(object sender, MouseEventArgs e)
        {
            ListBox focalList = (ListBox)sender;

            // Make sure we're hovering over a combatant
            if (focalList.IndexFromPoint(e.Location) >= 0 && focalList.IndexFromPoint(e.Location) < focalList.Items.Count )
            {
                generalToolTip.Active = true;

                // stops reloading tooltip repeatedly causing flickering
                if (toolTipCombatant == null || e.Location != toolTipLocation)
                {
                    Combatant focalCombatant = (Combatant)focalList.Items[focalList.IndexFromPoint(e.Location)];

                    // Players don't have HP listed
                    if (!focalCombatant.isPlayer())
                    {
                        generalToolTip.ToolTipTitle = (focalCombatant + " HP");
                        generalToolTip.Show((focalCombatant.getCurrentHP() + " / " + focalCombatant.getMaxHP()), focalList, e.Location.X,(e.Location.Y+20));

                        toolTipCombatant = focalCombatant;
                        toolTipLocation = e.Location;
                    }
                }
            }
            else
            {
                generalToolTip.Active = false;
                toolTipCombatant = null;
            }
        }

        void generalToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();

            // Determine the combatant we're hovering over
            //ListBox list = (ListBox)sender;
            //Console.WriteLine("Focal list is " + list);
            dyingList.Focus();
            Console.WriteLine("Focal index is: " + dyingList.IndexFromPoint(Cursor.Position));
            Combatant focalCombatant = (Combatant)dyingList.Items[dyingList.IndexFromPoint(Cursor.Position)];
            Console.WriteLine("Focal combatant is: " + focalCombatant);

            generalToolTip.ToolTipTitle = (focalCombatant+" HP");
            generalToolTip.SetToolTip(dyingList, (focalCombatant.getCurrentHP() + " / " + focalCombatant.getMaxHP()));
            e.DrawText();
        }

        public void initiative_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (list.Items.Count > 0)
            {
                e.DrawBackground();
                Graphics g = e.Graphics;
                Font f = e.Font;
                PointF p = new PointF(e.Bounds.X, e.Bounds.Y);
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
                        brush = new SolidBrush(Color.Gold);
                        break;
                    case "critical":
                        f = new Font(e.Font, FontStyle.Bold);
                        brush = new SolidBrush(Color.Red);
                        break;
                    case "dead":
                        f = new Font(e.Font, FontStyle.Bold);
                        brush = new SolidBrush(Color.Gray);
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
                    g.FillRectangle(new SolidBrush(SystemColors.Highlight), e.Bounds);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                }

                g.DrawString(list.Items[e.Index].ToString(), f, brush, p);

                e.DrawFocusRectangle();
            }
        }

        void dyingListContextMenu_Opening(object sender, CancelEventArgs e)
        {
            Combatant casualty = (Combatant)dyingList.SelectedItem;
            ToolStripMenuItem stabilise = new ToolStripMenuItem("Stabilise", null, new EventHandler(stabiliseCasualty));
            stabilise.Enabled = casualty.isStable() ? false : true;

            dyingListContextMenu.Items.Clear();
            dyingListContextMenu.Items.Add(stabilise);
        }

        void stabiliseCasualty(object sender, EventArgs e)
        {
            Combatant casualty = (Combatant)dyingList.SelectedItem;
            casualty.setStable(true);
        }

        void dyingList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dyingList.SelectedIndex = dyingList.IndexFromPoint(e.Location);

                if (dyingList.SelectedIndex != -1) dyingListContextMenu.Show(Cursor.Position);
            }
        }

        /*
         * Listens to keyboard for shortcuts and then acts accordingly.
         * @param msg No idea. VS created this one automatically.
         * @param keyData Contains the binary data of the key combination pressed.
         * @return Returns true when a key combination is recognised and successfully processed.
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Interpret the key data. Should really rewrite this as a switch/case.

            // Ctrl + L (List). Puts focus on the initiative list.
            if (keyData == (Keys.Control | Keys.L))
            {
                if (tabPlayer.SelectedTab == tabPC) listCombatants.Focus();
                else combatantList.Focus();
                return true;
            }
            // Ctrl + D (Delay). Puts focus on the delay list.
            else if (keyData == (Keys.Control | Keys.D))
            {
                if (tabPlayer.SelectedTab == tabDM) delayList.Focus();
                return true;
            }
            // Ctrl + -> (Right). Removes selected combatant from the initiative order and puts them in the delay list.
            else if (keyData == (Keys.Control | Keys.Right))
            {
                if (tabPlayer.SelectedTab == tabDM) delayButton.PerformClick();
                return true;
            }
            // Ctrl + <- (Left). Removes selected combatant from the delay list and inserts them in the initiative list.
            else if (keyData == (Keys.Control | Keys.Left))
            {
                if (tabPlayer.SelectedTab == tabDM) undelayButton.PerformClick();
                return true;
            }
            // Ctrl + ^ (Up). Moves combatant up in the initiative list.
            else if (keyData == (Keys.Control | Keys.Up))
            {
                if (tabPlayer.SelectedTab == tabDM) moveCombatantUp.PerformClick();
                return true;
            }
            // Ctrl + v (Down). Moves combatant down in the initiative list.
            else if (keyData == (Keys.Control | Keys.Down))
            {
                if (tabPlayer.SelectedTab == tabDM) moveCombatantDown.PerformClick();
                return true;
            }
            // Ctrl + U (Unconscious). Puts focus on the dying list.
            else if (keyData == (Keys.Control | Keys.U))
            {
                if (tabPlayer.SelectedTab == tabDM) dyingList.Focus();
                return true;
            }
            // Ctrl + K (Kill). Moves selected combatant to the dying list.
            else if (keyData == (Keys.Control | Keys.K))
            {
                if (tabPlayer.SelectedTab == tabDM) killButton.PerformClick();
                return true;
            }
            // Ctrl + R (Revive). Moves selected combatant from the dying list to the initiative list.
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
                    if (combatantList.SelectedIndex != -1)
                    {
                        WoundCombatant woundDialog = new WoundCombatant(this);
                        woundDialog.Show();
                    }
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
            // TODO: battle file export. Probably a basic File stream that prints to a
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
                    manualCurrentButton.Visible = true;
                    manualCurrentButton.Enabled = true;
                    manualMaxButton.Visible = true;
                    manualMaxButton.Enabled = true;
                }
                else
                {
                    combatantHPBar.Visible = false;
                    HPChange.Visible = false;
                    healButton.Visible = false;
                    damageButton.Visible = false;
                    remainingHP.Visible = false;
                    HPLabel.Visible = false;
                    manualCurrentButton.Visible = false;
                    manualCurrentButton.Enabled = false;
                    manualMaxButton.Visible = false;
                    manualMaxButton.Enabled = false;
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

                combatantList.Refresh();
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

        private void roundNumber_ValueChanged(object sender, EventArgs e)
        {
            // Check that we've just proceeded to the next round.
            if (roundNumber.Value == (currentRound + 1))
            {
                // Handle the dead and dying.
                if (dyingList.Items.Count > 0)
                {
                    // Display a dialog for each dying (not dead) combatant asking if they stabilise.
                    for (int i = 0; i < dyingList.Items.Count; i++)
                    {
                        Combatant casualty = (Combatant)dyingList.Items[i];

                        if (!casualty.isPlayer() && casualty.status() != "dead" && !casualty.isStable())
                        {
                            if (MessageBox.Show(casualty + "'s HP is at " + casualty.getCurrentHP() + ". Do they stabilise?", "Stabilise " + casualty + "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) casualty.setStable(true);
                            else casualty.setCurrentHP(casualty.getCurrentHP() - 1);
                        }

                        dyingList.Refresh();
                    }
                }
            }

            this.currentRound = roundNumber.Value;
        }

        private void manualCurrentButton_Click(object sender, EventArgs e)
        {
            // Make sure a combatant is selected
            if (combatantList.SelectedIndex != -1)
            {
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
                selectedCombatant.setCurrentHP(HPChange.IntValue);

                HPChange.IntValue = 0;

                combatantHPBar.Value = selectedCombatant.getCurrentHP(); // update the HP bar

                remainingHP.Text = selectedCombatant.getCurrentHP() + " / " + selectedCombatant.getMaxHP(); // update HP label
            }
        }

        private void manualMaxButton_Click(object sender, EventArgs e)
        {
            // Make sure a combatant is selected
            if (combatantList.SelectedIndex != -1)
            {
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
                selectedCombatant.setMaxHP(HPChange.IntValue);

                // If new max is lower than current HP, change current HP to match
                if (selectedCombatant.getCurrentHP() > selectedCombatant.getMaxHP()) selectedCombatant.setCurrentHP(selectedCombatant.getMaxHP());

                HPChange.IntValue = 0;

                combatantHPBar.Maximum = selectedCombatant.getMaxHP();
                combatantHPBar.Value = selectedCombatant.getCurrentHP(); // update the HP bar

                remainingHP.Text = selectedCombatant.getCurrentHP() + " / " + selectedCombatant.getMaxHP(); // update HP label
            }
        }

        private void dyingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dyingList.Refresh();
        }

        private void delayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            delayList.Refresh();
        }
    }
}
