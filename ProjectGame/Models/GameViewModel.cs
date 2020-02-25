using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGame.Models
{
    public class GameViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Href { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Rate { get; set; }

        public int Id { get; set; }
    }
}
