using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + product.Name);

        }

        public void Add2(string productName, string definition, double price, int stock) // Hatali Kullanim bu sekilde parametreli kullanmak .
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + productName);
        }
        public void Remove(Product product) { 
            
            Console.WriteLine("Urun basariyla kaldirildi!");
        
        }
    }
}
