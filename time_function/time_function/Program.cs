using System;

namespace time_function
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current_time = DateTime.Now;
            Console.WriteLine("Current date & time: " + current_time.ToString());
            Console.WriteLine("Current short date: " + current_time.ToShortDateString());
            Console.WriteLine("Current short time: " + current_time.ToShortTimeString());
            Console.WriteLine("Current long date: " + current_time.ToLongDateString());
            Console.WriteLine("Current long time: " + current_time.ToLongTimeString());

            Console.WriteLine("Current date & time: " + current_time.AddMonths(3).ToLongDateString());
            Console.WriteLine("Current date & time: " + current_time.AddDays(-10).ToLongDateString());

            DateTime myBrzday = new DateTime(1997, 9, 22);

            Console.WriteLine("My Brzday: " + myBrzday.ToLongDateString());

            DateTime myBirthday = DateTime.Parse("22/9/1997");

            Console.WriteLine("My Birthday: " + myBirthday.ToLongDateString());

            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine(Math.Round(myAge.TotalDays));

        }
    }
}
