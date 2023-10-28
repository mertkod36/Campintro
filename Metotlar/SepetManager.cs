using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi: "+urun.Adi);
        }

        public void Ekle2(string urunadi,string urunaciklamasi,int fiyati)
        {
            Console.WriteLine("sepete eklendi2: " + urunadi);
        }
    }
}
