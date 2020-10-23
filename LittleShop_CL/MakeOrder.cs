using System.Collections.Generic;

namespace LittleShop_CL
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
        public MakeOrder()
        {

        }
        //public Customer GetOrder()
        //{

        //}

    }
}
