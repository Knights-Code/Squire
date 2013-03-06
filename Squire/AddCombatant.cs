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
    public partial class AddCombatant : Form
    {
        General parentForm;

        public AddCombatant()
        {
            InitializeComponent();
        }

        public AddCombatant(General parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void checkboxIsPlayer_CheckedChanged(object sender, EventArgs e)
        {
            combatantHP.Enabled = !checkboxIsPlayer.Checked;
        }

        private void addOK_Click(object sender, EventArgs e)
        {
            if (this.combatantName.Text != String.Empty)
            {
                Combatant newCombatant;
                if (combatantHP.Enabled && combatantHP.IntValue != 0) newCombatant = new Combatant(combatantName.Text, combatantHP.IntValue);
                else newCombatant = new Combatant(combatantName.Text);

                parentForm.combatantList.Items.Add(newCombatant);
                this.Close();
            }
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
