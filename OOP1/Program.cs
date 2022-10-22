using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product {
                ID = 1,
                CategoryID = 2,//mobilya kategorisi
                ProductName = "Masa",
                Price = 850,
                Stock=12
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);








        }
    }
}
