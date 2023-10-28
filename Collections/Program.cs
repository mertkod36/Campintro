using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> isimler1 = new List<string> { "mert", "ela", "ece" };

            Console.WriteLine(isimler1[0]);
            Console.WriteLine(isimler1[1]);
            Console.WriteLine(isimler1[2]);
            isimler1.Add("elif");
            Console.WriteLine(isimler1[3]);



        }
    }
}
