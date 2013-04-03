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
    public partial class AddSpell : Form
    {
        General parentForm;

        public AddSpell()
        {
            InitializeComponent();
        }

        public AddSpell(General parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }
    }
}
