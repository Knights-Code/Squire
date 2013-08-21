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
    public partial class PlayerManifest : Form
    {
        public PlayerManifest()
        {
            InitializeComponent();
        }

        private void manifest_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character currentCharacter = (Character)manifest.SelectedItem; // store character information for quick access

            // Load in armour class data
            BaseAC.Value = currentCharacter.getBaseAC();
            BaseAC.Enabled = true;
            touchAC.Value = currentCharacter.getTouchAC();
            touchAC.Enabled = true;
            FFAC.Value = currentCharacter.getFFAC();
            FFAC.Enabled = true;

            // Destroy and rebuild metrics
            while (metricList.Items.Count > 0)
                metricList.Items.RemoveAt(0);

            for (int i = 0; i < currentCharacter.metricCount(); i++)
                metricList.Items.Add(currentCharacter.getMetricName(i));

            // Select first item if the character has any metrics
            if (currentCharacter.metricCount() > 0)
            {
                metricList.SelectedIndex = 0;
                metricList.Enabled = true;
                currentMetric.Value = currentCharacter.getMetricValue(0);
                currentMetric.Enabled = true;
                deleteMetric.Enabled = true;
            }
            else
            {
                metricList.Enabled = false;
                currentMetric.Value = 0;
                currentMetric.Enabled = false;
                deleteMetric.Enabled = false;
            }

            addMetric.Enabled = true;
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskName nameDialog = new AskName(this);
            nameDialog.Show();
        }

        private void metricList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character currentCharacter = (Character)manifest.SelectedItem;

            currentMetric.Value = currentCharacter.getMetricValue(metricList.SelectedIndex);
        }

        private void currentMetric_ValueChanged(object sender, EventArgs e)
        {
            Character currentCharacter = (Character)manifest.SelectedItem;

            currentCharacter.updateMetric(metricList.SelectedIndex, currentMetric.Value);
        }

        private void BaseAC_ValueChanged(object sender, EventArgs e)
        {
            Character currentCharacter = (Character)manifest.SelectedItem;

            currentCharacter.setBaseAC(BaseAC.Value);
        }

        private void touchAC_ValueChanged(object sender, EventArgs e)
        {
            Character currentCharacter = (Character)manifest.SelectedItem;

            currentCharacter.setTouchAC(touchAC.Value);
        }

        private void FFAC_ValueChanged(object sender, EventArgs e)
        {
            Character currentCharacter = (Character)manifest.SelectedItem;

            currentCharacter.setFFAC(FFAC.Value);
        }

        private void addMetric_Click(object sender, EventArgs e)
        {
            AddMetric addMetric = new AddMetric(this);
            addMetric.Show();
        }

        private void deleteMetric_Click(object sender, EventArgs e)
        {
            Character currentCharacter = (Character)manifest.SelectedItem;

            currentCharacter.deleteMetric(metricList.SelectedIndex); // remove from character
            metricList.Items.RemoveAt(metricList.SelectedIndex); // remove from metric list

            if (metricList.Items.Count > 0)
                metricList.SelectedIndex = 0; // select first metric in list to look tidy

            if (currentCharacter.metricCount() == 0)
                deleteMetric.Enabled = false;
        }
    }
}
