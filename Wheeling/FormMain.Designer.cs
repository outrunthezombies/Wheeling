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
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadLotteryResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TssSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GpbWheels = new System.Windows.Forms.GroupBox();
            this.LblChooseWheel = new System.Windows.Forms.Label();
            this.CboWheelSize = new System.Windows.Forms.ComboBox();
            this.LstDrawNumbers = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.BtnBuildWheel = new System.Windows.Forms.Button();
            this.MnuStrip.SuspendLayout();
            this.GpbWheels.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLotteryData)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(806, 24);
            this.MnuStrip.TabIndex = 0;
            this.MnuStrip.Text = "MnuMainMenu";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDrawToolStripMenuItem,
            this.LoadLotteryResultsToolStripMenuItem,
            this.TssSeparator,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // AddDrawToolStripMenuItem
            // 
            this.AddDrawToolStripMenuItem.Name = "AddDrawToolStripMenuItem";
            this.AddDrawToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddDrawToolStripMenuItem.Text = "Add Draw";
            this.AddDrawToolStripMenuItem.Click += new System.EventHandler(this.AddDrawToolStripMenuItem_Click);
            // 
            // LoadLotteryResultsToolStripMenuItem
            // 
            this.LoadLotteryResultsToolStripMenuItem.Name = "LoadLotteryResultsToolStripMenuItem";
            this.LoadLotteryResultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LoadLotteryResultsToolStripMenuItem.Text = "Load Lottery Results";
            this.LoadLotteryResultsToolStripMenuItem.Click += new System.EventHandler(this.LoadLotteryResultsToolStripMenuItem_Click);
            // 
            // TssSeparator
            // 
            this.TssSeparator.Name = "TssSeparator";
            this.TssSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // GpbWheels
            // 
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
            this.CboWheelSize.Size = new System.Drawing.Size(121, 21);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAvailableLotteries);
            this.groupBox1.Controls.Add(this.CboAvailableLotteries);
            this.groupBox1.Controls.Add(this.DgvLotteryData);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 518);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
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
            // BtnBuildWheel
            // 
            this.BtnBuildWheel.Enabled = false;
            this.BtnBuildWheel.Location = new System.Drawing.Point(263, 32);
            this.BtnBuildWheel.Name = "BtnBuildWheel";
            this.BtnBuildWheel.Size = new System.Drawing.Size(113, 23);
            this.BtnBuildWheel.TabIndex = 16;
            this.BtnBuildWheel.Text = "Build Wheel";
            this.BtnBuildWheel.UseVisualStyleBackColor = true;
            this.BtnBuildWheel.Click += new System.EventHandler(this.BtnBuildWheel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 558);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLotteryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadLotteryResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator TssSeparator;
        private System.Windows.Forms.GroupBox GpbWheels;
        private System.Windows.Forms.ComboBox CboWheelSize;
        private System.Windows.Forms.ListView LstDrawNumbers;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

