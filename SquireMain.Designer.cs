namespace Squire
{
    partial class SquireMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SquireMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.levelUpButton = new System.Windows.Forms.Button();
            this.generalButton = new System.Windows.Forms.Button();
            this.legendButton = new System.Windows.Forms.Button();
            this.playerManifestButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 336);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.levelUpButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.generalButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.legendButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.playerManifestButton, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 172);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(332, 160);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // levelUpButton
            // 
            this.levelUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelUpButton.Location = new System.Drawing.Point(39, 26);
            this.levelUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.levelUpButton.Name = "levelUpButton";
            this.levelUpButton.Size = new System.Drawing.Size(88, 28);
            this.levelUpButton.TabIndex = 0;
            this.levelUpButton.Text = "&Level Up";
            this.levelUpButton.UseVisualStyleBackColor = true;
            this.levelUpButton.Click += new System.EventHandler(this.levelUpButton_Click);
            // 
            // generalButton
            // 
            this.generalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generalButton.Location = new System.Drawing.Point(205, 26);
            this.generalButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(88, 28);
            this.generalButton.TabIndex = 1;
            this.generalButton.Text = "&General";
            this.generalButton.UseVisualStyleBackColor = true;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            // 
            // legendButton
            // 
            this.legendButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.legendButton.Location = new System.Drawing.Point(39, 106);
            this.legendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.legendButton.Name = "legendButton";
            this.legendButton.Size = new System.Drawing.Size(88, 28);
            this.legendButton.TabIndex = 2;
            this.legendButton.Text = "L&egend";
            this.legendButton.UseVisualStyleBackColor = true;
            this.legendButton.Click += new System.EventHandler(this.legendButton_Click);
            // 
            // playerManifestButton
            // 
            this.playerManifestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerManifestButton.Location = new System.Drawing.Point(192, 106);
            this.playerManifestButton.Name = "playerManifestButton";
            this.playerManifestButton.Size = new System.Drawing.Size(114, 28);
            this.playerManifestButton.TabIndex = 3;
            this.playerManifestButton.Text = "&Player Manifest";
            this.playerManifestButton.UseVisualStyleBackColor = true;
            this.playerManifestButton.Click += new System.EventHandler(this.playerManifestButton_Click);
            // 
            // SquireMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SquireMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Squire";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button levelUpButton;
        private System.Windows.Forms.Button generalButton;
        private System.Windows.Forms.Button legendButton;
        private System.Windows.Forms.Button playerManifestButton;
    }
}