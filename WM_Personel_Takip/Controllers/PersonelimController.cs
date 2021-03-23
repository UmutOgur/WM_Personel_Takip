using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WM_Personel_Takip.Models;

namespace WM_Personel_Takip.Controllers
{
    public class PersonelimController : Controller
    {
        Context db = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var listele = db.Personels.Include(x => x.Birim).ToList();
            return View(listele);
        }
        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in db.Birims.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.BirimAD,
                                                 Value = x.BirimID.ToString()


                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonel(Personel p)
        {
            var per = db.Birims.Where(x => x.BirimID == p.Birim.BirimID).FirstOrDefault();
            p.Birim = per;
            db.Personels.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
