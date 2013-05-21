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
    public class Profile_Ga
    {
        [Required]
        [Key]
        [Display(Name = "ID Gamme:")]
        public string ID_Gamme { get; set; }

        [Required]
        [Display(Name = "Gamme Entrante:")]
        public string In_Ga { get; set; }

        [Required]
        [Display(Name = "Gamme Sortante:")]
        public string Out_Ga { get; set; }

        [Required]
        [Display(Name = "Gamme Suivante:")]
        public string Next_Gamme { get; set; }

        [Required]
        [Display(Name = "Etat:")]
        public string Etat { get; set; }
        
        
       
        


        //    public class GammeDBContext : DbContext
        //    {
        //        public DbSet<Profile_Ga> Profil_Gas { get; set; }
        //        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //        {
        //            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        //        }
        //}
    }
}