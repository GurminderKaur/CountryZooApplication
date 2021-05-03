using CountryZooApplication.Models;
using CountryZooApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CountryZooApplication.Controllers
{
    public class HomeController : Controller
    {
        //somw test
        private readonly IAnimalRepository _animalRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IAnimalRepository animalRepository, ILogger<HomeController> logger)
        {
            _animalRepository = animalRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = _animalRepository.GetAllAnimals();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            HomeAnimalsViewModel homeAnimalsViewModel = new HomeAnimalsViewModel()
            {
                Animal = _animalRepository.GetAnimal(id),
                PageTitle = "Animal Details"
            };

            return View(homeAnimalsViewModel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            if (ModelState.IsValid)
            {
                Animal newAnimal = _animalRepository.Add(animal);
                return RedirectToAction("details", new { id = newAnimal.Id });
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
