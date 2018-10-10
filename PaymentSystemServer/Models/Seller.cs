using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSystemServer.Models
{
    public class Seller
    {
        public int SellerId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public List<Terminal> Terminals { get; set; }
    }
}
