using System;
using System.ComponentModel.Design.Serialization;

namespace M402_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // x
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            Console.WriteLine();

            Console.WriteLine("Vi trækker én dato fra en anden dato");
            DateTime d2 = DateTime.Now;
            DateTime d3 = d2.AddMonths(-3);

            TimeSpan antalDage = d2.Subtract(d3);
            Console.WriteLine("antaleDage = "+antalDage.Days);

            Console.WriteLine();

            Console.WriteLine("Vi kigger på TimeSpan");
            TimeSpan t2 = new TimeSpan(16, 0, 0);
            Console.WriteLine("t2 = " + t2);

            TimeSpan t3 = new TimeSpan(0, 30, 0);
            Console.WriteLine("t3 = " + t3);

            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine("t4 = " + t4);

            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine("t5 = " + t5);

        }
    }
}
