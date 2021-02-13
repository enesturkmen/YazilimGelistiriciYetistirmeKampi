using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gercek Musteri icin giris

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Enes";
            customer1.Surname = "Turkmen";
            customer1.TcNo = "12345678901";

            //Tuzel musteri icin giris (kodlama.io)

            CorparateCustomer customer2 = new CorparateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorparateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);



        }
    }
}
