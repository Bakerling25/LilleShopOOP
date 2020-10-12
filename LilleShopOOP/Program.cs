using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace LilleShopOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Thomas", "Thomas@", MakeItem());
            MakeOrder.Order(customer);
            Console.WriteLine("Her er den totale pris som der skal betales " + MakeOrder.TotalAmount(customer) + " kr.");
            Console.ReadLine();
        }
        public static List<Item> MakeItem()
        {
            List<Item> items = new List<Item>();
            Item item = new Item("Dette er en beskrivelse af denne vare", 999.95);
            items.Add(item);
            return items;
        }
    }
}
