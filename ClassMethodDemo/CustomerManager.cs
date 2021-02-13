using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added: " + customer.Id + ", " + customer.Name + ", " + customer.Surname);
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Customer listed: " + customer.Id + ", " + customer.Name + ", " + customer.Surname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted: " + customer.Id + ", " + customer.Name + ", " + customer.Surname);
        }
    }
}
