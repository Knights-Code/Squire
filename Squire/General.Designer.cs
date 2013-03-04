namespace Squire
{
    partial class General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.tabPlayer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCombatants = new System.Windows.Forms.Label();
            this.listCombatants = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupStats = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHP = new System.Windows.Forms.Label();
            this.HPBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.subtractHPButton = new System.Windows.Forms.Button();
            this.addHPButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.numericTextBox1 = new Squire.NumericTextBox();
            this.tabPlayer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupStats.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPlayer
            // 
            this.tabPlayer.Controls.Add(this.tabPage1);
            this.tabPlayer.Controls.Add(this.tabPage2);
            this.tabPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPlayer.Location = new System.Drawing.Point(0, 0);
            this.tabPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.tabPlayer.Name = "tabPlayer";
            this.tabPlayer.SelectedIndex = 0;
            this.tabPlayer.Size = new System.Drawing.Size(748, 447);
            this.tabPlayer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.88011F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.11989F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 415);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelCombatants, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listCombatants, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 415);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelCombatants
            // 
            this.labelCombatants.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCombatants.AutoSize = true;
            this.labelCombatants.Location = new System.Drawing.Point(85, 3);
            this.labelCombatants.Name = "labelCombatants";
            this.labelCombatants.Size = new System.Drawing.Size(63, 13);
            this.labelCombatants.TabIndex = 0;
            this.labelCombatants.Text = "Combatants";
            // 
            // listCombatants
            // 
            this.listCombatants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCombatants.FormattingEnabled = true;
            this.listCombatants.Location = new System.Drawing.Point(3, 23);
            this.listCombatants.Name = "listCombatants";
            this.listCombatants.Size = new System.Drawing.Size(228, 364);
            this.listCombatants.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.moveUpButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.addButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.moveDownButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 390);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(234, 25);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // moveUpButton
            // 
            this.moveUpButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.moveUpButton.Location = new System.Drawing.Point(3, 1);
            this.moveUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(75, 23);
            this.moveUpButton.TabIndex = 0;
            this.moveUpButton.Text = "Move Up";
            this.moveUpButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Location = new System.Drawing.Point(79, 1);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // moveDownButton
            // 
            this.moveDownButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.moveDownButton.Location = new System.Drawing.Point(156, 1);
            this.moveDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(75, 23);
            this.moveDownButton.TabIndex = 2;
            this.moveDownButton.Text = "Move Down";
            this.moveDownButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupStats, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(237, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.46725F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.53275F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(494, 409);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // groupStats
            // 
            this.groupStats.Controls.Add(this.tableLayoutPanel5);
            this.groupStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupStats.Location = new System.Drawing.Point(3, 3);
            this.groupStats.Name = "groupStats";
            this.groupStats.Size = new System.Drawing.Size(488, 269);
            this.groupStats.TabIndex = 0;
            this.groupStats.TabStop = false;
            this.groupStats.Text = "Statistics";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.78223F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.21777F));
            this.tableLayoutPanel5.Controls.Add(this.labelHP, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.HPBar, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(482, 250);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // labelHP
            // 
            this.labelHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(46, 13);
            this.labelHP.Name = "labelHP";
            this.tableLayoutPanel5.SetRowSpan(this.labelHP, 2);
            this.labelHP.Size = new System.Drawing.Size(22, 13);
            this.labelHP.TabIndex = 0;
            this.labelHP.Text = "HP";
            // 
            // HPBar
            // 
            this.HPBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HPBar.Location = new System.Drawing.Point(117, 3);
            this.HPBar.Name = "HPBar";
            this.HPBar.Size = new System.Drawing.Size(362, 14);
            this.HPBar.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel6.Controls.Add(this.subtractHPButton, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.numericTextBox1, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.addHPButton, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(114, 20);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(368, 20);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // subtractHPButton
            // 
            this.subtractHPButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subtractHPButton.Location = new System.Drawing.Point(139, 0);
            this.subtractHPButton.Margin = new System.Windows.Forms.Padding(0);
            this.subtractHPButton.Name = "subtractHPButton";
            this.subtractHPButton.Size = new System.Drawing.Size(20, 20);
            this.subtractHPButton.TabIndex = 0;
            this.subtractHPButton.Text = "–";
            this.subtractHPButton.UseVisualStyleBackColor = true;
            // 
            // addHPButton
            // 
            this.addHPButton.Location = new System.Drawing.Point(207, 0);
            this.addHPButton.Margin = new System.Windows.Forms.Padding(0);
            this.addHPButton.Name = "addHPButton";
            this.addHPButton.Size = new System.Drawing.Size(20, 20);
            this.addHPButton.TabIndex = 2;
            this.addHPButton.Text = "+";
            this.addHPButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save Battle ...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open Battle ...";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tabPlayer, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.closeButton, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(748, 472);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.Location = new System.Drawing.Point(673, 448);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.AllowSpace = false;
            this.numericTextBox1.Location = new System.Drawing.Point(159, 0);
            this.numericTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(48, 20);
            this.numericTextBox1.TabIndex = 1;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 496);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "General";
            this.Text = "Squire - General";
            this.tabPlayer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupStats.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPlayer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelCombatants;
        private System.Windows.Forms.ListBox listCombatants;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.ProgressBar HPBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button subtractHPButton;
        private NumericTextBox numericTextBox1;
        private System.Windows.Forms.Button addHPButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button closeButton;
    }
}