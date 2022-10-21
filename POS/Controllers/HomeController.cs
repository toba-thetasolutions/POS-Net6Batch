using Microsoft.AspNetCore.Mvc;
using POS.Models;
using System.Diagnostics;

namespace POS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                // error
                try
                {
                    int num1 = 10;
                    int num2 = 0;
                    int result = num1 / num2;
                }
                catch (Exception ex)
                {

                    ViewBag.Error = "Some error occured. Please consult your owner " + ex.Message;
                    //throw;
                    return View();
                }
            }
            catch(Exception ex)
            {
                // throw handle
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

        public IActionResult Dashboard()
        {
            try
            {
                return View();
            }
            catch
            {

            }
            return View();
        }
        public IActionResult UserDetail()
        {
            // 1st Object
            //Users Admin = new Users();
            //Admin.Id = 1;
            //Admin.FirstName = "ABC";
            //Admin.LastName = "XYZ";
            //Admin.Email = "abc@gmail.com";
            //Admin.Password = "12345";
            //Admin.Gender = 1;
            //ViewBag.AdminDetail = Admin;
            // 2nd Object
            AppUsers Client = new AppUsers
            {
                Id = 2,
                FirstName = "Momin",
                LastName = "XYZ",
                //  Email = "momin@gmail.com",
                Password = "123456789",
                Gender = 2
            };
            //ViewBag.ClientDetail = Client;
            return View(Client);
        }
        public IActionResult AllUsers()
        {
            IList<ItemCategories> oListCategories = new List<ItemCategories>();
            ItemCategories cat1 = new ItemCategories
            {
                Id = 1,
                CatName = "Samsung",
                CatCode = "001",          
            };
            ItemCategories cat2 = new ItemCategories
            {
                Id = 2,
                CatName = "OPPO",
                CatCode = "002",
            };
            oListCategories.Add(cat1);
            oListCategories.Add(cat2);
            return View(oListCategories);

        }

    }
}