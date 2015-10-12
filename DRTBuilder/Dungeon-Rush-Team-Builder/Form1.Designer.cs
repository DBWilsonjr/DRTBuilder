namespace Dungeon_Rush_Team_Builder
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lsvTMone = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvTMtwo = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvTMthree = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvTMfour = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvTMfive = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvTMsix = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTMchooser = new System.Windows.Forms.ListBox();
            this.legendaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creature_DatabaseDataSet = new Dungeon_Rush_Team_Builder.Creature_DatabaseDataSet();
            this.btnTMone = new System.Windows.Forms.Button();
            this.btnTMtwo = new System.Windows.Forms.Button();
            this.btnTMthree = new System.Windows.Forms.Button();
            this.btnTMfour = new System.Windows.Forms.Button();
            this.btnTMfive = new System.Windows.Forms.Button();
            this.btnTMsix = new System.Windows.Forms.Button();
            this.lblPower = new System.Windows.Forms.Label();
            this.txtPowCnt = new System.Windows.Forms.TextBox();
            this.creatureDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.legendaryTableAdapter = new Dungeon_Rush_Team_Builder.Creature_DatabaseDataSetTableAdapters.LegendaryTableAdapter();
            this.lblTMone = new System.Windows.Forms.Label();
            this.lblTMtwo = new System.Windows.Forms.Label();
            this.lblTMthree = new System.Windows.Forms.Label();
            this.lblTMfour = new System.Windows.Forms.Label();
            this.lblTMfive = new System.Windows.Forms.Label();
            this.lblTMsix = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApproxPower = new System.Windows.Forms.TextBox();
            this.lblApproxTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNotImplementedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lstAbility = new System.Windows.Forms.ListBox();
            this.btnACalc = new System.Windows.Forms.Button();
            this.lstAbility2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearTeam = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.legendaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creature_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatureDatabaseDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvTMone
            // 
            this.lsvTMone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvTMone.Location = new System.Drawing.Point(6, 113);
            this.lsvTMone.Name = "lsvTMone";
            this.lsvTMone.Size = new System.Drawing.Size(107, 154);
            this.lsvTMone.TabIndex = 0;
            this.lsvTMone.UseCompatibleStateImageBehavior = false;
            this.lsvTMone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stat";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 55;
            // 
            // lsvTMtwo
            // 
            this.lsvTMtwo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lsvTMtwo.Location = new System.Drawing.Point(137, 113);
            this.lsvTMtwo.Name = "lsvTMtwo";
            this.lsvTMtwo.Size = new System.Drawing.Size(107, 154);
            this.lsvTMtwo.TabIndex = 1;
            this.lsvTMtwo.UseCompatibleStateImageBehavior = false;
            this.lsvTMtwo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stat";
            this.columnHeader3.Width = 48;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 55;
            // 
            // lsvTMthree
            // 
            this.lsvTMthree.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lsvTMthree.Location = new System.Drawing.Point(268, 113);
            this.lsvTMthree.Name = "lsvTMthree";
            this.lsvTMthree.Size = new System.Drawing.Size(107, 154);
            this.lsvTMthree.TabIndex = 2;
            this.lsvTMthree.UseCompatibleStateImageBehavior = false;
            this.lsvTMthree.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Stat";
            this.columnHeader5.Width = 48;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.Width = 55;
            // 
            // lsvTMfour
            // 
            this.lsvTMfour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lsvTMfour.Location = new System.Drawing.Point(6, 296);
            this.lsvTMfour.Name = "lsvTMfour";
            this.lsvTMfour.Size = new System.Drawing.Size(107, 154);
            this.lsvTMfour.TabIndex = 3;
            this.lsvTMfour.UseCompatibleStateImageBehavior = false;
            this.lsvTMfour.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Stat";
            this.columnHeader7.Width = 48;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Value";
            this.columnHeader8.Width = 55;
            // 
            // lsvTMfive
            // 
            this.lsvTMfive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.lsvTMfive.Location = new System.Drawing.Point(137, 296);
            this.lsvTMfive.Name = "lsvTMfive";
            this.lsvTMfive.Size = new System.Drawing.Size(107, 154);
            this.lsvTMfive.TabIndex = 4;
            this.lsvTMfive.UseCompatibleStateImageBehavior = false;
            this.lsvTMfive.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Stat";
            this.columnHeader9.Width = 48;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Value";
            this.columnHeader10.Width = 55;
            // 
            // lsvTMsix
            // 
            this.lsvTMsix.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.lsvTMsix.Location = new System.Drawing.Point(268, 296);
            this.lsvTMsix.Name = "lsvTMsix";
            this.lsvTMsix.Size = new System.Drawing.Size(107, 154);
            this.lsvTMsix.TabIndex = 5;
            this.lsvTMsix.UseCompatibleStateImageBehavior = false;
            this.lsvTMsix.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Stat";
            this.columnHeader11.Width = 48;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Value";
            this.columnHeader12.Width = 55;
            // 
            // lstTMchooser
            // 
            this.lstTMchooser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstTMchooser.DataSource = this.legendaryBindingSource;
            this.lstTMchooser.DisplayMember = "Creature";
            this.lstTMchooser.FormattingEnabled = true;
            this.lstTMchooser.Location = new System.Drawing.Point(12, 28);
            this.lstTMchooser.Name = "lstTMchooser";
            this.lstTMchooser.Size = new System.Drawing.Size(174, 589);
            this.lstTMchooser.TabIndex = 6;
            this.lstTMchooser.ValueMember = "ID";
            // 
            // legendaryBindingSource
            // 
            this.legendaryBindingSource.DataMember = "Legendary";
            this.legendaryBindingSource.DataSource = this.creature_DatabaseDataSet;
            // 
            // creature_DatabaseDataSet
            // 
            this.creature_DatabaseDataSet.DataSetName = "Creature_DatabaseDataSet";
            this.creature_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTMone
            // 
            this.btnTMone.Location = new System.Drawing.Point(12, 628);
            this.btnTMone.Name = "btnTMone";
            this.btnTMone.Size = new System.Drawing.Size(75, 23);
            this.btnTMone.TabIndex = 7;
            this.btnTMone.Text = "Member #1";
            this.btnTMone.UseVisualStyleBackColor = true;
            this.btnTMone.Click += new System.EventHandler(this.btnTMone_Click);
            // 
            // btnTMtwo
            // 
            this.btnTMtwo.Location = new System.Drawing.Point(12, 657);
            this.btnTMtwo.Name = "btnTMtwo";
            this.btnTMtwo.Size = new System.Drawing.Size(75, 23);
            this.btnTMtwo.TabIndex = 8;
            this.btnTMtwo.Text = "Member #2";
            this.btnTMtwo.UseVisualStyleBackColor = true;
            this.btnTMtwo.Click += new System.EventHandler(this.btnTMtwo_Click);
            // 
            // btnTMthree
            // 
            this.btnTMthree.Location = new System.Drawing.Point(12, 686);
            this.btnTMthree.Name = "btnTMthree";
            this.btnTMthree.Size = new System.Drawing.Size(75, 23);
            this.btnTMthree.TabIndex = 9;
            this.btnTMthree.Text = "Member #3";
            this.btnTMthree.UseVisualStyleBackColor = true;
            this.btnTMthree.Click += new System.EventHandler(this.btnTMthree_Click);
            // 
            // btnTMfour
            // 
            this.btnTMfour.Location = new System.Drawing.Point(111, 628);
            this.btnTMfour.Name = "btnTMfour";
            this.btnTMfour.Size = new System.Drawing.Size(75, 23);
            this.btnTMfour.TabIndex = 10;
            this.btnTMfour.Text = "Member #4";
            this.btnTMfour.UseVisualStyleBackColor = true;
            this.btnTMfour.Click += new System.EventHandler(this.btnTMfour_Click);
            // 
            // btnTMfive
            // 
            this.btnTMfive.Location = new System.Drawing.Point(111, 657);
            this.btnTMfive.Name = "btnTMfive";
            this.btnTMfive.Size = new System.Drawing.Size(75, 23);
            this.btnTMfive.TabIndex = 11;
            this.btnTMfive.Text = "Member #5";
            this.btnTMfive.UseVisualStyleBackColor = true;
            this.btnTMfive.Click += new System.EventHandler(this.btnTMfive_Click);
            // 
            // btnTMsix
            // 
            this.btnTMsix.Location = new System.Drawing.Point(111, 686);
            this.btnTMsix.Name = "btnTMsix";
            this.btnTMsix.Size = new System.Drawing.Size(75, 23);
            this.btnTMsix.TabIndex = 12;
            this.btnTMsix.Text = "Member #6";
            this.btnTMsix.UseVisualStyleBackColor = true;
            this.btnTMsix.Click += new System.EventHandler(this.btnTMsix_Click);
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(53, 16);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(137, 20);
            this.lblPower.TabIndex = 13;
            this.lblPower.Text = "Total Base Power:";
            // 
            // txtPowCnt
            // 
            this.txtPowCnt.Location = new System.Drawing.Point(196, 16);
            this.txtPowCnt.Name = "txtPowCnt";
            this.txtPowCnt.ReadOnly = true;
            this.txtPowCnt.Size = new System.Drawing.Size(100, 20);
            this.txtPowCnt.TabIndex = 14;
            this.txtPowCnt.Text = "0";
            // 
            // creatureDatabaseDataSetBindingSource
            // 
            this.creatureDatabaseDataSetBindingSource.DataSource = this.creature_DatabaseDataSet;
            this.creatureDatabaseDataSetBindingSource.Position = 0;
            // 
            // legendaryTableAdapter
            // 
            this.legendaryTableAdapter.ClearBeforeFill = true;
            // 
            // lblTMone
            // 
            this.lblTMone.AutoSize = true;
            this.lblTMone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTMone.Location = new System.Drawing.Point(2, 90);
            this.lblTMone.Name = "lblTMone";
            this.lblTMone.Size = new System.Drawing.Size(89, 20);
            this.lblTMone.TabIndex = 15;
            this.lblTMone.Text = "Member #1";
            // 
            // lblTMtwo
            // 
            this.lblTMtwo.AutoSize = true;
            this.lblTMtwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTMtwo.Location = new System.Drawing.Point(133, 90);
            this.lblTMtwo.Name = "lblTMtwo";
            this.lblTMtwo.Size = new System.Drawing.Size(89, 20);
            this.lblTMtwo.TabIndex = 16;
            this.lblTMtwo.Text = "Member #2";
            // 
            // lblTMthree
            // 
            this.lblTMthree.AutoSize = true;
            this.lblTMthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTMthree.Location = new System.Drawing.Point(265, 88);
            this.lblTMthree.Name = "lblTMthree";
            this.lblTMthree.Size = new System.Drawing.Size(89, 20);
            this.lblTMthree.TabIndex = 17;
            this.lblTMthree.Text = "Member #3";
            // 
            // lblTMfour
            // 
            this.lblTMfour.AutoSize = true;
            this.lblTMfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTMfour.Location = new System.Drawing.Point(2, 270);
            this.lblTMfour.Name = "lblTMfour";
            this.lblTMfour.Size = new System.Drawing.Size(89, 20);
            this.lblTMfour.TabIndex = 18;
            this.lblTMfour.Text = "Member #4";
            // 
            // lblTMfive
            // 
            this.lblTMfive.AutoSize = true;
            this.lblTMfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTMfive.Location = new System.Drawing.Point(133, 270);
            this.lblTMfive.Name = "lblTMfive";
            this.lblTMfive.Size = new System.Drawing.Size(89, 20);
            this.lblTMfive.TabIndex = 19;
            this.lblTMfive.Text = "Member #5";
            // 
            // lblTMsix
            // 
            this.lblTMsix.AutoSize = true;
            this.lblTMsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTMsix.Location = new System.Drawing.Point(265, 270);
            this.lblTMsix.Name = "lblTMsix";
            this.lblTMsix.Size = new System.Drawing.Size(89, 20);
            this.lblTMsix.TabIndex = 20;
            this.lblTMsix.Text = "Member #6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvTMone);
            this.groupBox1.Controls.Add(this.txtPowCnt);
            this.groupBox1.Controls.Add(this.txtApproxPower);
            this.groupBox1.Controls.Add(this.lblTMsix);
            this.groupBox1.Controls.Add(this.lblApproxTotal);
            this.groupBox1.Controls.Add(this.lblPower);
            this.groupBox1.Controls.Add(this.lsvTMtwo);
            this.groupBox1.Controls.Add(this.lblTMfive);
            this.groupBox1.Controls.Add(this.lsvTMthree);
            this.groupBox1.Controls.Add(this.lblTMfour);
            this.groupBox1.Controls.Add(this.lblTMone);
            this.groupBox1.Controls.Add(this.lblTMthree);
            this.groupBox1.Controls.Add(this.lblTMtwo);
            this.groupBox1.Controls.Add(this.lsvTMfour);
            this.groupBox1.Controls.Add(this.lsvTMfive);
            this.groupBox1.Controls.Add(this.lsvTMsix);
            this.groupBox1.Location = new System.Drawing.Point(192, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 470);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dungeon Rush Team";
            // 
            // txtApproxPower
            // 
            this.txtApproxPower.Location = new System.Drawing.Point(228, 43);
            this.txtApproxPower.Name = "txtApproxPower";
            this.txtApproxPower.ReadOnly = true;
            this.txtApproxPower.Size = new System.Drawing.Size(100, 20);
            this.txtApproxPower.TabIndex = 25;
            this.txtApproxPower.Text = "0";
            // 
            // lblApproxTotal
            // 
            this.lblApproxTotal.AutoSize = true;
            this.lblApproxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApproxTotal.Location = new System.Drawing.Point(9, 41);
            this.lblApproxTotal.Name = "lblApproxTotal";
            this.lblApproxTotal.Size = new System.Drawing.Size(213, 20);
            this.lblApproxTotal.TabIndex = 24;
            this.lblApproxTotal.Text = "Approximate Total with Gear:";
            this.toolTip1.SetToolTip(this.lblApproxTotal, "Calculated based on Base Power plus rough average of 5-Star lv. 40 Tier 1 Legenda" +
        "ry gear (no sets).");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveNotImplementedToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // saveNotImplementedToolStripMenuItem
            // 
            this.saveNotImplementedToolStripMenuItem.Name = "saveNotImplementedToolStripMenuItem";
            this.saveNotImplementedToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.saveNotImplementedToolStripMenuItem.Text = "Save (Not Implemented)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lstAbility
            // 
            this.lstAbility.FormattingEnabled = true;
            this.lstAbility.Location = new System.Drawing.Point(583, 93);
            this.lstAbility.Name = "lstAbility";
            this.lstAbility.Size = new System.Drawing.Size(239, 173);
            this.lstAbility.TabIndex = 26;
            // 
            // btnACalc
            // 
            this.btnACalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACalc.Location = new System.Drawing.Point(583, 28);
            this.btnACalc.Name = "btnACalc";
            this.btnACalc.Size = new System.Drawing.Size(239, 30);
            this.btnACalc.TabIndex = 27;
            this.btnACalc.Text = "Ability Calc";
            this.btnACalc.UseVisualStyleBackColor = true;
            this.btnACalc.Click += new System.EventHandler(this.btnACalc_Click);
            // 
            // lstAbility2
            // 
            this.lstAbility2.FormattingEnabled = true;
            this.lstAbility2.Location = new System.Drawing.Point(583, 308);
            this.lstAbility2.Name = "lstAbility2";
            this.lstAbility2.Size = new System.Drawing.Size(239, 394);
            this.lstAbility2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Team Member Abilities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Team Bonus by Faction";
            // 
            // btnClearTeam
            // 
            this.btnClearTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTeam.Location = new System.Drawing.Point(249, 504);
            this.btnClearTeam.Name = "btnClearTeam";
            this.btnClearTeam.Size = new System.Drawing.Size(239, 34);
            this.btnClearTeam.TabIndex = 31;
            this.btnClearTeam.Text = "Clear Team Members";
            this.btnClearTeam.UseVisualStyleBackColor = true;
            this.btnClearTeam.Click += new System.EventHandler(this.btnClearTeam_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(249, 553);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(239, 34);
            this.btnClearAll.TabIndex = 32;
            this.btnClearAll.Text = "Clear All Fields";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 729);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClearTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAbility2);
            this.Controls.Add(this.btnACalc);
            this.Controls.Add(this.lstAbility);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTMsix);
            this.Controls.Add(this.btnTMfive);
            this.Controls.Add(this.btnTMfour);
            this.Controls.Add(this.btnTMthree);
            this.Controls.Add(this.btnTMtwo);
            this.Controls.Add(this.btnTMone);
            this.Controls.Add(this.lstTMchooser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.legendaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creature_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatureDatabaseDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvTMone;
        private System.Windows.Forms.ListView lsvTMtwo;
        private System.Windows.Forms.ListView lsvTMthree;
        private System.Windows.Forms.ListView lsvTMfour;
        private System.Windows.Forms.ListView lsvTMfive;
        private System.Windows.Forms.ListView lsvTMsix;
        private System.Windows.Forms.ListBox lstTMchooser;
        private System.Windows.Forms.Button btnTMone;
        private System.Windows.Forms.Button btnTMtwo;
        private System.Windows.Forms.Button btnTMthree;
        private System.Windows.Forms.Button btnTMfour;
        private System.Windows.Forms.Button btnTMfive;
        private System.Windows.Forms.Button btnTMsix;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.TextBox txtPowCnt;
        private System.Windows.Forms.BindingSource creatureDatabaseDataSetBindingSource;
        private Creature_DatabaseDataSet creature_DatabaseDataSet;
        private System.Windows.Forms.BindingSource legendaryBindingSource;
        private Creature_DatabaseDataSetTableAdapters.LegendaryTableAdapter legendaryTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblTMone;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label lblTMtwo;
        private System.Windows.Forms.Label lblTMthree;
        private System.Windows.Forms.Label lblTMfour;
        private System.Windows.Forms.Label lblTMfive;
        private System.Windows.Forms.Label lblTMsix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNotImplementedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblApproxTotal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtApproxPower;
        private System.Windows.Forms.ListBox lstAbility;
        private System.Windows.Forms.Button btnACalc;
        private System.Windows.Forms.ListBox lstAbility2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearTeam;
        private System.Windows.Forms.Button btnClearAll;
    }
}

