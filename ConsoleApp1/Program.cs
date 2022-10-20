using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Q2.計算圖書下個月歸還時間
            Console.WriteLine("請輸入借書時間： ");
            string input = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(input);
            //DateTime dt = DateTime.Now;
            string result = dt.AddMonths(1).ToString("yyyy-MM-dd");

            Console.WriteLine(result.ToString() + "下個月歸還");
        }
    }
}
