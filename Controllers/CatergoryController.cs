using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class CatergoryController : Controller
    {
        public readonly ApplicationDBContext _db;
        public CatergoryController(ApplicationDBContext db){
            _db=db;
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
    }
}