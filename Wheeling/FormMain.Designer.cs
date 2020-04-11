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
            this.CboAvailableLotteries = new System.Windows.Forms.ComboBox();
            this.LblAvailableLotteries = new System.Windows.Forms.Label();
            this.MnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLotteryData)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(1065, 24);
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
            this.DgvLotteryData.Location = new System.Drawing.Point(12, 78);
            this.DgvLotteryData.Name = "DgvLotteryData";
            this.DgvLotteryData.Size = new System.Drawing.Size(547, 446);
            this.DgvLotteryData.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.Width = 80;
            // 
            // N1
            // 
            this.N1.HeaderText = "N1";
            this.N1.Name = "N1";
            this.N1.ReadOnly = true;
            this.N1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N1.Width = 50;
            // 
            // N2
            // 
            this.N2.HeaderText = "N2";
            this.N2.Name = "N2";
            this.N2.ReadOnly = true;
            this.N2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N2.Width = 50;
            // 
            // N3
            // 
            this.N3.HeaderText = "N3";
            this.N3.Name = "N3";
            this.N3.ReadOnly = true;
            this.N3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N3.Width = 50;
            // 
            // N4
            // 
            this.N4.HeaderText = "N4";
            this.N4.Name = "N4";
            this.N4.ReadOnly = true;
            this.N4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N4.Width = 50;
            // 
            // N5
            // 
            this.N5.HeaderText = "N5";
            this.N5.Name = "N5";
            this.N5.ReadOnly = true;
            this.N5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N5.Width = 50;
            // 
            // N6
            // 
            this.N6.HeaderText = "N6";
            this.N6.Name = "N6";
            this.N6.ReadOnly = true;
            this.N6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N6.Width = 50;
            // 
            // N7
            // 
            this.N7.HeaderText = "N7";
            this.N7.Name = "N7";
            this.N7.ReadOnly = true;
            this.N7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N7.Width = 50;
            // 
            // Bonus
            // 
            this.Bonus.HeaderText = "Bonus";
            this.Bonus.Name = "Bonus";
            this.Bonus.ReadOnly = true;
            this.Bonus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bonus.Width = 50;
            // 
            // CboAvailableLotteries
            // 
            this.CboAvailableLotteries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAvailableLotteries.FormattingEnabled = true;
            this.CboAvailableLotteries.Location = new System.Drawing.Point(12, 51);
            this.CboAvailableLotteries.Name = "CboAvailableLotteries";
            this.CboAvailableLotteries.Size = new System.Drawing.Size(199, 21);
            this.CboAvailableLotteries.TabIndex = 3;
            this.CboAvailableLotteries.SelectedIndexChanged += new System.EventHandler(this.CboAvailableLotteries_SelectedIndexChanged);
            // 
            // LblAvailableLotteries
            // 
            this.LblAvailableLotteries.AutoSize = true;
            this.LblAvailableLotteries.Location = new System.Drawing.Point(12, 32);
            this.LblAvailableLotteries.Name = "LblAvailableLotteries";
            this.LblAvailableLotteries.Size = new System.Drawing.Size(93, 13);
            this.LblAvailableLotteries.TabIndex = 4;
            this.LblAvailableLotteries.Text = "Available Lotteries";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 580);
            this.Controls.Add(this.LblAvailableLotteries);
            this.Controls.Add(this.CboAvailableLotteries);
            this.Controls.Add(this.DgvLotteryData);
            this.Controls.Add(this.MnuStrip);
            this.Name = "FormMain";
            this.Text = "Lottery Wheeling";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLotteryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.DataGridView DgvLotteryData;
        private System.Windows.Forms.ToolStripMenuItem LoadLotteryResultsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn N1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N2;
        private System.Windows.Forms.DataGridViewTextBoxColumn N3;
        private System.Windows.Forms.DataGridViewTextBoxColumn N4;
        private System.Windows.Forms.DataGridViewTextBoxColumn N5;
        private System.Windows.Forms.DataGridViewTextBoxColumn N6;
        private System.Windows.Forms.DataGridViewTextBoxColumn N7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.ToolStripMenuItem AddDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator TssSeparator;
        private System.Windows.Forms.ComboBox CboAvailableLotteries;
        private System.Windows.Forms.Label LblAvailableLotteries;
    }
}

