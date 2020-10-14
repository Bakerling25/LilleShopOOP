using System;
using System.Collections.Generic;
using System.Text;

namespace LilleShopOOP
{
    public class AutoIncrement
    {
        int id = 1;
        public int Id()
        {
            
            return id++;
        }
    }
}
