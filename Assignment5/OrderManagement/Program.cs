﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
        class Program
        {
            static void Main(string[] args)
            {
                OrderService a = new OrderService();
                Func func=new Func(a);  
            }
        }
        
      
    

}
