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
            Game game = (from g in db.Games
                         where g.Id == id
                         select g).Include(g => g.Rates).FirstOrDefault();     
            
            if(game != null)
            {
                return View(new GameViewModel()
                {
                    Href = game.Href, 
                    Title= game.Title,
                    Width= game.Width,
                    Height= game.Height,
                });
            } 
            return Redirect("/Home/Index");
        }
    }
}