using System;
using System.Reflection.Emit;
using System.Runtime;

namespace M904_Brug_af_automatiske_egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Finn";
            p.Efternavn = "Bo";
            Console.WriteLine(p.FuldtNavn()); 

            p.Efternavn = "Andersen";
            Console.WriteLine(p.FuldtNavn());


        }

        class Person
        {
            public string Fornavn { get; set; }

            private string efternavn;

            public string Efternavn
            {
                get { return efternavn; }
                set
                {
                    if (value.Length < 3)
                        efternavn = "";
                    else
                        efternavn = value;

                }
            }

            public string FuldtNavn()
            {
                return Fornavn + " " + Efternavn;
            }

            //private string fuldtNavn;

            //public string FuldtNavn
            //{
            //    get {
            //        fuldtNavn = this.Fornavn + " " + this.Efternavn;
            //        return fuldtNavn; 
            //    }
            //    set { fuldtNavn = value; }
            //}


        }
    }
}
