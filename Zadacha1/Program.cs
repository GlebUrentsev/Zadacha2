using System;
namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {        
                DateTime date = new DateTime(2008, 1, 1);
                int n = int.Parse(Console.ReadLine());
                date = date.AddDays(n);
                if (date.Day < 10 && date.Month < 10)
                {
                    Console.WriteLine($"{date.DayOfWeek}, 0{date.Day}.0{date.Month}");
                }
                else if (date.Day < 10 && date.Month > 10)
                {
                    Console.WriteLine($"{date.DayOfWeek}, 0{date.Day}.{date.Month}");
                }
                else if (date.Day >= 10 && date.Month < 10)
                {
                    Console.WriteLine($"{date.DayOfWeek}, {date.Day}.0{date.Month}");
                }
                else if (date.Day >= 10 && date.Month>=10)
                {
                    Console.WriteLine($"{date.DayOfWeek}, {date.Day}.{date.Month}");
                }           
        }
    }
}
