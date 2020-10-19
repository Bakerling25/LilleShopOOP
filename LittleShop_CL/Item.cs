using LittleShop_CL;
using System;
using System.Collections.Generic;
using System.Text;

namespace LilleShopOOP
{
    public class Item:ItemAutoIncrement
    {
        private int itemsId;
        private string itemName;
        private string itemDiscription;
        private double itemPrice;
        

        public int ItemId
        {
            get
            {
                return itemsId;
            }
            set
            {
                itemsId = value;
            }
        }
        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
        }
        public string ItemDiscription
        {
            get
            {
                return itemDiscription;
            }
            set 
            {
                itemDiscription = value;
            }
        }
        public double ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                itemPrice = value;
            }
        }
        public Item(string name, string description, double price)
        {
            itemsId = Id();
            itemName = name;
            itemDiscription = description;
            itemPrice = RoundPrice(price);
        }
        public override int Id()
        {
            return base.Id();
        }
        public double RoundPrice(double price)
        {
            return Math.Round(price,2);
        }

    }
}
