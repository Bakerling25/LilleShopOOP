using System;
using System.Collections.Generic;
using System.Text;

namespace LilleShopOOP
{
    public abstract class CustomerAutoIncrement
    {
        static int id = 1;
        public virtual int Id()
        {
            
            return id++;
        }
    }
}
