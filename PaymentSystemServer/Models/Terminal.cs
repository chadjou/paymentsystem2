using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSystemServer.Models
{
    public class Terminal
    {
        public int TerminalId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }

    }
}
