﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using static SharedCode;

namespace Wheeling
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadLotteryResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLotteryData();
        }
        private void LoadLotteryData()
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (ListViewItem lvi in LstDrawNumbers.Items)
                lvi.Checked = false;

            if (CboAvailableLotteries.SelectedIndex >= 0)
            {
                string sql = "SELECT D.Draw_date,D.N1,D.N2,D.N3,D.N4,D.N5,D.N6,D.N7,D.Bonus,L.id,L.lottery_name,L.max_number,L.numbers_drawn FROM Lottery L INNER JOIN Draws D ON L.ID = D.Lottery_ID WHERE L.ID = " + lotteries[lotterySelected].ID + " ORDER BY D.Draw_date DESC";
                DgvLotteryData.Rows.Clear();

                OleDbDataReader oOleDbDataReader;
                int lotteryID = 0;
                string lotteryName = "";
                int lotteryMaxNumber = 0;
                int lotteryNumbersDrawn = 0;
                DateTime lotteryMinDrawDate = new DateTime();
                try
                {
                    if (OpenDBConnection(sql))
                    {
                        oOleDbDataReader = oOleDbCommand.ExecuteReader();

                        while (oOleDbDataReader.Read())
                        {
                            int field = oOleDbDataReader.FieldCount;
                            string[] rowData = new string[9];
                            int column = 0;
                            for (int index = 0; index < field; index++)
                            {
                                switch (index)
                                {
                                    case (int)DataColumn.DrawDate:
                                        if (lotteryMinDrawDate == default)
                                            lotteryMinDrawDate = oOleDbDataReader.GetDateTime(index);
                                        rowData[column] = oOleDbDataReader.GetDateTime(index).ToString("MMM. dd, yyyy");
                                        column++;
                                        break;
                                    case (int)DataColumn.LotteryID:
                                        lotteryID = oOleDbDataReader.GetInt32((int)DataColumn.LotteryID);
                                        break;
                                    case (int)DataColumn.LotteryName:
                                        lotteryName = oOleDbDataReader.GetString((int)DataColumn.LotteryName);
                                        break;
                                    case (int)DataColumn.NumbersDrawn:
                                        lotteryNumbersDrawn = oOleDbDataReader.GetInt32((int)DataColumn.NumbersDrawn);
                                        break;
                                    case (int)DataColumn.MaxNumber:
                                        lotteryMaxNumber = oOleDbDataReader.GetInt32((int)DataColumn.MaxNumber);
                                        break;
                                    default:
                                        rowData[column] = oOleDbDataReader.GetValue(index).ToString();
                                        column++;
                                        break;
                                }
                            }
                            DgvLotteryData.Rows.Add(rowData);
                        }
                        oOleDbDataReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    CloseDBConnection();
                }
            }
            LoadAllLotteryNumberOptions(LstDrawNumbers);
            Cursor.Current = Cursors.Default;
        }
        private void AddDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd FrmAddDraw = new FormAdd();
            FrmAddDraw.ShowDialog();
            LoadLotteryData();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            GetLotteries();
            foreach (Lottery lottery in lotteries)
                CboAvailableLotteries.Items.Add(lottery.Name);
        }
        private void CboAvailableLotteries_SelectedIndexChanged(object sender, EventArgs e)
        {
            lotterySelected = CboAvailableLotteries.SelectedIndex;
            LoadLotteryData();
            CboWheelSize.Enabled = true;
            MnuAddDrawToolStripMenuItem.Enabled = true;
            MnuLoadLotteryResultsToolStripMenuItem.Enabled = true;
        }
        private void CboWheelSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CboWheelSize.SelectedItem) < LstDrawNumbers.CheckedItems.Count)
            {
                foreach (ListViewItem lvi in LstDrawNumbers.Items)
                    lvi.Checked = false;
            }
            if (CboWheelSize.SelectedIndex > -1)
            {
                LstDrawNumbers.Enabled = true;
                BtnLoadWheel.Enabled = true;
            }

            CheckIfReadyToWheel();
        }
        private void CheckIfReadyToWheel()
        {
            if (LstDrawNumbers.CheckedItems.Count == Convert.ToInt32(CboWheelSize.SelectedItem))
            {
                BtnBuildWheel.Enabled = true;
                BtnSaveWheel.Enabled = true;
            }
            else if (LstDrawNumbers.CheckedItems.Count < Convert.ToInt32(CboWheelSize.SelectedItem))
            {
                BtnBuildWheel.Enabled = false;
                BtnSaveWheel.Enabled = false;
            }
        }
        private void BtnBuildWheel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Build the Wheel!");
        }
        private void BtnSaveWheel_Click(object sender, EventArgs e)
        {
            string wheel = "";
            for (int index = 0; index < LstDrawNumbers.CheckedItems.Count - 1; index++)
            {
                wheel += LstDrawNumbers.CheckedItems[index].Text + ",";
            }
            wheel += LstDrawNumbers.CheckedItems[LstDrawNumbers.CheckedItems.Count-1].Text;
            properties.Save();
            MessageBox.Show("Wheel is saved!");
        }

        private void BtnLoadWheel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in LstDrawNumbers.Items)
                lvi.Checked = false;
        }

        private void LstDrawNumbers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (LstDrawNumbers.CheckedItems.Count == Convert.ToInt32(CboWheelSize.SelectedItem))
                e.NewValue = CheckState.Unchecked;
        }
    }
}