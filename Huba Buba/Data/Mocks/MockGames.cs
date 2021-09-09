using Huba_Buba.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Huba_Buba.Data.Models;

namespace Huba_Buba.Data.Mocks
{
    public class MockGames : IAllGames
    {
        private readonly IGamesCategory _categoryGames = new MockCategory();

        public IEnumerable<Game> Games
        {
            get
            {
                return new List<Game>
                {
                    new Game
                    {
                        Name = "Hotline Miami",
                        Descroption = "(с англ. — «Горячая линия Майами») — компьютерная игра в жанре 2D Top-Down action, которую" +
             "разработали Юнатан Сёдерстрём и Деннис Ведин, ранее работавшие вместе над игрой Keyboard Drumset Fucking" +
             "Werewolf. Издателем является Devolver Digital. Выпущена 23 октября 2012 года для Windows посредством сервиса" +
             "Steam. Особенностями игры являются вид сверху, элементы стелса, чрезвычайная жестокость, а также" +
             "сюрреалистичный сюжет и аутентичный саундтрек. При работе над исполнением игры разработчики вдохновлялись культурой" +
             "восьмидесятых годов. Также большим источником вдохновения служил фильм «Драйв» — имя Николаса Виндинга Рефна" +
             "упомянуто в отдельной графе в титрах.",
                        Img = "/img/1.jpg",
                        Category = _categoryGames.AllCategories.First()
                    }
                };
            }
        }

        public Game GetObjectGame(int gameId)
        {
            throw new NotImplementedException();
        }
    }
}
