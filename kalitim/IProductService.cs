using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kalitim;

// interface bir soyut classtır.
// interface newlenemez.
// interfaceler birer anlaşmadır.

public  interface IProductService
{
    void Add();
    void Remove();
    void GetList();
}
