using System;

namespace M1002_Udvid_random
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            
            for (int i = 0; i < 22; i++)
            {
                Console.WriteLine(r.NextBool()); // true eller false
            }
        }
    }

    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            int t = this.Next(1, 1002);
            bool res = t <= 500;
            return res;
        }
    }
}
