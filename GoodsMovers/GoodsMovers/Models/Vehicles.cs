using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsMovers.Models
{
    public class Vehicles
    {
        public Vehicles()
        {
            VehicleList = new List<SelectListItem>();
        }

            [DisplayName("VehicleType")]
            public List<SelectListItem> VehicleList{ get; set;}

        

    }
}