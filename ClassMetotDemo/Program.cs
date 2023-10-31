// See https://aka.ms/new-console-template for more information


using ClassMetotDemo;

Musteri musteri1 = new Musteri();
musteri1.FirstName ="ali" ;
musteri1.Lastname ="tas";
musteri1.Id = 1 ;

Musteri musteri2 = new Musteri();
musteri2.FirstName = "ayşe";
musteri2.Lastname = "ileri";
musteri2.Id = 2;


Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

foreach (var Musteri in musteriler)
{
    Console.WriteLine(musteri.Id + " ");
    Console.WriteLine(musteri.Firstname + musteri.Lastname);
    
}

Console.WriteLine("Müşteri Ekle");
musteriManager.Add(musteri1);
musteriManager.Add(musteri2);
Console.WriteLine();









