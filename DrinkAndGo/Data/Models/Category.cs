using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //This will create one-to-many relation ship
        //Category have many drinks, but drink got only one category
        public List<Drink> Drinks { get; set; }
    }
}
