using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;

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
        Boolean fileLoading;
        Boolean changesSaved;

        enum LoadProgress { START, INITIATIVE, DELAY, DYING, INDICES };

        public General()
        {
            InitializeComponent();

            //-----( Initialise Components )-----\\
            combatantHPBar = new HPBar();
            combatantHPBar.Parent = tableLayoutPanel12;
            combatantHPBar.Dock = DockStyle.Fill;
            dyingListContextMenu = new ContextMenuStrip();
            dyingListContextMenu.RenderMode = generalMenu.RenderMode;
            
            generalToolTip = new ToolTip();
            generalToolTip.Active = false;
            
            //-----( Initialise Variables )-----\\
            currentRound = roundNumber.Value;
            fileLoading = false;
            changesSaved = true;

            //-----( Event Handlers )-----\\
            dyingList.LostFocus += dyingList_LostFocus;
            delayList.MouseMove += new MouseEventHandler(initiative_MouseMove);
            this.MouseMove += new MouseEventHandler(General_MouseMove);
            combatantList.KeyPress += new KeyPressEventHandler(initiative_KeyPress);
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            dyingList.MouseMove += new MouseEventHandler(initiative_MouseMove);
            dyingListContextMenu.Opening += new CancelEventHandler(dyingListContextMenu_Opening);
            dyingList.MouseDown += new MouseEventHandler(dyingList_MouseDown);
            dyingList.DrawItem += new DrawItemEventHandler(initiative_DrawItem);
            combatantList.DrawItem += initiative_DrawItem;
            delayList.DrawItem += initiative_DrawItem;
        }

        void dyingList_LostFocus(object sender, EventArgs e)
        {
            dyingList.SelectedIndex = -1;
        }

        /// If we don't want a list box to interpret the keyboard and select different items accordingly, overload the keypress event handler
        /// and handle the event ourselves (by just telling the system it's been dealt with).
        void initiative_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
                        generalToolTip.Show((focalCombatant.getCurrentHP() + " / " + focalCombatant.getMaxHP()) + (focalCombatant.isStable()?" (stable)":String.Empty), focalList, e.Location.X,(e.Location.Y+20));

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
                    if (currentCombatant.status() == "healthy")
                        g.FillRectangle(new SolidBrush(SystemColors.Highlight), e.Bounds);
                    else
                    {
                        switch (currentCombatant.status())
                        {
                            case "injured":
                                g.FillRectangle(new SolidBrush(Color.Orange), e.Bounds);
                                break;
                            case "critical":
                                g.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
                                break;
                            case "dead":
                                g.FillRectangle(new SolidBrush(Color.Gray), e.Bounds);
                                break;
                        }
                    }
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
            ToolStripMenuItem delete = new ToolStripMenuItem("Delete", null, new EventHandler(deleteCasualty));
            stabilise.Enabled = !casualty.isStable();

            dyingListContextMenu.Items.Clear();
            dyingListContextMenu.Items.Add(stabilise);
            dyingListContextMenu.Items.Add(delete);
        }

        private void deleteCasualty(object sender, EventArgs e)
        {
            dyingList.Items.Remove(dyingList.SelectedItem);
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
            switch (keyData)
            {
                // Ctrl + L (List). Puts focus on the initiative list.
                case (Keys.Control | Keys.L):
                    combatantList.Focus();
                    return true;
                    break;
                // Ctrl + D (Delay). Puts focus on the delay list.
                case (Keys.Control | Keys.D):
                    if (tabPlayer.SelectedTab == tabDM) delayList.Focus();
                    return true;
                    break;
                // Ctrl + -> (Right). Removes selected combatant from the initiative order and puts them in the delay list.
                case (Keys.Control | Keys.Right):
                    if (tabPlayer.SelectedTab == tabDM) delayButton.PerformClick();
                    return true;
                    break;
                // Ctrl + <- (Left). Removes selected combatant from the delay list and inserts them in the initiative list.
                case (Keys.Control | Keys.Left):
                    if (tabPlayer.SelectedTab == tabDM) undelayButton.PerformClick();
                    return true;
                    break;
                // Ctrl + ^ (Up). Moves combatant up in the initiative list.
                case (Keys.Control | Keys.Up):
                    if (tabPlayer.SelectedTab == tabDM) moveCombatantUp.PerformClick();
                    return true;
                    break;
                // Ctrl + v (Down). Moves combatant down in the initiative list.
                case (Keys.Control | Keys.Down):
                    if (tabPlayer.SelectedTab == tabDM) moveCombatantDown.PerformClick();
                    return true;
                    break;
                // Ctrl + U (Unconscious). Puts focus on the dying list.
                case (Keys.Control | Keys.U):
                    if (tabPlayer.SelectedTab == tabDM) dyingList.Focus();
                    return true;
                    break;
                // Ctrl + K (Kill). Moves selected combatant to the dying list.
                case (Keys.Control | Keys.K):
                    if (tabPlayer.SelectedTab == tabDM) killButton.PerformClick();
                    return true;
                    break;
                // Ctrl + R (Revive). Moves selected combatant from the dying list to the initiative list.
                case (Keys.Control | Keys.R):
                    if (tabPlayer.SelectedTab == tabDM) liveButton.PerformClick();
                    return true;
                    break;
                // Ctrl + W (Wound). Opens the Wound Combatant dialog.
                case (Keys.Control | Keys.W):
                    if (tabPlayer.SelectedTab == tabDM)
                    {
                        if (combatantList.SelectedIndex != -1)
                        {
                            WoundCombatant woundDialog = new WoundCombatant(this);
                            woundDialog.Show();
                        }
                    }
                    break;
                // Ctrl + N (New round). Increments the round number and selects the topmost combatant.
                case (Keys.Control | Keys.N):
                    if (tabPlayer.SelectedTab == tabDM)
                    {
                        roundNumber.Value++; // increment the round number
                        combatantList.SelectedIndex = 0; // select the first combatant in the initiative order
                    }
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openBattle = new OpenFileDialog();
            openBattle.DefaultExt = ".btl";
            openBattle.Filter = "Battle Files (*.btl)|*btl|All files (*.*)|*.*";
            openBattle.Title = "Open Battle";

            if (openBattle.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(openBattle.FileName);
                fileLoading = true; // lock down for load

                string currentLine;
                LoadProgress filePosition = LoadProgress.START;

                while ((currentLine = file.ReadLine()) != null )
                {
                    if (currentLine != String.Empty)
                    {
                        switch (currentLine)
                        {
                            case "Initiative List":
                                filePosition = LoadProgress.INITIATIVE;
                                currentLine = file.ReadLine();
                                break;
                            case "Delay List":
                                filePosition = LoadProgress.DELAY;
                                currentLine = file.ReadLine();
                                break;
                            case "Dying List":
                                filePosition = LoadProgress.DYING;
                                currentLine = file.ReadLine();
                                break;
                            case "Indices":
                                filePosition = LoadProgress.INDICES;
                                currentLine = file.ReadLine();
                                break;
                        }

                        if (filePosition != LoadProgress.INDICES)
                        {
                            if (currentLine != String.Empty)
                            {
                                string[] items = currentLine.Split('\t');

                                Combatant newCombatant = new Combatant(items[0], int.Parse(items[2]), Convert.ToDecimal(items[3]));
                                newCombatant.setCurrentHP(int.Parse(items[1]));

                                // Process effects.
                                for (int i = 5; i < (int.Parse(items[4]) * 2) + 5; i += 2)
                                    newCombatant.addEffect(items[i], Convert.ToDecimal(items[i + 1]));

                                switch (filePosition)
                                {
                                    case LoadProgress.INITIATIVE:
                                        combatantList.Items.Add(newCombatant);
                                        break;
                                    case LoadProgress.DELAY:
                                        delayList.Items.Add(newCombatant);
                                        break;
                                    case LoadProgress.DYING:
                                        dyingList.Items.Add(newCombatant);
                                        break;
                                }
                            }
                        }
                        else
                        {
                            string[] items = currentLine.Split('\t');
                            combatantList.SelectedIndex = int.Parse(items[0]);
                            delayList.SelectedIndex = int.Parse(items[1]);
                            dyingList.SelectedIndex = int.Parse(items[2]);
                            roundNumber.Value = Convert.ToDecimal(items[3]);
                        }
                    }
                }

                file.Close();
                fileLoading = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveBattle = new SaveFileDialog();
            saveBattle.DefaultExt = ".btl";
            saveBattle.Filter = "Battle Files (*.btl)|*btl|All files (*.*)|*.*";
            saveBattle.OverwritePrompt = true;
            saveBattle.Title = "Save Battle";

            if (saveBattle.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveBattle.FileName);

                file.WriteLine("Initiative List");
                for (int i = 0; i < combatantList.Items.Count; i++)
                {
                    Combatant c = (Combatant)combatantList.Items[i];
                    file.WriteLine(c.toString());
                }

                file.WriteLine();
                file.WriteLine("Delay List");
                for (int i = 0; i < delayList.Items.Count; i++)
                {
                    Combatant c = (Combatant)delayList.Items[i];
                    file.WriteLine(c.toString());
                }

                file.WriteLine();
                file.WriteLine("Dying List");
                for (int i = 0; i < dyingList.Items.Count; i++)
                {
                    Combatant c = (Combatant)dyingList.Items[i];
                    file.WriteLine(c.toString());
                }

                file.WriteLine();
                file.WriteLine("Indices");
                file.WriteLine(combatantList.SelectedIndex + "\t" + delayList.SelectedIndex + "\t" + dyingList.SelectedIndex +"\t"+roundNumber.Value);

                file.Close();
            }
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

                // Combatant's Name
                labelCombatantName.Text = selectedCombatant.getName();

                // Attack Group
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

                // Effects Group
                // Destroy and rebuild table, adding the combatant's active effects afterward.
                destroyAndRebuild(effectsTable);

                ArrayList indexToDelete = new ArrayList();

                // Check for any effects expiring and prompt user to remove them.
                for (int j = 0; j < selectedCombatant.EffectCount; j++)
                {
                    if (selectedCombatant.getEffectDuration(j) == 0)
                    {
                        if (MessageBox.Show("Effect duration of " + selectedCombatant.getEffectName(j) + " has reached zero."
                            + " Remove from effect list?", "Effect on Combatant \"" +
                            selectedCombatant + "\" Expiring", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                            indexToDelete.Add(j);
                    }
                }

                for (int j = indexToDelete.Count - 1; j > -1; j--)
                    selectedCombatant.removeEffect((int)indexToDelete[j]);

                destroyAndRebuild(effectsTable);

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

                newEffectButton.Enabled = false;
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

                // If there's a combatant selected in the dying list, deselect.
                dyingList.SelectedIndex = -1;

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
            // Check that we've just proceeded to the next round. Ignore changes by open menu
            // item because it's just loading in data and doesn't reflect actual round changes.
            if (roundNumber.Value == (currentRound + 1) && !fileLoading)
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

                // Handle effects by reducing the rounds remaining on each one by 1 round.
                for (int i = 0; i < combatantList.Items.Count; i++)
                {
                    Combatant currentCombatant = (Combatant)combatantList.Items[i];

                    // Check that the combatant has effects to update.
                    if (currentCombatant.EffectCount > 0)
                    {
                        // Reduce each effect's duration by 1 if it hasn't already reached 0.
                        for (int j = 0; j < currentCombatant.EffectCount; j++)
                            currentCombatant.setEffectDuration((currentCombatant.getEffectDuration(j) > 0) ? (currentCombatant.getEffectDuration(j) - 1) : 0, j);
                    }
                }

                for (int i = 0; i < delayList.Items.Count; i++)
                {
                    Combatant currentCombatant = (Combatant)delayList.Items[i];

                    // Check that the combatant has effects to update.
                    if (currentCombatant.EffectCount > 0)
                    {
                        // Reduce each effect's duration by 1 if it hasn't already reached 0.
                        for (int j = 0; j < currentCombatant.EffectCount; j++)
                            currentCombatant.setEffectDuration((currentCombatant.getEffectDuration(j) > 0) ? (currentCombatant.getEffectDuration(j) - 1) : 0, j);
                    }
                }

                for (int i = 0; i < dyingList.Items.Count; i++)
                {
                    Combatant currentCombatant = (Combatant)dyingList.Items[i];

                    // Check that the combatant has effects to update.
                    if (currentCombatant.EffectCount > 0)
                    {
                        // Reduce each effect's duration by 1 if it hasn't already reached 0.
                        for (int j = 0; j < currentCombatant.EffectCount; j++)
                            currentCombatant.setEffectDuration((currentCombatant.getEffectDuration(j) > 0) ? (currentCombatant.getEffectDuration(j) - 1) : 0, j);
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
                try
                {
                    Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

                    // If the user tries to set current hp to a value higher than max, stop 'em
                    if (HPChange.IntValue <= selectedCombatant.getMaxHP()) selectedCombatant.setCurrentHP(HPChange.IntValue);
                    else MessageBox.Show("Current HP can't be higher than max HP!", "Error: Value Exceeds Maximum", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    HPChange.IntValue = 0;

                    combatantHPBar.Value = selectedCombatant.getCurrentHP() < 0 ? 0 : selectedCombatant.getCurrentHP(); // update the HP bar

                    remainingHP.Text = selectedCombatant.getCurrentHP() + " / " + selectedCombatant.getMaxHP(); // update HP label
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void manualMaxButton_Click(object sender, EventArgs e)
        {
            // Make sure a combatant is selected
            if (combatantList.SelectedIndex != -1)
            {
                try
                {
                    if (HPChange.IntValue > 0)
                    {
                        Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
                        int difference = 0;
                        difference = HPChange.IntValue - selectedCombatant.getMaxHP();
                        selectedCombatant.setMaxHP(HPChange.IntValue);

                        // Keep current HP in line.
                        selectedCombatant.setCurrentHP(selectedCombatant.getCurrentHP() + difference);

                        HPChange.IntValue = 0;

                        combatantHPBar.Maximum = selectedCombatant.getMaxHP();
                        combatantHPBar.Value = selectedCombatant.getCurrentHP(); // update the HP bar

                        remainingHP.Text = selectedCombatant.getCurrentHP() + " / " + selectedCombatant.getMaxHP(); // update HP label
                    }
                    else
                        MessageBox.Show("New maximum must be greater than zero.", "Error: Invalid Maximum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void newEffectButton_Click(object sender, EventArgs e)
        {
            effectsTable.RowCount++;
            TextBox effectName = new TextBox();
            NumericUpDown roundsRemaining = new NumericUpDown();
            CheckBox bDelete = new CheckBox();
            
            roundsRemaining.Value = 0;
            roundsRemaining.Width = 35;
            roundsRemaining.Anchor = AnchorStyles.Left;
            roundsRemaining.Anchor = AnchorStyles.Top;
            roundsRemaining.ValueChanged += new EventHandler(roundsRemaining_ValueChanged);
            roundsRemaining.Enabled = false;
            
            effectName.Dock = DockStyle.Fill;
            effectName.TextChanged += new EventHandler(effectName_TextChanged);

            bDelete.Anchor = AnchorStyles.None;
            bDelete.CheckedChanged += new EventHandler(bDelete_CheckedChanged);
            bDelete.Enabled = false;

            bDelete.Parent = effectsTable;
            effectName.Parent = effectsTable;
            roundsRemaining.Parent = effectsTable;

            newEffectButton.Enabled = false;
        }

        void effectName_TextChanged(object sender, EventArgs e)
        {
            // Store current effect data and selected combatant for quick reference.
            TextBox focalEffect = (TextBox)sender;
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
            NumericUpDown focalDuration;
            CheckBox focalCheckBox;

            // Determine zero-based row index of current effect.
            int effectIndex = (effectsTable.GetPositionFromControl(focalEffect).Row - 1);
            int focalRow = effectsTable.GetPositionFromControl(focalEffect).Row;
            focalDuration = (NumericUpDown)effectsTable.GetControlFromPosition(2, focalRow);
            focalCheckBox = (CheckBox)effectsTable.GetControlFromPosition(0, focalRow);

            // Modify the respective effect data in the combatant.
            // Check if there are existing effects already.
            if (selectedCombatant.EffectCount > 0)
            {
                // Check if we're modifying an existing effect or adding a new one.
                if (effectIndex < selectedCombatant.EffectCount) selectedCombatant.setEffectName(focalEffect.Text, effectIndex);
                else selectedCombatant.addEffect(focalEffect.Text, 0);
            }
            else
            {
                selectedCombatant.addEffect(focalEffect.Text, 0);
            }

            // If there's text in the box, unlock duration, selection box, and "New" button.
            if (focalEffect.Text.Length > 0)
            {
                focalDuration.Enabled = true;
                focalCheckBox.Enabled = true;
                newEffectButton.Enabled = true;
            }
            else
            {
                focalDuration.Enabled = false;
                focalCheckBox.Enabled = false;
                newEffectButton.Enabled = false;
            }
        }

        void bDelete_CheckedChanged(object sender, EventArgs e)
        {
            deleteEffectButton.Enabled = false;

            for (int i = 0; i < effectsTable.Controls.Count; i++)
            {
                if (effectsTable.Controls[i] is CheckBox)
                {
                    CheckBox focalBox = (CheckBox)effectsTable.Controls[i];
                    if (focalBox.Checked) deleteEffectButton.Enabled = true;
                }
            }
        }

        void roundsRemaining_ValueChanged(object sender, EventArgs e)
        {
            // Store current effect data and selected combatant for quick reference.
            NumericUpDown focalDuration = (NumericUpDown)sender;
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            // Determine zero-based row index of current effect.
            int effectIndex = (effectsTable.GetPositionFromControl(focalDuration).Row - 1);
            int focalRow = effectsTable.GetPositionFromControl(focalDuration).Row;

            // Modify the respective effect data in the combatant.
            selectedCombatant.setEffectDuration(focalDuration.Value, effectIndex);
        }

        private void deleteEffectButton_Click(object sender, EventArgs e)
        {
            if (combatantList.SelectedIndex != 1)
            {
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
                ArrayList indexToDeleteFrom = new ArrayList();

                int effectCount = 0;

                // Record the indices of the first control in each row marked for deletion.
                for (int i = 0; i < effectsTable.Controls.Count; i++)
                {
                    if (effectsTable.Controls[i] is CheckBox)
                    {
                        CheckBox focalBox = (CheckBox)effectsTable.Controls[i];
                        if (focalBox.Checked) indexToDeleteFrom.Add(effectCount);
                        effectCount++;
                    }
                }

                // Remove effects from the combatant.
                for (int i = indexToDeleteFrom.Count-1; i > -1; i--)
                    selectedCombatant.removeEffect((int)indexToDeleteFrom[i]);

                // Rebuild table.
                destroyAndRebuild(effectsTable);
            }
        }

        public void destroyAndRebuild(TableLayoutPanel table)
        {
            if (combatantList.SelectedIndex != -1)
            {
                Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

                newEffectButton.Enabled = true;

                // Nuke table for rebuild.
                while (table.RowCount > 2)
                {
                    for (int i = 0; i < 3; i++)
                        table.Controls.RemoveAt(table.Controls.Count - 1); // Remove last control
                    table.RowCount--;
                }

                // Now rebuild!
                for (int i = 0; i < selectedCombatant.EffectCount; i++)
                {
                    newEffectButton.PerformClick();

                    // Load effect data into the newly created controls.
                    TextBox currentEffectName = (TextBox)table.GetControlFromPosition(1, table.RowCount - 2);
                    NumericUpDown currentEffectDuration = (NumericUpDown)table.GetControlFromPosition(2, table.RowCount - 2);

                    currentEffectName.Text = selectedCombatant.getEffectName(i);
                    currentEffectDuration.Value = selectedCombatant.getEffectDuration(i);

                    if (currentEffectName.Text.Length == 0) newEffectButton.Enabled = false;
                }
            }
        }

        private void rollInitiativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (combatantList.Items.Count > 0)
            {
                RollInitiative rollInitiative = new RollInitiative(this);
                rollInitiative.Show();
            }
            else
                MessageBox.Show("There are no combatants in the combatant list. Please add some using the \"Add ...\" button.",
                    "Error: No Combatants", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void calculateXPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Legend will now open. The combatants list will be loaded in to the players list and the dead and dying list will"
                + " be loaded in to the enemies list. Proceed?", "Continue to Legend", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Lists to hold players and enemies to load into Legend.
                ArrayList players = new ArrayList();
                ArrayList enemies = new ArrayList();

                // Populate lists.
                for (int i = 0; i < combatantList.Items.Count; i++)
                    players.Add(combatantList.Items[i]);
                for (int i = 0; i < dyingList.Items.Count; i++)
                    enemies.Add(dyingList.Items[i]);

                Legend legend = new Legend(players, enemies);
                legend.Show();
            }
        }

        private void clearDyingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset round number to one?", "Reset Round Number", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                roundNumber.Value = 1;
            }

            while (dyingList.Items.Count > 0)
                dyingList.Items.RemoveAt(0);
        }
    }
}
