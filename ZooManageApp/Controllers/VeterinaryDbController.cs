using Microsoft.AspNetCore.Mvc;
using ZooManageApp.Data;
using ZooManageApp.Models;

namespace ZooManageApp.Controllers
{
    public class VeterinaryDbController : Controller
    {
        readonly ZooManageAppDbContext _zooManageApp;
        public VeterinaryDbController(ZooManageAppDbContext zooManageApp)
        {
            _zooManageApp = zooManageApp;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_zooManageApp.Veterinaries.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Create(Veterinary veterinary) 
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                veterinary.Id = veterinary.Id;
                _zooManageApp.Veterinaries.Add(veterinary);
                _zooManageApp.SaveChanges();
            }
            return RedirectToAction("index");


        }

    }
}
