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
    public partial class SpellcasterSettings : Form
    {
        Familiar parentForm;
        List<SpellCount> spellCountPerLevel;

        struct SpellCount
        {
            uint spellsPerDay = 0;
            uint spellsRemaining = 0;
        }

        public SpellcasterSettings()
        {
            InitializeComponent();
            spellCountPerLevel = new List<SpellCount>();
        }

        public SpellcasterSettings(Familiar parentForm)
        {
            this.parentForm = parentForm;
            spellCountPerLevel = new List<SpellCount>();
            InitializeComponent();
        }

        private void highestSpellLevelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.parentForm.setHighestSpellLevel(Decimal.ToUInt32(highestSpellLevelNumericUpDown.Value));
            spellLevelListBox.Items.Clear();

            for (int i = 0; i <= highestSpellLevelNumericUpDown.Value; i++)
            {
                spellLevelListBox.Items.Add(Common.SpellLevel + " " + i);
            }
        }

        private void addClassOrDomainButton_Click(object sender, EventArgs e)
        {
            if (customClassDomainTextbox.Text != Common.customClassDomainDefault)
            {
                spellcasterClassesAndDomains.Items.Add(customClassDomainTextbox.Text);
                return;
            }

            spellcasterClassesAndDomains.Items.Add(masterListOfClassesAndDomains.SelectedItem.ToString());
        }

        private void customClassDomainTextbox_TextChanged(object sender, EventArgs e)
        {
            masterListOfClassesAndDomains.ClearSelected();
        }

        private void clearCustomTextButton_Click(object sender, EventArgs e)
        {
            customClassDomainTextbox.Text = Common.customClassDomainDefault;
        }

        private void removeClassOrDomainButton_Click(object sender, EventArgs e)
        {
            spellcasterClassesAndDomains.Items.Remove(spellcasterClassesAndDomains.SelectedItem);
        }

        private void CasterTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.parentForm.setSpontaneousCaster(spontaneousCasterRadioButton.Checked);
        }

        private void spellLevelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
