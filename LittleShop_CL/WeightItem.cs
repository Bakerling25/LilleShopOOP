using System;
using System.Collections.Generic;
using System.Text;
using LilleShopOOP;
using LittleShop_CL;

namespace LittleShop_CL
{
    class WeightItem:Item
    {
        private double wAmount;
        public double Wamount { get { return wAmount; } set { wAmount = value; } }
        public WeightItem(string wName,string wDescription,float wPrice,double wAmount):base(wName,wDescription,wPrice)
        {
            ItemName = wName;
            ItemDiscription = wDescription;
            ItemPrice = wPrice;
            Wamount = wAmount;
        }
    }
}
