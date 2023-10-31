using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {

       
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Firstname + musteri.LastName + "Müşteri Eklendi");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Firstname + musteri.Lastname + musteri.Id);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + musteri.Lastname + "Müşteri Silindi");
        }
    }
}
