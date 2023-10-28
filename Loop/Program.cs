using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "c#";
            string kurs2 = "css";
            string kurs3 = "html";


            string[] kurslar = new string[] { "c#", "css", "html" }; // içine kurs1, kurs2, kurs3 de yazabilirdik.

            for (var i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("--------------------------------------");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
