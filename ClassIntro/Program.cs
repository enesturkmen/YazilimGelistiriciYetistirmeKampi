using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string adi = "Enes";
            int yas = 23;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kenan Varis";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
            */

            Product urun1 = new Product();
            urun1.UrunAdi = "Laptop";
            urun1.UrunAdedi = 100;
            urun1.UrunKategori = "Elektronik";

            Product urun2 = new Product();
            urun2.UrunAdi = "Masa";
            urun2.UrunAdedi = 500;
            urun2.UrunKategori = "Mobilya";

            Product urun3 = new Product();
            urun3.UrunAdi = "Tirmik";
            urun3.UrunAdedi = 50;
            urun3.UrunKategori = "Bahce";

            Product[] products = new Product[] { urun1, urun2, urun3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].UrunKategori + " : " + products[i].UrunAdi);
            }
            Console.WriteLine("------------");
            foreach (var product in products)
            {
                Console.WriteLine(product.UrunKategori + " : " + product.UrunAdi);
            }
            Console.WriteLine("------------");
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine(products[j].UrunKategori + " : " + products[j].UrunAdi);
                j++;
            }
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    class Product
    {
        public string UrunAdi { get; set; }
        public int UrunAdedi { get; set; }
        public string UrunKategori { get; set; }
    }
}
