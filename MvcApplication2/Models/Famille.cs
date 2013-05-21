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
    public class Famille
    {

        
        [Key]
        public string ID_Famille { get; set; }
        
        public string Nom_Famille { get; set; }
        [ForeignKey ("Profile_Ga")]
        public string ID_Gamme { get; set; }
        public virtual Profile_Ga Profile_Ga { get; set; }
    }

        //public class GammeDBContext : DbContext
        //{
        //    public DbSet<Famille> Familles { get; set; }
        //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        //    }

        //}
    }
