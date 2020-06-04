using System;

namespace M601_Simple_metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(3, 7);
            Console.WriteLine(res);

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);

            double res3 = BeregnBeløbEfterMoms(100, .25);
            Console.WriteLine(res3);



        }

        static int LægSammen(int a, int b)
        {
            return (a + b);
        }

        static double BeregnAreal(int radius)
        {
            return (radius * radius * Math.PI);
        }

        static double BeregnBeløbEfterMoms(double beløb, double momsPct)
        {
            return (beløb * (1 + momsPct));
        }
    }
}
