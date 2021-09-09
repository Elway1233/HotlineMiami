using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Huba_Buba.Data.Interfaces;
using Huba_Buba.Data.Models;
using Huba_Buba.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Huba_Buba.Controllers
{
    public class GamesController : Controller
    {

        private readonly IAllGames _allGames;
        private readonly IGamesCategory _allCategories;

        public GamesController(IAllGames allGames, IGamesCategory gamesCategory)
        {
            _allGames = allGames;
            _allCategories = gamesCategory;
        }

        [Route("Games/List")]
        [Route("Games/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Game> games = null;
            string gameCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                games = _allGames.Games.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("Hotline Miami",category,StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.CategoryName.Equals("Hotline Miami)).OrderBy(i => i.Id);
                }
                else if(string.Equals("Игровой процесс", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.CategoryName.Equals("Игровой процесс)).OrderBy(i => i.Id);
                }
                else if (string.Equals("Разработка", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.CategoryName.Equals("Разработка")).OrderBy(i => i.Id);
                }
                else if (string.Equals("Hotline Miami 2: Wrong Number", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.CategoryName.Equals("Hotline Miami 2: Wrong Number")).OrderBy(i => i.Id);
                }
                else if (string.Equals("Музыка", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.CategoryName.Equals("Музыка")).OrderBy(i => i.Id);
                }
                else if (string.Equals("Отзывы", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.CategoryName.Equals("Отзывы")).OrderBy(i => i.Id);
                }
                else if (string.Equals("Интересные факты", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.CategoryName.Equals("Интересные факты")).OrderBy(i => i.Id);
                }

                gameCategory = _category;

            }


            ViewBag.Title = "Hotline Miami";
            var gameObj = new GameListViewModel
            {
                AllGames = games,
                GameCategory = gameCategory
            };

            return View(gameObj);
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}