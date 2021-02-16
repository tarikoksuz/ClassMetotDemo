using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirtName + " " + customer.LastName + " " + customer.TcKimlikNo + " " + customer.Gender + " " + "Eklendi");
        }

        public void Delete(Customer customer) 
        {
            Console.WriteLine(customer.FirtName + " " + customer.LastName + " " + customer.TcKimlikNo + " " + customer.Gender + " " + "Silindi");
        }

        public void List(Customer[] customers)
        {
            
        }
    }
}
