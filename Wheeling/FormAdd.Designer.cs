namespace Wheeling
{
    partial class FormAdd
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
            this.BtnAddDraw = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.DtpDrawDate = new System.Windows.Forms.DateTimePicker();
            this.LblLottery = new System.Windows.Forms.Label();
            this.LstDrawNumbers = new System.Windows.Forms.ListView();
            this.CboBonusNumber = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnAddDraw
            // 
            this.BtnAddDraw.Location = new System.Drawing.Point(384, 101);
            this.BtnAddDraw.Name = "BtnAddDraw";
            this.BtnAddDraw.Size = new System.Drawing.Size(75, 23);
            this.BtnAddDraw.TabIndex = 8;
            this.BtnAddDraw.Text = "Add";
            this.BtnAddDraw.UseVisualStyleBackColor = true;
            this.BtnAddDraw.Click += new System.EventHandler(this.BtnAddDraw_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(384, 130);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DtpDrawDate
            // 
            this.DtpDrawDate.Location = new System.Drawing.Point(7, 48);
            this.DtpDrawDate.Name = "DtpDrawDate";
            this.DtpDrawDate.Size = new System.Drawing.Size(200, 20);
            this.DtpDrawDate.TabIndex = 10;
            // 
            // LblLottery
            // 
            this.LblLottery.AutoSize = true;
            this.LblLottery.Location = new System.Drawing.Point(7, 13);
            this.LblLottery.Name = "LblLottery";
            this.LblLottery.Size = new System.Drawing.Size(0, 13);
            this.LblLottery.TabIndex = 11;
            // 
            // LstDrawNumbers
            // 
            this.LstDrawNumbers.HideSelection = false;
            this.LstDrawNumbers.Location = new System.Drawing.Point(7, 74);
            this.LstDrawNumbers.Name = "LstDrawNumbers";
            this.LstDrawNumbers.Size = new System.Drawing.Size(371, 301);
            this.LstDrawNumbers.TabIndex = 12;
            this.LstDrawNumbers.UseCompatibleStateImageBehavior = false;
            this.LstDrawNumbers.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LstDrawNumbers_ItemSelectionChanged);
            // 
            // CboBonusNumber
            // 
            this.CboBonusNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBonusNumber.FormattingEnabled = true;
            this.CboBonusNumber.Location = new System.Drawing.Point(384, 74);
            this.CboBonusNumber.Name = "CboBonusNumber";
            this.CboBonusNumber.Size = new System.Drawing.Size(75, 21);
            this.CboBonusNumber.TabIndex = 13;
            this.CboBonusNumber.SelectedIndexChanged += new System.EventHandler(this.CboBonusNumber_SelectedIndexChanged);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 389);
            this.Controls.Add(this.CboBonusNumber);
            this.Controls.Add(this.LstDrawNumbers);
            this.Controls.Add(this.LblLottery);
            this.Controls.Add(this.DtpDrawDate);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddDraw);
            this.Name = "FormAdd";
            this.Text = "Add Lottery Results";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAddDraw;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DateTimePicker DtpDrawDate;
        private System.Windows.Forms.Label LblLottery;
        private System.Windows.Forms.ListView LstDrawNumbers;
        private System.Windows.Forms.ComboBox CboBonusNumber;
    }
}