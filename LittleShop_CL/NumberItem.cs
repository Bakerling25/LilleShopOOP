using System;

namespace LittleShop_CL
{
    class NumberItem:Item,IComparable<NumberItem>
    {
        private int nAmount;
        public int NAmount { get { return nAmount; } set { nAmount = value; } }

        public NumberItem(string nName,string nDescription,double nPrice,int nAmount):base(nName,nDescription,nPrice)
        {
            ItemName = nName;
            ItemDiscription = nDescription;
            ItemPrice = nPrice;
            NAmount = nAmount;
        }
        public int CompareTo(NumberItem numberItem)
        {
            return 1;//placeholder
        }
    }
}
