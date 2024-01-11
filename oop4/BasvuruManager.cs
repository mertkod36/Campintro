﻿using oop4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class BasvuruManager
    {                          //bütün kredilerin referanlarını tutuyor(IKrediManager)
        //methot enjection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {

            //Basvuran bilgilerini değerlendirme

            krediManager.Hesapla();
            loggerService.Log();

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