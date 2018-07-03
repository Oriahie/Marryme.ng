using Domain.Entities;
using Service;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            List<Item> all = context.GetAll()/*.Where(e => !e.IsDeleted)*/.ToList();
            
            return View(all);
        }

        public ActionResult AddImage()
        {
            Item item = new Item();
            return View(item);
        }

        [HttpPost]
        public ActionResult AddImage(Item model, HttpPostedFileBase image1)
        {
            if (image1!=null)
            {
                model.Image = new byte[image1.ContentLength];
                image1.InputStream.Read(model.Image, 0, image1.ContentLength);
            }
            context.Add(model);
            context.Save();
            return View(model);
        }
    }
}