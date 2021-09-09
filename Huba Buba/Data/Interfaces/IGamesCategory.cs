using Huba_Buba.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Huba_Buba.Data.Interfaces
{
    public interface IGamesCategory
    {

        IEnumerable<Category> AllCategories { get; }

    }
}
