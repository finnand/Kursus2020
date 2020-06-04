using System;
using System.Collections.Generic;

namespace M751_Samlinger_simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(4);
            lst.Add(7);
            lst.Add(2);

            foreach (var item in lst)
            {
                Console.WriteLine(value: item);
            }


            Stack<DateTime> stk = new Stack<DateTime>();
            stk.Push(new DateTime(2017, 10, 23));
            stk.Push(new DateTime(2020, 7, 8));
            stk.Push(new DateTime(2023, 2, 25));

            foreach (var item in stk)
            {
                Console.WriteLine(value: item);
            }

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Abe");
            dic.Add(2, "Kat");
            dic.Add(3, "Hund");

            var p = dic[2];
            Console.WriteLine(value: p);



        }
    }
}
