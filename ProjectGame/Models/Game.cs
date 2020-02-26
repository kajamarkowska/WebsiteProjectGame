using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGame.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Href { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
       

        public ICollection<GameRate> Rates { get; set; }
    }
}
