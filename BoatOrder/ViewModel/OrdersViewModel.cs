using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatOrder.ViewModel
{
    public class OrdersViewModel
    {

      
            public int ID { get; set; }

            public DateTime OrderDate { get; set; }

            public string Items { get; set; }

     
            public DateTime ShipmentDate { get; set; }

      
            public int CustomerID { get; set; }

        

    }
}
