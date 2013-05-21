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
    public class Historique
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Num_Serie")]
        public string Id_NS { get; set; }
        [Key]
        [ForeignKey("Poste")]
        [Column(Order = 1)]
        public string ID_Poste { get; set; }
        public string ID_Gamme { get; set; }
        public virtual Poste Poste { get; set; }
        public virtual Num_Serie Num_Serie { get; set; }
    }
    //public class GammeDBContext : DbContext
    //{
    //    public DbSet<Historique> Historiques { get; set; }
    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
    //    }
    //}
}
    
