//using Huba_Buba.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Huba_Buba.Data.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descroption { get; set; }
        public string Img { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
