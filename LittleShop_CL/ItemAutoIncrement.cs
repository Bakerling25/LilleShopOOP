﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LittleShop_CL
{
    public abstract class ItemAutoIncrement
    {
        static int id = 1;
        public virtual int Id()
        {

            return id++;
        }
    }
}
