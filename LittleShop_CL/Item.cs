using LittleShop_CL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LilleShopOOP
{
    public abstract class Item:ItemAutoIncrement,IComparable<Item>//bare et forsøg
    {
        private int itemsId;
        private int numberOfItems;
        private string itemName;
        private string itemDiscription;
        private double itemPrice;
        

        protected int ItemId
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
        protected int NumberOfItems
        {
            get 
            {
                return numberOfItems;
            }
            set
            {
                numberOfItems = value;
            }
        }
        protected string ItemName
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
        protected string ItemDiscription
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
        protected double ItemPrice
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
        protected Item(string name, string description, double price)
        {
            itemsId = Id();
            itemPrice = RoundPrice(price);
        }
        protected override int Id()
        {
            return base.Id();
        }
        protected double RoundPrice(double price)
        {
            return Math.Round(price,2);
        }
        public int CompareTo(Item item)
        {
            return 1;//mangler at skrive kode her
        }

    }
}
