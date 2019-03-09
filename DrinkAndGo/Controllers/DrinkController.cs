using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        //Constructor
        //Getting all dummy data (from: services -> Interfaces - > Mocks)
        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }

        //Returning Dummy data (action name = List, so View name is List,)
        //Controller name = Drink so folder is drink just reminder
        public ViewResult List()
        {
            var drinks = _drinkRepository.Drinks;
            return View(drinks);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}