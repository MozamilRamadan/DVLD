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
        public static clsUsers _USER {  get; set; }

        public static bool IsLoggedIn
        {
            get { return _USER != null; }
        }

        public static void LogeOut()
        {
            _USER = null;
        }
    }
}
