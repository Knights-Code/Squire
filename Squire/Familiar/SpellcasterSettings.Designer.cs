namespace Squire
{
    partial class SpellcasterSettings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.spellCountBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.spellLevelListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.spellsReaminingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.spellsPerDayLabel = new System.Windows.Forms.Label();
            this.spellsRemainingLabel = new System.Windows.Forms.Label();
            this.spellsPerDayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.highestSpellLevelBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.highestSpellLabel = new System.Windows.Forms.Label();
            this.highestSpellLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.spellTypesAndLevelBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.clearCustomTextButton = new System.Windows.Forms.Button();
            this.removeClassOrDomainButton = new System.Windows.Forms.Button();
            this.addClassOrDomainButton = new System.Windows.Forms.Button();
            this.spellcasterClassesAndDomains = new System.Windows.Forms.ListBox();
            this.masterListOfClassesAndDomains = new System.Windows.Forms.ListBox();
            this.customClassDomainTextbox = new System.Windows.Forms.TextBox();
            this.spellcasterTypeBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.spontaneousCasterRadioButton = new System.Windows.Forms.RadioButton();
            this.preparedCasterRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelSettingsButton = new System.Windows.Forms.Button();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.removePreparedSpell = new System.Windows.Forms.Button();
            this.addPreparedSpell = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.showAllSpellsCheckbox = new System.Windows.Forms.CheckBox();
            this.spellLevelComboBox = new System.Windows.Forms.ComboBox();
            this.spellsPreparedLabel = new System.Windows.Forms.Label();
            this.spellBook = new System.Windows.Forms.DataGridView();
            this.preparedSpells = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.spellCountBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellsReaminingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellsPerDayNumericUpDown)).BeginInit();
            this.highestSpellLevelBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highestSpellLevelNumericUpDown)).BeginInit();
            this.spellTypesAndLevelBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.spellcasterTypeBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparedSpells)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spellcaster Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.spellCountBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.highestSpellLevelBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.spellTypesAndLevelBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.spellcasterTypeBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.01418F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.98582F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 516);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // spellCountBox
            // 
            this.spellCountBox.Controls.Add(this.tableLayoutPanel5);
            this.spellCountBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellCountBox.Location = new System.Drawing.Point(3, 328);
            this.spellCountBox.Name = "spellCountBox";
            this.spellCountBox.Size = new System.Drawing.Size(447, 144);
            this.spellCountBox.TabIndex = 6;
            this.spellCountBox.TabStop = false;
            this.spellCountBox.Text = "Spells Per Day and Spells Remaining";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.68668F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.31332F));
            this.tableLayoutPanel5.Controls.Add(this.spellLevelListBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(441, 125);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // spellLevelListBox
            // 
            this.spellLevelListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellLevelListBox.FormattingEnabled = true;
            this.spellLevelListBox.Items.AddRange(new object[] {
            "Level 0"});
            this.spellLevelListBox.Location = new System.Drawing.Point(3, 3);
            this.spellLevelListBox.Name = "spellLevelListBox";
            this.spellLevelListBox.Size = new System.Drawing.Size(169, 119);
            this.spellLevelListBox.TabIndex = 0;
            this.spellLevelListBox.SelectedIndexChanged += new System.EventHandler(this.spellLevelListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.spellsReaminingNumericUpDown, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.spellsPerDayLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.spellsRemainingLabel, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.spellsPerDayNumericUpDown, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(178, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(260, 119);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // spellsReaminingNumericUpDown
            // 
            this.spellsReaminingNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spellsReaminingNumericUpDown.Location = new System.Drawing.Point(165, 79);
            this.spellsReaminingNumericUpDown.Name = "spellsReaminingNumericUpDown";
            this.spellsReaminingNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.spellsReaminingNumericUpDown.TabIndex = 5;
            // 
            // spellsPerDayLabel
            // 
            this.spellsPerDayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spellsPerDayLabel.AutoSize = true;
            this.spellsPerDayLabel.Location = new System.Drawing.Point(28, 23);
            this.spellsPerDayLabel.Margin = new System.Windows.Forms.Padding(3);
            this.spellsPerDayLabel.Name = "spellsPerDayLabel";
            this.spellsPerDayLabel.Size = new System.Drawing.Size(73, 13);
            this.spellsPerDayLabel.TabIndex = 1;
            this.spellsPerDayLabel.Text = "Spells per day";
            this.spellsPerDayLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // spellsRemainingLabel
            // 
            this.spellsRemainingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spellsRemainingLabel.AutoSize = true;
            this.spellsRemainingLabel.Location = new System.Drawing.Point(23, 82);
            this.spellsRemainingLabel.Margin = new System.Windows.Forms.Padding(3);
            this.spellsRemainingLabel.Name = "spellsRemainingLabel";
            this.spellsRemainingLabel.Size = new System.Drawing.Size(83, 13);
            this.spellsRemainingLabel.TabIndex = 2;
            this.spellsRemainingLabel.Text = "Spells remaining";
            // 
            // spellsPerDayNumericUpDown
            // 
            this.spellsPerDayNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spellsPerDayNumericUpDown.Location = new System.Drawing.Point(165, 19);
            this.spellsPerDayNumericUpDown.Name = "spellsPerDayNumericUpDown";
            this.spellsPerDayNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.spellsPerDayNumericUpDown.TabIndex = 3;
            // 
            // highestSpellLevelBox
            // 
            this.highestSpellLevelBox.Controls.Add(this.tableLayoutPanel3);
            this.highestSpellLevelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highestSpellLevelBox.Location = new System.Drawing.Point(3, 278);
            this.highestSpellLevelBox.Name = "highestSpellLevelBox";
            this.highestSpellLevelBox.Size = new System.Drawing.Size(447, 44);
            this.highestSpellLevelBox.TabIndex = 5;
            this.highestSpellLevelBox.TabStop = false;
            this.highestSpellLevelBox.Text = "Highest Spell Level";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel3.Controls.Add(this.highestSpellLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.highestSpellLevelNumericUpDown, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(441, 25);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // highestSpellLabel
            // 
            this.highestSpellLabel.AutoSize = true;
            this.highestSpellLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.highestSpellLabel.Location = new System.Drawing.Point(64, 3);
            this.highestSpellLabel.Margin = new System.Windows.Forms.Padding(3);
            this.highestSpellLabel.Name = "highestSpellLabel";
            this.highestSpellLabel.Size = new System.Drawing.Size(217, 19);
            this.highestSpellLabel.TabIndex = 0;
            this.highestSpellLabel.Text = "What is the highest spell level you can cast?";
            this.highestSpellLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highestSpellLevelNumericUpDown
            // 
            this.highestSpellLevelNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.highestSpellLevelNumericUpDown.Location = new System.Drawing.Point(287, 3);
            this.highestSpellLevelNumericUpDown.Name = "highestSpellLevelNumericUpDown";
            this.highestSpellLevelNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.highestSpellLevelNumericUpDown.TabIndex = 1;
            this.highestSpellLevelNumericUpDown.ValueChanged += new System.EventHandler(this.highestSpellLevelNumericUpDown_ValueChanged);
            // 
            // spellTypesAndLevelBox
            // 
            this.spellTypesAndLevelBox.Controls.Add(this.tableLayoutPanel2);
            this.spellTypesAndLevelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellTypesAndLevelBox.Location = new System.Drawing.Point(3, 80);
            this.spellTypesAndLevelBox.Name = "spellTypesAndLevelBox";
            this.spellTypesAndLevelBox.Size = new System.Drawing.Size(447, 192);
            this.spellTypesAndLevelBox.TabIndex = 4;
            this.spellTypesAndLevelBox.TabStop = false;
            this.spellTypesAndLevelBox.Text = "Spellcaster Classes and Domains";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.50485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.49514F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel2.Controls.Add(this.clearCustomTextButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.removeClassOrDomainButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.addClassOrDomainButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.spellcasterClassesAndDomains, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.masterListOfClassesAndDomains, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.customClassDomainTextbox, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.58904F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.41096F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(441, 173);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // clearCustomTextButton
            // 
            this.clearCustomTextButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearCustomTextButton.Location = new System.Drawing.Point(224, 149);
            this.clearCustomTextButton.Name = "clearCustomTextButton";
            this.clearCustomTextButton.Size = new System.Drawing.Size(53, 21);
            this.clearCustomTextButton.TabIndex = 8;
            this.clearCustomTextButton.Text = "Clear";
            this.clearCustomTextButton.UseVisualStyleBackColor = true;
            this.clearCustomTextButton.Click += new System.EventHandler(this.clearCustomTextButton_Click);
            // 
            // removeClassOrDomainButton
            // 
            this.removeClassOrDomainButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.removeClassOrDomainButton.Location = new System.Drawing.Point(219, 90);
            this.removeClassOrDomainButton.Name = "removeClassOrDomainButton";
            this.removeClassOrDomainButton.Size = new System.Drawing.Size(62, 22);
            this.removeClassOrDomainButton.TabIndex = 7;
            this.removeClassOrDomainButton.Text = "Remove";
            this.removeClassOrDomainButton.UseVisualStyleBackColor = true;
            this.removeClassOrDomainButton.Click += new System.EventHandler(this.removeClassOrDomainButton_Click);
            // 
            // addClassOrDomainButton
            // 
            this.addClassOrDomainButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addClassOrDomainButton.Location = new System.Drawing.Point(219, 61);
            this.addClassOrDomainButton.Name = "addClassOrDomainButton";
            this.addClassOrDomainButton.Size = new System.Drawing.Size(62, 23);
            this.addClassOrDomainButton.TabIndex = 6;
            this.addClassOrDomainButton.Text = "Add >>";
            this.addClassOrDomainButton.UseVisualStyleBackColor = true;
            this.addClassOrDomainButton.Click += new System.EventHandler(this.addClassOrDomainButton_Click);
            // 
            // spellcasterClassesAndDomains
            // 
            this.spellcasterClassesAndDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellcasterClassesAndDomains.FormattingEnabled = true;
            this.spellcasterClassesAndDomains.Location = new System.Drawing.Point(304, 3);
            this.spellcasterClassesAndDomains.Name = "spellcasterClassesAndDomains";
            this.tableLayoutPanel2.SetRowSpan(this.spellcasterClassesAndDomains, 3);
            this.spellcasterClassesAndDomains.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.spellcasterClassesAndDomains.Size = new System.Drawing.Size(134, 167);
            this.spellcasterClassesAndDomains.TabIndex = 2;
            // 
            // masterListOfClassesAndDomains
            // 
            this.masterListOfClassesAndDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterListOfClassesAndDomains.FormattingEnabled = true;
            this.masterListOfClassesAndDomains.Items.AddRange(new object[] {
            "Bard (Brd)",
            "Cleric (Clr)",
            "Druid (Drd)",
            "Paladin (Pal)",
            "Ranger (Rgr)",
            "Sorcerer (Sor)",
            "Wizard (Wiz)",
            "Air",
            "Animal",
            "Chaos",
            "Death",
            "Destruction",
            "Earth",
            "Evil",
            "Fire",
            "Good",
            "Healing",
            "Knowledge",
            "Law",
            "Luck",
            "Magic",
            "Plant",
            "Protection",
            "Strength",
            "Sun",
            "Travel",
            "Trickery",
            "War",
            "Water"});
            this.masterListOfClassesAndDomains.Location = new System.Drawing.Point(3, 3);
            this.masterListOfClassesAndDomains.Name = "masterListOfClassesAndDomains";
            this.tableLayoutPanel2.SetRowSpan(this.masterListOfClassesAndDomains, 2);
            this.masterListOfClassesAndDomains.Size = new System.Drawing.Size(194, 140);
            this.masterListOfClassesAndDomains.TabIndex = 0;
            this.masterListOfClassesAndDomains.SelectedIndexChanged += new System.EventHandler(this.masterListOfClassesAndDomains_SelectedIndexChanged);
            // 
            // customClassDomainTextbox
            // 
            this.customClassDomainTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customClassDomainTextbox.Location = new System.Drawing.Point(3, 149);
            this.customClassDomainTextbox.Name = "customClassDomainTextbox";
            this.customClassDomainTextbox.Size = new System.Drawing.Size(194, 20);
            this.customClassDomainTextbox.TabIndex = 3;
            this.customClassDomainTextbox.Text = "Type Other Class or Domain Here";
            this.customClassDomainTextbox.TextChanged += new System.EventHandler(this.customClassDomainTextbox_TextChanged);
            // 
            // spellcasterTypeBox
            // 
            this.spellcasterTypeBox.Controls.Add(this.tableLayoutPanel4);
            this.spellcasterTypeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellcasterTypeBox.Location = new System.Drawing.Point(3, 3);
            this.spellcasterTypeBox.Name = "spellcasterTypeBox";
            this.spellcasterTypeBox.Size = new System.Drawing.Size(447, 71);
            this.spellcasterTypeBox.TabIndex = 3;
            this.spellcasterTypeBox.TabStop = false;
            this.spellcasterTypeBox.Text = "Spellcaster Type";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.spontaneousCasterRadioButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.preparedCasterRadioButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(441, 52);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // spontaneousCasterRadioButton
            // 
            this.spontaneousCasterRadioButton.AutoSize = true;
            this.spontaneousCasterRadioButton.Location = new System.Drawing.Point(3, 29);
            this.spontaneousCasterRadioButton.Name = "spontaneousCasterRadioButton";
            this.spontaneousCasterRadioButton.Size = new System.Drawing.Size(121, 17);
            this.spontaneousCasterRadioButton.TabIndex = 3;
            this.spontaneousCasterRadioButton.Text = "Spontaneous Caster";
            this.spontaneousCasterRadioButton.UseVisualStyleBackColor = true;
            // 
            // preparedCasterRadioButton
            // 
            this.preparedCasterRadioButton.AutoSize = true;
            this.preparedCasterRadioButton.Checked = true;
            this.preparedCasterRadioButton.Location = new System.Drawing.Point(3, 3);
            this.preparedCasterRadioButton.Name = "preparedCasterRadioButton";
            this.preparedCasterRadioButton.Size = new System.Drawing.Size(101, 17);
            this.preparedCasterRadioButton.TabIndex = 2;
            this.preparedCasterRadioButton.TabStop = true;
            this.preparedCasterRadioButton.Text = "Prepared Caster";
            this.preparedCasterRadioButton.UseVisualStyleBackColor = true;
            this.preparedCasterRadioButton.CheckedChanged += new System.EventHandler(this.CasterTypeRadioButton_CheckedChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.cancelSettingsButton, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.saveSettingsButton, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 478);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(447, 35);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // cancelSettingsButton
            // 
            this.cancelSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelSettingsButton.Location = new System.Drawing.Point(226, 6);
            this.cancelSettingsButton.Name = "cancelSettingsButton";
            this.cancelSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSettingsButton.TabIndex = 1;
            this.cancelSettingsButton.Text = "Cancel";
            this.cancelSettingsButton.UseVisualStyleBackColor = true;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveSettingsButton.Location = new System.Drawing.Point(131, 6);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(89, 23);
            this.saveSettingsButton.TabIndex = 0;
            this.saveSettingsButton.Text = "&Save settings";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spells Prepared";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel11, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.spellBook, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.preparedSpells, 0, 3);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.88976F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.11024F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(453, 516);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.button5, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 479);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(447, 34);
            this.tableLayoutPanel11.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.Location = new System.Drawing.Point(226, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button6.Location = new System.Drawing.Point(131, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "&Save settings";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.removePreparedSpell, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.addPreparedSpell, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 257);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(447, 34);
            this.tableLayoutPanel10.TabIndex = 8;
            // 
            // removePreparedSpell
            // 
            this.removePreparedSpell.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.removePreparedSpell.Location = new System.Drawing.Point(226, 6);
            this.removePreparedSpell.Name = "removePreparedSpell";
            this.removePreparedSpell.Size = new System.Drawing.Size(62, 22);
            this.removePreparedSpell.TabIndex = 8;
            this.removePreparedSpell.Text = "Remove";
            this.removePreparedSpell.UseVisualStyleBackColor = true;
            // 
            // addPreparedSpell
            // 
            this.addPreparedSpell.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addPreparedSpell.Location = new System.Drawing.Point(145, 5);
            this.addPreparedSpell.Name = "addPreparedSpell";
            this.addPreparedSpell.Size = new System.Drawing.Size(75, 23);
            this.addPreparedSpell.TabIndex = 7;
            this.addPreparedSpell.Text = "vv Add vv";
            this.addPreparedSpell.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.showAllSpellsCheckbox, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.spellLevelComboBox, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.spellsPreparedLabel, 0, 2);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(447, 75);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // showAllSpellsCheckbox
            // 
            this.showAllSpellsCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showAllSpellsCheckbox.AutoSize = true;
            this.showAllSpellsCheckbox.Location = new System.Drawing.Point(176, 29);
            this.showAllSpellsCheckbox.Name = "showAllSpellsCheckbox";
            this.showAllSpellsCheckbox.Size = new System.Drawing.Size(95, 17);
            this.showAllSpellsCheckbox.TabIndex = 1;
            this.showAllSpellsCheckbox.Text = "Show all spells";
            this.showAllSpellsCheckbox.UseVisualStyleBackColor = true;
            // 
            // spellLevelComboBox
            // 
            this.spellLevelComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.spellLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spellLevelComboBox.FormattingEnabled = true;
            this.spellLevelComboBox.Location = new System.Drawing.Point(163, 3);
            this.spellLevelComboBox.Name = "spellLevelComboBox";
            this.spellLevelComboBox.Size = new System.Drawing.Size(121, 21);
            this.spellLevelComboBox.TabIndex = 0;
            // 
            // spellsPreparedLabel
            // 
            this.spellsPreparedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spellsPreparedLabel.AutoSize = true;
            this.spellsPreparedLabel.Location = new System.Drawing.Point(170, 56);
            this.spellsPreparedLabel.Name = "spellsPreparedLabel";
            this.spellsPreparedLabel.Size = new System.Drawing.Size(106, 13);
            this.spellsPreparedLabel.TabIndex = 2;
            this.spellsPreparedLabel.Text = "x of y spells prepared";
            this.spellsPreparedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spellBook
            // 
            this.spellBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spellBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellBook.Location = new System.Drawing.Point(3, 84);
            this.spellBook.Name = "spellBook";
            this.spellBook.Size = new System.Drawing.Size(447, 167);
            this.spellBook.TabIndex = 1;
            // 
            // preparedSpells
            // 
            this.preparedSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preparedSpells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preparedSpells.Location = new System.Drawing.Point(3, 297);
            this.preparedSpells.Name = "preparedSpells";
            this.preparedSpells.Size = new System.Drawing.Size(447, 176);
            this.preparedSpells.TabIndex = 2;
            // 
            // SpellcasterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 551);
            this.Controls.Add(this.tabControl1);
            this.Name = "SpellcasterSettings";
            this.Text = "Spellcaster Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.spellCountBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellsReaminingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellsPerDayNumericUpDown)).EndInit();
            this.highestSpellLevelBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highestSpellLevelNumericUpDown)).EndInit();
            this.spellTypesAndLevelBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.spellcasterTypeBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparedSpells)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox spellCountBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListBox spellLevelListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.NumericUpDown spellsReaminingNumericUpDown;
        private System.Windows.Forms.Label spellsPerDayLabel;
        private System.Windows.Forms.Label spellsRemainingLabel;
        private System.Windows.Forms.NumericUpDown spellsPerDayNumericUpDown;
        private System.Windows.Forms.GroupBox highestSpellLevelBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label highestSpellLabel;
        private System.Windows.Forms.NumericUpDown highestSpellLevelNumericUpDown;
        private System.Windows.Forms.GroupBox spellTypesAndLevelBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button removeClassOrDomainButton;
        private System.Windows.Forms.Button addClassOrDomainButton;
        private System.Windows.Forms.ListBox spellcasterClassesAndDomains;
        private System.Windows.Forms.ListBox masterListOfClassesAndDomains;
        private System.Windows.Forms.TextBox customClassDomainTextbox;
        private System.Windows.Forms.GroupBox spellcasterTypeBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button cancelSettingsButton;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.CheckBox showAllSpellsCheckbox;
        private System.Windows.Forms.ComboBox spellLevelComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button addPreparedSpell;
        private System.Windows.Forms.DataGridView spellBook;
        private System.Windows.Forms.DataGridView preparedSpells;
        private System.Windows.Forms.Button removePreparedSpell;
        private System.Windows.Forms.Label spellsPreparedLabel;
        private System.Windows.Forms.Button clearCustomTextButton;
        private System.Windows.Forms.RadioButton spontaneousCasterRadioButton;
        private System.Windows.Forms.RadioButton preparedCasterRadioButton;



    }
}