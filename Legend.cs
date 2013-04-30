﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

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
        public Legend()
        {
            InitializeComponent();

            //-----( Event Handlers )-----\\
            playerLevel.Enter += new EventHandler(numericField_Enter);
            enemyLevel.Enter += numericField_Enter;
            playerLevel.Click += numericField_Enter;
            enemyLevel.Click += numericField_Enter;
        }

        public Legend(ArrayList players, ArrayList enemies)
        {
            InitializeComponent();

            //-----( Event Handlers )-----\\
            playerLevel.Enter += new EventHandler(numericField_Enter);
            enemyLevel.Enter += numericField_Enter;
            playerLevel.Click += numericField_Enter;
            enemyLevel.Click += numericField_Enter;

            // Load in players and enemies.
            for (int i = 0; i < players.Count; i++)
            {
                Combatant currentPlayer = (Combatant)players[i];
                Contender newPlayer = new Contender(currentPlayer.getName(), currentPlayer.getLevel());
                playerList.Items.Add(newPlayer);
            }
            for (int i = 0; i < enemies.Count; i++)
            {
                Combatant currentEnemy = (Combatant)enemies[i];
                Contender newEnemy = new Contender(currentEnemy.getName(), currentEnemy.getLevel());
                enemyList.Items.Add(newEnemy);
            }

            calculateButton.Enabled = (playerList.Items.Count > 0 && enemyList.Items.Count > 0);
        }

        void numericField_Enter(object sender, EventArgs e)
        {
            NumericUpDown source = (NumericUpDown)sender;

            source.Select(0, source.Text.Length);
        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            if (playerName.Text.Length > 0 && playerLevel.Value > 0)
            {
                playerList.Items.Add(new Contender(playerName.Text, playerLevel.Value));

                playerName.Text = String.Empty;
                playerLevel.Value = 0;

                playerName.Focus(); // put cursor back in name entry box

                if (enemyList.Items.Count > 0)
                    calculateButton.Enabled = true;
                else
                    calculateButton.Enabled = false;
            }
        }

        private Boolean areLevelsEqual()
        {
            Boolean result = true;
            if (playerList.Items.Count > 0)
            {
                Contender currentContender = (Contender)playerList.Items[0];
                decimal levelStandard = currentContender.level; // set the standard. All levels must be equal to this one.

                // Check the levels of every player in the list. If any of them have levels that don't match the standard, break the loop to
                // send back a result of "false".
                for (int i = 1; i < playerList.Items.Count; i++)
                {
                    currentContender = (Contender)playerList.Items[i];
                    if (currentContender.level != levelStandard)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        private void addEnemy_Click(object sender, EventArgs e)
        {
            if (enemyName.Text.Length > 0 && enemyLevel.Value > 0)
            {
                enemyList.Items.Add(new Contender(enemyName.Text, enemyLevel.Value));

                enemyName.Text = String.Empty;
                enemyLevel.Value = 0;

                enemyName.Focus(); // put cursor back in name entry box

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
                if (areLevelsEqual() && playerList.Items.Count > 1)
                {
                    Contender firstPlayer = (Contender)playerList.Items[0];
                    XP = 0;

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
                        XP = 0;

                        for (int i = 0; i < enemyList.Items.Count; i++)
                        {
                            Contender enemy = (Contender)enemyList.Items[i];
                            XP += calculateXP(currentPlayer.level, enemy.level);
                        }

                        XP = Math.Floor(XP / playerList.Items.Count);
                        intXP = Convert.ToInt32(XP);

                        MessageBox.Show(currentPlayer.name+" earns " + intXP + " experience points.", "Result", MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private decimal calculateXP(decimal playerLevel, decimal enemyLevel)
        {
            double x = (double)( playerLevel<=3?( enemyLevel<=3?enemyLevel:3 ):( enemyLevel==1&&playerLevel<7?1:playerLevel )); // tell me THIS isn't confusing.
            // Nested ternary operators, everybody! The above line changes player level to another value if it and enemy level are low enough (because low-
            // level characters get special treatment).
            double y = (double)enemyLevel;
            double z = y - x;

            double result = 0;

            if (z != 0)
            {
                if (z % 2 == 0)
                    result = (300 * x) * Math.Pow(2, (z / 2));
                else
                {
                    decimal lower = Convert.ToDecimal((300 * x) * Math.Pow(2, ((z - 1) / 2)));
                    decimal higher = Convert.ToDecimal((300 * x) * Math.Pow(2, ((z + 1) / 2)));

                    if (x < y)
                    {
                        double total = (double)(lower + higher);
                        result = total / 2;
                    }
                    else
                    {
                        double diff = (double)(higher - lower);
                        result = (diff / 3) + (double)lower;
                    }
                }
            }
            else
                result = 300 * x;

            result = Math.Ceiling(result);
            return Convert.ToDecimal(result);
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
