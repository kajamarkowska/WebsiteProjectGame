using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectGame.Data;
using ProjectGame.Models;

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
            IList<GameViewModel> games = (from game in db.Games
                                          select new GameViewModel()
                                          {
                                              Title = game.Title,
                                              Description = game.Description,
                                              Rate = game.Rate
                                          }).ToList();
            return View(games);
        }


    }
}