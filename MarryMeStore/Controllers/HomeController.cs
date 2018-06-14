using Domain.Entities;
using Service;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MarryMeStore.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly MarryService<Item> context;
        
        public HomeController()
        {
            
            context = new MarryService<Item>();
            
            
        }

        public ActionResult Index()
        {
            List<Item> all = context.GetAll().ToList();
            ViewBag.content = all;
  
            
            return View();
        }
        
    }
}