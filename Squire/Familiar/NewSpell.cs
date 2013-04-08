﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Squire
{
    public partial class NewSpell : Form
    {
        Familiar parentForm;

        public NewSpell()
        {
            InitializeComponent();
        }

        public NewSpell(Familiar parentForm)
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
            newSpell.spelllevel = this.spellLevelTypeBox.Text + " " + this.spellLevelNumberBox.Text;
            foreach (object item in this.spellComponentsBox.CheckedItems)
            {
                newSpell.spellcomponents += item.ToString() + ", ";
            }


            newSpell.spellcomponents = newSpell.spellcomponents.TrimEnd(' ');
            newSpell.spellcomponents = newSpell.spellcomponents.TrimEnd(',');

            newSpell.spellcastingtime = this.spellCastingTimeBox.Text;
            newSpell.spellrange = this.spellRangeBox.Text;
            newSpell.spellarea = this.spellAreaBox.Text;
            newSpell.spelleffect = this.spellEffectBox.Text;
            newSpell.spelltargets = this.spellTargetsBox.Text;
            newSpell.spellduration = this.spellDurationBox.Text;
            newSpell.spellsavingthrow = this.spellSavingThrowBox.Text;
            newSpell.spellresistance = this.spellResistanceBox.Text;
            newSpell.spelldescription = this.spellDescriptionBox.Text;

            parentForm.addSpell(newSpell, false);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}