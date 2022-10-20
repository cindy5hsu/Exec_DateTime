using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q5.列出指定年份的每一個星期日

            Console.WriteLine("請輸入年份，列如 2022 : ");
            string input = Console.ReadLine();

            int year =Convert.ToInt32(input);
            //大於0才合理，而且有上限
            //找出該年的第一天
            DateTime firstDay = new DateTime(year, 1, 1);

            //找出該年的星期日
           
            int weekday = (int) firstDay.DayOfWeek;//between 0~6
            //用以下這行， 若是0 =》 7-0 除以七的餘數是零
            //           若是0 =》 7 -1 除以七的餘數是6
            //           若是0 =》 7 -2 除以七的餘數是5
            //           若是0 =》 7 -6 除以七的餘數是1
            DateTime firstSunday = firstDay.AddDays((7 - weekday) % 7);
            //if(weekday > 0)
            //{
            //    firstSunday = firstDay.AddDays(7 - weekday);
            //}
            DateTime endDay = new DateTime(year, 12, 31);//該年最後一天
            for(DateTime i = firstSunday; i<=endDay; i = i.AddDays(7))
            {
                Console.WriteLine(i.ToString("yyyy/MM/dd"));
            }
        }
    }
}
