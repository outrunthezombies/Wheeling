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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLotteryResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvLotteryData = new System.Windows.Forms.DataGridView();
            this.LblLotteryName = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLotteryData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MnuMainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadLotteryResultsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadLotteryResultsToolStripMenuItem
            // 
            this.loadLotteryResultsToolStripMenuItem.Name = "loadLotteryResultsToolStripMenuItem";
            this.loadLotteryResultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadLotteryResultsToolStripMenuItem.Text = "Load Lottery Results";
            this.loadLotteryResultsToolStripMenuItem.Click += new System.EventHandler(this.LoadLotteryResultsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            this.DgvLotteryData.Location = new System.Drawing.Point(12, 140);
            this.DgvLotteryData.Name = "DgvLotteryData";
            this.DgvLotteryData.Size = new System.Drawing.Size(547, 384);
            this.DgvLotteryData.TabIndex = 1;
            // 
            // LblLotteryName
            // 
            this.LblLotteryName.AutoSize = true;
            this.LblLotteryName.Location = new System.Drawing.Point(12, 121);
            this.LblLotteryName.Name = "LblLotteryName";
            this.LblLotteryName.Size = new System.Drawing.Size(0, 13);
            this.LblLotteryName.TabIndex = 2;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 580);
            this.Controls.Add(this.LblLotteryName);
            this.Controls.Add(this.DgvLotteryData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Lottery Wheeling";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLotteryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView DgvLotteryData;
        private System.Windows.Forms.ToolStripMenuItem loadLotteryResultsToolStripMenuItem;
        private System.Windows.Forms.Label LblLotteryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn N1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N2;
        private System.Windows.Forms.DataGridViewTextBoxColumn N3;
        private System.Windows.Forms.DataGridViewTextBoxColumn N4;
        private System.Windows.Forms.DataGridViewTextBoxColumn N5;
        private System.Windows.Forms.DataGridViewTextBoxColumn N6;
        private System.Windows.Forms.DataGridViewTextBoxColumn N7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
    }
}

