using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoodsMovers.Models
{
    public class GoodsMoversContext:DbContext
    {
        public DbSet<LoginDetails> logindetails { get; set; }

        public DbSet<DeliveryDetails> deliverydetails { get; set; }
    }
}