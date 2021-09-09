using Huba_Buba.Data.Interfaces;
using Huba_Buba.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Huba_Buba.Data.Repository
{
    public class GameRepository : IAllGames
    {
        private readonly AppDBContent appDBContent;

        public GameRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public IEnumerable<Game> Games => appDBContent.Games.Include(c => c.Category);

        public Game GetObjectGame(int gameId) => appDBContent.Games.FirstOrDefault(c => c.Id == gameId);
    }
}
