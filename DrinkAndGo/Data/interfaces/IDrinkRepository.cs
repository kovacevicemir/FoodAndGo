using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.interfaces
{
    public interface IDrinkRepository
    {
        //to get all drinks
        IEnumerable<Drink> Drinks { get; }
        //to get only prefferedDrinks
        IEnumerable<Drink> PreferredDrinks { get;}
        //to get drink by ID
        Drink GetDrinkById(int drinkId);
    }
}
