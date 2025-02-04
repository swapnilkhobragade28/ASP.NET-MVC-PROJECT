using GoodsMovers.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsMovers.Controllers
{
    public class GoodsMoversController : Controller
    {

        GoodsMoversContext db=new GoodsMoversContext();
        DAL d=new DAL();

        // GET: GoodsMovers
        //Homepage
        public ActionResult HomePage()
        {
            var data = db.logindetails.ToList();
            return View(data);
        }



        // Customer Signup Page
        public ActionResult SignUpCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUpCustomer(LoginDetails l)
        {
            if(l.email==null || l.name==null || l.city==null || l.phone==null || l.password==null)
            {
                return View();
            }
            else
            {
                db.logindetails.Add(l);
                db.SaveChanges();
                return RedirectToAction("HomePage");
                TempData["AlertMsg"] = "Your account is created successfully !!!";
            }
        }


        // Delivery Person Signup Page
        public ActionResult SignUpDeliveryPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUpDeliveryPerson(LoginDetails l)
        {
            if (l.email == null || l.name == null || l.city == null || l.phone == null || l.password == null || l.vehicleType==null || l.vehicleNo==null || l.licenceNo ==null)
            {
                return View();
            }
            else
            {
                db.logindetails.Add(l);
                db.SaveChanges();
                return RedirectToAction("HomePage");
                TempData["AlertMsg"] = "Your account is created successfully !!!";
            }
        }


        //Log in page
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LoginDetails l)
        {
            string query = $"select * from LoginDetails where email='{l.email}' and password='{l.password}'";
            SqlDataReader rdr = d.GetSqlDataReader(query);

            if (rdr.Read())
            {
                TempData["userEmail"] = l.email;
                return View("pass");
            }
            else
            {
                TempData["alertMessage"] = "Username or Password is wrong !!!";
                return View();
            }
        }

        public ActionResult pass()
        {
            return View();
        }

    }
}