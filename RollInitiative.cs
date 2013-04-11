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
    public struct Placeholder
    {
        public Combatant theContender;
        public decimal init;

        public Placeholder(Combatant theContender)
        {
            this.theContender = theContender;
            this.init = 0;
        }

        public override string ToString()
        {
            return theContender + "("+init+")";
        }
    }

    public partial class RollInitiative : Form
    {
        General parentForm;
        Combatant[] combatants;
        int[] scores;

        public RollInitiative()
        {
            InitializeComponent();
        }

        public RollInitiative(General parentForm)
        {
            InitializeComponent();

            //-----( Variables )-----\\
            this.parentForm = parentForm;

            combatants = new Combatant[parentForm.combatantList.Items.Count];
            scores = new int[parentForm.combatantList.Items.Count];

            for (int i = 0; i < parentForm.combatantList.Items.Count; i++)
            {
                Combatant currentCombatant = (Combatant)parentForm.combatantList.Items[i];
                initiativeList.Items.Add(currentCombatant);
                scores[i] = 0;
            }

            //-----( Event Handlers )-----\\
            okButton.Click += okButton_Click;
            initiativeScore.KeyPress += new KeyPressEventHandler(initiativeScore_KeyPress);

            if (initiativeList.Items.Count > 0)
                initiativeList.SelectedIndex = 0;

            initiativeScore.Select(0, initiativeScore.Text.Length);
        }

        void initiativeScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                initiativeList.SelectedIndex = initiativeList.SelectedIndex != (initiativeList.Items.Count - 1) ? initiativeList.SelectedIndex + 1 : initiativeList.Items.Count - 1;
                initiativeScore.Select(0, initiativeScore.Text.Length);
            }
        }

        void okButton_Click(object sender, EventArgs e)
        {
            // This is where the magic happens! (read: "this is where the bubble sort algorithm happens")
            for (int i = 0; i < initiativeList.Items.Count; i++)
            {
                for (int j = 0; j < initiativeList.Items.Count - i; j++)
                {
                    if (j + 1 < scores.Length)
                    {
                        Combatant currentCombatant = (Combatant)initiativeList.Items[j];
                        Combatant nextCombatant = (Combatant)initiativeList.Items[j + 1];
                        int currentScore = scores[j];
                        int nextScore = scores[j + 1];

                        if (scores[j + 1] > scores[j])
                        {
                            scores[j] = nextScore;
                            scores[j + 1] = currentScore;
                            initiativeList.Items.RemoveAt(j);
                            if (initiativeList.Items.Count == 1) initiativeList.Items.Add(currentCombatant);
                            else initiativeList.Items.Insert(j + 1, currentCombatant);
                        }
                        else if (scores[j + 1] == scores[j])
                        {
                            if (MessageBox.Show(currentCombatant + " and " + nextCombatant + " have identical scores; does " + currentCombatant + " go first?",
                                "Initiative Conflict", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            {
                                scores[j] = nextScore;
                                scores[j + 1] = currentScore;
                                initiativeList.Items.RemoveAt(j);
                                if (initiativeList.Items.Count == 1) initiativeList.Items.Add(currentCombatant);
                                else initiativeList.Items.Insert(j + 1, currentCombatant);
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < initiativeList.Items.Count; i++) parentForm.combatantList.Items.RemoveAt(0);

            for (int i = 0; i < initiativeList.Items.Count; i++) parentForm.combatantList.Items.Add(initiativeList.Items[i]);

            this.Close();

            initiativeList.Refresh();
        }

        private void initiativeScore_ValueChanged(object sender, EventArgs e)
        {
            if (initiativeList.SelectedIndex != -1)
            {
                scores[initiativeList.SelectedIndex] = Convert.ToInt32(initiativeScore.Value);

                initiativeList.Refresh();
            }
        }

        private void initiativeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initiativeList.SelectedIndex != -1)
            {
                initiativeScore.Value = scores[initiativeList.SelectedIndex];
                initiativeScore.Enabled = true;
            }
            else
                initiativeScore.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
