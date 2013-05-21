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
    public class ProduitController : Controller
    {
        private GammeContext db = new GammeContext();

        //
        // GET: /Produit/

        public ViewResult Index()
        {
            var produits = db.Produits.Include(p => p.Sous_Famille).Include(p => p.Profile_Ga);
            return View(produits.ToList());
        }

        //
        // GET: /Produit/Details/5

        public ViewResult Details(string id)
        {
            Produit produit = db.Produits.Find(id);
            return View(produit);
        }

        //
        // GET: /Produit/Create

        public ActionResult Create()
        {
            ViewBag.ID_SFamille = new SelectList(db.Sous_Familles, "ID_SFamaille", "Nom_SFamille");
            ViewBag.ID_Gamme = new SelectList(db.Profil_Gas, "ID_Gamme", "In_Ga");
            return View();
        } 

        //
        // POST: /Produit/Create

        [HttpPost]
        public ActionResult Create(Produit produit)
        {
            if (ModelState.IsValid)
            {
                db.Produits.Add(produit);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.ID_SFamille = new SelectList(db.Sous_Familles, "ID_SFamaille", "Nom_SFamille", produit.ID_SFamille);
            ViewBag.ID_Gamme = new SelectList(db.Profil_Gas, "ID_Gamme", "In_Ga", produit.ID_Gamme);
            return View(produit);
        }
        
        //
        // GET: /Produit/Edit/5
 
        public ActionResult Edit(string id)
        {
            Produit produit = db.Produits.Find(id);
            ViewBag.ID_SFamille = new SelectList(db.Sous_Familles, "ID_SFamaille", "Nom_SFamille", produit.ID_SFamille);
            ViewBag.ID_Gamme = new SelectList(db.Profil_Gas, "ID_Gamme", "In_Ga", produit.ID_Gamme);
            return View(produit);
        }

        //
        // POST: /Produit/Edit/5

        [HttpPost]
        public ActionResult Edit(Produit produit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_SFamille = new SelectList(db.Sous_Familles, "ID_SFamaille", "Nom_SFamille", produit.ID_SFamille);
            ViewBag.ID_Gamme = new SelectList(db.Profil_Gas, "ID_Gamme", "In_Ga", produit.ID_Gamme);
            return View(produit);
        }

        //
        // GET: /Produit/Delete/5
 
        public ActionResult Delete(string id)
        {
            Produit produit = db.Produits.Find(id);
            return View(produit);
        }

        //
        // POST: /Produit/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Produit produit = db.Produits.Find(id);
            db.Produits.Remove(produit);
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