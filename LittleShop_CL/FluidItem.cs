using LilleShopOOP;

namespace LittleShop_CL
{
    public class FluidItem : Item
    {
        private float fAmount;
        public float Famount
        {
            get
            {
                return fAmount;
            }
            set
            {
                fAmount = value;
            }
        }
        //public FluidItem(string fItemName, string fDescription, double fPrice) : base(fItemName, fDescription, fPrice) {  }


        public FluidItem(string fItemName, string fDescription, double fPrice, float fAmount) : base(fItemName, fDescription, fPrice) 
        {
            Famount = fAmount;
            ItemName = fItemName;
            ItemDiscription = fDescription;
            ItemPrice = fPrice;
        }


        public override string ToString()
        {
            return "vare nr:" + Famount + ItemName;
        }
    }
}
