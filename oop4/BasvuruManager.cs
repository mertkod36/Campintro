using oop4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class BasvuruManager
    {                          //bütün kredilerin referanlarını tutuyor(IKrediManager)
        public void BasvuruYap(IKrediManager krediManager)
        {

            //Basvuran bilgilerini değerlendirme

            krediManager.Hesapla();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
