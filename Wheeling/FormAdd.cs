using System;
using System.Windows.Forms;
using static SharedCode;

namespace Wheeling
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormAdd_Load(object sender, EventArgs e)
        {
            LoadAllLotteryNumberOptions(LstDrawNumbers);
            LoadAllLotteryNumberOptions(CboBonusNumber);

            LblLottery.Text = lotteryInfo[LotteryInfo.LotteryName].ToString();
            if ((DateTime)lotteryInfo[LotteryInfo.MinDrawDate] != default)
                DtpDrawDate.MinDate = (DateTime)lotteryInfo[LotteryInfo.MinDrawDate];
        }
        private void BtnAddDraw_Click(object sender, EventArgs e)
        {
            if (LstDrawNumbers.SelectedItems.Count == (int)lotteryInfo[LotteryInfo.NumbersDrawn] && CboBonusNumber.SelectedIndex >= 0)
            {
                // Go ahead and save
                string sqlInsertUpdate = "INSERT INTO Draws (lottery_id,draw_date,n1,n2,n3,n4,n5,n6,n7,bonus) " +
                "VALUES (" + lotteryInfo[LotteryInfo.LotteryID] + ",'" + DtpDrawDate.Value.ToString("yyyy-MM-dd") + "'";
                for (int index = 0; index < 7; index++)
                {
                    if (index < LstDrawNumbers.SelectedItems.Count)
                        sqlInsertUpdate += "," + LstDrawNumbers.SelectedItems[index].Text;
                    else
                        sqlInsertUpdate += ",null";
                }
                sqlInsertUpdate += "," + CboBonusNumber.SelectedItem.ToString() + ")";
                try
                {
                    if (OpenDBConnection(sqlInsertUpdate))
                        oOleDbCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    CloseDBConnection();
                    this.Close();
                }
            }
        }
        private void LstDrawNumbers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            CheckBonusNumber();

            if (LstDrawNumbers.SelectedItems.Count > (int)lotteryInfo[LotteryInfo.NumbersDrawn])
                e.Item.Selected = false;
        }
        private void CboBonusNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBonusNumber();
        }
        private void CheckBonusNumber()
        {
            for (int index = 0; index < LstDrawNumbers.SelectedItems.Count; index++)
            {
                if (CboBonusNumber.SelectedIndex > -1 && CboBonusNumber.SelectedItem.ToString().Equals(LstDrawNumbers.SelectedItems[index].Text))
                    CboBonusNumber.SelectedIndex = -1;
            }
        }
    }
}