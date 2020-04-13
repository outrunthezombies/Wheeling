using System;
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
            lotteryInfo.Clear();
            LstDrawNumbers.Items.Clear();

            if (CboAvailableLotteries.SelectedIndex >= 0)
            {
                string sql = "SELECT D.Draw_date,D.N1,D.N2,D.N3,D.N4,D.N5,D.N6,D.N7,D.Bonus,L.id,L.lottery_name,L.max_number,L.numbers_drawn FROM Lottery L INNER JOIN Draws D ON L.ID = D.Lottery_ID WHERE L.ID = " + lotteries[CboAvailableLotteries.SelectedItem.ToString()] + " ORDER BY D.Draw_date DESC";
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
                    lotteryInfo.Add(LotteryInfo.LotteryID, lotteryID);
                    lotteryInfo.Add(LotteryInfo.LotteryName, lotteryName);
                    lotteryInfo.Add(LotteryInfo.NumbersDrawn, lotteryNumbersDrawn);
                    lotteryInfo.Add(LotteryInfo.MaxNumber, lotteryMaxNumber);
                    lotteryInfo.Add(LotteryInfo.MinDrawDate, lotteryMinDrawDate.AddDays(1));

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
            foreach (KeyValuePair<string, int> kvp in lotteries)
                CboAvailableLotteries.Items.Add(kvp.Key);
        }

        private void CboAvailableLotteries_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLotteryData();
            CboWheelSize.Enabled = true;
        }

        private void CboWheelSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CboWheelSize.SelectedItem) < LstDrawNumbers.SelectedItems.Count)
            {
                for (int index = 0; index < LstDrawNumbers.Items.Count; index++)
                    LstDrawNumbers.Items[index].Selected = false;
            }
            if (CboWheelSize.SelectedIndex > -1)
                LstDrawNumbers.Enabled = true;
            CheckIfReadyToWheel();
        }
        private void CheckIfReadyToWheel()
        {
            if (LstDrawNumbers.SelectedItems.Count == Convert.ToInt32(CboWheelSize.SelectedItem))
                BtnBuildWheel.Enabled = true;
            else if (LstDrawNumbers.SelectedItems.Count < Convert.ToInt32(CboWheelSize.SelectedItem))
                BtnBuildWheel.Enabled = false;
        }
        private void LstDrawNumbers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (LstDrawNumbers.SelectedItems.Count > Convert.ToInt32(CboWheelSize.SelectedItem))
                e.Item.Selected = false;
            CheckIfReadyToWheel();
        }
        private void BtnBuildWheel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Build the Wheel!");
        }
    }
}
