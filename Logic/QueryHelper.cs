using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConscriptFinder.Logic
{
    public static class QueryHelper
    {
        public static string ConscriptQuery = "Запрос с INNER JOIN'ом";
        public static string ConscriptCommandQuery = "Обычный запрос из одной из таблиц";

        public static string ConscriptCommandAdditionQuery = "Обычный запрос из одной из таблиц";

        public static Dictionary<string, string> ConscriptQueryParameters = new Dictionary<string, string>()
        {
            {"KeyFromDB1", null},
            {"KeyFromDB2", null},
            {"KeyFromDB3", null},
            {"KeyFromDB4", null},
            {"KeyFromDB5", null},
            {"KeyFromDB6", null},
            {"KeyFromDB7", null},
            {"KeyFromDB8", null},
            {"KeyFromDB9", null},
            {"KeyFromDB10", null}
        };

        public static Dictionary<string, string> ConscriptCommandQueryParameters = new Dictionary<string, string>()
        {
            {"KeyFromDB1", null},
            {"KeyFromDB2", null},
            {"KeyFromDB3", null},
            {"KeyFromDB4", null}
        };

        public static string FormQuery()
        {
            bool IsFirstParameter = true, IsConscriptCommandQuery = false;
            
            foreach (string key in ConscriptQueryParameters.Keys)
            { 
                if (ConscriptQueryParameters[key] != null)
                {
                    if(IsFirstParameter == true)
                    {
                        IsFirstParameter = false;
                        ConscriptQuery += ($" WHERE {key} = \'{ConscriptQueryParameters[key]}\'");
                        //ConscriptQuery += ($" WHERE {key} LIKE \'%{ConscriptQueryParameters[key]}%\'");
                    }
                    else
                    {
                        ConscriptQuery += ($" AND {key} = \'{ConscriptQueryParameters[key]}\'");
                        //ConscriptQuery += ($" AND {key} LIKE \'%{ConscriptQueryParameters[key]}%\'");
                    }
                }
            }

            foreach (string key in ConscriptCommandQueryParameters.Keys)
            {
                if (ConscriptCommandQueryParameters[key] != null)
                {
                    if (ConscriptCommandQueryParameters[key] != null) IsConscriptCommandQuery = true;

                    if (IsFirstParameter == true)
                    {
                        IsFirstParameter = false;
                        ConscriptCommandQuery += ($" WHERE {key} = \'{ConscriptCommandQueryParameters[key]}\'");
                        //ConscriptCommandQuery += ($" WHERE {key} LIKE \'%{ConscriptCommandQueryParameters[key]}%\'");
                    }
                    else
                    {
                        ConscriptCommandQuery += ($" AND {key} = \'{ConscriptCommandQueryParameters[key]}\'");
                        //ConscriptCommandQuery += ($" AND {key} LIKE \'%{ConscriptCommandQueryParameters[key]}%\'");
                    }
                }
            }

            if (IsConscriptCommandQuery)
            {
                DBWorker.Query = ConscriptCommandQuery;
                DBWorker.IsConscriptCommandQuery = true;
                return ConscriptCommandQuery;
            }
            else
            {
                DBWorker.Query = ConscriptQuery;
                DBWorker.IsConscriptQuery = true;
                return ConscriptQuery;
            }
        }

        public static void ClearQuery()
        {
            ConscriptQuery = "Запрос с INNER JOIN'ом";

            ConscriptCommandQuery = "Обычный запрос из одной из таблиц";

            ConscriptCommandAdditionQuery = "Обычный запрос из одной из таблиц";

            DBWorker.IsConscriptCommandQuery = false;
            DBWorker.IsConscriptQuery = false;

            foreach (string key in ConscriptQueryParameters.Keys.ToList())
                ConscriptQueryParameters[key] = null;

            foreach (string key in ConscriptCommandQueryParameters.Keys.ToList())
                ConscriptCommandQueryParameters[key] = null;
        }
    }
}
