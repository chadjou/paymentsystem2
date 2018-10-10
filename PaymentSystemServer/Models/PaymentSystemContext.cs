using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSystemServer.Models
{
    public class PaymentSystemContext : DbContext
    {

        public PaymentSystemContext(DbContextOptions<PaymentSystemContext> options) : base(options)
        { }

        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
    }
}
