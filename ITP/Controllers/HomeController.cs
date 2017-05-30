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
                new Item { Title = "Procesor" },
                new Item { Title = "GPU" },
                new Item { Title = "Monitor" },
                new Item { Title = "Optická mech." },
                new Item { Title = "Klávesnice a Myš" },
                new Item { Title = "Tiskárna" },
                new Item { Title = "Operační Paměť" },
                new Item { Title = "Vnitřní Paměť" },
                new Item { Title = "Základní Deska" }
            };
            return View(item);
        }
    }
}