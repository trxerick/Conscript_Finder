using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using ConscriptFinder.States;
using System.Configuration;
using System.Windows;

namespace ConscriptFinder.Logic
{
    public static class DBWorker
    {
        public static SQLiteConnection Connection;
        public static SQLiteDataReader DataReader;
        public static List<object> RecievedData;
        public static string Query;
        public static bool IsConscriptQuery = false;
        public static bool IsConscriptCommandQuery = false;
        public static object locker = new object();

        public static void OpenConnection()
        {
            Connection = new SQLiteConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            Connection.Open();
        }

        public static async Task ExecuteQuery()
        {
            await Task.Run(() =>
            {
                lock (locker) 
                {
                    try
                    {
                        SQLiteCommand Command = Connection.CreateCommand();
                        Command.CommandText = Query;

                        DataReader = Command.ExecuteReader();

                        bool QueryForPRIZ = false;

                        RecievedData = new List<object>();

                        if (Query.Contains("FROM PRIZ"))
                        {
                            QueryForPRIZ = true;
                        }
                        if (QueryForPRIZ)
                        {
                            while (DataReader.Read())
                            {
                                Conscript CurConscript = new Conscript();

				//Param i'ый специально изменненные поля Conscript'a и kom'а.

                                if (!DataReader.IsDBNull(0)) CurConscript.param1 = DataReader.GetString(0);
                                if (!DataReader.IsDBNull(1)) CurConscript.param2 = DataReader.GetString(1);
                                if (!DataReader.IsDBNull(2)) CurConscript.param3 = DataReader.GetString(2);
                                if (!DataReader.IsDBNull(3)) CurConscript.param4 = DataReader.GetString(3);
                                if (!DataReader.IsDBNull(4)) CurConscript.param5 = Helper.ConvertPRIZToConscription(DataReader.GetString(4));
                                if (!DataReader.IsDBNull(5)) CurConscript.param6 = DataReader.GetString(5);
                                if (!DataReader.IsDBNull(6)) CurConscript.param7 = DataReader.GetString(6);
                                if (!DataReader.IsDBNull(7)) CurConscript.param8 = DataReader.GetString(7);
                                if (!DataReader.IsDBNull(8)) CurConscript.param9 = DataReader.GetString(8);
                                if (!DataReader.IsDBNull(9)) CurConscript.param10 = DataReader.GetString(9);
                                if (!DataReader.IsDBNull(10)) CurConscript.param11 = DataReader.GetString(10);
                                if (!DataReader.IsDBNull(11)) CurConscript.param12 = DataReader.GetString(11);
                                if (!DataReader.IsDBNull(12)) CurConscript.param13 = DataReader.GetString(12);
                                if (!DataReader.IsDBNull(13)) CurConscript.param14 = DataReader.GetString(13);
                                if (!DataReader.IsDBNull(14)) CurConscript.param15 = DataReader.GetString(14);
                                if (!DataReader.IsDBNull(15)) CurConscript.param16 = DataReader.GetInt16(15);
                                if (!DataReader.IsDBNull(16)) CurConscript.param17 = DataReader.GetInt16(16);
                                if (!DataReader.IsDBNull(17)) CurConscript.param18 = DataReader.GetInt16(17);
                                if (!DataReader.IsDBNull(18)) CurConscript.param19 = DataReader.GetString(18);
                                if (!DataReader.IsDBNull(19)) CurConscript.param20 = DataReader.GetString(19);
                                if (!DataReader.IsDBNull(20)) CurConscript.param21 = DataReader.GetString(20);
                                if (!DataReader.IsDBNull(21)) CurConscript.param22 = DataReader.GetString(21);
                                if (!DataReader.IsDBNull(22)) CurConscript.param23 = DataReader.GetString(22);
                                if (!DataReader.IsDBNull(23)) CurConscript.param24 = DataReader.GetString(23);
                                if (!DataReader.IsDBNull(24)) CurConscript.param25 = DataReader.GetString(24);
                                if (!DataReader.IsDBNull(25)) CurConscript.param26 = DataReader.GetString(25);
                                if (!DataReader.IsDBNull(26)) CurConscript.param27 = DataReader.GetString(26);
                                if (!DataReader.IsDBNull(27)) CurConscript.param28 = DataReader.GetString(27);
                                if (!DataReader.IsDBNull(28)) CurConscript.param29 = DataReader.GetString(28);
                                if (!DataReader.IsDBNull(29)) CurConscript.param30 = DataReader.GetString(29);
                                if (!DataReader.IsDBNull(30)) CurConscript.param31 = DataReader.GetString(30);
                                if (!DataReader.IsDBNull(31)) CurConscript.param32 = DataReader.GetString(31);
                                if (!DataReader.IsDBNull(32)) CurConscript.param33 = DataReader.GetString(32);
                                if (!DataReader.IsDBNull(33)) CurConscript.param34 = DataReader.GetString(33);
                                if (!DataReader.IsDBNull(34)) CurConscript.param35 = DataReader.GetString(34);
                                if (!DataReader.IsDBNull(35)) CurConscript.param36 = DataReader.GetInt16(35);
                                if (!DataReader.IsDBNull(36)) CurConscript.param37 = DataReader.GetString(36);
                                if (!DataReader.IsDBNull(37)) CurConscript.param38 = DataReader.GetString(37);
                                if (!DataReader.IsDBNull(38)) CurConscript.param39 = DataReader.GetString(38);
                                if (!DataReader.IsDBNull(39)) CurConscript.param40 = DataReader.GetString(39);
                                if (!DataReader.IsDBNull(40)) CurConscript.param41 = DataReader.GetString(40);
                                if (!DataReader.IsDBNull(41)) CurConscript.param42 = DataReader.GetInt16(41);
                                if (!DataReader.IsDBNull(42)) CurConscript.param43 = DataReader.GetString(42);
                                if (!DataReader.IsDBNull(43)) CurConscript.param44 = DataReader.GetString(43);
                                if (!DataReader.IsDBNull(44)) CurConscript.param45 = DataReader.GetInt16(44);

                                RecievedData.Add(CurConscript);
                            }
                        }
                        else
                        {
                            while (DataReader.Read())
                            {
                                ConscriptCommand CurConscriptCommand = new ConscriptCommand();
                                if (!DataReader.IsDBNull(0)) CurConscriptCommand.param1 = Helper.ConvertPRIZToConscription(DataReader.GetString(0));
                                if (!DataReader.IsDBNull(1)) CurConscriptCommand.param2 = DataReader.GetString(1);
                                if (!DataReader.IsDBNull(2)) CurConscriptCommand.param3 = DataReader.GetString(2);
                                if (!DataReader.IsDBNull(3)) CurConscriptCommand.param4 = DataReader.GetString(3);
                                if (!DataReader.IsDBNull(4)) CurConscriptCommand.param5 = DataReader.GetString(4);
                                if (!DataReader.IsDBNull(5)) CurConscriptCommand.param6 = DataReader.GetString(5);
                                if (!DataReader.IsDBNull(6)) CurConscriptCommand.param7 = DataReader.GetString(6);
                                if (!DataReader.IsDBNull(7)) CurConscriptCommand.param8 = DataReader.GetString(7);
                                if (!DataReader.IsDBNull(8)) CurConscriptCommand.param9 = DataReader.GetString(8);
                                if (!DataReader.IsDBNull(9)) CurConscriptCommand.param10 = DataReader.GetString(9);
                                if (!DataReader.IsDBNull(10)) CurConscriptCommand.param11 = DataReader.GetString(10);
                                if (!DataReader.IsDBNull(11)) CurConscriptCommand.param12 = DataReader.GetString(11);
                                if (!DataReader.IsDBNull(12)) CurConscriptCommand.param13 = DataReader.GetString(12);
                                if (!DataReader.IsDBNull(13)) CurConscriptCommand.param14 = DataReader.GetString(13);
                                if (!DataReader.IsDBNull(14)) CurConscriptCommand.param15 = DataReader.GetString(14);
                                if (!DataReader.IsDBNull(15)) CurConscriptCommand.param16 = DataReader.GetString(15);
                                if (!DataReader.IsDBNull(16)) CurConscriptCommand.param17 = DataReader.GetString(16);
                                if (!DataReader.IsDBNull(17)) CurConscriptCommand.param18 = DataReader.GetString(17);
                                if (!DataReader.IsDBNull(18)) CurConscriptCommand.param19 = DataReader.GetString(18);
                                if (!DataReader.IsDBNull(19)) CurConscriptCommand.param20 = DataReader.GetString(19);
                                if (!DataReader.IsDBNull(20)) CurConscriptCommand.param21 = DataReader.GetString(20);
                                if (!DataReader.IsDBNull(21)) CurConscriptCommand.param22 = DataReader.GetString(21);
                                if (!DataReader.IsDBNull(22)) CurConscriptCommand.param23 = DataReader.GetInt16(22);
                                if (!DataReader.IsDBNull(23)) CurConscriptCommand.param24 = DataReader.GetString(23);

                                RecievedData.Add(CurConscriptCommand);
                            }
                        }
                    } 
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при выполнении поиска в бд\n{ex.Message}\n{ex.StackTrace}", "Ошибка", MessageBoxButton.OKCancel);
                    }
                }
            });
        }

        public static void CloseConnection()
        {
            Connection.Close();
        }
    }
}
