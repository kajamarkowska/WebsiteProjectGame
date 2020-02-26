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
    public class GameController : Controller
    {
        private Db db;

        public GameController (Db db)
        {
            this.db = db;
        }

        public IActionResult Play(int id)
        {
            Game game = (from g in db.Games.Include(g => g.Rates)
                         where g.Id == id
                         select g).FirstOrDefault();     
            
            if(game != null)
            {
                return View(new GameViewModel()
                {
                    Id = game.Id,
                    Href = game.Href, 
                    Title= game.Title,
                    Width= game.Width,
                    Height= game.Height,
                    Rate =game.Rates.Count>0? game.Rates.Average(r => r.Rate):0,
                });
            } 
            return Redirect("/Home/Index");
        }
        public IActionResult Rate(int gameId, int rate)
        {
            Game game = db.Games.Include(g => g.Rates).FirstOrDefault(g => g.Id == gameId);
                if (game != null)
            {
                game.Rates.Add(new GameRate()
                {
                    Rate = rate
                }) ;
                db.SaveChanges();
            }
            return View();
        }
    }
}