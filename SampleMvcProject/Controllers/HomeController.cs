using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public string PostUsingParameter(string firstname, string lastname, string email, string address, string address2, string city, string zip)
        {
            string details = "User Registered Successfully!! You details are First Name: " + firstname + ", Last Name: " + lastname + ", Email: " + email + ", Address: " + address + ", Address2: " + address2 + ", City: " + city + ", Zip: " + zip; 
            return details;
        }
    }
}