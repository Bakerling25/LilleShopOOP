using System;
using System.Collections.Generic;
using System.Text;

namespace LilleShopOOP
{
    public class Item
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
        public Item(string name, string description, double price, int id)
        {
            itemsId = id;
            itemName = name;
            itemDiscription = description;
            itemPrice = price;
        }
        
    }
}
