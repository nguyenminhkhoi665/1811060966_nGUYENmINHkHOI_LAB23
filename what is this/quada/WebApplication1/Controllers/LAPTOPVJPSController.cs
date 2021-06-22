using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class LAPTOPVJPSController : Controller
    {

        public List<LAPTOPVJP> listGoodlaps = new List<LAPTOPVJP>();
        public LAPTOPVJPSController()
        {
            listGoodlaps.Add(new LAPTOPVJP()
            {
                Id = 1,
                Title = "Acer Nitro 5",
                Author = "Acer",
                PublicYear = 2020,
                Price = 20000000,
                Cover = "Content/image/Acer-Nitro-5-2020-9539-congngheviet-1920x1280-1.jpg"
            });
            listGoodlaps.Add(new LAPTOPVJP()
            {
                Id = 2,
                Title = "Asus Rog GX550",
                Author = "Acer",
                PublicYear = 2020,
                Price = 30000000,
                Cover = "Content/image/asus-rog-gx550lws-hf102t.png"
            });
            listGoodlaps.Add(new LAPTOPVJP()
            {
                Id = 3,
                Title = "Asus Zenbook GX550",
                Author = "Acer",
                PublicYear = 2020,
                Price = 40000000,
                Cover = "Content/image/laptop-acer-aspire-5-a514-i5-ram-8gb-ssd-512gb-den-ban-phim_8-ksp.jpg"
            });

        }

        public ActionResult ListGoodlaps()
        {
            ViewBag.TitlePageName = "laptoop view";
            return View(listGoodlaps);
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            LAPTOPVJP lap = listGoodlaps.Find(s => s.Id == id);
            if (lap == null)
                return HttpNotFound();
            return View(lap);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            LAPTOPVJP LAPTOP = listGoodlaps.Find(l => l.Id == id);
            if (LAPTOP == null)
                return HttpNotFound();
            return View(LAPTOP);
        }
        [HttpPost]
        public ActionResult Edit(LAPTOPVJP laptop)
        {
            var editLaptop = listGoodlaps.Find(l => l.Id == laptop.Id);
            editLaptop.Title = laptop.Title;
            editLaptop.Author = laptop.Author;
            editLaptop.PublicYear = laptop.PublicYear;
            return View("ListGoodlaps", listGoodlaps);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LAPTOPVJP laptop)
        {
            listGoodlaps.Add(laptop);
            return View("ListGoodlaps", listGoodlaps);
        }
    }
}