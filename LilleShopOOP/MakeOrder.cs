using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace LilleShopOOP
{
    class MakeOrder
    {
        private List<Customer> customers;
        private List<Item> items;

        public List<Customer> Customers { get { return customers; } set { customers = value; } }
        public List<Item> Items { get { return items; } set { items = value; } }

        public MakeOrder(List<Customer> customers, List<Item> items)
        {
            Customers = customers;
            Items = items;
        }
        public void printOrder()
        {
            foreach (Customer customer in customers)
            {
                customer.Items = items;
                Console.WriteLine("KundeNavn: " + customer.Name + " KundeId: " + customer.CustomerId);
                foreach (Item item in customer.Items)
                {
                    Console.WriteLine("VareID: " + item.ItemId + " VareBeskrivelse: " + item.ItemDiscription + " Pris: " + item.ItemPrice + " kr.");
                }
            }
            
        }
        
    }
}
