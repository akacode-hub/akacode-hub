using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.MovieCrusier.Utility
{
    public class DateUtility
    {
        public DateTime ConvertToShortDateString(string inputDate)
        {
            DateTime d = DateTime.ParseExact(inputDate, new string[] { "MM/dd/yyyy", "dd/MM/yyyy" }, null, System.Globalization.DateTimeStyles.None);
            return d;

        }
    }
}
