using System;

namespace M1101_Eget_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] array = new IDbFunktioner[4];

            array[0] = new Hund();
            array[1] = new Ubåd();
            array[2] = new Hund();
            array[3] = new Ubåd();

            foreach (var item in array)
            {
                item.Gem();
            }

        }


        interface IDbFunktioner
        {
            void Gem();
        }


        class Hund : IDbFunktioner
        {
            public string Navn { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer hund.........");
            }
        }

        class Ubåd : IDbFunktioner
        {
            public int Nummer { get; set; }
            public double Turbine { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer ubåd.........");
            }
        }




    }
}
