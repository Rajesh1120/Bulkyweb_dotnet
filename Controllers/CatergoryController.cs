using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class CatergoryController : Controller
    {
        public readonly ApplicationDBContext _db;
        public CatergoryController(ApplicationDBContext db){
            _db = db;
        }
        public IActionResult Index()
        {
            List<Catergory> objCatergoryList= _db.Catergories.ToList();
            return View(objCatergoryList);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Catergory obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "display order don't match each other ");
            }
            if(ModelState.IsValid)
            { 
                _db.Catergories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        
            
            return View();
            
        }
    }
}