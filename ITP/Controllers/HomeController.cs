using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITP.Models;

namespace ITP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Item> item = new List<Item>()
            {
                new Item { Title = "Procesor", Link = "CPU" },
                new Item { Title = "GPU", Link = "GPU" },
                new Item { Title = "Monitor", Link = "MOR" },
                new Item { Title = "Optická mech.", Link = "CD" },
                new Item { Title = "Klávesnice a Myš", Link = "KB" },
                new Item { Title = "Tiskárna", Link = "PER" },
                new Item { Title = "Operační Paměť", Link = "RAM" },
                new Item { Title = "Vnitřní Paměť", Link = "HDD" },
                new Item { Title = "Základní Deska", Link = "MB" }
            };
            return View(item);
        }
        public ActionResult CPU()
        {
            var item = new Item() { Title = "Procesor", Link = "CPU" };
            return View(item);
        }
        public ActionResult CD()
        {
            var item = new Item() { Title = "Disc Drive", Link = "CD" };
            return View(item);
        }
        public ActionResult GPU()
        {
            var item = new Item() { Title = "Graphics", Link = "GPU" };
            return View(item);
        }
        public ActionResult HDD()
        {
            var item = new Item() { Title = "Disk Drive nebo Solid State", Link = "HDD" };
            return View(item);
        }
        public ActionResult KB()
        {
            var item = new Item() { Title = "Klávesnice a myš", Link = "KB" };
            return View(item);
        }
        public ActionResult MB()
        {
            var item = new Item() { Title = "Motherboard", Link = "MB" };
            return View(item);
        }
        public ActionResult MOR()
        {
            var item = new Item() { Title = "Monitor", Link = "MOR" };
            return View(item);
        }
        public ActionResult PER()
        {
            var item = new Item() { Title = "Tiskarna", Link = "PER" };
            return View(item);
        }
        public ActionResult RAM()
        {
            var item = new Item() { Title = "System Memory", Link = "RAM" };
            return View(item);
        }
    }
}