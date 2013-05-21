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
    public class Fonction_Poste
    {
        [Key]
        [Column (Order = 0)]
        [ForeignKey("Poste")]
        
        public string ID_Poste { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Fonction")]
      
        public string ID_Fonction { get; set; }
        public int  Droit { get; set; }

        public virtual Poste Poste { get; set; }
        public virtual Fonction Fonction { get; set; }

    }
        //public class GammeDBContext : DbContext
        //{
        //    public DbSet<Fonction_Poste> Fonction_Postes { get; set; }
        //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        //    }

        //}
    
    
}