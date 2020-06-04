using System;

namespace M451_Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stopur 369 ms
            //System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            //s.Start();
            //string a = "";
            //for (int i = 0; i < 50_000; i++)
            //{
            //    a += "*";
            //}
            //s.Stop();
            //Console.WriteLine($"ms = {s.ElapsedMilliseconds}");

            // Stopur 9 ms
            //System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //s.Start();
            //for (int i = 0; i < 500_000; i++)
            //{
            //    sb.Append("*");
            //}
            //s.Stop();
            //Console.WriteLine($"ms = {s.ElapsedMilliseconds}");


            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Linje 1");
            sb.AppendLine("Linje 2");
            sb.Insert(3, "**");
            sb.Replace("**", "!!");
            sb.Append("@@");
            Console.WriteLine($"Længde: {sb.Length}");
            Console.WriteLine($"Indhold:\r\n{sb.ToString()}");
            // ---------- Output: ----------
            //Længde: 22
            //Indhold:
            //Lin!!je 1
            //Linje 2
            //@@

 

        }
    }
}
