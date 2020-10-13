using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace LilleShopOOP
{
    class Shop
    {
        

        public void Kør()
        {
            List<Customer> customers = new List<Customer>();
            List<Item> items = new List<Item>();
            AutoIncrement increment = new AutoIncrement();
            int optionDecider;
            do
            {
                Console.WriteLine("1)  Ny Kunde \n2)  Ny Vare \n3)  Udskriv Order\n4)  Exit");
                optionDecider = int.Parse(Console.ReadLine());
                switch (optionDecider)
                {
                    case 1:
                         customers.Add(MakeCustomer(increment.Id()));
                        break;
                    case 2:
                        items.Add(MakeItem(increment.Id()));
                        break;
                    case 3:
                        MakeOrder makeOrder = new MakeOrder(customers, items);
                        makeOrder.printOrder();
                        break;
                    default:
                        break;
                }
            } while (Exit(optionDecider)); 
        }
        public static Customer MakeCustomer(int increment)
        {

            Customer NewCustomer = new Customer(CustomerName(), CustomerEmail(), increment);
            return NewCustomer;
        }
        public static Item MakeItem(int increment)
        {
            Item item = new Item(ItemName(),ItemDiscription(), Price(), increment);
            return item;
        }
        public static string CustomerName()
        {
            Console.WriteLine("Tilføj Navnet På Kunden");
            string Name = Console.ReadLine();
            return Name;
        }
        public static string CustomerEmail()
        {
            string Email = "Kunde@Email ";
            return Email;
        }
        public static double Price()
        {
            double Price;
            double seed;
            int temp;
            Random random = new Random();
            seed = random.NextDouble();
            temp = random.Next(100, 9999);
            return Price =  seed * (double)temp;
        }
        public static string ItemDiscription()
        {
            Console.WriteLine("Tilføj Beskrivelse På Produktet");
            string ItemDisc = Console.ReadLine();
            return ItemDisc;
        }
        public static string ItemName()
        {
            Console.WriteLine("Vare Navn");
            string itemName = Console.ReadLine();
            return itemName;
        }
        public static bool Exit(int decider)
        {
            if (decider != 4)
            {
                return true;
            }
            return false;
        }
    }
}
