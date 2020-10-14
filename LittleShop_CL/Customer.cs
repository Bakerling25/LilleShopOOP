using System;
using System.Collections.Generic;
using System.Text;

namespace LilleShopOOP
{
     public class Customer
    {
        private int customerId;
        private string name;
        private string customerEmail;
        private List<Item> items;
        

        public int CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string CustomerEmail
        {
            get
            {
                return customerEmail;
            }
            set
            {
                customerEmail = value;
            }
        }
        public List<Item> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }
        public Customer(string name, string email, int id)
        {
            CustomerId = id;
            Name = name;
            CustomerEmail = email;
        }
        public Customer(string name, int id)
        {
            CustomerId = id;
            Name = name;
        }

    }
}
