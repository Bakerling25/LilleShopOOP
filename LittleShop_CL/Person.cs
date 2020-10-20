using LilleShopOOP;
using System.Collections.Generic;

namespace LittleShop_CL
{
    public class Person:PersonAutoIncrement
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string customerEmail;
        


        protected int PersonId
        {
            get
            {
                return personId;
            }
            private set
            {
                personId = value;
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
        public string Email
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
        public Person()
        {
            PersonId = Id();
            
        }
        //public Person()
        //{
        //    PersonId = Id();
            
        //}

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public override string ToString()
        {
            return "Person ID: " + personId + " " + FullName();
        }
        protected override int Id()
        {
            return base.Id();
        }
        

    }
}
