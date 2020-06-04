using System;

namespace M801_Simpel_terning
{
    public class Terning
    {
        public int værdi;
        private bool snyd;

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.snyd = snyd;
            Ryst();
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            Random rnd = new Random();
            int tal = rnd.Next(1, 7);
        } 


    }
}
