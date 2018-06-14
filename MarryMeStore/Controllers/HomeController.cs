using Domain.Entities;
using MarryMeStore.ViewModel;
using Service;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MarryMeStore.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly MarryService<Item> context;
        private readonly Item item;
        public HomeController()
        {
            
            context = new MarryService<Item>();
            item = new Item();
            
        }

        public ActionResult Index()
        {
            List<Item> all = context.GetAll().ToList();
            ViewBag.content = all;

            //ItemViewModel ivm = new ItemViewModel
            //{
                
            //    Items = all,
            //    ItemName = item.ItemName,
            //    Price = item.Price,
            //    Description = item.Description,
            //    ImageUrl = item.ImageUrl
            //};

            
            
            
            return View();
        }
        
    }
}