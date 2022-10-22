using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using POS.Data;
using POS.Models;

namespace POS.Controllers
{
    public class ItemsController : Controller
    {
        private static  POSDbContext db;
        public ItemsController(POSDbContext _context)
        {
            db = _context;
        }

        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult AddItem()
        {
            return View();
        }
        public IActionResult UpdateItem()
        {
            return View();
        }
        public IActionResult DetailItem()
        {
            Items objItem = new Items();
            objItem.Id = 1;
            objItem.ItemName = "Laptop";
            objItem.Serial = 1;
            objItem.ItemCode = "ITM-" + objItem.Serial.ToString();
            objItem.Price = 100;
            objItem.Qunatity = 20;
            return View(objItem);
        }
        public IActionResult AllItem()
        {
            return View();
        }
        public IActionResult DeleteItem()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddItemCategory()
        {
            ItemCategories objCat = null;

            return View(objCat);
        }
        [HttpPost]
        public IActionResult AddItemCategory(ItemCategories objCat)
        {
            try
            {
                objCat.CreatedDate = DateTime.Now;
                objCat.CreatedBy = "Admin";
                db.ItemCategories.Add(objCat);
                db.SaveChanges();
                ViewBag.SMessage = "Data Saved Successfully";
            }
            catch(Exception ex)
            {
                ViewBag.EMessage = "Some Error occurred. please try again";
            }
        
            return View();
        }
        public IActionResult AllCategories()
        {
            ViewBag.SMessage = TempData["SMessage"];
            IList<ItemCategories> oListCat = null;
            oListCat = db.ItemCategories.Where(m=> m.IsDel == false).OrderBy(m=>m.CatName).ToList();
            return View(oListCat);
        }
        public IActionResult CategoryDetail(int id)

        { 
            ItemCategories objCat = db.ItemCategories.Find(id); 
            return View(objCat);
        }
        // update / edit
        public IActionResult UpdateCategory(int id)
        {
            ViewBag.SMessage = TempData["SMessage"];
            ItemCategories objCat = db.ItemCategories.Find(id);
            return View(objCat);
        }
        [HttpPost]
        public IActionResult UpdateCategory(ItemCategories objcate)
        {
            objcate.ModifiedDate = DateTime.Now;
            objcate.ModifyBy = "System";
            db.ItemCategories.Update(objcate);
            db.SaveChanges();
            TempData["SMessage"] = "Data Updated Successfully";
            return RedirectToAction(nameof(ItemsController.UpdateCategory), new {id = objcate.Id });
        }
        // delete view
        public IActionResult DeleteCategory(int id)
        {
            ItemCategories objCat = db.ItemCategories.Find(id);
            objCat.IsDel = true;
            objCat.ModifiedDate = DateTime.Now;
            objCat.ModifyBy = "Touba";
            db.ItemCategories.Update(objCat);
            db.SaveChanges();
            TempData["SMessage"] = "Data Deleted Successfully";
            return RedirectToAction(nameof(ItemsController.AllCategories));
        }
    }
}
