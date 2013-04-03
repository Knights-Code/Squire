﻿namespace Squire
{
    partial class Familiar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Familiar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSpellbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSpellbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSpellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.preparedSpellsList = new System.Windows.Forms.DataGridView();
            this.preparedSpellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparedSpellLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparedSpellSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparedSpellComponents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparedSpellCastingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.preparedSpellsRemaining = new System.Windows.Forms.ProgressBar();
            this.preparedSpellLevels = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.spellBookGrid = new System.Windows.Forms.DataGridView();
            this.spellBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellBookLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellBookSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellBookComponents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellBookCastingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellDescriptionBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preparedSpellsList)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellBookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSpellbookToolStripMenuItem,
            this.saveSpellbookToolStripMenuItem,
            this.addSpellToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSpellbookToolStripMenuItem
            // 
            this.openSpellbookToolStripMenuItem.Name = "openSpellbookToolStripMenuItem";
            this.openSpellbookToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openSpellbookToolStripMenuItem.Text = "Open Spellbook";
            // 
            // saveSpellbookToolStripMenuItem
            // 
            this.saveSpellbookToolStripMenuItem.Name = "saveSpellbookToolStripMenuItem";
            this.saveSpellbookToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.saveSpellbookToolStripMenuItem.Text = "Save Spellbook";
            // 
            // addSpellToolStripMenuItem
            // 
            this.addSpellToolStripMenuItem.Name = "addSpellToolStripMenuItem";
            this.addSpellToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addSpellToolStripMenuItem.Text = "Add Spell";
            this.addSpellToolStripMenuItem.Click += new System.EventHandler(this.addSpellToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.spellDescriptionBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 472);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 239);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(492, 230);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prepared Spells";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.preparedSpellsList, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(486, 204);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // preparedSpellsList
            // 
            this.preparedSpellsList.AllowUserToOrderColumns = true;
            this.preparedSpellsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preparedSpellsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preparedSpellName,
            this.preparedSpellLevel,
            this.preparedSpellSchool,
            this.preparedSpellComponents,
            this.preparedSpellCastingTime});
            this.preparedSpellsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preparedSpellsList.Location = new System.Drawing.Point(3, 53);
            this.preparedSpellsList.Name = "preparedSpellsList";
            this.preparedSpellsList.Size = new System.Drawing.Size(480, 148);
            this.preparedSpellsList.TabIndex = 2;
            // 
            // preparedSpellName
            // 
            this.preparedSpellName.HeaderText = "Name";
            this.preparedSpellName.Name = "preparedSpellName";
            this.preparedSpellName.ReadOnly = true;
            // 
            // preparedSpellLevel
            // 
            this.preparedSpellLevel.HeaderText = "Level";
            this.preparedSpellLevel.Name = "preparedSpellLevel";
            this.preparedSpellLevel.ReadOnly = true;
            // 
            // preparedSpellSchool
            // 
            this.preparedSpellSchool.HeaderText = "School";
            this.preparedSpellSchool.Name = "preparedSpellSchool";
            this.preparedSpellSchool.ReadOnly = true;
            // 
            // preparedSpellComponents
            // 
            this.preparedSpellComponents.HeaderText = "Components";
            this.preparedSpellComponents.Name = "preparedSpellComponents";
            this.preparedSpellComponents.ReadOnly = true;
            // 
            // preparedSpellCastingTime
            // 
            this.preparedSpellCastingTime.HeaderText = "Casting Time";
            this.preparedSpellCastingTime.Name = "preparedSpellCastingTime";
            this.preparedSpellCastingTime.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.tableLayoutPanel5.Controls.Add(this.preparedSpellsRemaining, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.preparedSpellLevels, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(480, 44);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // preparedSpellsRemaining
            // 
            this.preparedSpellsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preparedSpellsRemaining.Location = new System.Drawing.Point(112, 3);
            this.preparedSpellsRemaining.MaximumSize = new System.Drawing.Size(0, 20);
            this.preparedSpellsRemaining.MinimumSize = new System.Drawing.Size(0, 20);
            this.preparedSpellsRemaining.Name = "preparedSpellsRemaining";
            this.preparedSpellsRemaining.Size = new System.Drawing.Size(365, 20);
            this.preparedSpellsRemaining.TabIndex = 1;
            // 
            // preparedSpellLevels
            // 
            this.preparedSpellLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preparedSpellLevels.FormattingEnabled = true;
            this.preparedSpellLevels.Location = new System.Drawing.Point(3, 3);
            this.preparedSpellLevels.MinimumSize = new System.Drawing.Size(103, 38);
            this.preparedSpellLevels.Name = "preparedSpellLevels";
            this.preparedSpellLevels.Size = new System.Drawing.Size(103, 38);
            this.preparedSpellLevels.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.spellBookGrid, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(492, 230);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Known Spells";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spellBookGrid
            // 
            this.spellBookGrid.AllowUserToOrderColumns = true;
            this.spellBookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spellBookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spellBookName,
            this.spellBookLevel,
            this.spellBookSchool,
            this.spellBookComponents,
            this.spellBookCastingTime});
            this.spellBookGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellBookGrid.Location = new System.Drawing.Point(3, 23);
            this.spellBookGrid.Name = "spellBookGrid";
            this.spellBookGrid.Size = new System.Drawing.Size(486, 204);
            this.spellBookGrid.TabIndex = 1;
            // 
            // spellBookName
            // 
            this.spellBookName.HeaderText = "Name";
            this.spellBookName.Name = "spellBookName";
            this.spellBookName.ReadOnly = true;
            // 
            // spellBookLevel
            // 
            this.spellBookLevel.HeaderText = "Level";
            this.spellBookLevel.Name = "spellBookLevel";
            this.spellBookLevel.ReadOnly = true;
            // 
            // spellBookSchool
            // 
            this.spellBookSchool.HeaderText = "School";
            this.spellBookSchool.Name = "spellBookSchool";
            this.spellBookSchool.ReadOnly = true;
            // 
            // spellBookComponents
            // 
            this.spellBookComponents.HeaderText = "Components";
            this.spellBookComponents.Name = "spellBookComponents";
            this.spellBookComponents.ReadOnly = true;
            // 
            // spellBookCastingTime
            // 
            this.spellBookCastingTime.HeaderText = "Casting Time";
            this.spellBookCastingTime.Name = "spellBookCastingTime";
            this.spellBookCastingTime.ReadOnly = true;
            // 
            // spellDescriptionBox
            // 
            this.spellDescriptionBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.spellDescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellDescriptionBox.Enabled = false;
            this.spellDescriptionBox.Location = new System.Drawing.Point(501, 3);
            this.spellDescriptionBox.Multiline = true;
            this.spellDescriptionBox.Name = "spellDescriptionBox";
            this.spellDescriptionBox.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.spellDescriptionBox, 2);
            this.spellDescriptionBox.Size = new System.Drawing.Size(244, 466);
            this.spellDescriptionBox.TabIndex = 0;
            // 
            // Familiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(764, 534);
            this.Name = "Familiar";
            this.Text = "Squire - Familiar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preparedSpellsList)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellBookGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSpellbookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSpellbookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSpellToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox spellDescriptionBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListBox preparedSpellLevels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView spellBookGrid;
        private System.Windows.Forms.DataGridView preparedSpellsList;
        private System.Windows.Forms.ProgressBar preparedSpellsRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparedSpellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparedSpellLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparedSpellSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparedSpellComponents;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparedSpellCastingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellBookLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellBookSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellBookComponents;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellBookCastingTime;
    }
}