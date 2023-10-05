using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim;

public class ProductService : IProductService
{
    
        public void Add()
        {
            Console.WriteLine("Ürün eklendi.");
        }

        public void GetList()
        {
            Console.WriteLine("Ürünler listelendi.");
        }

        public void Remove()
        {
            Console.WriteLine("Ürünler silindi.");
        }
    
}
