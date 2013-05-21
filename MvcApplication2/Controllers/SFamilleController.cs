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
    public class SFamilleController : Controller
    {
        private GammeContext db = new GammeContext();

        //
        // GET: /SFamille/

        public ViewResult Index()
        {
            var sous_familles = db.Sous_Familles.Include(s => s.Famille).Include(s => s.Profile_Ga);
            return View(sous_familles.ToList());
        }

        //
        // GET: /SFamille/Details/5

        public ViewResult Details(string id)
        {
            Sous_Famille sous_famille = db.Sous_Familles.Find(id);
            return View(sous_famille);
        }

        //
        // GET: /SFamille/Create

        public ActionResult Create()
        {
            ViewBag.ID_Famille = new SelectList(db.Familles, "ID_Famille", "Nom_Famille");
            ViewBag.ID_Gamme = new SelectList(db.Profil_Gas, "ID_Gamme", "In_Ga");
            return View();
        } 

        //
        // POST: /SFamille/Create

        [HttpPost]
        public ActionResult Create(Sous_Famille sous_famille)
        {
            if (ModelState.IsValid)
            {
                db.Sous_Familles.Add(sous_famille);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.ID_Famille = new SelectList(db.Familles, "ID_Famille", "Nom_Famille", sous_famille.ID_Famille);
            ViewBag.ID_Gamme = new SelectList(db.Profil_Gas, "ID_Gamme", "In_Ga", sous_famille.ID_Gamme);
            return View(sous_famille);
        }
        
        //
        // GET: /SFamille/Edit/5
 
        public ActionResult Edit(string id)
        {
            Sous_Famille sous_famille = db.Sous_Familles.Find(id);
            ViewBag.ID_Famille = new SelectList(db.Familles, "ID_Famille", "Nom_Famille", sous_famille.ID_Famille);
            ViewBag.ID_Gamme = new SelectList(db.Profil_Gas, "ID_Gamme", "In_Ga", sous_famille.ID_Gamme);
            return View(sous_famille);
        }

        //
        // POST: /SFamille/Edit/5

        [HttpPost]
        public ActionResult Edit(Sous_Famille sous_famille)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sous_famille).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Famille = new SelectList(db.Familles, "ID_Famille", "Nom_Famille", sous_famille.ID_Famille);
            ViewBag.ID_Gamme = new SelectList(db.Profil_Gas, "ID_Gamme", "In_Ga", sous_famille.ID_Gamme);
            return View(sous_famille);
        }

        //
        // GET: /SFamille/Delete/5
 
        public ActionResult Delete(string id)
        {
            Sous_Famille sous_famille = db.Sous_Familles.Find(id);
            return View(sous_famille);
        }

        //
        // POST: /SFamille/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Sous_Famille sous_famille = db.Sous_Familles.Find(id);
            db.Sous_Familles.Remove(sous_famille);
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