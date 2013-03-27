using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Squire
{
    public struct Contender
    {
        public string name;
        public decimal level;

        public Contender(string name, decimal level)
        {
            this.name = name;
            this.level = level;
        }

        public override string ToString()
        {
            return name + " ("+level+")";
        }
    }

    public partial class Legend : Form
    {
        Boolean levelsAreEqual;
        decimal levelStandard;

        public Legend()
        {
            InitializeComponent();
            levelsAreEqual = true;
            levelStandard = 0;
        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            if (playerName.Text.Length > 0 && playerLevel.Value > 0)
            {
                playerList.Items.Add(new Contender(playerName.Text, playerLevel.Value));

                if (playerList.Items.Count == 1)
                    levelStandard = playerLevel.Value;
                else if (playerLevel.Value != levelStandard)
                    levelsAreEqual = false;

                playerName.Text = String.Empty;
                playerLevel.Value = 0;

                if (enemyList.Items.Count > 0)
                    calculateButton.Enabled = true;
                else
                    calculateButton.Enabled = false;
            }
        }

        private void addEnemy_Click(object sender, EventArgs e)
        {
            if (enemyName.Text.Length > 0 && enemyLevel.Value > 0)
            {
                enemyList.Items.Add(new Contender(enemyName.Text, enemyLevel.Value));

                enemyName.Text = String.Empty;
                enemyLevel.Value = 0;

                if (playerList.Items.Count > 0)
                    calculateButton.Enabled = true;
                else
                    calculateButton.Enabled = false;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal XP = 0;
            int intXP = 0;

            if (playerList.Items.Count > 0 && enemyList.Items.Count > 0)
            {
                if (levelsAreEqual && playerList.Items.Count > 1)
                {
                    Contender firstPlayer = (Contender)playerList.Items[0];

                    for (int i = 0; i < enemyList.Items.Count; i++)
                    {
                        Contender enemy = (Contender)enemyList.Items[i];
                        XP += calculateXP(firstPlayer.level, enemy.level);
                    }

                    XP = Math.Floor(XP / playerList.Items.Count);
                    intXP = Convert.ToInt32(XP);

                    MessageBox.Show("Each party member earns " + intXP + " experience points.", "Result", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                }
                else
                {
                    for (int p = 0; p < playerList.Items.Count; p++)
                    {
                        Contender currentPlayer = (Contender)playerList.Items[p];

                        for (int i = 0; i < enemyList.Items.Count; i++)
                        {
                            Contender enemy = (Contender)enemyList.Items[i];
                            XP += calculateXP(currentPlayer.level, enemy.level);
                        }

                        XP = Math.Floor(XP / playerList.Items.Count);
                        intXP = Convert.ToInt32(XP);

                        MessageBox.Show(currentPlayer+" earns " + intXP + " experience points.", "Result", MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private decimal calculateXP(decimal playerLevel, decimal enemyLevel)
        {
            decimal XPmodifier = 1;
            decimal equationMultiplier = 300;
            decimal result = 0;
            int numSteps = 0;

            if (enemyLevel < 1)
            {
                XPmodifier = enemyLevel;
                enemyLevel = 1;
            }
            if (playerLevel < 4) playerLevel = 1;

            playerLevel = Math.Floor(playerLevel);
            enemyLevel = Math.Floor(enemyLevel);

            if (enemyLevel < playerLevel)
            {
                for (decimal i = enemyLevel; i < playerLevel; i += 2)
                {
                    if ( i == (playerLevel-1) )
                        equationMultiplier = 200;
                    else
                        numSteps++;
                }

                result = playerLevel * equationMultiplier;

                for (int i = 0; i < numSteps; i++)
                    result /= 2;
            }
            else if (enemyLevel == playerLevel)
            {
                result = playerLevel * equationMultiplier;
            }
            else
            {
                for (decimal i = enemyLevel; i > playerLevel; i -= 2)
                {
                    if (i == (playerLevel + 1))
                        equationMultiplier = 400;
                    numSteps++;
                }

                result = playerLevel * equationMultiplier;

                for (int i = 0; i < numSteps; i++)
                    result *= 2;
            }

            return result * XPmodifier;
        }

        private void removePlayer_Click(object sender, EventArgs e)
        {
            if (playerList.SelectedIndex != -1)
            {
                playerList.Items.RemoveAt(playerList.SelectedIndex);
                if (playerList.Items.Count == 0) calculateButton.Enabled = false;
            }
        }

        private void removeEnemy_Click(object sender, EventArgs e)
        {
            if (enemyList.SelectedIndex != -1)
            {
                enemyList.Items.RemoveAt(enemyList.SelectedIndex);
                if (enemyList.Items.Count == 0) calculateButton.Enabled = false;
            }
        }
    }
}
