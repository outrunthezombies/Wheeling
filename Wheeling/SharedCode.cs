using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Wheeling;

public static class SharedCode
{
    public static WheelingProperties properties = new WheelingProperties();
    public static OleDbConnection oOleDbConnection = new OleDbConnection();
    public static OleDbCommand oOleDbCommand;
    public static readonly string sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + properties.Get("datasource") + ";Persist Security Info=False;";
    public static List<Lottery> lotteries = new List<Lottery>();
    public static int lotterySelected = -1;

    public enum DataColumn
    {
        DrawDate = 0,
        N1 = 1,
        N2 = 2,
        N3 = 3,
        N4 = 4,
        N5 = 5,
        N6 = 6,
        N7 = 7,
        Bonus = 8,
        LotteryID = 9,
        LotteryName = 10,
        MaxNumber = 11,
        NumbersDrawn = 12
    }
    public enum LotteryInfo
    {
        LotteryID = 0,
        LotteryName = 1,
        MinDrawDate = 2,
        MaxNumber = 3,
        NumbersDrawn = 4
    }
    public static Boolean OpenDBConnection(string sql)
    {
        try
        {
            if (oOleDbConnection == null)
                oOleDbConnection = new OleDbConnection();
            if (oOleDbConnection.State != ConnectionState.Open)
            {
                oOleDbConnection.ConnectionString = sConnectionString;
                oOleDbConnection.Open();
            }
            oOleDbCommand = new OleDbCommand(sql, oOleDbConnection);

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

    public static void CloseDBConnection()
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
    public static void GetLotteries()
    {
        string sql = "SELECT id, lottery_name, max_number, numbers_drawn FROM Lottery ORDER BY lottery_name";

        OleDbDataReader oOleDbDataReader;
        try
        {
            if (OpenDBConnection(sql))
            {
                oOleDbDataReader = oOleDbCommand.ExecuteReader();

                while (oOleDbDataReader.Read())
                {
                    Lottery lottery = new Lottery
                    {
                        ID = oOleDbDataReader.GetInt32(0),
                        Name = oOleDbDataReader.GetString(1),
                        MaxNumber = oOleDbDataReader.GetInt32(2),
                        NumbersDrawn = oOleDbDataReader.GetInt32(3)
                    };
                    lotteries.Add(lottery);
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
    public static void LoadAllLotteryNumberOptions(ListView lstView)
    {
        for (int index = 1; index <= lotteries[lotterySelected].MaxNumber; index++)
            lstView.Items.Add(index.ToString());
    }
    public static void LoadAllLotteryNumberOptions(ComboBox cboBox)
    {
        for (int index = 1; index <= lotteries[lotterySelected].MaxNumber; index++)
            cboBox.Items.Add(index);
    }
}