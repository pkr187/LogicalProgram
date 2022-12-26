using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Dayoftheweek
    {
        int day, month, year;
        public void Days()
        {
            Console.WriteLine("\t Program to get Day Of the Week After Specified Days");
            Console.WriteLine("\t ==================================================================");
            Console.Write("\t Enter Days After Today : ");
            int days = Convert.ToInt32(Console.ReadLine());
            DateTime date = DateTime.Now.AddDays(days);
            Console.WriteLine("\t Current Date : " + DateTime.Now.ToString("MM/dd/yyyy"));
            Console.WriteLine("\t Date After {0} Days : {1}", days, date.ToString("MM/dd/yyyy"));
            Console.WriteLine("\t Day Of The Week On {0} : {1}", date.ToString("MM/dd/yyyy"), date.DayOfWeek);
            Console.ReadKey();
        }
    }
}
