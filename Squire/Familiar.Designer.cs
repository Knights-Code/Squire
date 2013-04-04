namespace Squire
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
            this.printSpellbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreparedSpellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.preparedSpellsGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.preparedSpellLevels = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.preparedSpellsProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.spellBookGrid = new System.Windows.Forms.DataGridView();
            this.spellDescriptionBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.spellsRemainingLabel = new System.Windows.Forms.Label();
            this.outof = new System.Windows.Forms.Label();
            this.totalSpellsLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preparedSpellsGrid)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellBookGrid)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
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
            this.addSpellToolStripMenuItem,
            this.printSpellbookToolStripMenuItem,
            this.printPreparedSpellsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSpellbookToolStripMenuItem
            // 
            this.openSpellbookToolStripMenuItem.Name = "openSpellbookToolStripMenuItem";
            this.openSpellbookToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openSpellbookToolStripMenuItem.Text = "Open Spellbook";
            // 
            // saveSpellbookToolStripMenuItem
            // 
            this.saveSpellbookToolStripMenuItem.Name = "saveSpellbookToolStripMenuItem";
            this.saveSpellbookToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveSpellbookToolStripMenuItem.Text = "Save Spellbook";
            // 
            // addSpellToolStripMenuItem
            // 
            this.addSpellToolStripMenuItem.Name = "addSpellToolStripMenuItem";
            this.addSpellToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addSpellToolStripMenuItem.Text = "Add Spell to Spellbook";
            this.addSpellToolStripMenuItem.Click += new System.EventHandler(this.addSpellToolStripMenuItem_Click);
            // 
            // printSpellbookToolStripMenuItem
            // 
            this.printSpellbookToolStripMenuItem.Name = "printSpellbookToolStripMenuItem";
            this.printSpellbookToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.printSpellbookToolStripMenuItem.Text = "Print Spellbook";
            // 
            // printPreparedSpellsToolStripMenuItem
            // 
            this.printPreparedSpellsToolStripMenuItem.Name = "printPreparedSpellsToolStripMenuItem";
            this.printPreparedSpellsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.printPreparedSpellsToolStripMenuItem.Text = "Print Prepared Spells";
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
            this.tableLayoutPanel4.Controls.Add(this.preparedSpellsGrid, 0, 1);
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
            // preparedSpellsGrid
            // 
            this.preparedSpellsGrid.AllowUserToOrderColumns = true;
            this.preparedSpellsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preparedSpellsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preparedSpellsGrid.Location = new System.Drawing.Point(3, 53);
            this.preparedSpellsGrid.Name = "preparedSpellsGrid";
            this.preparedSpellsGrid.Size = new System.Drawing.Size(480, 148);
            this.preparedSpellsGrid.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.tableLayoutPanel5.Controls.Add(this.preparedSpellLevels, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(480, 44);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // preparedSpellLevels
            // 
            this.preparedSpellLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preparedSpellLevels.FormattingEnabled = true;
            this.preparedSpellLevels.Items.AddRange(new object[] {
            "All"});
            this.preparedSpellLevels.Location = new System.Drawing.Point(3, 3);
            this.preparedSpellLevels.MinimumSize = new System.Drawing.Size(103, 38);
            this.preparedSpellLevels.Name = "preparedSpellLevels";
            this.preparedSpellLevels.Size = new System.Drawing.Size(103, 38);
            this.preparedSpellLevels.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.preparedSpellsProgressBar, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(109, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(371, 44);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // preparedSpellsProgressBar
            // 
            this.preparedSpellsProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preparedSpellsProgressBar.Location = new System.Drawing.Point(3, 3);
            this.preparedSpellsProgressBar.Name = "preparedSpellsProgressBar";
            this.preparedSpellsProgressBar.Size = new System.Drawing.Size(365, 16);
            this.preparedSpellsProgressBar.TabIndex = 0;
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
            this.spellBookGrid.AllowUserToAddRows = false;
            this.spellBookGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.spellBookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spellBookGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellBookGrid.Location = new System.Drawing.Point(3, 23);
            this.spellBookGrid.MultiSelect = false;
            this.spellBookGrid.Name = "spellBookGrid";
            this.spellBookGrid.ReadOnly = true;
            this.spellBookGrid.Size = new System.Drawing.Size(486, 204);
            this.spellBookGrid.TabIndex = 1;
            this.spellBookGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spellBookGrid_CellContentClick);
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
            this.spellDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.spellDescriptionBox.Size = new System.Drawing.Size(244, 466);
            this.spellDescriptionBox.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel7.Controls.Add(this.spellsRemainingLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.outof, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.totalSpellsLabel, 2, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(243, 25);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(125, 16);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // spellsRemainingLabel
            // 
            this.spellsRemainingLabel.AutoSize = true;
            this.spellsRemainingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellsRemainingLabel.Location = new System.Drawing.Point(3, 0);
            this.spellsRemainingLabel.Name = "spellsRemainingLabel";
            this.spellsRemainingLabel.Size = new System.Drawing.Size(30, 16);
            this.spellsRemainingLabel.TabIndex = 0;
            this.spellsRemainingLabel.Text = "0";
            this.spellsRemainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outof
            // 
            this.outof.AutoSize = true;
            this.outof.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outof.Location = new System.Drawing.Point(39, 0);
            this.outof.Name = "outof";
            this.outof.Size = new System.Drawing.Size(46, 16);
            this.outof.TabIndex = 1;
            this.outof.Text = "out of";
            this.outof.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSpellsLabel
            // 
            this.totalSpellsLabel.AutoSize = true;
            this.totalSpellsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalSpellsLabel.Location = new System.Drawing.Point(91, 0);
            this.totalSpellsLabel.Name = "totalSpellsLabel";
            this.totalSpellsLabel.Size = new System.Drawing.Size(31, 16);
            this.totalSpellsLabel.TabIndex = 2;
            this.totalSpellsLabel.Text = "0";
            this.totalSpellsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Load += new System.EventHandler(this.Familiar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preparedSpellsGrid)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellBookGrid)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
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
        public System.Windows.Forms.DataGridView spellBookGrid;
        private System.Windows.Forms.DataGridView preparedSpellsGrid;
        private System.Windows.Forms.ToolStripMenuItem printSpellbookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreparedSpellsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ProgressBar preparedSpellsProgressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label spellsRemainingLabel;
        private System.Windows.Forms.Label outof;
        private System.Windows.Forms.Label totalSpellsLabel;
    }
}