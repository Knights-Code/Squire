using System;
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
        ArrayList rootsChecked;
        ArrayList batchGroups;

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
            rootsChecked = new ArrayList();
            batchGroups = new ArrayList();

            // Process each combatant and add them to the initiative list.
            for (int i = 0; i < parentForm.combatantList.Items.Count; i++)
            {
                Combatant currentCombatant = (Combatant)parentForm.combatantList.Items[i];
                
                // It's easier to have the twelve goblins act on the same initiative count. Let's check if the current combatant is
                // part of a batch, and then ask the user if they want to treat them as one entity in the initiative order.
                if (currentCombatant.getBatchRoot() != String.Empty)
                {
                    // Make sure we haven't already asked about this particular batch.
                    Boolean hasBeenChecked = false;
                    for (int j = 0; j < rootsChecked.Count; j++)
                    {
                        hasBeenChecked = (currentCombatant.getBatchRoot() == Convert.ToString(rootsChecked[j]));
                        if (hasBeenChecked) break;
                    }

                    // If it's a new batch, ask if the combatants should be "folded in" to one entity for the purpose of initiative.
                    if (!hasBeenChecked)
                    {
                        if (MessageBox.Show(currentCombatant + " is part of a generated batch of combatants. Would you like to have them all act on"
                            + " the same initiative count?", "Batch Combatant Detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Combatant batchGroupName = new Combatant(currentCombatant.getBatchRoot()+"s");
                            batchGroupName.setBatchRoot(currentCombatant.getBatchRoot());
                            ArrayList batchGroup = new ArrayList(); // create a place to store the batch

                            // Check the combatant list for any members of the batch and then add them to the list.
                            for (int id = 1; id < currentCombatant.getBatchTotal(); id++)
                            {
                                for (int iter = 0; iter < parentForm.combatantList.Items.Count; iter++)
                                {
                                    Combatant currentBatch = (Combatant)parentForm.combatantList.Items[iter];

                                    if (currentBatch.getName() == batchGroupName.getBatchRoot() + " #" + id)
                                        batchGroup.Add(currentBatch);
                                }
                            }

                            batchGroups.Add(batchGroup);
                            initiativeList.Items.Add(batchGroupName);
                        }
                        else
                            initiativeList.Items.Add(currentCombatant);

                        rootsChecked.Add(currentCombatant.getBatchRoot());
                    }
                } else
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
            int numCombatants = initiativeList.Items.Count;

            // These track which same-score combatants have already had their scores compared (and their positions resolved).
            ArrayList comparisonLog = new ArrayList();
            Combatant[] comparisonRecord = new Combatant[2];

            // This is where the magic happens! (read: "this is where the bubble sort algorithm happens")
            for (int i = 0; i < numCombatants; i++)
            {
                for (int j = 0; j < numCombatants - i; j++)
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

                        // If two combatants rolled the same initiative, determine who goes first.
                        else if (scores[j + 1] == scores[j])
                        {
                            Boolean haveBeenCompared = false;

                            // Check the log to determine if these combatants have had their scores compared already.
                            for (int k = 0; k < comparisonLog.Count; k++)
                            {
                                Combatant[] currentRecord = (Combatant[])comparisonLog[k];
                                haveBeenCompared = (currentRecord.Contains(currentCombatant) && currentRecord.Contains(nextCombatant));
                                if (haveBeenCompared) break;
                            }

                            // If they haven't been compared yet, compare them now and then make a note that they've been compared.
                            if (!haveBeenCompared)
                            {
                                // Ask user who goes first and then reposition accordingly.
                                if (MessageBox.Show(currentCombatant + " and " + nextCombatant + " have identical scores; does " + currentCombatant + " go first?",
                                    "Initiative Conflict", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                {
                                    scores[j] = nextScore;
                                    scores[j + 1] = currentScore;
                                    initiativeList.Items.RemoveAt(j);
                                    if (initiativeList.Items.Count == 1) initiativeList.Items.Add(currentCombatant);
                                    else initiativeList.Items.Insert(j + 1, currentCombatant);
                                }

                                // Record comparison.
                                Combatant[] newRecord = new Combatant[] {currentCombatant,nextCombatant};
                                comparisonLog.Add(newRecord);
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < initiativeList.Items.Count; i++) parentForm.combatantList.Items.RemoveAt(0);

            for (int i = 0; i < initiativeList.Items.Count; i++)
            {
                Combatant currentCombatant = (Combatant)initiativeList.Items[i];

                // Check to see if this is actually a header for a batch of combatants.
                if (currentCombatant.getBatchRoot() != String.Empty && currentCombatant.getName() == currentCombatant.getBatchRoot() + "s")
                {
                    // If so, check the batch root of the first combatant in each batch group. If it matches, add the batch to the combatant
                    // list all at once.
                    for (int j = 0; j < batchGroups.Count; j++)
                    {
                        ArrayList batchGroup = (ArrayList)batchGroups[j];
                        Combatant firstInstance = (Combatant)batchGroup[0];

                        if (firstInstance.getBatchRoot() == currentCombatant.getBatchRoot())
                        {
                            for (int k = 0; k < batchGroup.Count; k++)
                                parentForm.combatantList.Items.Add(batchGroup[k]);
                        }
                    }
                } else
                    parentForm.combatantList.Items.Add(initiativeList.Items[i]);
            }

            parentForm.roundNumber.Value = 1;

            this.Close();
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
