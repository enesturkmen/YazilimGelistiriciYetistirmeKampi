﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Entity
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " guncellendi");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " deleted.");
            
        }
        //CRUD  Create   Read   Update   Delete
        //Urunle ilgili operasyonlar Manager sinifinda olur
    }
}
