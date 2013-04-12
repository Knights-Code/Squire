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
            return name + " (" + level + ")";
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

            if (playerList.Items.Count <= 0 || enemyList.Items.Count <= 0)
            {
                return;
            }

            foreach (Contender player in playerList.Items)
            {
                XP = 0;
                foreach (Contender enemy in enemyList.Items)
                {
                    XP += calculateXP(player.level, enemy.level);
                }

                XP = Math.Floor(XP / playerList.Items.Count);
                intXP = Convert.ToInt32(XP);

                MessageBox.Show(player.name + " earns " + intXP + " experience points.", "Result", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
            }


        }

        private decimal calculateXP(decimal playerLevel, decimal enemyLevel)
        {
            int scale = ((int)enemyLevel - (int)playerLevel) + 8;
            double XPModifier;

            switch (scale)
            {
                case 1:
                    XPModifier = 25;
                    break;
                case 2:
                    XPModifier = 38;
                    break;
                case 3:
                    XPModifier = 50;
                    break;
                case 4:
                    XPModifier = 75;
                    break;
                case 5:
                    XPModifier = 100;
                    break;
                case 6:
                    XPModifier = 150;
                    break;
                case 7:
                    XPModifier = 200;
                    break;
                case 8:
                    XPModifier = 300;
                    break;
                case 9:
                    XPModifier = 450;
                    break;
                case 10:
                    XPModifier = 600;
                    break;
                case 11:
                    XPModifier = 900;
                    break;
                case 12:
                    XPModifier = 1200;
                    break;
                case 13:
                    XPModifier = 1800;
                    break;
                case 14:
                    XPModifier = 2400;
                    break;
                case 15:
                    XPModifier = 3600;
                    break;
                default:
                    XPModifier = -1;
                    break;
            }

            /*
            double Offset = 12.5;
            for (int i = 1; i < scale; i++)
            {
                XPModifier += Offset;

                if (Offset == 100)
                {
                    Offset = 150;
                    continue;
                }

                if (i % 2 == 0 && i != 7)
                {
                    Offset += Offset;
                }
            }*/

            double XP = XPModifier * (double)playerLevel;

            return (decimal)XP;
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
