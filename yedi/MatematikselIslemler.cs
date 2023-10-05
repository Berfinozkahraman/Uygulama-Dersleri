using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// public her yerden erişim demek
// genelde classlar public olarak yazılır
namespace yedi;

internal class MatematikselIslemler // bu projenin içinden erişim sağlar
{
    // f(x,y) = x + y
    public void Topla (int sayi1, int sayi2)
    {
        Console.WriteLine(sayi1 + sayi2);
    }

    public void Carp (int sayi1, int sayi2)
    {
        Console.WriteLine(sayi1 * sayi2);
    }

    public void Bol (int sayi1, int sayi2) // void değer döndürmez
    {
        Console.WriteLine(sayi1 / sayi2);
    }

    public int Cikar (int sayi1, int sayi2) // return değer döndürür
    {
        //  web arayüzü, mobil, consol kullanılabilir
        return(sayi1 - sayi2);
    }




}
