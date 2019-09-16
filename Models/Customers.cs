using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nankivell_MIS4200.Models
{
    public class Customers
    {
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public ICollection<Orders> Orders { get; set; }

    }
}