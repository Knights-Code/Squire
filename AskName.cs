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
    public partial class AskName : Form
    {
        PlayerManifest parentForm;

        public AskName()
        {
            InitializeComponent();
        }

        public AskName(PlayerManifest parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();

            playerName.Focus();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Character newCharacter = new Character(playerName.Text);
            parentForm.manifest.Items.Add(newCharacter);
            parentForm.manifest.SelectedIndex = parentForm.manifest.Items.Count - 1;
            this.Close();
        }
    }
}
