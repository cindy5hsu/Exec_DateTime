using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q6.根據日期, 傳回今天是本月的上旬, 中旬或下旬
            DateTime monthOfDayGreeting = DateTime.Now;
            string theday = string.Empty; 
            if (monthOfDayGreeting.Hour >= 1 && monthOfDayGreeting.Hour < 11)
            {
                theday = "本月的上旬!";
            }
            else if (monthOfDayGreeting.Hour >= 12 && monthOfDayGreeting.Hour < 22)
            {
                theday = "本月中旬!";
            }
            else
            {
                theday = ("本月下旬!");
            }
            Console.WriteLine($"今天是 {theday}");
            
            ////////////////////
            //老師寫法
            //int day = DateTime.Today.Day; //得知今天是幾號

            //string msg = string.Empty;

            //if (day > 0 && day <= 10)
            //{
            //    msg = "上旬";
            //}
            //else if (day > 10 && day <= 20)
            //{
            //    msg = "中旬";
            //}
            //else
            //{
            //    msg = "下旬";
            //}
            //Console.WriteLine($"今天是本月是  {msg}");

            ////比較好的寫法
            //if(day > 20)
            //{
            //    msg = "上旬";
            //}
            //else if(day > 10)
            //{
            //    msg = "中旬";
            //}
            //else
            //{
            //    msg = "下旬";
            //}

        }
    }
}
