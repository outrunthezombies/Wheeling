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
            this.BtnSaveWheel = new System.Windows.Forms.Button();
            this.BtnBuildWheel = new System.Windows.Forms.Button();
            this.LblChooseWheel = new System.Windows.Forms.Label();
            this.CboWheelSize = new System.Windows.Forms.ComboBox();
            this.LstDrawNumbers = new System.Windows.Forms.ListView();
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
            this.BtnLoadWheel = new System.Windows.Forms.Button();
            this.MnuStrip.SuspendLayout();
            this.GpbWheels.SuspendLayout();
            this.gbbLotteryData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLotteryData)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFileToolStripMenuItem});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(806, 24);
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
            this.GpbWheels.Controls.Add(this.BtnLoadWheel);
            this.GpbWheels.Controls.Add(this.BtnSaveWheel);
            this.GpbWheels.Controls.Add(this.BtnBuildWheel);
            this.GpbWheels.Controls.Add(this.LblChooseWheel);
            this.GpbWheels.Controls.Add(this.CboWheelSize);
            this.GpbWheels.Controls.Add(this.LstDrawNumbers);
            this.GpbWheels.Location = new System.Drawing.Point(415, 32);
            this.GpbWheels.Name = "GpbWheels";
            this.GpbWheels.Size = new System.Drawing.Size(385, 518);
            this.GpbWheels.TabIndex = 6;
            this.GpbWheels.TabStop = false;
            // 
            // BtnSaveWheel
            // 
            this.BtnSaveWheel.Enabled = false;
            this.BtnSaveWheel.Location = new System.Drawing.Point(212, 30);
            this.BtnSaveWheel.Name = "BtnSaveWheel";
            this.BtnSaveWheel.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveWheel.TabIndex = 17;
            this.BtnSaveWheel.Text = "Save Wheel";
            this.BtnSaveWheel.UseVisualStyleBackColor = true;
            this.BtnSaveWheel.Click += new System.EventHandler(this.BtnSaveWheel_Click);
            // 
            // BtnBuildWheel
            // 
            this.BtnBuildWheel.Enabled = false;
            this.BtnBuildWheel.Location = new System.Drawing.Point(127, 30);
            this.BtnBuildWheel.Name = "BtnBuildWheel";
            this.BtnBuildWheel.Size = new System.Drawing.Size(75, 23);
            this.BtnBuildWheel.TabIndex = 16;
            this.BtnBuildWheel.Text = "Build Wheel";
            this.BtnBuildWheel.UseVisualStyleBackColor = true;
            this.BtnBuildWheel.Click += new System.EventHandler(this.BtnBuildWheel_Click);
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
            "15"});
            this.CboWheelSize.Location = new System.Drawing.Point(6, 32);
            this.CboWheelSize.Name = "CboWheelSize";
            this.CboWheelSize.Size = new System.Drawing.Size(100, 21);
            this.CboWheelSize.TabIndex = 14;
            this.CboWheelSize.SelectedIndexChanged += new System.EventHandler(this.CboWheelSize_SelectedIndexChanged);
            // 
            // LstDrawNumbers
            // 
            this.LstDrawNumbers.Enabled = false;
            this.LstDrawNumbers.HideSelection = false;
            this.LstDrawNumbers.Location = new System.Drawing.Point(6, 59);
            this.LstDrawNumbers.Name = "LstDrawNumbers";
            this.LstDrawNumbers.Size = new System.Drawing.Size(371, 311);
            this.LstDrawNumbers.TabIndex = 13;
            this.LstDrawNumbers.UseCompatibleStateImageBehavior = false;
            this.LstDrawNumbers.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LstDrawNumbers_ItemSelectionChanged);
            // 
            // gbbLotteryData
            // 
            this.gbbLotteryData.Controls.Add(this.LblAvailableLotteries);
            this.gbbLotteryData.Controls.Add(this.CboAvailableLotteries);
            this.gbbLotteryData.Controls.Add(this.DgvLotteryData);
            this.gbbLotteryData.Location = new System.Drawing.Point(12, 32);
            this.gbbLotteryData.Name = "gbbLotteryData";
            this.gbbLotteryData.Size = new System.Drawing.Size(397, 518);
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
            this.CboAvailableLotteries.Location = new System.Drawing.Point(6, 35);
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
            this.DgvLotteryData.Size = new System.Drawing.Size(382, 446);
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
            // BtnLoadWheel
            // 
            this.BtnLoadWheel.Enabled = false;
            this.BtnLoadWheel.Location = new System.Drawing.Point(302, 30);
            this.BtnLoadWheel.Name = "BtnLoadWheel";
            this.BtnLoadWheel.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadWheel.TabIndex = 18;
            this.BtnLoadWheel.Text = "Load Wheel";
            this.BtnLoadWheel.UseVisualStyleBackColor = true;
            this.BtnLoadWheel.Click += new System.EventHandler(this.BtnLoadWheel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 558);
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
    }
}

