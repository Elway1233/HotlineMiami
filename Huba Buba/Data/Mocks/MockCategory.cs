using Huba_Buba.Data.Interfaces;
using Huba_Buba.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Huba_Buba.Data.Mocks
{
    public class MockCategory : IGamesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Hotline Miami"},
                    new Category{CategoryName = "Игровой процесс"},
                    new Category{CategoryName = "Разработка"},
                    new Category{CategoryName = "Hotline Miami 2: Wrong Number"},
                    new Category{CategoryName = "Музыка"},
                    new Category{CategoryName = "Отзывы"},
                    new Category{CategoryName = "Интересные факты"},

                };
            }
        }
    }
}
