﻿// See https://aka.ms/new-console-template for more information



using System.Collections.Generic;

//string[] isimler = new string[] {"ali","veli","ayşe","fatma" };
//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);
//Console.WriteLine(  "--------------------------------");

//isimler = new string[5];
//isimler[ 4] = "tarkan";
//Console.WriteLine(isimler[4]);
//Console.WriteLine(isimler[0]);

//toplu comment alma ctrl + k  ctrl +c ile yapılır. geri almak ctrl + k  ctrl + u ile

List<string> isimler2 = new List<string> { "ali", "veli", "ayşe", "fatma" };

Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);

isimler2.Add("mertcan");

Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);