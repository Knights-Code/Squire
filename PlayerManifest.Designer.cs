namespace Squire
{
    partial class PlayerManifest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerManifest));
            this.menuPlayerManifest = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.manifest = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BaseAC = new System.Windows.Forms.NumericUpDown();
            this.touchAC = new System.Windows.Forms.NumericUpDown();
            this.FFAC = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metricList = new System.Windows.Forms.ComboBox();
            this.currentMetric = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.addMetric = new System.Windows.Forms.Button();
            this.deleteMetric = new System.Windows.Forms.Button();
            this.menuPlayerManifest.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touchAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFAC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentMetric)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPlayerManifest
            // 
            this.menuPlayerManifest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuPlayerManifest.Location = new System.Drawing.Point(0, 0);
            this.menuPlayerManifest.Name = "menuPlayerManifest";
            this.menuPlayerManifest.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPlayerManifest.Size = new System.Drawing.Size(301, 24);
            this.menuPlayerManifest.TabIndex = 0;
            this.menuPlayerManifest.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveManifestToolStripMenuItem,
            this.openManifestToolStripMenuItem,
            this.addPlayerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveManifestToolStripMenuItem
            // 
            this.saveManifestToolStripMenuItem.Name = "saveManifestToolStripMenuItem";
            this.saveManifestToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveManifestToolStripMenuItem.Text = "Save Manifest...";
            // 
            // openManifestToolStripMenuItem
            // 
            this.openManifestToolStripMenuItem.Name = "openManifestToolStripMenuItem";
            this.openManifestToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openManifestToolStripMenuItem.Text = "Open Manifest...";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addPlayerToolStripMenuItem.Text = "Add Player...";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.55814F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.44186F));
            this.mainPanel.Controls.Add(this.manifest, 0, 0);
            this.mainPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(301, 163);
            this.mainPanel.TabIndex = 1;
            // 
            // manifest
            // 
            this.manifest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manifest.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manifest.FormattingEnabled = true;
            this.manifest.Location = new System.Drawing.Point(3, 3);
            this.manifest.Name = "manifest";
            this.manifest.Size = new System.Drawing.Size(92, 157);
            this.manifest.TabIndex = 0;
            this.manifest.SelectedIndexChanged += new System.EventHandler(this.manifest_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(101, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.40764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.59236F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(197, 157);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Armour Class";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BaseAC, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.touchAC, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.FFAC, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.38462F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.61538F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(185, 49);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FF";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Touch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BaseAC
            // 
            this.BaseAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BaseAC.Location = new System.Drawing.Point(3, 23);
            this.BaseAC.Name = "BaseAC";
            this.BaseAC.Size = new System.Drawing.Size(55, 21);
            this.BaseAC.TabIndex = 3;
            // 
            // touchAC
            // 
            this.touchAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.touchAC.Location = new System.Drawing.Point(64, 23);
            this.touchAC.Name = "touchAC";
            this.touchAC.Size = new System.Drawing.Size(55, 21);
            this.touchAC.TabIndex = 4;
            // 
            // FFAC
            // 
            this.FFAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FFAC.Location = new System.Drawing.Point(125, 23);
            this.FFAC.Name = "FFAC";
            this.FFAC.Size = new System.Drawing.Size(57, 21);
            this.FFAC.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metrics";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.13513F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.86486F));
            this.tableLayoutPanel3.Controls.Add(this.metricList, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.currentMetric, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.07143F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.92857F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(185, 56);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // metricList
            // 
            this.metricList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metricList.FormattingEnabled = true;
            this.metricList.Location = new System.Drawing.Point(3, 3);
            this.metricList.Name = "metricList";
            this.metricList.Size = new System.Drawing.Size(133, 21);
            this.metricList.TabIndex = 0;
            // 
            // currentMetric
            // 
            this.currentMetric.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.currentMetric.Location = new System.Drawing.Point(142, 3);
            this.currentMetric.Name = "currentMetric";
            this.currentMetric.Size = new System.Drawing.Size(40, 21);
            this.currentMetric.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.addMetric, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.deleteMetric, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(179, 27);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // addMetric
            // 
            this.addMetric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addMetric.Location = new System.Drawing.Point(7, 3);
            this.addMetric.Name = "addMetric";
            this.addMetric.Size = new System.Drawing.Size(75, 21);
            this.addMetric.TabIndex = 1;
            this.addMetric.Text = "Add";
            this.addMetric.UseVisualStyleBackColor = true;
            // 
            // deleteMetric
            // 
            this.deleteMetric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteMetric.Location = new System.Drawing.Point(96, 3);
            this.deleteMetric.Name = "deleteMetric";
            this.deleteMetric.Size = new System.Drawing.Size(75, 21);
            this.deleteMetric.TabIndex = 2;
            this.deleteMetric.Text = "Delete";
            this.deleteMetric.UseVisualStyleBackColor = true;
            // 
            // PlayerManifest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 187);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPlayerManifest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPlayerManifest;
            this.MaximizeBox = false;
            this.Name = "PlayerManifest";
            this.Text = "Player Manifest";
            this.menuPlayerManifest.ResumeLayout(false);
            this.menuPlayerManifest.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touchAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFAC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentMetric)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPlayerManifest;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveManifestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openManifestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BaseAC;
        private System.Windows.Forms.NumericUpDown touchAC;
        private System.Windows.Forms.NumericUpDown FFAC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox metricList;
        private System.Windows.Forms.NumericUpDown currentMetric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button addMetric;
        private System.Windows.Forms.Button deleteMetric;
        public System.Windows.Forms.ListBox manifest;
    }
}