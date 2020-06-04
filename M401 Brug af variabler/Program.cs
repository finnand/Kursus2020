using System;

namespace M401_Brug_af_variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 10;
            Console.WriteLine("tal = "+tal);

            Console.WriteLine("Først lægger vi til");
            for (int i = 0; i < 5; i++)
            {
                tal++;
                Console.WriteLine("tal = " + tal);
            }

            Console.WriteLine("og så trækker vi fra.");
            for (int i = 0; i < 5; i++)
            {
                tal--;
                Console.WriteLine("tal = " + tal);
            }

            Console.WriteLine("Der lægges 20 til tal");
            tal += 20;
            Console.WriteLine("tal = " + tal);

            Console.WriteLine();
            Console.WriteLine("Der kigges på kommatal");
            double kommatal = 12.5;
            
            Console.WriteLine("Først lægger vi til");
            for (int i = 0; i < 5; i++)
            {
                kommatal++;
                Console.WriteLine("kommatal = "+kommatal);
            }

            Console.WriteLine("og så trækker vi fra.");
            for (int i = 0; i < 5; i++)
            {
                kommatal--;
                Console.WriteLine("kommatal = " + kommatal);
            }

            Console.WriteLine("kommatal ganges med 200");
            kommatal *= 200;
            Console.WriteLine("kommatal = " + kommatal.ToString("C2"));



        }
    }
}
