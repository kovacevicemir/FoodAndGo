using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.interfaces
{
    interface ICategoryRepository
    {
        //WHY ONLY GET; ?
        IEnumerable<Category> Categories { get; }
        //Category GetCategoryById(int categoryID);
    }
}
