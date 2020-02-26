using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectGame.Data;
using ProjectGame.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectGame.Controllers
{
    public class CatalogController : Controller
    {
        private Db db;

        public CatalogController(Db db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            IList<GameViewModel> games = (from game in db.Games.Include(g => g.Rates)
                                          select new GameViewModel()
                                          {
                                              Title = game.Title,
                                              Description = game.Description,    
                                              Id = game.Id,
                                              Rate =game.Rates.Average(r => r.Rate)

                                          }).ToList();
            return View(games);
        }


    }
}