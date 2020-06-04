using System;

namespace M801_Simpel_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            Console.WriteLine(t1.værdi);    // 1
            t1.Ryst(); 
            Console.WriteLine(t1.værdi);    // tilfældig værdi

            Terning t2 = new Terning(true);
            Console.WriteLine(t2.værdi);    // 2
            t2.Ryst();
            Console.WriteLine(t2.værdi);    // tilfældig værdi

            Terning t3 = new Terning(false);    // Fejl: Forkert værdi            
        }
    }
}
