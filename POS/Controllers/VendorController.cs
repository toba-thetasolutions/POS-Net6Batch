using Microsoft.AspNetCore.Mvc;

namespace POS.Controllers
{
    public class VendorController : Controller
    {
        public IActionResult AddVendor()
        {
            var firstName = "ABC";
            var id = 0;
            ViewBag.UserName = firstName;
            ViewBag.Id = id;
           // TempData["UserInfo"] = "Request From Add Vendor";
            return RedirectToAction("AllVendors");
        }
        public IActionResult Index()
        {
            ViewBag.UserName = "ASP.NET";
            TempData["UserName"] = "ASP.NET";
            ViewBag.Id = 1;
            return View();
        }
        public IActionResult AllVendors()
        {
           ViewBag.Request = TempData["UserInfo"];
            return View();
        }
    }
}
