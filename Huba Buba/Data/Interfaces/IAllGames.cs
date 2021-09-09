using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Huba_Buba.Data.Models;

namespace Huba_Buba.Data.Interfaces
{
    public interface IAllGames
    {

        IEnumerable<Game> Games { get;}

        Game GetObjectGame(int gameId);

    }
}
