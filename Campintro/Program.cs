 using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "css";
            kurs2.Egitmen = "mert";
            kurs2.IzlenmeOrani = 19;


            kurs[] kurslar = new kurs[] { (kurs)kurs1, kurs2 };

            foreach (var kursum in kurslar)
            {
                Console.WriteLine("egitmen: "+kursum.Egitmen + " kurs: " +kursum.KursAdi);
            }









        }
    }
}
