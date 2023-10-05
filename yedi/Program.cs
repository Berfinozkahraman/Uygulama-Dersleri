using System;
using yedi;

MatematikselIslemler islemler = new MatematikselIslemler(); 
islemler.Topla(3, 4);
islemler.Carp(3, 4);
islemler.Bol(3, 4);
islemler.Bol(5, 4);
int cikar = islemler.Cikar(5, 4); 
Console.WriteLine(cikar);
Console.WriteLine(islemler.Cikar(7,8));

