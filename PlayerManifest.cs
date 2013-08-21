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
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskName nameDialog = new AskName(this);
            nameDialog.Show();
        }
    }
}
