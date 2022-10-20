using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q3 取得本月一日
            string day = System.DateTime.Now.ToString();
            int date = System.DateTime.Now.Day;
            
            //String FirstDay =System.DateTime.Now.AddDays(Convert.ToDouble(date-1)).DayOfWeek.ToString();
            DateTime FirstDay = DateTime.Now.AddDays(-DateTime.Now.Day + 1);

            Console.WriteLine(date + " " + FirstDay);
        }
    }
}
