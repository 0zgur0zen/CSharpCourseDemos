﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
    class CustomerManager
    {
        public void List(Customer[] customers)
        {
            Console.WriteLine($"Müşteri Listesi:");
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Müşteri Adı:{customer.Name}\nMüşteri Soyadı:{customer.Surname}\nMüşteri Kimlik No:{customer.Id}\n" +
                    $"Müşteri No:{customer.CustomerId}\nHesap Türü:{customer.AccountType}\nHesap Bakiyesi:{customer.Balance}\n********************");
            }
        }
        public void Add(Customer customer)
        {
            Console.WriteLine($"+++++++++++++\nYeni Bir Müşteri Eklendi\nMüşteri Bilgileri\nAdı:{customer.Name}\n" +
                $"Soyadı:{customer.Surname}\nMüşteri Id No:{customer.Id}\nMüşteri No:{customer.CustomerId}\n" +
                $"Hesap Türü:{customer.AccountType}\nHesap Bakiyesi:{customer.Balance}\n**********************");
        }
        public void Clear(Customer customer)
        {
            Console.WriteLine($"'{customer.CustomerId}'Müşteri Numaralı Kişi Silindi");
        }
       
    }
}
