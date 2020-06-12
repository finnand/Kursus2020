using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;


namespace M1206_Simpel_regnemaskine_Lambda
{
    class Program
    {
        //}public static object Tilføjelse { get; private set; }

        // Se bemærkning i opgaven:
        //static Func<int, int, int> plus = (a, b) => a + b;
        //static Func<int, int, int> minus = (a, b) => a - b;
        //static Func<int, int, int> gange = (a, b) => a * b;
        //static Func<int, int, int> divider = (a, b) => a / b;

        static async Task Main(string[] args)
        {
            int res = 0;
            res = Beregner(1, 1, (a, b) => a + b);
            Console.WriteLine(res);
            res = Beregner(2, 1, (a, b) => a - b);
            Console.WriteLine(res);
            res = Beregner(2, 2, (a, b) => a * b);
            Console.WriteLine(res);
            res = Beregner(4, 2, (a, b) => a / b);
            Console.WriteLine(res);

            var f = FindTilfældigFunktion();
            res = f(10, 5);
            Console.WriteLine(res);

            f = FindTilfældigFunktion2((a, b) => a + b, (a, b) => a - b, (a, b) => a * b, (a, b) => a / b);
            res = f(10, 5);
            Console.WriteLine(res);

            // Avanceret brug af expressions (det skal du ikke kunne - det er blot til orientering)
            await Tilføjelse.Ekstra();

        }

        public static int Beregner(int a, int b, Func<int, int, int> funktion)
        {
            return funktion(a, b);
        }

        public static Func<int, int, int> FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return (a, b) => a + b;

            if (System.DateTime.Now.Millisecond <= 500)
                return (a, b) => a - b;

            if (System.DateTime.Now.Millisecond <= 750)
                return (a, b) => a * b;

            return (a, b) => a / b;
        }

        public static Func<int, int, int> FindTilfældigFunktion2(params Func<int, int, int>[] funktioner)
        {
            System.Random rnd = new Random();
            int nr = rnd.Next(0, funktioner.Length);
            return funktioner[nr];
        }



        class Tilføjelse
        {
            public static async Task Ekstra()

            {

                // Kræver NuGet-pakken: Microsoft.CodeAnalysis.CSharp.Scripting



                // Antag at dette kommer fra en tekstfil eller db eller ?

                string tekstMedformler = "navn;formel\r\n";

                tekstMedformler += "Plus; (a,b)=>a+b\r\n";

                tekstMedformler += "Minus; (a,b)=>a-b\r\n";

                tekstMedformler += "Gange; (a,b)=>a*b\r\n";

                tekstMedformler += "Divider; (a,b)=>a/b";



                // Split til linjer

                string[] formlerLinjer = tekstMedformler.Split("\r\n");

                // Split til en dictionary

                Dictionary<string, Func<int, int, int>> formler = new Dictionary<string, Func<int, int, int>>();

                for (int i = 1; i < formlerLinjer.Length; i++)

                {

                    var tmp = formlerLinjer[i].Split(";");

                    string navn = tmp[0];

                    string formelSomStreng = tmp[1];

                    // Dan en compileret lambda fra en streng (!!!!!)

                    Func<int, int, int> compileretLambda = await CSharpScript.EvaluateAsync<Func<int, int, int>>(formelSomStreng);

                    formler.Add(navn, compileretLambda);

                }



                Console.WriteLine(formler["Plus"](2, 2));       // 4

                Console.WriteLine(formler["Minus"](8, 3));      // 5

                Console.WriteLine(formler["Gange"](3, 3));      // 9

                Console.WriteLine(formler["Divider"](9, 3));    // 3



                int a = 2, b = 2;

                foreach (var formel in formler)

                    Console.WriteLine($"{a} {formel.Key} {b} = {formel.Value(a, b)}");



                /*

                 2 Plus 2 = 4

                 2 Minus 2 = 0

                 2 Gange 2 = 4

                 2 Divider 2 = 1

                */



                // Forudsat at formler er placeret i en tekstfil eller db

                // kan brugeren nu selv tilføje sine egne formler





            }
        }
    }
}
