using System;
using System.Collections.Generic;
using System.Text;

namespace LilleShopOOP
{
    public abstract class PersonAutoIncrement
    {
        static int id = 1;
        protected virtual int Id()
        {
            
            return id++;
        }
    }
}
