using System;

namespace Sorgular
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type safety = Tip güvenliği
            // Do not repeat yourself = Kendini tekrarlama
            // kategoriEtiketi değer tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 57000;
            double faizOrani = 1.40;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 5.50;
            double dolarBugun = 5.50;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış tuşu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış tuşu");
            }
            else
            {
                Console.WriteLine("Değişmedi tuşu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları tuşu");
            }
            else
            {
                Console.WriteLine("Giriş yap tuşu");
            }


            Console.WriteLine(kategoriEtiketi);



        }
    }
}
