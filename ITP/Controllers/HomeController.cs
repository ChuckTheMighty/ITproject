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
    }
}