using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{ 
    public class PosteController : Controller
    {
        private GammeContext db = new GammeContext();

        //
        // GET: /Poste/

        public ViewResult Index()
        {
            var postes = db.Postes.Include(p => p.Ligne);
            return View(postes.ToList());
        }

        //
        // GET: /Poste/Details/5

        public ViewResult Details(string id)
        {
            Poste poste = db.Postes.Find(id);
            return View(poste);
        }

        //
        // GET: /Poste/Create

        public ActionResult Create()
        {
            ViewBag.ID_Ligne = new SelectList(db.Lignes, "ID_Ligne", "ID_UF");
            return View();
        } 

        //
        // POST: /Poste/Create

        [HttpPost]
        public ActionResult Create(Poste poste)
        {
            if (ModelState.IsValid)
            {
                db.Postes.Add(poste);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.ID_Ligne = new SelectList(db.Lignes, "ID_Ligne", "ID_UF", poste.ID_Ligne);
            return View(poste);
        }
        
        //
        // GET: /Poste/Edit/5
 
        public ActionResult Edit(string id)
        {
            Poste poste = db.Postes.Find(id);
            ViewBag.ID_Ligne = new SelectList(db.Lignes, "ID_Ligne", "ID_UF", poste.ID_Ligne);
            return View(poste);
        }

        //
        // POST: /Poste/Edit/5

        [HttpPost]
        public ActionResult Edit(Poste poste)
        {
            if (ModelState.IsValid)
            {
                db.Entry(poste).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Ligne = new SelectList(db.Lignes, "ID_Ligne", "ID_UF", poste.ID_Ligne);
            return View(poste);
        }

        //
        // GET: /Poste/Delete/5
 
        public ActionResult Delete(string id)
        {
            Poste poste = db.Postes.Find(id);
            return View(poste);
        }

        //
        // POST: /Poste/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Poste poste = db.Postes.Find(id);
            db.Postes.Remove(poste);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}