using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExamApp.Models
{
    public class GVar
    {
        #region [DB연결 String획득]
        internal static string GetDBConstr()
        {
            string conStr = string.Empty;

            conStr = "data source=.\\SQLEXPRESS;initial catalog=TestSrvDB;user id=sa;password=1234";

            return conStr;
        }
        #endregion
    }
}
