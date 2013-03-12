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
            damage.KeyPress += damage_KeyPress;

            //-----( Components )-----//
            // Generate wound list from combatant list
            for (int i=0; i < parentForm.combatantList.Items.Count; i++)
            {
                Combatant currentCombatant = (Combatant)parentForm.combatantList.Items[i];
                if (!currentCombatant.isPlayer()) woundList.Items.Add(currentCombatant);
            }
            woundList.SelectedIndex = 0; // select topmost combatant
        }

        void damage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) okButton.PerformClick(); // without focus on the main form the enter key is ignored, so here's an event handler to trigger the ok button manually
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
                //parentForm.log((Combatant)parentForm.combatantList.selectedItem + " dealt "+damage.IntValue+" points of damage to " + selectedCombatant);

                this.Close();
            }
        }
    }
}
