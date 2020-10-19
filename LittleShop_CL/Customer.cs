using System.Collections.Generic;

namespace LilleShopOOP
{
    public class Customer:CustomerAutoIncrement
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string customerEmail;
        private List<Item> items;
        

        public int CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string CustomerEmail
        {
            get
            {
                return customerEmail;
            }
            set
            {
                customerEmail = value;
            }
        }
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
        public Customer(string firstName,string lastName, string email)
        {
            CustomerId = Id();
            FirstName =firstName;
            LastName = lastName;
            CustomerEmail = email;
        }
        public Customer(string firstName,string lastName)
        {
            CustomerId = Id();
            FirstName = firstName;
            LastName = lastName;
        }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public override string ToString()
        {
            return "Kunde ID: " + customerId + " " + FullName();
        }
        public override int Id()
        {
            return base.Id();
        }
        public string DeletedCustomer()
        {
            return FullName() + " er blevet slette";
        }

    }
}
