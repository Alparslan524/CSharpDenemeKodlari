using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi!\n"+"Ürün Adı: "+product.ProductName+"\n" +
                "Ürün Fiyatı: "+product.Price+"\nStok Adedi: "+product.Stock);
        }
    
    
    
    }
}
