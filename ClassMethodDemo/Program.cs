using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            CustomerManager customerManager = new CustomerManager();

            customer1.Id = 1;
            customer1.Name = "Enes";
            customer1.Surname = "Turkmen";

            customerManager.Add(customer1);
            customerManager.List(customer1);
            customerManager.Delete(customer1);
        }
    }
}
