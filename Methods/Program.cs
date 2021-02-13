using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Definition = "Amasya Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Definition = "Diyarbakir Watermelon";

            Product[] products = new Product[] { product1, product2 };

            foreach (var allProduct in products)
            {
                Console.WriteLine(allProduct.Name + " : " + allProduct.Price + " : " + allProduct.Definition);
            }
            Console.WriteLine("-----------METHODS------------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add2("Lemon", "Mersin Lemon", 15, 50);

        }
    }
}
