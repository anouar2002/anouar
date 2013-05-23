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
    public class FonctionController : Controller
    {
        private GammeContext db = new GammeContext();

        //
        // GET: /Fonction/

        public ViewResult Index()
        {
            var fonctions = db.Fonctions.Include(f => f.Phase);
            return View(fonctions.ToList());
        }

        //
        // GET: /Fonction/Details/5

        public ViewResult Details(string id)
        {
            Fonction fonction = db.Fonctions.Find(id);
            return View(fonction);
        }

        //
        // GET: /Fonction/Create

        public ActionResult Create()
        {
            ViewBag.ID_Phase = new SelectList(db.Phases, "ID_Phase", "Nom_Phase");
            return View();
        } 

        //
        // POST: /Fonction/Create

        [HttpPost]
        public ActionResult Create(Fonction fonction)
        {
            if (ModelState.IsValid)
            {
                db.Fonctions.Add(fonction);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.ID_Phase = new SelectList(db.Phases, "ID_Phase", "Nom_Phase", fonction.ID_Phase);
            return View(fonction);
        }
        
        //
        // GET: /Fonction/Edit/5
 
        public ActionResult Edit(string id)
        {
            Fonction fonction = db.Fonctions.Find(id);
            ViewBag.ID_Phase = new SelectList(db.Phases, "ID_Phase", "Nom_Phase", fonction.ID_Phase);
            return View(fonction);
        }

        //
        // POST: /Fonction/Edit/5

        [HttpPost]
        public ActionResult Edit(Fonction fonction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fonction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Phase = new SelectList(db.Phases, "ID_Phase", "Nom_Phase", fonction.ID_Phase);
            return View(fonction);
        }

        //
        // GET: /Fonction/Delete/5
 
        public ActionResult Delete(string id)
        {
            Fonction fonction = db.Fonctions.Find(id);
            return View(fonction);
        }

        //
        // POST: /Fonction/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Fonction fonction = db.Fonctions.Find(id);
            db.Fonctions.Remove(fonction);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [HttpGet]
        public ActionResult gerer(Fonction fonction, Poste poste)
        {
            var viewModel = new FlowViewModel();
            viewModel.PostesItems = new SelectList(db.Postes.ToList(), "ID_Poste", "ID_Poste");
            viewModel.FoncItems = db.Fonctions.ToList();

            return View(viewModel);
            
        }
    }
}