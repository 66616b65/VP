using System;
using System.Collections.Generic;
using OOPExample;

namespace ExampleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Figure>();
            list.Add(new Round("Кружок", 2));
            list.Add(new Quadrate("Квадратик", 4));

            foreach(var i in list)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
