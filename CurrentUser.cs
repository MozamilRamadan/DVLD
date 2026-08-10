using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DVLD
{
    public static class clsCurrentUser
    {
        public static clsUsers USER {  get; set; }

        public static bool IsLoggedIn
        {
            get { return USER != null; }
        }

        public static void LogeOut()
        {
            USER = null;
        }
    }
}
