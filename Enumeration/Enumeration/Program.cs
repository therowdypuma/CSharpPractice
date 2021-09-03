using System;

namespace Enumeration
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
        

            Console.WriteLine(WeekDays.Monday); // Monday
            Console.WriteLine(WeekDays.Tuesday); // Tuesday
            Console.WriteLine(WeekDays.Wednesday); // Wednesday
            Console.WriteLine(WeekDays.Thursday); // Thursday
            Console.WriteLine(WeekDays.Friday); // Friday
            Console.WriteLine(WeekDays.Saturday); // Saturday
            Console.WriteLine(WeekDays.Sunday); // Sunday

            Console.WriteLine(WeekDays.Friday);
            int day = (int)WeekDays.Friday;
            Console.WriteLine(day);

            var wd = (WeekDays)5;
            Console.WriteLine(wd);

            Console.Read();

         
        }
    }
}
