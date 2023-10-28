 using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 12;
            urun1.StokAdedi = 2;


            Urun urun2 = new Urun();
            urun2.Adi = "armut";
            urun2.Fiyati = 8;
            urun2.StokAdedi = 45;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("-----");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Console.WriteLine("------------------------");

            sepetManager.Ekle2("kapuz","güzeldir",15);
        }
    }
}
