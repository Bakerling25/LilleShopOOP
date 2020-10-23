using System;
using System.Collections.Generic;
using System.Text;

namespace LittleShop_CL
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
