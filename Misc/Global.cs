using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityParty.Misc
{
    /// <summary>
    /// Contains global strings to be used throughout the project
    /// </summary>
    public static class Global
    {
        public static String dbLoc = "./Dblite";
        public static String WorkItemsContainerTable = "work_items";
        public static String date = "";

        public static String DateToString(DateTime d)
        {
            return String.Format("{0}/{1}/{2}", d.Month, d.Day, d.Year);
        }
    }
}
