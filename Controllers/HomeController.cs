using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day1B.Repositories;
using Microsoft.AspNetCore.Mvc;
using Day1B.Models;

namespace Day1B.Controllers
{
    public class HomeController : Controller
    {
        public BookRepository bookRepository;

        public HomeController() {

            bookRepository = new BookRepository();
        }

        public ViewResult Index()
        {
            List<Book> allbook = bookRepository.GetAllBook();
            return View(allbook);
        }

        public ViewResult create() {
            return View();
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
