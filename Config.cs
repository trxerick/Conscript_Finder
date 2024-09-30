using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConscriptFinder
{
    public static class Config
    {
        public static List<string> RVKList = new List<string>(ConfigurationManager.AppSettings["RVKList"].Split(',').ToList());

        public static Dictionary<string, string> ConscriptList = new Dictionary<string, string>();
        public static void FillConscriptList()
        {
            List<string> PRIZ = ConfigurationManager.AppSettings["PRIZ"].Split(',').ToList();
            List<string> PRIZNames = ConfigurationManager.AppSettings["PRIZNames"].Split(',').ToList();
            int idx = 0;

            foreach(string pr in PRIZNames)
                ConscriptList.Add(pr, PRIZ[idx++]);
        }

        public static List<string> StationList = new List<string>(ConfigurationManager.AppSettings["StationsList"].Split(',').ToList());

        public static List<string> MilKinds = new List<string>(ConfigurationManager.AppSettings["MilKinds"].Split(',').ToList());
    }
}
