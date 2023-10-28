using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 20;
            product1.ProductName = "koltuk";
            product1.UnitPrice = 300;
            product1.UnitInStock = 40;

            Product product2 = new Product { Id = 2, CategoryId = 6, UnitInStock = 8, ProductName = "şilgi", UnitPrice = 25 };

            //PascalCase    //camelCase
            //case sensitive
            //Stack                         //Heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine("-----------------------------------");
            productManager.Update(product2);
        }
    }
}
