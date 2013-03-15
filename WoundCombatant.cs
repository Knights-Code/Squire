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
    public partial class WoundCombatant : Form
    {
        General parentForm;


        public WoundCombatant()
        {
            InitializeComponent();
        }

        public WoundCombatant(General parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();

            //-----( Event Handlers )-----//
            okButton.Click += okButton_Click; // for some reason VS refused to generate a click handler
            cancelButton.Click += cancelButton_Click;
            woundList.DrawItem += parentForm.initiative_DrawItem;
            woundList.MouseMove += parentForm.initiative_MouseMove;

            //-----( Components )-----//
            // Generate wound list from combatant list
            for (int i=0; i < parentForm.combatantList.Items.Count; i++)
            {
                Combatant currentCombatant = (Combatant)parentForm.combatantList.Items[i];
                if (!currentCombatant.isPlayer()) woundList.Items.Add(currentCombatant);
            }
            
            if ( woundList.Items.Count > 0 ) woundList.SelectedIndex = 0; // select topmost combatant
        }

        void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void okButton_Click(object sender, EventArgs e)
        {
            // Make sure a combatant is selected
            if (woundList.SelectedIndex != -1)
            {
                // Store the combatant for quick reference
                Combatant selectedCombatant = (Combatant)woundList.SelectedItem;

                selectedCombatant.setCurrentHP((selectedCombatant.getCurrentHP() - damage.IntValue)); // damage selected combatant

                // TODO: log that selected combatant in the initiative list has damaged the selected combatant in the wound list
                //parentForm.log((Combatant)parentForm.combatantList.SelectedItem + " dealt "+damage.IntValue+" points of damage to " + selectedCombatant);

                // If this wound has dealt enough damage to drop the combatant, prompt user to move them to the dead and dying list.
                if (selectedCombatant.getCurrentHP() < 0)
                {
                    if (MessageBox.Show((Combatant)parentForm.combatantList.SelectedItem + " has dealt enough damage to drop the combatant being injured. "+
                        "Would you like to move the victim to the dead and dying list?", selectedCombatant + "'s Hit Points Below 0", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        parentForm.combatantList.Items.Remove(selectedCombatant);
                        parentForm.dyingList.Items.Add(selectedCombatant);
                        parentForm.dyingList.Refresh();
                    }
                }

                parentForm.combatantList.Refresh();
                parentForm.delayList.Refresh();
                this.Close();
            }
        }

        private void woundList_SelectedIndexChanged(object sender, EventArgs e)
        {
            woundList.Refresh();
        }
    }
}
