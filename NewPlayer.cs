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
    public partial class NewPlayer : Form
    {
        General parentForm;

        public NewPlayer()
        {
            InitializeComponent();
        }

        public NewPlayer(General parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();

            nameBox.Focus();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            OKButton.Enabled = nameBox.TextLength > 0 && HPBox.Value > 0;
        }

        private void HPBox_ValueChanged(object sender, EventArgs e)
        {
            OKButton.Enabled = nameBox.TextLength > 0 && HPBox.Value > 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (parentForm.playerName.Text != "[No PC Loaded]")
            {
                if (MessageBox.Show("Current PC data will be overwritten. Proceed?", "Overwrite existing data", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    this.Close();
            }

            Player newPlayer = new Player(nameBox.Text, (int)HPBox.Value);
            parentForm.player = newPlayer;
        }
    }
}
