using System;


namespace DateAndTime
{

   
    class Program
    {
        public static bool BetweenRanges(int a, int b, int number)
        {
            return (a <= number && number <= b);
        }
        static void Main(string[] args)
        {
            
            //DateTime myValue = DateTime.Now;
            
            //Console.WriteLine(myValue);

            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());

            //DateTime dt = new DateTime(636370000000000000); // Ticks
            //Console.WriteLine(DateTime.MinValue.Ticks); 
            //Console.WriteLine(DateTime.MaxValue.Ticks);

            //DateTime dt1 = new DateTime(2015, 12, 31);
            //TimeSpan ts = new TimeSpan(25, 20, 55); // Time Span
            //DateTime newDate = dt1.Add(ts);
            //Console.WriteLine(newDate);

            //DateTime dt2 = new DateTime(2015, 12, 31);
            //DateTime dt3 = new DateTime(2016, 2, 2);
            //TimeSpan result = dt3.Subtract(dt2);
            //Console.WriteLine(result);


            //Find Age of User in Years Months Days - Input User's DOB

            int year, month, day;

            Console.WriteLine("Enter Your DOB - as dd-mm-yyyyy");

            day = Convert.ToInt32(Console.ReadLine());
            while (!BetweenRanges(1, 31, day))
            {
                Console.WriteLine("Not A Valid Date");
                day = Convert.ToInt32(Console.ReadLine());
            }

            month = Convert.ToInt32(Console.ReadLine());

            while (!BetweenRanges(1, 12, month))
            {
                Console.WriteLine("Not A Valid Month");
                month = Convert.ToInt32(Console.ReadLine());
            }

            year = Convert.ToInt32(Console.ReadLine());

            while (!BetweenRanges(0000, 9999, year))
            {
                Console.WriteLine("Not A Valid Year");
                year = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"So Your DOB is {day}-{month}-{year}");


            DateTime TodayDate = DateTime.Today;
            string currentDates = TodayDate.ToShortDateString();     // 12-07-1998      

            Console.WriteLine(currentDates);

            char[] spearator = { '-' };
            String[] strlist = currentDates.Split(spearator);

            int nowDate = Convert.ToInt32(strlist[0]);
            int nowMonth = Convert.ToInt32(strlist[1]);
            int nowYear = Convert.ToInt32(strlist[2]);


            if (nowDate < day)
            {
                nowDate += DateTime.DaysInMonth(TodayDate.Year, TodayDate.Month);
                nowMonth -= 1;
            }

            if (nowMonth < month)
            {
                nowYear -= 1;
                nowMonth += 12;
            }

            Console.WriteLine($"\nSo, You're {nowYear - year} Years {nowMonth - month} Months {nowDate - day} Days Old.");
            Console.Read();
        }
    }
}
