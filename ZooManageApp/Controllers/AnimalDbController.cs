using Microsoft.AspNetCore.Mvc;
using ZooManageApp.Data;
using ZooManageApp.Models;

namespace ZooManageApp.Controllers
{
    public class AnimalDbController : Controller
    {
        readonly ZooManageAppDbContext _zooManageApp;

        public AnimalDbController(ZooManageAppDbContext zooManageApp)
        {
            _zooManageApp = zooManageApp;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_zooManageApp.Animals.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Animal animal) 
        {
            ModelState.Remove("id");
            if(ModelState.IsValid)
            {
                animal.Id= animal.Id;
                _zooManageApp.Animals.Add(animal);
                _zooManageApp.SaveChanges();
            }
            return RedirectToAction("index");
        }

    }
}
