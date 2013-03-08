namespace Squire
{
    partial class AddCombatant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCombatant));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelAddCombatant = new System.Windows.Forms.Label();
            this.checkboxIsPlayer = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCombatantName = new System.Windows.Forms.Label();
            this.combatantName = new System.Windows.Forms.TextBox();
            this.combatantHP = new Squire.NumericTextBox();
            this.labelCombatantHP = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addCancel = new System.Windows.Forms.Button();
            this.addOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 130);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.86713F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.13287F));
            this.tableLayoutPanel2.Controls.Add(this.labelAddCombatant, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkboxIsPlayer, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 24);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelAddCombatant
            // 
            this.labelAddCombatant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAddCombatant.AutoSize = true;
            this.labelAddCombatant.Location = new System.Drawing.Point(3, 5);
            this.labelAddCombatant.Name = "labelAddCombatant";
            this.labelAddCombatant.Size = new System.Drawing.Size(410, 13);
            this.labelAddCombatant.TabIndex = 0;
            this.labelAddCombatant.Text = "Enter the name (and hit points in the case of a monster) of the new combatant, be" +
                "low.\r\n";
            // 
            // checkboxIsPlayer
            // 
            this.checkboxIsPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkboxIsPlayer.AutoSize = true;
            this.checkboxIsPlayer.Location = new System.Drawing.Point(444, 3);
            this.checkboxIsPlayer.Name = "checkboxIsPlayer";
            this.checkboxIsPlayer.Size = new System.Drawing.Size(61, 17);
            this.checkboxIsPlayer.TabIndex = 1;
            this.checkboxIsPlayer.Text = "Player?";
            this.checkboxIsPlayer.UseVisualStyleBackColor = true;
            this.checkboxIsPlayer.CheckedChanged += new System.EventHandler(this.checkboxIsPlayer_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.88462F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.11538F));
            this.tableLayoutPanel3.Controls.Add(this.labelCombatantName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.combatantName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.combatantHP, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelCombatantHP, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(520, 64);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelCombatantName
            // 
            this.labelCombatantName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCombatantName.AutoSize = true;
            this.labelCombatantName.Location = new System.Drawing.Point(211, 9);
            this.labelCombatantName.Name = "labelCombatantName";
            this.labelCombatantName.Size = new System.Drawing.Size(35, 13);
            this.labelCombatantName.TabIndex = 0;
            this.labelCombatantName.Text = "Name";
            // 
            // combatantName
            // 
            this.combatantName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combatantName.Location = new System.Drawing.Point(252, 6);
            this.combatantName.Name = "combatantName";
            this.combatantName.Size = new System.Drawing.Size(118, 20);
            this.combatantName.TabIndex = 0;
            // 
            // combatantHP
            // 
            this.combatantHP.AllowSpace = false;
            this.combatantHP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combatantHP.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.combatantHP.IntValue = 0;
            this.combatantHP.Location = new System.Drawing.Point(252, 38);
            this.combatantHP.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.combatantHP.Name = "combatantHP";
            this.combatantHP.Size = new System.Drawing.Size(118, 20);
            this.combatantHP.TabIndex = 3;
            this.combatantHP.Text = "0";
            // 
            // labelCombatantHP
            // 
            this.labelCombatantHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCombatantHP.AutoSize = true;
            this.labelCombatantHP.Location = new System.Drawing.Point(194, 41);
            this.labelCombatantHP.Name = "labelCombatantHP";
            this.labelCombatantHP.Size = new System.Drawing.Size(52, 13);
            this.labelCombatantHP.TabIndex = 2;
            this.labelCombatantHP.Text = "Hit Points";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addCancel);
            this.flowLayoutPanel1.Controls.Add(this.addOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // addCancel
            // 
            this.addCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addCancel.Location = new System.Drawing.Point(448, 3);
            this.addCancel.Name = "addCancel";
            this.addCancel.Size = new System.Drawing.Size(75, 23);
            this.addCancel.TabIndex = 0;
            this.addCancel.Text = "&Cancel";
            this.addCancel.UseVisualStyleBackColor = true;
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // addOK
            // 
            this.addOK.Location = new System.Drawing.Point(367, 3);
            this.addOK.Name = "addOK";
            this.addOK.Size = new System.Drawing.Size(75, 23);
            this.addOK.TabIndex = 1;
            this.addOK.Text = "&OK";
            this.addOK.UseVisualStyleBackColor = true;
            this.addOK.Click += new System.EventHandler(this.addOK_Click);
            // 
            // AddCombatant
            // 
            this.AcceptButton = this.addOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.addCancel;
            this.ClientSize = new System.Drawing.Size(526, 130);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCombatant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Combatant";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelAddCombatant;
        private System.Windows.Forms.CheckBox checkboxIsPlayer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelCombatantName;
        private System.Windows.Forms.TextBox combatantName;
        private System.Windows.Forms.Label labelCombatantHP;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addCancel;
        private System.Windows.Forms.Button addOK;
        private NumericTextBox combatantHP;
    }
}