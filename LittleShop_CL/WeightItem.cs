using System;

namespace LittleShop_CL
{
    public class WeightItem:Item,IComparable<WeightItem>
    {
        private double wAmount;
        public double Wamount { get { return wAmount ; } set { wAmount = value; } }
        public WeightItem(string wName,string wDescription,float wPrice,double wAmount):base(wName,wDescription,wPrice)
        {
            ItemName = wName;
            ItemDiscription = wDescription;
            ItemPrice = wPrice;
            Wamount = wAmount;
        }
        public int CompareTo(WeightItem weightItem)
        {
            return 1; // PlaceHolder
        }
    }
}
