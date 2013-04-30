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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.enemyName = new System.Windows.Forms.TextBox();
            this.enemyLevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.playerList = new System.Windows.Forms.ListBox();
            this.enemyList = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.playerName = new System.Windows.Forms.TextBox();
            this.playerLevel = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.addPlayer = new System.Windows.Forms.Button();
            this.removePlayer = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.addEnemy = new System.Windows.Forms.Button();
            this.removeEnemy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyLevel)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerLevel)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.calculateButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.58242F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.41758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.enemyName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.enemyLevel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(149, 216);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(140, 32);
            this.tableLayoutPanel3.TabIndex = 7;
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
            this.enemyLevel.DecimalPlaces = 2;
            this.enemyLevel.Location = new System.Drawing.Point(73, 3);
            this.enemyLevel.Name = "enemyLevel";
            this.enemyLevel.Size = new System.Drawing.Size(64, 20);
            this.enemyLevel.TabIndex = 1;
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
            this.playerList.Location = new System.Drawing.Point(3, 35);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(140, 144);
            this.playerList.TabIndex = 1;
            // 
            // enemyList
            // 
            this.enemyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enemyList.FormattingEnabled = true;
            this.enemyList.Location = new System.Drawing.Point(149, 35);
            this.enemyList.Name = "enemyList";
            this.enemyList.Size = new System.Drawing.Size(140, 144);
            this.enemyList.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.calculateButton, 2);
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(108, 260);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 216);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(140, 32);
            this.tableLayoutPanel2.TabIndex = 6;
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
            this.playerLevel.DecimalPlaces = 2;
            this.playerLevel.Location = new System.Drawing.Point(73, 3);
            this.playerLevel.Name = "playerLevel";
            this.playerLevel.Size = new System.Drawing.Size(64, 20);
            this.playerLevel.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.addPlayer, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.removePlayer, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 182);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(146, 31);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // addPlayer
            // 
            this.addPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPlayer.Location = new System.Drawing.Point(3, 4);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(67, 23);
            this.addPlayer.TabIndex = 3;
            this.addPlayer.Text = "Add";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // removePlayer
            // 
            this.removePlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removePlayer.Location = new System.Drawing.Point(76, 4);
            this.removePlayer.Name = "removePlayer";
            this.removePlayer.Size = new System.Drawing.Size(67, 23);
            this.removePlayer.TabIndex = 4;
            this.removePlayer.Text = "Remove";
            this.removePlayer.UseVisualStyleBackColor = true;
            this.removePlayer.Click += new System.EventHandler(this.removePlayer_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.addEnemy, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.removeEnemy, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(146, 182);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(146, 31);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // addEnemy
            // 
            this.addEnemy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEnemy.Location = new System.Drawing.Point(3, 4);
            this.addEnemy.Name = "addEnemy";
            this.addEnemy.Size = new System.Drawing.Size(67, 23);
            this.addEnemy.TabIndex = 4;
            this.addEnemy.Text = "Add";
            this.addEnemy.UseVisualStyleBackColor = true;
            this.addEnemy.Click += new System.EventHandler(this.addEnemy_Click);
            // 
            // removeEnemy
            // 
            this.removeEnemy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeEnemy.Location = new System.Drawing.Point(76, 4);
            this.removeEnemy.Name = "removeEnemy";
            this.removeEnemy.Size = new System.Drawing.Size(67, 23);
            this.removeEnemy.TabIndex = 5;
            this.removeEnemy.Text = "Remove";
            this.removeEnemy.UseVisualStyleBackColor = true;
            this.removeEnemy.Click += new System.EventHandler(this.removeEnemy_Click);
            // 
            // Legend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 313);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Legend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legend";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyLevel)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerLevel)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button removePlayer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button removeEnemy;
    }
}