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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 273);
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 139);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(286, 131);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // levelUpButton
            // 
            this.levelUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelUpButton.Location = new System.Drawing.Point(34, 21);
            this.levelUpButton.Name = "levelUpButton";
            this.levelUpButton.Size = new System.Drawing.Size(75, 23);
            this.levelUpButton.TabIndex = 0;
            this.levelUpButton.Text = "&Level Up";
            this.levelUpButton.UseVisualStyleBackColor = true;
            this.levelUpButton.Click += new System.EventHandler(this.levelUpButton_Click);
            // 
            // generalButton
            // 
            this.generalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generalButton.Location = new System.Drawing.Point(177, 21);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(75, 23);
            this.generalButton.TabIndex = 1;
            this.generalButton.Text = "&General";
            this.generalButton.UseVisualStyleBackColor = true;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            // 
            // legendButton
            // 
            this.legendButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.legendButton.Location = new System.Drawing.Point(34, 86);
            this.legendButton.Name = "legendButton";
            this.legendButton.Size = new System.Drawing.Size(75, 23);
            this.legendButton.TabIndex = 2;
            this.legendButton.Text = "&Legend";
            this.legendButton.UseVisualStyleBackColor = true;
            this.legendButton.Click += new System.EventHandler(this.legendButton_Click);
            // 
            // SquireMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}