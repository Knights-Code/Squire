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
        Familiar parentForm;

        public AddSpell()
        {
            InitializeComponent();
        }

        public AddSpell(Familiar parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void addSpellButton_Click(object sender, EventArgs e)
        {
            if (this.spellNameBox.Text == String.Empty)
            {
                MessageBox.Show("Error: spell name field must not be empty", "No Spell Name Given",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Spell newSpell = new Spell(this.spellNameBox.Text);

            newSpell.spellschoolandsubschool = this.spellSchoolBox.Text;
            newSpell.spelldescriptor = this.spellDescriptorBox.Text;
            newSpell.spelllevel = this.spellLevelTypeBox.Text + this.spellLevelNumberBox.Text;
            newSpell.spellcomponents = this.spellComponentsBox.Text;
            newSpell.spellcastingtime = this.spellCastingTimeBox.Text;
            newSpell.spellrange = this.spellRangeBox.Text;
            newSpell.spellrange = this.spellRangeBox.Text;
            newSpell.spelleffect = this.spellEffectBox.Text;
            newSpell.spelltargets = this.spellTargetsBox.Text;
            newSpell.spellduration = this.spellDurationBox.Text;
            newSpell.spellsavingthrow = this.spellSavingThrowBox.Text;
            newSpell.spellresistance = this.spellResistanceBox.Text;
            newSpell.spelldescription = this.spellDescriptionBox.Text;


            parentForm.addSpelltoSpellbook(newSpell);
            parentForm.getSpellbookSource();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
