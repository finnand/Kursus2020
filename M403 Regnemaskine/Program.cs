using System;

namespace M403_Regnemaskine
{
    class Program
    {
        // x
        private const string funktioner = "Indtast funktion: P(plus), M(minus), G(gange), D(dividér)";

        static void Main(string[] args)
        {
            Console.WriteLine("Regnemaskine");

            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();

            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();

            Console.WriteLine(funktioner);
            string opr = Console.ReadLine();

            double t1 = System.Convert.ToDouble(tal1);
            double t2 = System.Convert.ToDouble(tal2);

            double result = t1 + t2;

            Console.WriteLine(value: "Operator der er valgt: " + opr);
            Console.WriteLine(value: "Resultat: " + result.ToString("N2"));
        }
    }
}
