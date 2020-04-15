namespace Wheeling
{
    partial class FormMain
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
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAddDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLoadLotteryResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TssSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MnuExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GpbWheels = new System.Windows.Forms.GroupBox();
            this.BtnLoadWheel = new System.Windows.Forms.Button();
            this.BtnSaveWheel = new System.Windows.Forms.Button();
            this.LblChooseWheel = new System.Windows.Forms.Label();
            this.CboWheelSize = new System.Windows.Forms.ComboBox();
            this.LstDrawNumbers = new System.Windows.Forms.ListView();
            this.BtnBuildWheel = new System.Windows.Forms.Button();
            this.gbbLotteryData = new System.Windows.Forms.GroupBox();
            this.LblAvailableLotteries = new System.Windows.Forms.Label();
            this.CboAvailableLotteries = new System.Windows.Forms.ComboBox();
            this.DgvLotteryData = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GpbTickets = new System.Windows.Forms.GroupBox();
            this.CboTickets = new System.Windows.Forms.ComboBox();
            this.DgvTickets = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTickets = new System.Windows.Forms.Label();
            this.LblRecommendationsLabel = new System.Windows.Forms.Label();
            this.LblRecommendations = new System.Windows.Forms.Label();
            this.MnuStrip.SuspendLayout();
            this.GpbWheels.SuspendLayout();
            this.gbbLotteryData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLotteryData)).BeginInit();
            this.GpbTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFileToolStripMenuItem});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(1197, 24);
            this.MnuStrip.TabIndex = 0;
            this.MnuStrip.Text = "MnuMainMenu";
            // 
            // MnuFileToolStripMenuItem
            // 
            this.MnuFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAddDrawToolStripMenuItem,
            this.MnuLoadLotteryResultsToolStripMenuItem,
            this.TssSeparator,
            this.MnuExitToolStripMenuItem});
            this.MnuFileToolStripMenuItem.Name = "MnuFileToolStripMenuItem";
            this.MnuFileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.MnuFileToolStripMenuItem.Text = "File";
            // 
            // MnuAddDrawToolStripMenuItem
            // 
            this.MnuAddDrawToolStripMenuItem.Enabled = false;
            this.MnuAddDrawToolStripMenuItem.Name = "MnuAddDrawToolStripMenuItem";
            this.MnuAddDrawToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MnuAddDrawToolStripMenuItem.Text = "Add Draw";
            this.MnuAddDrawToolStripMenuItem.Click += new System.EventHandler(this.AddDrawToolStripMenuItem_Click);
            // 
            // MnuLoadLotteryResultsToolStripMenuItem
            // 
            this.MnuLoadLotteryResultsToolStripMenuItem.Enabled = false;
            this.MnuLoadLotteryResultsToolStripMenuItem.Name = "MnuLoadLotteryResultsToolStripMenuItem";
            this.MnuLoadLotteryResultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MnuLoadLotteryResultsToolStripMenuItem.Text = "Load Lottery Results";
            this.MnuLoadLotteryResultsToolStripMenuItem.Click += new System.EventHandler(this.LoadLotteryResultsToolStripMenuItem_Click);
            // 
            // TssSeparator
            // 
            this.TssSeparator.Name = "TssSeparator";
            this.TssSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuExitToolStripMenuItem
            // 
            this.MnuExitToolStripMenuItem.Name = "MnuExitToolStripMenuItem";
            this.MnuExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MnuExitToolStripMenuItem.Text = "Exit";
            this.MnuExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // GpbWheels
            // 
            this.GpbWheels.Controls.Add(this.LblRecommendations);
            this.GpbWheels.Controls.Add(this.LblRecommendationsLabel);
            this.GpbWheels.Controls.Add(this.BtnLoadWheel);
            this.GpbWheels.Controls.Add(this.BtnSaveWheel);
            this.GpbWheels.Controls.Add(this.LblChooseWheel);
            this.GpbWheels.Controls.Add(this.CboWheelSize);
            this.GpbWheels.Controls.Add(this.LstDrawNumbers);
            this.GpbWheels.Location = new System.Drawing.Point(415, 32);
            this.GpbWheels.Name = "GpbWheels";
            this.GpbWheels.Size = new System.Drawing.Size(385, 479);
            this.GpbWheels.TabIndex = 6;
            this.GpbWheels.TabStop = false;
            // 
            // BtnLoadWheel
            // 
            this.BtnLoadWheel.Enabled = false;
            this.BtnLoadWheel.Location = new System.Drawing.Point(302, 32);
            this.BtnLoadWheel.Name = "BtnLoadWheel";
            this.BtnLoadWheel.Size = new System.Drawing.Size(75, 24);
            this.BtnLoadWheel.TabIndex = 18;
            this.BtnLoadWheel.Text = "Load Wheel";
            this.BtnLoadWheel.UseVisualStyleBackColor = true;
            this.BtnLoadWheel.Click += new System.EventHandler(this.BtnLoadWheel_Click);
            // 
            // BtnSaveWheel
            // 
            this.BtnSaveWheel.Enabled = false;
            this.BtnSaveWheel.Location = new System.Drawing.Point(212, 32);
            this.BtnSaveWheel.Name = "BtnSaveWheel";
            this.BtnSaveWheel.Size = new System.Drawing.Size(75, 24);
            this.BtnSaveWheel.TabIndex = 17;
            this.BtnSaveWheel.Text = "Save Wheel";
            this.BtnSaveWheel.UseVisualStyleBackColor = true;
            this.BtnSaveWheel.Click += new System.EventHandler(this.BtnSaveWheel_Click);
            // 
            // LblChooseWheel
            // 
            this.LblChooseWheel.AutoSize = true;
            this.LblChooseWheel.Location = new System.Drawing.Point(6, 16);
            this.LblChooseWheel.Name = "LblChooseWheel";
            this.LblChooseWheel.Size = new System.Drawing.Size(100, 13);
            this.LblChooseWheel.TabIndex = 15;
            this.LblChooseWheel.Text = "Choose Wheel Size";
            // 
            // CboWheelSize
            // 
            this.CboWheelSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboWheelSize.Enabled = false;
            this.CboWheelSize.FormattingEnabled = true;
            this.CboWheelSize.Items.AddRange(new object[] {
            "7",
            "9",
            "11",
            "15",
            "18"});
            this.CboWheelSize.Location = new System.Drawing.Point(6, 34);
            this.CboWheelSize.Name = "CboWheelSize";
            this.CboWheelSize.Size = new System.Drawing.Size(100, 21);
            this.CboWheelSize.TabIndex = 14;
            this.CboWheelSize.SelectedIndexChanged += new System.EventHandler(this.CboWheelSize_SelectedIndexChanged);
            // 
            // LstDrawNumbers
            // 
            this.LstDrawNumbers.CheckBoxes = true;
            this.LstDrawNumbers.Enabled = false;
            this.LstDrawNumbers.HideSelection = false;
            this.LstDrawNumbers.Location = new System.Drawing.Point(6, 62);
            this.LstDrawNumbers.Name = "LstDrawNumbers";
            this.LstDrawNumbers.Size = new System.Drawing.Size(371, 407);
            this.LstDrawNumbers.TabIndex = 13;
            this.LstDrawNumbers.UseCompatibleStateImageBehavior = false;
            this.LstDrawNumbers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LstDrawNumbers_ItemChecked);
            // 
            // BtnBuildWheel
            // 
            this.BtnBuildWheel.Enabled = false;
            this.BtnBuildWheel.Location = new System.Drawing.Point(119, 32);
            this.BtnBuildWheel.Name = "BtnBuildWheel";
            this.BtnBuildWheel.Size = new System.Drawing.Size(75, 24);
            this.BtnBuildWheel.TabIndex = 16;
            this.BtnBuildWheel.Text = "Build Wheel";
            this.BtnBuildWheel.UseVisualStyleBackColor = true;
            this.BtnBuildWheel.Click += new System.EventHandler(this.BtnBuildWheel_Click);
            // 
            // gbbLotteryData
            // 
            this.gbbLotteryData.Controls.Add(this.LblAvailableLotteries);
            this.gbbLotteryData.Controls.Add(this.CboAvailableLotteries);
            this.gbbLotteryData.Controls.Add(this.DgvLotteryData);
            this.gbbLotteryData.Location = new System.Drawing.Point(12, 32);
            this.gbbLotteryData.Name = "gbbLotteryData";
            this.gbbLotteryData.Size = new System.Drawing.Size(397, 479);
            this.gbbLotteryData.TabIndex = 15;
            this.gbbLotteryData.TabStop = false;
            // 
            // LblAvailableLotteries
            // 
            this.LblAvailableLotteries.AutoSize = true;
            this.LblAvailableLotteries.Location = new System.Drawing.Point(6, 16);
            this.LblAvailableLotteries.Name = "LblAvailableLotteries";
            this.LblAvailableLotteries.Size = new System.Drawing.Size(93, 13);
            this.LblAvailableLotteries.TabIndex = 7;
            this.LblAvailableLotteries.Text = "Available Lotteries";
            // 
            // CboAvailableLotteries
            // 
            this.CboAvailableLotteries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAvailableLotteries.FormattingEnabled = true;
            this.CboAvailableLotteries.Location = new System.Drawing.Point(6, 32);
            this.CboAvailableLotteries.Name = "CboAvailableLotteries";
            this.CboAvailableLotteries.Size = new System.Drawing.Size(199, 21);
            this.CboAvailableLotteries.TabIndex = 6;
            this.CboAvailableLotteries.SelectedIndexChanged += new System.EventHandler(this.CboAvailableLotteries_SelectedIndexChanged);
            // 
            // DgvLotteryData
            // 
            this.DgvLotteryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLotteryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.N1,
            this.N2,
            this.N3,
            this.N4,
            this.N5,
            this.N6,
            this.N7,
            this.Bonus});
            this.DgvLotteryData.Location = new System.Drawing.Point(6, 62);
            this.DgvLotteryData.Name = "DgvLotteryData";
            this.DgvLotteryData.Size = new System.Drawing.Size(382, 407);
            this.DgvLotteryData.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.Width = 75;
            // 
            // N1
            // 
            this.N1.HeaderText = "N1";
            this.N1.Name = "N1";
            this.N1.ReadOnly = true;
            this.N1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N1.Width = 30;
            // 
            // N2
            // 
            this.N2.HeaderText = "N2";
            this.N2.Name = "N2";
            this.N2.ReadOnly = true;
            this.N2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N2.Width = 30;
            // 
            // N3
            // 
            this.N3.HeaderText = "N3";
            this.N3.Name = "N3";
            this.N3.ReadOnly = true;
            this.N3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N3.Width = 30;
            // 
            // N4
            // 
            this.N4.HeaderText = "N4";
            this.N4.Name = "N4";
            this.N4.ReadOnly = true;
            this.N4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N4.Width = 30;
            // 
            // N5
            // 
            this.N5.HeaderText = "N5";
            this.N5.Name = "N5";
            this.N5.ReadOnly = true;
            this.N5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N5.Width = 30;
            // 
            // N6
            // 
            this.N6.HeaderText = "N6";
            this.N6.Name = "N6";
            this.N6.ReadOnly = true;
            this.N6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N6.Width = 30;
            // 
            // N7
            // 
            this.N7.HeaderText = "N7";
            this.N7.Name = "N7";
            this.N7.ReadOnly = true;
            this.N7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N7.Width = 30;
            // 
            // Bonus
            // 
            this.Bonus.HeaderText = "Bon";
            this.Bonus.Name = "Bonus";
            this.Bonus.ReadOnly = true;
            this.Bonus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bonus.Width = 30;
            // 
            // GpbTickets
            // 
            this.GpbTickets.Controls.Add(this.CboTickets);
            this.GpbTickets.Controls.Add(this.DgvTickets);
            this.GpbTickets.Controls.Add(this.LblTickets);
            this.GpbTickets.Controls.Add(this.BtnBuildWheel);
            this.GpbTickets.Location = new System.Drawing.Point(806, 32);
            this.GpbTickets.Name = "GpbTickets";
            this.GpbTickets.Size = new System.Drawing.Size(385, 479);
            this.GpbTickets.TabIndex = 16;
            this.GpbTickets.TabStop = false;
            // 
            // CboTickets
            // 
            this.CboTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTickets.Enabled = false;
            this.CboTickets.FormattingEnabled = true;
            this.CboTickets.Items.AddRange(new object[] {
            "6",
            "10",
            "11",
            "12",
            "19",
            "24"});
            this.CboTickets.Location = new System.Drawing.Point(9, 34);
            this.CboTickets.Name = "CboTickets";
            this.CboTickets.Size = new System.Drawing.Size(100, 21);
            this.CboTickets.TabIndex = 17;
            this.CboTickets.SelectedIndexChanged += new System.EventHandler(this.CboTickets_SelectedIndexChanged);
            // 
            // DgvTickets
            // 
            this.DgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DgvTickets.Location = new System.Drawing.Point(9, 62);
            this.DgvTickets.Name = "DgvTickets";
            this.DgvTickets.Size = new System.Drawing.Size(382, 407);
            this.DgvTickets.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ticket";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "N1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 30;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "N2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 30;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "N3";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "N4";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 30;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "N5";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 30;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "N6";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 30;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "N7";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 30;
            // 
            // LblTickets
            // 
            this.LblTickets.AutoSize = true;
            this.LblTickets.Location = new System.Drawing.Point(6, 16);
            this.LblTickets.Name = "LblTickets";
            this.LblTickets.Size = new System.Drawing.Size(45, 13);
            this.LblTickets.TabIndex = 15;
            this.LblTickets.Text = "Tickets:";
            // 
            // LblRecommendationsLabel
            // 
            this.LblRecommendationsLabel.AutoSize = true;
            this.LblRecommendationsLabel.Location = new System.Drawing.Point(126, 15);
            this.LblRecommendationsLabel.Name = "LblRecommendationsLabel";
            this.LblRecommendationsLabel.Size = new System.Drawing.Size(98, 13);
            this.LblRecommendationsLabel.TabIndex = 19;
            this.LblRecommendationsLabel.Text = "Recommendations:";
            // 
            // LblRecommendations
            // 
            this.LblRecommendations.AutoSize = true;
            this.LblRecommendations.Location = new System.Drawing.Point(219, 15);
            this.LblRecommendations.Name = "LblRecommendations";
            this.LblRecommendations.Size = new System.Drawing.Size(0, 13);
            this.LblRecommendations.TabIndex = 20;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 523);
            this.Controls.Add(this.GpbTickets);
            this.Controls.Add(this.gbbLotteryData);
            this.Controls.Add(this.GpbWheels);
            this.Controls.Add(this.MnuStrip);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Lottery Wheeling";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.GpbWheels.ResumeLayout(false);
            this.GpbWheels.PerformLayout();
            this.gbbLotteryData.ResumeLayout(false);
            this.gbbLotteryData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLotteryData)).EndInit();
            this.GpbTickets.ResumeLayout(false);
            this.GpbTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuLoadLotteryResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAddDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator TssSeparator;
        private System.Windows.Forms.GroupBox GpbWheels;
        private System.Windows.Forms.ComboBox CboWheelSize;
        private System.Windows.Forms.ListView LstDrawNumbers;
        private System.Windows.Forms.GroupBox gbbLotteryData;
        private System.Windows.Forms.Label LblAvailableLotteries;
        private System.Windows.Forms.ComboBox CboAvailableLotteries;
        private System.Windows.Forms.DataGridView DgvLotteryData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn N1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N2;
        private System.Windows.Forms.DataGridViewTextBoxColumn N3;
        private System.Windows.Forms.DataGridViewTextBoxColumn N4;
        private System.Windows.Forms.DataGridViewTextBoxColumn N5;
        private System.Windows.Forms.DataGridViewTextBoxColumn N6;
        private System.Windows.Forms.DataGridViewTextBoxColumn N7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.Label LblChooseWheel;
        private System.Windows.Forms.Button BtnBuildWheel;
        private System.Windows.Forms.Button BtnSaveWheel;
        private System.Windows.Forms.Button BtnLoadWheel;
        private System.Windows.Forms.GroupBox GpbTickets;
        private System.Windows.Forms.DataGridView DgvTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label LblTickets;
        private System.Windows.Forms.ComboBox CboTickets;
        private System.Windows.Forms.Label LblRecommendations;
        private System.Windows.Forms.Label LblRecommendationsLabel;
    }
}

