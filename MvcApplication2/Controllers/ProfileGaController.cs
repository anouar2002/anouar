using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;
using MvcApplication2.ViewModels;

namespace MvcApplication2.Controllers
{ 
    public class ProfileGaController : Controller
    {
        private GammeContext db = new GammeContext();
        public List<Gamme> ListG = new List<Gamme>();

        //
        // GET: /ProfileGa/

        public ActionResult Gestion(FlowViewModel model)
        {

           
            return PartialView(model);

        }
        [HttpGet]
        public ActionResult Index(Profile_Ga profile_ga, Poste poste)
        {
             
            var viewModel = new FlowViewModel();
            viewModel.PostesItems = new SelectList(db.Postes.ToList(), "ID_Poste", "ID_Poste");
            
               viewModel.Profile_GaItems = db.Profil_Gas.ToList();
               viewModel.GaItems = db.Gammes.ToList();
                  
            return View(viewModel);
            


        }

        
        //
        // GET: /ProfileGa/Details/5

        public ViewResult Details(string id)
        {
            Profile_Ga profile_ga = db.Profil_Gas.Find(id);
            return View(profile_ga);
        }

        //
        // GET: /ProfileGa/Create

        public ActionResult Create()
        {
            
            return View();
        } 

        //
        // POST: /ProfileGa/Create

        [HttpPost]
        public ActionResult Create(Profile_Ga profile_ga)
        {
            if (ModelState.IsValid)
            {
                db.Profil_Gas.Add(profile_ga);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(profile_ga);
        }
        
        //
        // GET: /ProfileGa/Edit/5
 
        public ActionResult Edit(string id)
        {
            Profile_Ga profile_ga = db.Profil_Gas.Find(id);
            return View(profile_ga);
        }

        //
        // POST: /ProfileGa/Edit/5

        [HttpPost]
        public ActionResult Edit(Profile_Ga profile_ga)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profile_ga).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profile_ga);
        }

        //
        // GET: /ProfileGa/Delete/5
 
        public ActionResult Delete(string id)
        {
            Profile_Ga profile_ga = db.Profil_Gas.Find(id);
            return View(profile_ga);
        }

        //
        // POST: /ProfileGa/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Profile_Ga profile_ga = db.Profil_Gas.Find(id);
            db.Profil_Gas.Remove(profile_ga);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [HttpPost]
        public ActionResult Save(FlowViewModel model)
        {
            Console.WriteLine("" + model.Nbr_Passage);
            if (ModelState.IsValid)
            {
                Gamme G = new Gamme();
                G.ID_Gamme = model.SelectedProfile_Ga;
                G.ID_Poste = model.SelectedPoste;
                G.Last_Posts = model.PostePrecedentSelected;
                G.Next_Posts = model.PosteSuivantSelected;
                G.Nbr_Passage = int.Parse(model.Nbr_Passage);
                G.Position = int.Parse(model.Position);
                ListG.Add(G);
                db.Gammes.Add(G);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
           
        }

        public ActionResult Update(string id)
        {
            FlowViewModel flv = new FlowViewModel();
            flv.Profile_GaItems = db.Profil_Gas.ToList();
            flv.GaItems = db.Gammes.ToList();
            return View(flv);
        }

        [HttpPost]
        public ActionResult Update(FlowViewModel model)
        {
            Console.WriteLine("" + model.Nbr_Passage);
           
                Gamme G = new Gamme();
                ListG.Remove(G);
                db.Gammes.Remove(G); 
                G.ID_Gamme = model.SelectedProfile_Ga;
                G.ID_Poste = model.SelectedPoste;
                G.Last_Posts = model.PostePrecedentSelected;
                G.Next_Posts = model.PosteSuivantSelected;
                G.Nbr_Passage = int.Parse(model.Nbr_Passage);
                G.Position = int.Parse(model.Position);
                ListG.Add(G);
                db.Gammes.Add(G);
                db.SaveChanges();
            
            return RedirectToAction("Index");

        }



        
    }
}