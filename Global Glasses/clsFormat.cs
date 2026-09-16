using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Global_Glasses
{
    public class clsFormat
    {
        public static string DateToShort(DateTime date)
        {
            return date.ToString("DD/MMM/yyyy");
        } 
    }
}
