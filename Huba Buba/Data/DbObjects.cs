using Huba_Buba.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Huba_Buba.Data
{
    public class DbObjects
    {

        public static void Initial(AppDBContent content)
        {

            if (content.Categorys.Any())
            {
                content.Categorys.AddRange(Categories.Select(c => c.Value));
            }


            if (content.Games.Any())
            {
                content.Games.AddRange(GameModel.Select(c => c.Value));
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                    new Category { CategoryName = "Hotline Miami", Description = "Hotline Miami" },
                    };

                    category = new Dictionary<string, Category>();

                    foreach (Category element in list)
                    {
                        category.Add(element.CategoryName, element);
                    }

                }
                return category;
            }
        }


        private static Dictionary<string, Game> gameModel;

        public static Dictionary<string, Game> GameModel
        {
            get
            {
                if (gameModel == null)
                {
                    var list = new Game[]
                    {

                         new Game
                    {
                        Name = "Hotline Miami",
                        Img = "/img/1.jpg",
                        Category = Categories["Hotline Miami"]
                    },
                            new Game
                    {
                        Name = "Игровой процесс",
                        Img = "/img/4.jpg",
                        Category = Categories["Игровой процесс"]
                    },
                               new Game
                    {
                        Name = "Разработка",
                        Img = "/img/7.jpg",
                        Category = Categories["Разработка"]
                    },
                                  new Game
                    {
                        Name = "Hotline Miami 2: Wrong Number",
                        Img = "/img/9.jpg",
                        Category = Categories["Hotline Miami 2: Wrong Number"]
                    },
                                  new Game
                    {
                        Name = "Музыка",
                        Descroption = "",
                        Img = "/img/20.jpg",
                        Category = Categories["Музыка"]
                    },
                                  new Game
                    {
                        Name = "Отзывы",
                        Img = "/img/21.jpg",
                        Category = Categories["Отзывы"]
                    },
                                  new Game
                    {
                        Name = "Интересные факты",
                        Img = "/img/23.jpg",
                        Category = Categories["Интересные факты"]
                    }


                    };

                    gameModel = new Dictionary<string, Game>();

                    foreach (Game element in list)
                    {
                        gameModel.Add(element.Name, element);
                    }

                }

                return gameModel;
            }
        }
    }
}
