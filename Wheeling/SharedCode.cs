using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Wheeling;

public static class SharedCode
{
    public static WheelingProperties properties = new WheelingProperties();
    public static OleDbConnection oOleDbConnection;
    public static OleDbCommand oOleDbCommand;
    // "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Greg\\source\\repos\\Wheeling\\Wheeling\\wheeling.accdb;Persist Security Info=False;"
    public static readonly string sConnectionString = "Provider=" + properties.Get("provider") +
                                                      "Data Source=" + properties.Get("datasource") +
                                                      "Persist Security Info=" + properties.Get("security");
    public static Dictionary<string, int> lotteries = new Dictionary<string, int>();
    public static Dictionary<LotteryInfo, object> lotteryInfo = new Dictionary<LotteryInfo, object>();

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
            oOleDbConnection = new OleDbConnection
            {
                ConnectionString = sConnectionString
            };
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
        string sql = "SELECT id, lottery_name FROM Lottery ORDER BY id ASC";

        OleDbDataReader oOleDbDataReader;
        try
        {
            if (OpenDBConnection(sql))
            {
                oOleDbDataReader = oOleDbCommand.ExecuteReader();

                while (oOleDbDataReader.Read())
                {
                    lotteries.Add(oOleDbDataReader.GetString(1), oOleDbDataReader.GetInt32(0));
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
}