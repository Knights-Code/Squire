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
    public partial class AddMetric : Form
    {
        PlayerManifest parentForm;

        public AddMetric()
        {
            InitializeComponent();
        }

        public AddMetric(PlayerManifest parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();

            metricName.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metricName_TextChanged(object sender, EventArgs e)
        {
            OKButton.Enabled = metricName.TextLength > 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Character currentCharacter = (Character)parentForm.manifest.SelectedItem;

            // Add metric to list and to the character.
            parentForm.metricList.Items.Add(metricName.Text);

            currentCharacter.addMetric(metricName.Text, metricValue.Value);
            
            parentForm.deleteMetric.Enabled = true;
            parentForm.metricList.Enabled = true;
            parentForm.currentMetric.Enabled = true;

            parentForm.metricList.SelectedIndex = parentForm.metricList.Items.Count - 1; // select last item in list

            this.Close();
        }
    }
}
