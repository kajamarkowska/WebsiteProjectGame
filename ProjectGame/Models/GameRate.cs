using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGame.Models
{
    public class GameRate
    {
        public int GameId { get; set; }
        public int Rate { get; set; }
        public int Id { get; set; }
        public Game Game { get; set; }
    }
}
