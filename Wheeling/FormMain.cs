using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheeling
{
    public partial class FormMain : Form
    {
        private OleDbConnection oOleDbConnection;
        private OleDbCommand oOleDbCommand;
        private readonly string sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Greg\\source\\repos\\Wheeling\\Wheeling\\wheeling.accdb;Persist Security Info=False;";
        private string lotteryName;
        private enum DataColumn
        {
            LotteryName = 0,
            DrawDate = 1,
            N1 = 2,
            N2 = 3,
            N3 = 4,
            N4 = 5,
            N5 = 6,
            N6 = 7,
            N7 = 8,
            Bonus = 9
        }
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
            LoadLotteryData(1);
        }
        private Boolean OpenDBConnection(string sql)
        {
            try
            {
                oOleDbConnection = new OleDbConnection();
                oOleDbConnection.ConnectionString = sConnectionString;
                oOleDbConnection.Open();
                if (oOleDbConnection.State == ConnectionState.Open)
                {
                    oOleDbCommand = new OleDbCommand(sql, oOleDbConnection);
                }

                return true;
            }
            catch (Exception ex)
            {
                oOleDbCommand = null;
                oOleDbConnection = null;
                Console.WriteLine(ex.StackTrace);

                return false;
            }
        }

        private void CloseDBConnection()
        {
            try
            {
                if (oOleDbConnection != null && oOleDbConnection.State == ConnectionState.Open)
                    oOleDbConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                oOleDbCommand = null;
                oOleDbConnection = null;
            }
        }
        private void LoadLotteryData(int lottery)
        {
            string sql = "SELECT L.lottery_name,D.Date,D.N1,D.N2,D.N3,D.N4,D.N5,D.N6,D.N7,D.Bonus FROM Lottery L INNER JOIN Draws D ON L.ID = D.Lottery_ID WHERE L.ID = " + lottery + " ORDER BY D.Date DESC";
            this.DgvLotteryData.Rows.Clear();

            OleDbDataReader oOleDbDataReader;
            try
            {
                if (OpenDBConnection(sql))
                {
                    oOleDbDataReader = oOleDbCommand.ExecuteReader();

                    while (oOleDbDataReader.Read())
                    {
                        int field = oOleDbDataReader.FieldCount;
                        string[] rowData = new string[field];
                        int column = 0;
                        lotteryName = oOleDbDataReader.GetString((int)DataColumn.LotteryName);
                        for (int index=0; index<field; index++)
                        {
                            if (index != (int)DataColumn.LotteryName)
                            {
                                if (index == (int)DataColumn.DrawDate)
                                {
                                    rowData[column] = oOleDbDataReader.GetDateTime(index).ToString("MMM. dd, yyyy");
                                } 
                                else
                                {
                                    rowData[column] = oOleDbDataReader.GetValue(index).ToString();
                                }
                                column++;
                            }
                        }
                        this.DgvLotteryData.Rows.Add(rowData);
                    }
                    LblLotteryName.Text = lotteryName;
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
    }
}
