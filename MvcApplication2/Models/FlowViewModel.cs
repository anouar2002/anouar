using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data.Entity;
using MvcApplication2.Models;
using MvcApplication2.Controllers;
namespace MvcApplication2.Models
{
    public class FlowViewModel
    {

        [Key]
        public string IDv { get; set; }
        [NotMapped]
        public SelectList PostesItems { get; set; }
        public List<Profile_Ga> Profile_GaItems { get; set; }
        public List<Gamme> GaItems { get; set; }
        public List<Famille> FaItems { get; set; }
        public List<Sous_Famille> SFItems { get; set; }
        public List<Produit> PItems { get; set; }
        public List<Ns_AFaire> NSItems { get; set; }
        public List<Genre> GenreItems { get; set; }
        public List<Fonction> FoncItems { get; set; }

    

        public string SelectedProfile_Ga { get; set; }

        
      public string SelectedPoste { get; set; }
      public string SelectedFonction { get; set; }

      public string PostePrecedentSelected { get; set; } 
      public string PosteSuivantSelected { get; set; }

       
        public string Position { get; set; }
        public string  Nbr_Passage { get; set; }

        public string SelectedGenre { get; set; } 

        public List<Gamme> ListG {get;set;}


        
    }

}