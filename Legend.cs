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
            int scale = (int)enemyLevel - (int)playerLevel + 8;
            double Offset = 12.5;
            double XPModifier = Offset * 2;

            for (int i = 1; i < scale; i++)
            {
                if (i % 2 == 1 && i != 8)
                {
                    Offset += Offset;
                }

                if (i == 8)
                {
                    Offset = Offset * 1.5;
                }

                XPModifier += Offset;
            }

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
