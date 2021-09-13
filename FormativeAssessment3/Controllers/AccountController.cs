using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using FormativeAssessment3.Models;


namespace FormativeAssessment3.Controllers
{
    public class AccountController : Controller
    {
        PRGSAEntities4 db = new PRGSAEntities4();

        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Register(Register registerTable)
        {
           
            if (db.Registers.Any(x => x.Email == registerTable.Email))
            {
                ViewBag.Notification = "This account Exists";
                return View();
            }
            else
            {
                db.Registers.Add(registerTable);
                db.SaveChanges();
                return RedirectToAction("Portfolio", "Home");
            }

        }

        [HttpPost]
        public ActionResult Login()
        {
            ViewBag.Message = "Your portfolio page.";

            return View();
        }

         [HttpGet]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(Register registerTable)
        {

            var checkLogin = db.Registers.Where(x => x.Email.Equals(registerTable.Email)
            && x.Password.Equals(registerTable.Password)).FirstOrDefault();
            if (checkLogin != null)
            {
                ViewBag.Notification = "You are logged in";
                return RedirectToAction("Portfolio", "Home");
            }
            else
            {
                ViewBag.Notification = "Wrong Username or password";


            }
            return View();
            //using (PRGSAEntities4 db = new PRGSAEntities4())
            //{
            //    var logindetails = db.Registers.Where(x => x.Email == registerTable.Email &&
            //    x.Password == registerTable.Password).FirstOrDefault();//use a var keyword to represent a class 
            //    if (logindetails == null)
            //    {
            //        ViewBag.Notification = "Wrong Username or password";
            //        return RedirectToAction("Index","Home");

            //    }
            //    else
            //    {
            //        Session["ID"] = logindetails.ID;
            //        return RedirectToAction("Portfolio", "Home");
            //    }
            //}
        }

       

    }
}


    
        
       
    
