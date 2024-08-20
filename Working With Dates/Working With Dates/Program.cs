using System;

namespace Working_With_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Date and time are immutable 
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now; 
            var today = DateTime.Today;
            
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
            var tomrrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine("Tomrrow: " + tomrrow);
            Console.WriteLine("Yesterday: " + yesterday);
            

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd"));
            
            // ======== Time Spn =========

            //Creating 
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; // this returns timespan 
            Console.WriteLine( "Duration: " + duration);

            // Properties 
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add 
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)).TotalMinutes);


            // Subtract
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)).TotalMinutes);

            //ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }
    }
}
