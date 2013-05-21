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
    public class Fonction
    {
        [Key]
        public string ID_Fonction { get; set; }
        
        public string Nom_Fonction { get; set; }
        [ForeignKey("Phase")]
        public string ID_Phase { get; set; }
        public virtual Phase Phase { get; set; }

    }
    //    public class GammeDBContext : DbContext
    //    {
    //        public DbSet<Fonction> Fonctions { get; set; }
    //        protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //        {
    //            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
    //        }

    //    }
    
    }
