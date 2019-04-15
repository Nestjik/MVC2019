using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5_5_vj.Models;

namespace _5_5_vj.Controllers
{
    public class PrikazDaChildAkcijomController : Controller
    {
        public ViewResult ObradiListu()
        {
            List<Artikl> lArt = new List<Artikl>
            {
                new Artikl(){Kategorija="voce",Naziv="Banana",Cijena=10.9m,Kolicina=10},
                new Artikl(){Kategorija="povrce",Naziv="Mrkva",Cijena=5.9m,Kolicina=2},
                new Artikl(){Kategorija="meso",Naziv="Kobaja",Cijena=30.9m,Kolicina=8}
            };
            return View(lArt);
        }
    }
}