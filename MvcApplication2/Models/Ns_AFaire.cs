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
    public class Ns_AFaire
    {
        [Key]
        public string Num_Serie { get; set; }
        [ForeignKey("Produit")]
        public string Code_Produit { get; set; }
        [ForeignKey("Profile_Ga")]
        public string ID_Gamme { get; set; }
        public virtual Produit Produit { get; set; }
        public virtual Profile_Ga Profile_Ga { get; set; }
    }
    //public class GammeDBContext : DbContext
    //{
    //    public DbSet<Ns_AFaire> Ns_AFaires { get; set; }
    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
    //    }
    //}
    
} 