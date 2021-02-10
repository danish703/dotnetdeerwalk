using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Day1B.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public String Myfunc(int? id,string name) {
            return $"id={id} and name={name}";
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult Contactus()
        {
            return View();
        }
    }
}
