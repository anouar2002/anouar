using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data.Entity;

namespace MvcApplication2.Models
{
    public class Poste
    {
        [Required]
        [Key]
        [Display(Name = "ID Poste :")]
        public string ID_Poste { get; set; }

        [Required]
        [Display(Name = "Nom Poste:")]
        public string nom_Poste { get; set; }

        [Required]
        [Display(Name = "Application :")]
        public string Application { get; set; }

        [Required]
        [Display(Name = "In Poste :")]
        public string In_Po { get; set; }

        [Required]
        [Display(Name = "Out Poste :")]
        public string Out_Po { get; set; }

        [Required]
        [Display(Name = "Etat :")]
        public string Etat { get; set; }

        [Required]
        [ForeignKey("Ligne")]
        [Display(Name = "ID Ligne :")]
        public string ID_Ligne { get; set; }

        [Required]
        [Display(Name = "Mouvement :")]
        public string Mouvement { get; set; }

        public virtual Ligne Ligne { get; set; }
        public IEnumerable<Ligne> Lignes { get; set; }

        public virtual ICollection<Poste> Postes { get; set; }
    }
    //public class GammeDBContextP : DbContext
    //{
    //    public DbSet<Poste> Postes { get; set; }

    //}
}