using Huba_Buba.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Huba_Buba.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Game> AllGames { get; set; }

        public string GameCategory { get; set; }
    }
}
