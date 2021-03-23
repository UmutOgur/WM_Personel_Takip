using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WM_Personel_Takip.Models;

namespace WM_Personel_Takip.Controllers
{
    public class DefaultController : Controller
    {
        Context db = new Context();
        public IActionResult Index()
        {
            var listele = db.Birims.ToList();
            return View(listele);
        }
        [HttpGet] // ilk sayfa yüklendiğinde çalışacak olan yer
        public IActionResult YeniBirim()
        {
            return View();
        }
        [HttpPost]//eklenme kısmı yani psot edildiğinde aşağıdaki kod satırları çalışsın.
        public IActionResult YeniBirim(Birim b)
        {
            db.Birims.Add(b);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult BirimSil(int id)
        {
            var sil = db.Birims.Find(id);
            db.Birims.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimGetir(int id)
        {
            var getir = db.Birims.Find(id);
            return View("BirimGetir", getir);
        }
        public IActionResult BirimGuncelle(Birim b)
        {
            var deger = db.Birims.Find(b.BirimID);
            deger.BirimAD = b.BirimAD;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult BirimDetay(int id)
        {
            var degerler = db.Personels.Where(x => x.BirimID == id).ToList();
            var brmad = db.Birims.Where(x => x.BirimID == id).Select(y => y.BirimAD).FirstOrDefault();
            ViewBag.brm = brmad;
            return View(degerler);
        }
    }
}
