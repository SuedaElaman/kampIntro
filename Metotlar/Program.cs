using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string productAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";


            string[] meyveler = new string[] {"elma","karpuz"};

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1,product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------");


            }
            Console.WriteLine("----------Metotlar-------");
            //instance -örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("üzüm", "Yeşil Erik", 12,8);






        }
    }
}
