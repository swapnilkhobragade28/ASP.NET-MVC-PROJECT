using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Web.Mvc;

namespace GoodsMovers.Models
{
    [Table("LoginDetails")]
    public class LoginDetails
    {
            [Key]
            public string email { get; set; }

            public string password { get; set; }

            public string loginType { get; set; }

            public string name { get; set; }

            public string city { get; set; }

            public long phone { get; set; }

            public string vehicleType { get; set; }

            public string vehicleNo { get; set; }

            public string licenceNo { get; set; }

        //public LoginDetails()
        //{
        //    VehicleList = new List<SelectListItem>();
        //}

        //[DisplayName("VehicleType")]
        //public List<SelectListItem> VehicleList { get; set; }

    }
}