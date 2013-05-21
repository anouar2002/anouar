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
    public class Ligne
    {
        [Key]
        public string ID_Ligne { get; set; }
        [ForeignKey("UF")]
        public string ID_UF { get; set; }
        public virtual UF UF { get; set; }
        public virtual ICollection<Ligne> Lignes { get; set; }

        
    }
    //public class GammeDBContext : DbContext
    //{
    //    public DbSet<Ligne> Lignes { get; set; }
    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
    //    }
    //}
    }
 
