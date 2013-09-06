namespace Squire
{
    partial class NewPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayer));
            this.NewPlayerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HPBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.NewPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewPlayerPanel
            // 
            this.NewPlayerPanel.ColumnCount = 2;
            this.NewPlayerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.65892F));
            this.NewPlayerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.34109F));
            this.NewPlayerPanel.Controls.Add(this.label1, 0, 0);
            this.NewPlayerPanel.Controls.Add(this.label2, 0, 2);
            this.NewPlayerPanel.Controls.Add(this.HPBox, 1, 2);
            this.NewPlayerPanel.Controls.Add(this.label3, 0, 1);
            this.NewPlayerPanel.Controls.Add(this.nameBox, 1, 1);
            this.NewPlayerPanel.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.NewPlayerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewPlayerPanel.Location = new System.Drawing.Point(0, 0);
            this.NewPlayerPanel.Name = "NewPlayerPanel";
            this.NewPlayerPanel.RowCount = 4;
            this.NewPlayerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.86957F));
            this.NewPlayerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.21739F));
            this.NewPlayerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.34783F));
            this.NewPlayerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.69565F));
            this.NewPlayerPanel.Size = new System.Drawing.Size(387, 115);
            this.NewPlayerPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.NewPlayerPanel.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your character\'s name and maximum hit points below.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hit Points";
            // 
            // HPBox
            // 
            this.HPBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HPBox.Location = new System.Drawing.Point(141, 56);
            this.HPBox.Name = "HPBox";
            this.HPBox.Size = new System.Drawing.Size(52, 23);
            this.HPBox.TabIndex = 1;
            this.HPBox.ValueChanged += new System.EventHandler(this.HPBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameBox.Location = new System.Drawing.Point(141, 27);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(134, 23);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.OKButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(138, 81);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 34);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelButton.Location = new System.Drawing.Point(171, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(90, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "&OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 115);
            this.Controls.Add(this.NewPlayerPanel);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPlayer";
            this.Text = "Enter character details";
            this.NewPlayerPanel.ResumeLayout(false);
            this.NewPlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel NewPlayerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown HPBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}