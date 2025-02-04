using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodsMovers.Models
{
    [Table("DeliveryDetails")]
    public class DeliveryDetails
    {
        [Key]
        public int deliveryId { get; set; }

        public string CustomerName { get; set; }

        public long customerPhone { get; set; }

        public string CustomerEmail { get; set; }

        public string pickupAddress { get; set; }

        public string deliveryAddress { get; set; }

        public double avgWeight { get; set; }

        public double avgDistance { get; set; }

        public double charges { get; set; }

        public string deliveryPresonName { get; set; }

        public long deliveryPersonPhone { get; set; }

        public string deliveryPersonEmail { get; set; }

        public string vehicleType { get; set; }

        public string vehicleNo { get; set; }

        public string LicenceNo { get; set; }

        public string deliveryStatus { get; set; }
    }
}