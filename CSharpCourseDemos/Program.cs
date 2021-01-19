using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Engin";
            customer1.Surname = "Ersoy";
            customer1.Id = "123456";
            customer1.CustomerId = "001";
            customer1.AccountType = "EURO";
            customer1.Balance = 12249;

            Customer customer2 = new Customer();
            customer2.Name = "Ali Nurhan";
            customer2.Surname = "Özen";
            customer2.Id = "234567";
            customer2.CustomerId = "002";
            customer2.AccountType = "USD";
            customer2.Balance = 17899;

            Customer customer3 = new Customer();
            customer3.Name = "Susan";
            customer3.Surname = "Kreeft";
            customer3.Id = "345678";
            customer3.CustomerId = "003";
            customer3.AccountType = "EURO";
            customer3.Balance = 16989;

            Customer customer4 = new Customer();
            customer4.Name = "Emel";
            customer4.Surname = "Çalışkan";
            customer4.Id = "456789";
            customer4.CustomerId = "004";
            customer4.AccountType = "GBP";
            customer4.Balance = 9880;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };


            CustomerManager customerManager = new CustomerManager();
                      
            customerManager.List(customers);
            customerManager.Add(customer4);
            customerManager.Clear(customer4);
           
        }
    }
}
