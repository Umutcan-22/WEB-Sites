using Microsoft.AspNetCore.Mvc;
using Umutcan_Gungor_241103013.Models;

namespace Umutcan_Gungor_241103013.Controllers
{
    public class ProjeController : Controller
    {
        public IActionResult Anasayfa()
        {
            return View();
        }
        public IActionResult Hakkimizda()
        {
            return View();
        }
        public IActionResult SatilikMotorlar()
        {
            return View();
        }
        public IActionResult SatilikEkipmanlar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Deneme()
        {
            return View();
        }


        
        [HttpPost]
        public IActionResult Deneme(string adsoyad,string email,decimal telefon,string mesaj)
        {
            List<UserVM> liste = new List<UserVM>();
            UserVM l = new UserVM();
            l.AdSoyad = adsoyad;
            l.Eposta = email;
            l.Telefon = telefon;
            l.Mesaj = mesaj;

            liste.Add(l);

            return View("BasvuruSonuc",liste);
        }
        public IActionResult BasvuruSonuc()
        {
           

            return View();
        }

       
    }
}
