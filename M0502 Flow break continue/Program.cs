using System;

namespace M0502_Flow_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 != 0)
                    continue;

                if (i > 15)
                    break;

                Console.WriteLine(i);
            }

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core) 
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
