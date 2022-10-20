using System;

namespace CSharpDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            SepetManager sepetManager = new SepetManager();
            Product product1= new Product();
            product1.productName = "Armut";
            product1.productPrice = 5;
            product1.productComment = "Armutun iyisini ayılar yermiş";

            Product product2 = new Product();
            product2.productName = "Kavun";
            product2.productPrice = 3;
            product2.productComment = "En sevdiğim meyve";

            Product[] products = new Product[] {product1,product2};
            
            foreach (Product fproduct in products)
            {
                Console.WriteLine("Urun Adi: "+fproduct.productName);
                Console.WriteLine("Urun Fiyati: " + fproduct.productPrice);
                Console.WriteLine("Urun Açiklamasi: " + fproduct.productComment);
                sepetManager.Ekle(fproduct);
                Console.WriteLine("*******************");
            }
        
        }
    }
}
