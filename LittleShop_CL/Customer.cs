using LittleShop_CL;
using System.Collections.Generic;

namespace LittleShop_CL
{
    public class Customer:Person
    {
        private List<Item> items;

        public List<Item> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }
        public Customer(string firstName,string lastName,string email)//:base(firstName,lastName,email)
        {
            FirstName = FirstName;
            LastName = lastName;
            Email = email;
        }
        public Customer(string firstName, string lastName)// : base(firstName, lastName)
        {
            FirstName = FirstName;
            LastName = lastName;
            
        }

        public override string ToString()
        {
            return "Kunde Id " + PersonId + " " + FullName();
        }
        public string DeletedCustomer()
        {
            return FullName() + " er blevet slette";
        }
        

    }
}
