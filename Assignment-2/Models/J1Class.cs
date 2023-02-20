using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2.Models
{
    public class J1Class
    {
        public int NoofPckgDelivered { get; set; }
        public int NoofObsticals { get; set; }

        public int DeliveryObsticalPoints(J1Class j1Class)
        {
            return (50 * j1Class.NoofPckgDelivered) - (10 * j1Class.NoofObsticals) + 
                ((j1Class.NoofPckgDelivered > j1Class.NoofObsticals) ? 500 : 0);
        }
    }
}