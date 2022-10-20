using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q7.根據不同時間, 傳回不同問安方式

            DateTime timeOfDayGreeting = DateTime.Now;

            if (timeOfDayGreeting.Hour >= 0 && timeOfDayGreeting.Hour < 11)
            {
                Console.WriteLine("Good morning!");
            }
            else if (timeOfDayGreeting.Hour >= 12 && timeOfDayGreeting.Hour < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }
            
            Console.ReadKey();
            

            
            
        }
    }
}
