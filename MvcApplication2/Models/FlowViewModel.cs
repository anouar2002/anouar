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

    

        public string SelectedProfile_Ga { get; set; }

        
      public string SelectedPoste { get; set; }

      public string PostePrecedentSelected { get; set; } 
      public string PosteSuivantSelected { get; set; }

       
        public string Position { get; set; }
        public string  Nbr_Passage { get; set; }
       
        public List<Gamme> ListG = new List<Gamme>();

    
 
  
        
    }

}