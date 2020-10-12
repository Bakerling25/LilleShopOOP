using System;
using System.Collections.Generic;
using System.Text;

namespace LilleShopOOP
{
    class MakeOrder
    {
        public static void Order(Customer customer)
        {
            
            foreach(Item item in customer.Items)
            {
                Console.WriteLine("KundeNavn: " + customer.Name + "\nVareId: " + item.ItemId + "\nVarebeskrivelse: " + item.ItemDiscription + "\nPris: " + item.ItemPrice + " kr.");
            }
            
        }
        public static double TotalAmount(Customer customer) 
        {
            double totalAmount = 0;
            foreach (var item in customer.Items)
            {
                totalAmount += item.ItemPrice;
            }
            return totalAmount;
        }
    }
}
