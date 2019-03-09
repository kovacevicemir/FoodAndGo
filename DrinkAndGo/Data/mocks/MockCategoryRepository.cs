using DrinkAndGo.Data.interfaces;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                //this will create fake testing data, 2 categories in list
                return new List<Category>
                {
                    new Category {CategoryName = "Alcoholic", Description = "All alcohol drinks"},
                    new Category {CategoryName = "Non-Alcoholic", Description = "All non-alcohol drinks"}

                };
            }
        }
    }
}
