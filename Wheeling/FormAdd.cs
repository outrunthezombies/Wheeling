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

            LblLottery.Text = lotteries[lotterySelected].Name;
            if (lotteries[lotterySelected].MinDrawDate != default)
                DtpDrawDate.MinDate = lotteries[lotterySelected].MinDrawDate;
        }
        private void BtnAddDraw_Click(object sender, EventArgs e)
        {
            if (LstDrawNumbers.CheckedItems.Count == (int)lotteries[lotterySelected].NumbersDrawn && CboBonusNumber.SelectedIndex >= 0)
            {
                // Go ahead and save
                string sqlInsertUpdate = "INSERT INTO Draws (lottery_id,draw_date,n1,n2,n3,n4,n5,n6,n7,bonus) " +
                "VALUES (" + lotteries[lotterySelected].ID + ",'" + DtpDrawDate.Value.ToString("yyyy-MM-dd") + "'";
                for (int index = 0; index < 7; index++)
                {
                    if (index < LstDrawNumbers.CheckedItems.Count)
                        sqlInsertUpdate += "," + LstDrawNumbers.CheckedItems[index].Text;
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

            if (LstDrawNumbers.CheckedItems.Count > lotteries[lotterySelected].NumbersDrawn)
                e.Item.Selected = false;
        }
        private void CboBonusNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBonusNumber();
        }
        private void CheckBonusNumber()
        {
            for (int index = 0; index < LstDrawNumbers.CheckedItems.Count; index++)
            {
                if (CboBonusNumber.SelectedIndex > -1 && CboBonusNumber.SelectedItem.ToString().Equals(LstDrawNumbers.CheckedItems[index].Text))
                    CboBonusNumber.SelectedIndex = -1;
            }
        }
        private void LstDrawNumbers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (LstDrawNumbers.CheckedItems.Count == lotteries[lotterySelected].NumbersDrawn)
                e.NewValue = CheckState.Unchecked;
        }
    }
}