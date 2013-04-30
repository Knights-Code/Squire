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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.checkboxIsPlayer = new System.Windows.Forms.CheckBox();
            this.useBatch = new System.Windows.Forms.CheckBox();
            this.useGenerousHP = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addCancel = new System.Windows.Forms.Button();
            this.addOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCombatantName = new System.Windows.Forms.Label();
            this.combatantName = new System.Windows.Forms.TextBox();
            this.labelCombatantHP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.batchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.batchNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.batchExpression = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.batchCR = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.combatantLevel = new System.Windows.Forms.NumericUpDown();
            this.combatantHP = new Squire.NumericTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatantLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 226);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.38461F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.61539F));
            this.tableLayoutPanel2.Controls.Add(this.labelAddCombatant, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 75);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelAddCombatant
            // 
            this.labelAddCombatant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAddCombatant.AutoSize = true;
            this.labelAddCombatant.Location = new System.Drawing.Point(3, 31);
            this.labelAddCombatant.Name = "labelAddCombatant";
            this.labelAddCombatant.Size = new System.Drawing.Size(237, 13);
            this.labelAddCombatant.TabIndex = 0;
            this.labelAddCombatant.Text = "Enter the details of the new combatant(s), below.\r\n";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.checkboxIsPlayer, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.useBatch, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.useGenerousHP, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(368, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(149, 69);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // checkboxIsPlayer
            // 
            this.checkboxIsPlayer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkboxIsPlayer.AutoSize = true;
            this.checkboxIsPlayer.Location = new System.Drawing.Point(3, 3);
            this.checkboxIsPlayer.Name = "checkboxIsPlayer";
            this.checkboxIsPlayer.Size = new System.Drawing.Size(61, 17);
            this.checkboxIsPlayer.TabIndex = 1;
            this.checkboxIsPlayer.Text = "Player?";
            this.checkboxIsPlayer.UseVisualStyleBackColor = true;
            this.checkboxIsPlayer.CheckedChanged += new System.EventHandler(this.checkboxIsPlayer_CheckedChanged);
            // 
            // useBatch
            // 
            this.useBatch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.useBatch.AutoSize = true;
            this.useBatch.Location = new System.Drawing.Point(3, 27);
            this.useBatch.Name = "useBatch";
            this.useBatch.Size = new System.Drawing.Size(104, 17);
            this.useBatch.TabIndex = 2;
            this.useBatch.Text = "Use Batch Add?";
            this.useBatch.UseVisualStyleBackColor = true;
            this.useBatch.CheckedChanged += new System.EventHandler(this.useBatch_CheckedChanged);
            // 
            // useGenerousHP
            // 
            this.useGenerousHP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.useGenerousHP.AutoSize = true;
            this.useGenerousHP.Enabled = false;
            this.useGenerousHP.Location = new System.Drawing.Point(3, 51);
            this.useGenerousHP.Name = "useGenerousHP";
            this.useGenerousHP.Size = new System.Drawing.Size(128, 15);
            this.useGenerousHP.TabIndex = 3;
            this.useGenerousHP.Text = "Use \"Generous HP\"?";
            this.useGenerousHP.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addCancel);
            this.flowLayoutPanel1.Controls.Add(this.addOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 196);
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
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 84);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(520, 109);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Single";
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
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.combatantLevel, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(248, 84);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelCombatantName
            // 
            this.labelCombatantName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCombatantName.AutoSize = true;
            this.labelCombatantName.Location = new System.Drawing.Point(80, 7);
            this.labelCombatantName.Name = "labelCombatantName";
            this.labelCombatantName.Size = new System.Drawing.Size(35, 13);
            this.labelCombatantName.TabIndex = 0;
            this.labelCombatantName.Text = "Name";
            // 
            // combatantName
            // 
            this.combatantName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combatantName.Location = new System.Drawing.Point(121, 3);
            this.combatantName.Name = "combatantName";
            this.combatantName.Size = new System.Drawing.Size(118, 20);
            this.combatantName.TabIndex = 0;
            // 
            // labelCombatantHP
            // 
            this.labelCombatantHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCombatantHP.AutoSize = true;
            this.labelCombatantHP.Location = new System.Drawing.Point(63, 34);
            this.labelCombatantHP.Name = "labelCombatantHP";
            this.labelCombatantHP.Size = new System.Drawing.Size(52, 13);
            this.labelCombatantHP.TabIndex = 2;
            this.labelCombatantHP.Text = "Hit Points";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(263, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Multiple (\"Batch\" Add)";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.batchName, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.batchNumber, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.batchExpression, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.batchCR, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(248, 84);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // batchName
            // 
            this.batchName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.batchName.Enabled = false;
            this.batchName.Location = new System.Drawing.Point(47, 3);
            this.batchName.Name = "batchName";
            this.batchName.Size = new System.Drawing.Size(75, 20);
            this.batchName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "How Many?";
            // 
            // batchNumber
            // 
            this.batchNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batchNumber.Enabled = false;
            this.batchNumber.Location = new System.Drawing.Point(203, 3);
            this.batchNumber.Name = "batchNumber";
            this.batchNumber.Size = new System.Drawing.Size(42, 20);
            this.batchNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(148, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "HP Expression";
            // 
            // batchExpression
            // 
            this.batchExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.batchExpression, 2);
            this.batchExpression.Enabled = false;
            this.batchExpression.Location = new System.Drawing.Point(128, 59);
            this.batchExpression.Name = "batchExpression";
            this.batchExpression.Size = new System.Drawing.Size(117, 20);
            this.batchExpression.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 49);
            this.label4.Name = "label4";
            this.tableLayoutPanel5.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CR";
            // 
            // batchCR
            // 
            this.batchCR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batchCR.DecimalPlaces = 2;
            this.batchCR.Enabled = false;
            this.batchCR.Location = new System.Drawing.Point(61, 45);
            this.batchCR.Name = "batchCR";
            this.tableLayoutPanel5.SetRowSpan(this.batchCR, 2);
            this.batchCR.Size = new System.Drawing.Size(46, 20);
            this.batchCR.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Level";
            // 
            // combatantLevel
            // 
            this.combatantLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combatantLevel.DecimalPlaces = 2;
            this.combatantLevel.Location = new System.Drawing.Point(121, 59);
            this.combatantLevel.Name = "combatantLevel";
            this.combatantLevel.Size = new System.Drawing.Size(120, 20);
            this.combatantLevel.TabIndex = 5;
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
            this.combatantHP.Location = new System.Drawing.Point(121, 30);
            this.combatantHP.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.combatantHP.Name = "combatantHP";
            this.combatantHP.Size = new System.Drawing.Size(118, 20);
            this.combatantHP.TabIndex = 3;
            this.combatantHP.Text = "0";
            // 
            // AddCombatant
            // 
            this.AcceptButton = this.addOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.addCancel;
            this.ClientSize = new System.Drawing.Size(526, 226);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCombatant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Combatant";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatantLevel)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox batchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown batchNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox batchExpression;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox useBatch;
        private System.Windows.Forms.CheckBox useGenerousHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown combatantLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown batchCR;
    }
}