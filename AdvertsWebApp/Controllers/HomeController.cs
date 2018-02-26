using AdvertsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvertsWebApp.Controllers
{
    public class HomeController : Controller
    {


        public HomeController()
        {
            advertDb = new AdvertDb();    
        }

        private List<Advert> adverts;
        private AdvertDb advertDb;
        
        //.šī funkjcija tiek izsaukta, kad tiek pieprasīts weblapas bāzes ceļš
        // GET: Home
        public ActionResult Index()
        {
            //Izsaucam view funkciju, lai uzģenerētu html rezultātu
            //no mūsu index.cshtml faila, tajā iekšā izmantojot, kas pieejami adverts sarakstā
            return View(advertDb.Adverts.ToList());
        }

        public ActionResult Advert(int advertId)
        {
            Advert ad = GetAdvertFromDb(advertId);
            return View(ad);
        }

        private Advert GetAdvertFromDb(int advertId)
        {
            //Apskatam katru sludinājumu sarakstā
            foreach (var ad in advertDb.Adverts)
            {
                //JA sludinājuma id ir tāds pats, kā tas, ko lietotājs pieprasījis
                if (ad.AdvertId == advertId)
                {
                    //atgriezst atrasto sludinājumu
                    return ad;
                }
            }

            return null;
        }

        public ActionResult CreateAdvert()
        {
            return View();
        }
        //šis atribūts norāda, ka šo funkciju iespējams izsaukt arPost vaicājumu
        //tas ir, iespējams atsūtit viņai datus no formas
      [HttpPost]
        public ActionResult CreateAdvert(Advert advert)
        {
            advert.CreationTime = DateTime.Now;
            advertDb.Adverts.Add(advert);
            advertDb.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditAdvert(int advertId)
        {
            Advert ad = GetAdvertFromDb(advertId);
            return View(ad);
        }

        [HttpPost]
        public ActionResult EditAdvert(Advert advert)
        {
            if(!ModelState.IsValid)
            {
                return View(advert);
            }
            advertDb.Entry(advert).State = EntityState.Modified;
            advertDb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
    
}