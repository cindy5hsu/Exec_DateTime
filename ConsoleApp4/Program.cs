using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q4.取得本月最後一天
            String yy = DateTime.Now.Year.ToString();
            String mm = DateTime.Now.Month.ToString();
            DateTime LastDay = DateTime.Now.AddMonths(1).AddDays(-DateTime.Now.AddMonths(1).Day);

            Console.WriteLine(mm + " " + LastDay);
        }
    }
}
