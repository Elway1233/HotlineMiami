using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Huba_Buba.Data.Interfaces;
using Huba_Buba.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Huba_Buba.Controllers
{
    public class HomeController : Controller
    {

        private IAllGames _game;

        public HomeController(IAllGames game)
        {
            _game = game;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Категории";
            HomeViewModel obj = new HomeViewModel();
            obj.AllGames = _game.Games;
            obj.GameCategory = "Категории";

            return View(obj);
        }
    }
}