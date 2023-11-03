// See https://aka.ms/new-console-template for more information


using OOP2;

Product product1= new Product();
product1.Id = 1;
product1.CategoryId = 4;
product1.ProductName ="kalem";
product1.UnitPrice = 24;
product1.UnitInStock =82;


Product product2= new Product { Id=2,CategoryId=9,ProductName="tablet",UnitPrice=3000,UnitInStock=44}; 


//PascalCase   //camelCase
//case sensitive
ProductManager productManager = new ProductManager();
productManager.Add(product1);
Console.WriteLine(  product1.ProductName);

Console.WriteLine("---------------------");

int toplamSonuc=productManager.Topla(2,3);
Console.WriteLine(  "----");

productManager.Topla2(2, 3);