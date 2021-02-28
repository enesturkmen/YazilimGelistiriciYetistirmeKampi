using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            CustomerManager customerManager = new CustomerManager();

            customer1.Id = 1;
            customer1.Name = "Enes";
            customer1.Surname = "Turkmen";

            customer2.Id = 2;
            customer2.Name = "Mikail";
            customer2.Surname = "Kaya";

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (var allCustomers in customers)
            {
                Console.WriteLine(allCustomers.Id + " " + allCustomers.Name + " "+ allCustomers.Surname);
            }

            customerManager.Add(customer1);
            customerManager.List(customer1);
            customerManager.Delete(customer1);
        }
    }
}
