// See https://aka.ms/new-console-template for more information







using oop4;
using OOP4;
using System.Collections.Generic;

//IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
//ıhtiyacKrediManager.Hesapla();

//TasitKrediManager tasitKrediManager = new TasitKrediManager();
//tasitKrediManager.Hesapla();

//KonutKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();


IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();

IKrediManager tasitKrediManager = new TasitKrediManager();

IKrediManager konutKrediManager = new KonutKrediManager();


ILoggerService databaseLoggerService = new DataBaseLoggerService();
ILoggerService filebaseLoggerService = new FileBaseLoggerService();


BasvuruManager basvuruManager= new BasvuruManager();
//basvuruManager.BasvuruYap(tasitKrediManager);
//basvuruManager.BasvuruYap(tasitKrediManager,new DataBaseLoggerService());
//basvuruManager.BasvuruYap(tasitKrediManager,databaseLoggerService);
basvuruManager.BasvuruYap(new EsnafKredisiManager(),new SmsLoggerService());


List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,tasitKrediManager };//burada banka çalışanı birden fazla kredinin hesaplanması için sisteme kredileri giriyor........bu kod sayesinde birden fazla kredi aynı anda hesaplanabiliyor.
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
