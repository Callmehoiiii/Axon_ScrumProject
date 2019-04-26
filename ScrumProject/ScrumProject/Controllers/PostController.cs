using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScrumProject.BAL;
using ScrumProject.Models;

namespace ScrumProject.Controllers
{
    public class PostController : Controller
    {
        public User user;
        public Scrum_StudentAccomodationContext context;
        public HouseTypeBAL HouseTypeBal;
        public HouseBAL HouseBal;
        private IHostingEnvironment iHostingEnvironment;

        public PostController(Scrum_StudentAccomodationContext context, IHostingEnvironment iHostingEnvironment)
        {
            this.context = context;
            HouseTypeBal = new HouseTypeBAL(context);
            HouseBal = new HouseBAL(context);
            user = new User();
            this.iHostingEnvironment = iHostingEnvironment;
        }

        public IActionResult Index(User _user)
        {
            this.user = _user;
            ViewBag.TypeList = HouseTypeBal.GetListHouseTypes();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post(string diachi, string dientich, int type, int gia, string user, string sodienthoai, IFormFile image)
        {
            if (image != null)
            {
                string extension = Path.GetExtension(image.FileName.ToLower());
                string filePath = Path.GetFullPath(
                    Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot/img/houses"));
                string fileName = HouseBal.NextIDHouse() + extension;
                using (var fileStream = new FileStream(
                    Path.Combine(filePath, fileName),
                    FileMode.Create))
                {
                    await image.CopyToAsync(fileStream);
                }

                House house = new House
                {
                    IdHouse = HouseBal.NextIDHouse(),
                    Adress = diachi,
                    Area = dientich,
                    Contact = sodienthoai,
                    Price = gia.ToString(),
                    IdType = type,
                    IdAcc = this.user.IdAcc,
                    Image = fileName
                };
                await HouseBal.InsertHouse(house);
                return RedirectToAction("Index", "Homepage");
            }
            else
            {
                House house = new House
                {
                    IdHouse = HouseBal.NextIDHouse(),
                    Adress = diachi,
                    Area = dientich,
                    Contact = sodienthoai,
                    Price = gia.ToString(),
                    IdType = type,
                    IdAcc = this.user.IdAcc,
                    Image = null
                };
                await HouseBal.InsertHouse(house);
                return RedirectToAction("Index", "Homepage");
            }
        }
    }
}