using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace LilleShopOOP
{
    public class MakeOrder
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
        public string GetOrder()
        {
            string tempCust = "";
            foreach (Customer customer in customers)
            {
                tempCust = "Kunde email: " + customer.CustomerEmail;
                return tempCust;
            }
            return tempCust;
        }
        
    }
}
