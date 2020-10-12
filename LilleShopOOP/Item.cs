﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LilleShopOOP
{
    class Item
    {
        private int itemsId;
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
        public Item(int id, string description, double price)
        {
            itemsId = id;
            itemDiscription = description;
            itemPrice = price;
        }
    }
}
