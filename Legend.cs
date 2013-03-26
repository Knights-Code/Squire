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

                if (playerList.Items.Count == 0)
                    levelStandard = playerLevel.Value;
                else if (playerLevel.Value != levelStandard)
                    levelsAreEqual = false;
            }
        }

        private void addEnemy_Click(object sender, EventArgs e)
        {
            if (enemyName.Text.Length > 0 && enemyLevel.Value > 0)
                enemyList.Items.Add(new Contender(enemyName.Text, enemyLevel.Value));
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal XP = 0;
            if (levelsAreEqual)
            {
                if (playerList.Items.Count > 0 && enemyList.Items.Count > 0)
                {
                    Contender firstPlayer = (Contender)playerList.Items[0];

                    for (int i = 0; i < enemyList.Items.Count; i++)
                    {
                        Contender enemy = (Contender)enemyList.Items[i];
                        XP += calculateXP(firstPlayer.level, enemy.level);
                    }
                }
            }
        }

        private decimal calculateXP(decimal playerLevel, decimal enemyLevel)
        {
            throw new NotImplementedException();
        }
    }
}
