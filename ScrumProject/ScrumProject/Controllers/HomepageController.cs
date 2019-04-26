using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScrumProject.Models;
using ScrumProject.BAL;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScrumProject.Controllers
{
    public class HomepageController : Controller
    {
        private Scrum_StudentAccomodationContext context;
        private HouseBAL houseBAL;

        public HomepageController(Scrum_StudentAccomodationContext context)
        {
            this.houseBAL = new HouseBAL(context);
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<House> houseList = new List<House>();
            houseList = houseBAL.getAllHouse();
            return View(houseList);
        }

        [HttpGet]
        public IActionResult Filter(string type)
        {
            if (type == "High")
            {
                List<House> houseList = new List<House>();
                houseList = houseBAL.getAllHouseHightoLow();
                return View("Index", houseList);
            }
            else
            {
                List<House> houseList = new List<House>();
                houseList = houseBAL.getAllHouseLowtoHigh();
                return View("Index", houseList);
            }
        }
    }
}
