using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1.計算三天後 DVD 應歸還時間
            Console.WriteLine("請輸入借書時間： ");
            string input = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(input);
           // DateTime dt = DateTime.Now;
            string result = dt.AddDays(3).ToString("yyyy-MM-dd");
            
            Console.WriteLine(result.ToString()+ "三天後 DVD 應歸還");
        }
    }
}
