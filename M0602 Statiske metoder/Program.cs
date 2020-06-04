using System;

namespace M0602_Statiske_metoder
{
    class Program
    {
        static void Main(string[] args)

        {
            // Opret en fil på c:\temp kaldet test.txt og put lidt tekst i  
            // PS: Husk at windows kunne finde på at kalde den test.txt.txt (gem som "test.txt" - altså med anførselstegn)
            bool t = System.IO.File.Exists(@"c:\temp\test.txt");

            Console.WriteLine($"Findes fil: {t}");

            string indhold = System.IO.File.ReadAllText(@"c:\temp\test.txt");

            Console.WriteLine(indhold);



            var fil = new System.IO.FileInfo(@"c:\temp\test.txt");

            DateTime d = fil.LastAccessTime;

            Console.WriteLine($"Tid: {d}");

            string ex = fil.Extension;

            Console.WriteLine($"Extension: {ex}");



            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }
        }
    }
}
