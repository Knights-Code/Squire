namespace Squire
{
    partial class Legend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Legend));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.playerList = new System.Windows.Forms.ListBox();
            this.enemyList = new System.Windows.Forms.ListBox();
            this.addPlayer = new System.Windows.Forms.Button();
            this.addEnemy = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.playerName = new System.Windows.Forms.TextBox();
            this.playerLevel = new System.Windows.Forms.NumericUpDown();
            this.enemyName = new System.Windows.Forms.TextBox();
            this.enemyLevel = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.enemyList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.addPlayer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addEnemy, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.calculateButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.93103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.06896F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a list of players on the left and a list of enemies on the right, then cli" +
                "ck \"Calculate\".";
            // 
            // playerList
            // 
            this.playerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerList.FormattingEnabled = true;
            this.playerList.Location = new System.Drawing.Point(3, 41);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(140, 250);
            this.playerList.TabIndex = 1;
            // 
            // enemyList
            // 
            this.enemyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enemyList.FormattingEnabled = true;
            this.enemyList.Location = new System.Drawing.Point(149, 41);
            this.enemyList.Name = "enemyList";
            this.enemyList.Size = new System.Drawing.Size(140, 250);
            this.enemyList.TabIndex = 2;
            // 
            // addPlayer
            // 
            this.addPlayer.Location = new System.Drawing.Point(3, 297);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(75, 23);
            this.addPlayer.TabIndex = 3;
            this.addPlayer.Text = "Add ...";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // addEnemy
            // 
            this.addEnemy.Location = new System.Drawing.Point(149, 297);
            this.addEnemy.Name = "addEnemy";
            this.addEnemy.Size = new System.Drawing.Size(75, 23);
            this.addEnemy.TabIndex = 4;
            this.addEnemy.Text = "Add ...";
            this.addEnemy.UseVisualStyleBackColor = true;
            this.addEnemy.Click += new System.EventHandler(this.addEnemy_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.calculateButton, 2);
            this.calculateButton.Location = new System.Drawing.Point(108, 372);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.playerName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.playerLevel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 328);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(140, 32);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.enemyName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.enemyLevel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(149, 328);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(140, 32);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(3, 3);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(64, 20);
            this.playerName.TabIndex = 0;
            // 
            // playerLevel
            // 
            this.playerLevel.Location = new System.Drawing.Point(73, 3);
            this.playerLevel.Name = "playerLevel";
            this.playerLevel.Size = new System.Drawing.Size(64, 20);
            this.playerLevel.TabIndex = 1;
            // 
            // enemyName
            // 
            this.enemyName.Location = new System.Drawing.Point(3, 3);
            this.enemyName.Name = "enemyName";
            this.enemyName.Size = new System.Drawing.Size(64, 20);
            this.enemyName.TabIndex = 0;
            // 
            // enemyLevel
            // 
            this.enemyLevel.Location = new System.Drawing.Point(73, 3);
            this.enemyLevel.Name = "enemyLevel";
            this.enemyLevel.Size = new System.Drawing.Size(64, 20);
            this.enemyLevel.TabIndex = 1;
            // 
            // Legend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Legend";
            this.Text = "Legend";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox enemyName;
        private System.Windows.Forms.NumericUpDown enemyLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.ListBox enemyList;
        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.Button addEnemy;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.NumericUpDown playerLevel;
    }
}