using System;

namespace SecondLessonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunAdi = "Elma";
            product1.UrunFiyati = 5;
            product1.Stok = 200;

            Product product2 = new Product();
            product2.UrunAdi = "Muz";
            product2.UrunFiyati = 15;
            product2.Stok = 1200;

            Product product3 = new Product();
            product3.UrunAdi = "Kivi";
            product3.UrunFiyati = 8;
            product3.Stok = 200;


            Product[] product = new Product[] {product1,product2,product3 };
           
            foreach (var products in product)
            {
                Console.WriteLine(products.UrunAdi+ ":" +products.UrunFiyati+":"+ products.Stok+":");
            }
            

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(product[i]);
            }

            int c = 0;
            while(c<product.Length)
            {
                Console.WriteLine(product[c]);
            }
            

            

        }

       
    }
}
