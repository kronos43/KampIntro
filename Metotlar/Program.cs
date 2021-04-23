using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 17;
            product1.Aciklamasi = "Amasya Elması";
            
            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 34;
            product2.Aciklamasi = "Diyarbakır Karpuzu";


            Product[] products = new Product[] {product1, product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklamasi);
                Console.WriteLine("-------------------------");
            }


            Console.WriteLine("----------------Metotlar-----------------");
            //encapsulation
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(product1);
            sepetmanager.Ekle(product2);



            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12, 10);
        }
    }
}


//don't repeat yourself