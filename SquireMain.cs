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
    public partial class SquireMain : Form
    {
        public SquireMain()
        {
            InitializeComponent();
        }

        private void generalButton_Click(object sender, EventArgs e)
        {
            General general = new General();
            general.Show();
        }

        private void levelUpButton_Click(object sender, EventArgs e)
        {
            LevelUp levelup = new LevelUp();
            levelup.Show();
        }

        private void legendButton_Click(object sender, EventArgs e)
        {
            Legend legend = new Legend();
            legend.Show();
        }

        private void playerManifestButton_Click(object sender, EventArgs e)
        {
            PlayerManifest playerManifest = new PlayerManifest();
            playerManifest.Show();
        }
    }
}
