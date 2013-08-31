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
    public partial class AddPCAbility : Form
    {
        General parentForm;

        public AddPCAbility()
        {
            InitializeComponent();
        }

        public AddPCAbility(General parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();

            abilityName.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            parentForm.player.addAbility(abilityName.Text, abilityDescription.Text);
            parentForm.abilityDropdown.Items.Add(abilityName.Text);
            parentForm.removeAbilityButton.Enabled = parentForm.player.numAbilities() > 0;
        }

        private void abilityName_TextChanged(object sender, EventArgs e)
        {
            OKButton.Enabled = abilityName.Text.Length > 0 && abilityDescription.Text.Length > 0;
        }

        private void abilityDescription_TextChanged(object sender, EventArgs e)
        {
            OKButton.Enabled = abilityName.Text.Length > 0 && abilityDescription.Text.Length > 0;
        }
    }
}
