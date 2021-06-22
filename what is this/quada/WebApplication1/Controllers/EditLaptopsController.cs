using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EditLaptopsController : Controller
    {
        List<LAPTOPVJP> listGoodlaps = new List<LAPTOPVJP>();

        public ActionResult EditLaptops(int id) { 
            
            listGoodlaps.Add(new LAPTOPVJP()
            {
                Id = 1,
                Title = "Acer Nitro 5",
                Author = "Acer",
                PublicYear = 2020,
                Price = 20000000,
                Cover = "Content/image/acer.jpg"
            });
            listGoodlaps.Add(new LAPTOPVJP()
            {
                Id = 2,
                Title = "Asus Rog GX550",
                Author = "Acer",
                PublicYear = 2020,
                Price = 30000000,
                Cover = "Content/image/asus-rog-gx550lws-hf102t.jpg"
            });
            listGoodlaps.Add(new LAPTOPVJP()
            {
                Id = 3,
                Title = "Asus Zenbook GX550",
                Author = "Acer",
                PublicYear = 2020,
                Price = 40000000,
                Cover = "Content/image/asus-zenbook-ux482eg-i5-ka166t-600x600.jpg"
            });

            LAPTOPVJP LAPTOP = new LAPTOPVJP();
            foreach(LAPTOPVJP p in listGoodlaps)
            {
                if(p.Id==id)
                {
                    LAPTOP = p;
                    break;
                }
            }
            if(LAPTOP==null)
                {
                return HttpNotFound();

            }
            return View(LAPTOP);
                

            
        }

        public ActionResult Update(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            LAPTOPVJP LAPTOP = listGoodlaps.Find(l => l.Id == id);
            if (LAPTOP == null)
                return HttpNotFound();
            return View(LAPTOP);
        }
    }
}