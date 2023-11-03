using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine( product.ProductName+"eklendi");

        }

        public void upDate(Product product)
        {
            Console.WriteLine(product.ProductName+"güncellendi");

        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(  sayi1+sayi2);

        }


    }
}
