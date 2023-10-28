using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 12;
            int sayi2 = 10;

            sayi1 = sayi2;
            Console.WriteLine(sayi1);
            Console.WriteLine("---------------");
            Console.WriteLine(sayi2);

            Console.WriteLine("------------------------------------");

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 4, 6, 8 };

            sayilar1 = sayilar2;
            sayilar2[0] = 99;

            Console.WriteLine(sayilar1[0]);
            Console.WriteLine("---");
            Console.WriteLine(sayilar2[0]);
            Console.WriteLine("---");
            Console.WriteLine(sayilar2[1]);
            Console.WriteLine("---");
            Console.WriteLine(sayilar1[1]);




        }
    }
}
