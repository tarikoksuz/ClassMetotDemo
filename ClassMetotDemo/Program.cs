using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.FirtName = "Harrison";
            customer1.LastName = "Ford";
            customer1.TcKimlikNo = "12345678910";
            customer1.Gender = "Erkek";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.FirtName = "Scarlett";
            customer2.LastName = "Johansson";
            customer2.TcKimlikNo = "12345678911";
            customer2.Gender = "Kadın";

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.FirtName = "Charlize";
            customer3.LastName = "Theron";
            customer3.TcKimlikNo = "12345678912";
            customer3.Gender = "Kadın";

            Customer customer4 = new Customer();
            customer4.CustomerId = 4;
            customer4.FirtName = "Tom";
            customer4.LastName = "Cruise";
            customer4.TcKimlikNo = "12345678915";
            customer4.Gender = "Erkek";
            
            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new  Customer[] { customer1, customer2, customer3, customer4 };
            customerManager.Add(customer1);
            customerManager.Delete(customer1);
            customerManager.List(customers);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirtName + " " + customer.LastName + " " + customer.TcKimlikNo + " " + customer.Gender);
            }

            



        }


    }
}
