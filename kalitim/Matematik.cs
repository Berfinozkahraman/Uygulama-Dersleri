using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim;

public class Matematik
{
    int sayi_1;
    int sayi_2;
    public Matematik(int sayi1, int sayi2)
    {
        sayi_1 = sayi1;
        sayi_2 = sayi2;
    }

    public void Topla()
    {
        Console.WriteLine(sayi_1+sayi_2);
    }

    public void Cikar()
    {
        Console.WriteLine(sayi_1- sayi_2);
    }


}
