using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q5列出指定年份的每一個星期日
            //先找出來第一個星期天
            //之後 + 7天
            //DateTime startDate = new DateTime(2022, 1, 1);
            //DateTime endDate = new DateTime(2022, 12, 31);

            //DateTime firstDate = DateTime.MinValue;
            //DateTime firstDateInWeek = DateTime.MinValue;
            //DateTime targetDate = DateTime.MinValue;

            //int firstWeekNumber = 0;


            //CultureInfo info = CultureInfo.CurrentCulture;

            //List<DateTime> result = new List<DateTime>();
            /////////////////
            //List<DateTime> dates = new List<DateTime>();
            //int year = 2013;
            //int month = 1;
            //DateTime firstdayinyear = new DateTime(year, month, 1);
            //DayOfWeek day = firstdayinyear.DayOfWeek;
            //Console.WriteLine(day);
            //DateTime firstday = firstdayinyear.AddDays(5);
            //targetDate = firstDate.AddDays((firstWeekNumber - 1) * 7);


            //DayOfWeek day = DayOfWeek.Sunday;
            //System.Globalization.CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            //for (int i = 1; i <= currentCulture.Calendar.GetDaysInMonth(year, month); i++)
            //{
            //    DateTime d = new DateTime(year, month, i);
            //    if (d.DayOfWeek == day)
            //    {
            //        dates.Add(d);
            //    }
            //    Console.WriteLine(d);
            }
            

            //for (int i = 1; i <= 12; i++)
            //{
            //    firstDateInWeek = new DateTime(2011, i, 1);
            //    //firstDate = new DateTime(firstDateInWeek.Year, 1, 1);

            //    firstWeekNumber = info.Calendar.GetWeekOfYear(firstDateInWeek, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            //    //fourthWeekNumber = firstWeekNumber;

            //    //targetDate = firstDate.AddDays((firstWeekNumber - 1) * 7);

            //    while (targetDate.DayOfWeek != DayOfWeek.Sunday)
            //    {
            //        targetDate = targetDate.AddDays(-1);
            //    }
            //    if (targetDate >= startDate)
            //    {

            //        result.Add(targetDate);
            //    }
            //    Console.WriteLine(targetDate);
            //}

        }   

    }
}
