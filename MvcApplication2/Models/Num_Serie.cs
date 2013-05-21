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
    public class Num_Serie
    {
        [Key]
        public string Id_NS { get; set; }
        public string Code_Produit { get; set; }
        public string Sous_Famille { get; set; }
        public string Last_Post { get; set; }
        public string Last_Mvt { get; set; }
        public string Last_Gamme { get; set; }
        public string Current_Game { get; set; }
   
    }
    //public class GammeDBContext : DbContext
    //{
    //    public DbSet<Num_Serie> Num_Series { get; set; }
    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
    //    }
    //}
    }
    
