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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCombatantButton_Click(object sender, EventArgs e)
        {
            AddCombatant addDialog = new AddCombatant(this);
            addDialog.Show();
        }

        private void combatantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;
            combatantHPBar.Maximum = selectedCombatant.getMaxHP();
            combatantHPBar.Minimum = 0;
            combatantHPBar.Value = selectedCombatant.getCurrentHP();

            remainingHP.Text = selectedCombatant.getCurrentHP() + " / " + selectedCombatant.getMaxHP();
            nameTextBox.Text = selectedCombatant.getName();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            selectedCombatant.setName(nameTextBox.Text);
        }

        private void healButton_Click(object sender, EventArgs e)
        {
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            if (selectedCombatant.getCurrentHP() + HPChange.IntValue > selectedCombatant.getMaxHP()) selectedCombatant.setCurrentHP(selectedCombatant.getMaxHP());
            else selectedCombatant.setCurrentHP(selectedCombatant.getCurrentHP() + HPChange.IntValue);

            HPChange.IntValue = 0;
        }

        private void damageButton_Click(object sender, EventArgs e)
        {
            Combatant selectedCombatant = (Combatant)combatantList.SelectedItem;

            selectedCombatant.setCurrentHP(selectedCombatant.getCurrentHP() - HPChange.IntValue);

            HPChange.IntValue = 0;
        }
    }
}
