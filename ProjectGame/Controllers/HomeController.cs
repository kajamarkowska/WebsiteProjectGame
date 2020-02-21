using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectGame.Data;

namespace ProjectGame.Controllers
{
    public class HomeController : Controller
    {
        private Db db;

        public HomeController (Db db) 
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}