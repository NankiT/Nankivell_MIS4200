﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nankivell_MIS4200.Models
{
    public class Orders
    {
        public int orderID { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<OrderDetails> OrderDetails { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int customerID { get; set; }
        public virtual Customers Customers { get; set; }
    }
}