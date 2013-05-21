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
    public class Phase
    {

        [Key]
        public string ID_Phase { get; set; }
        public string Nom_Phase { get; set; }
   
    }
    //public class GammeDBContext : DbContext
    //{
    //    public DbSet<Phase> Phases { get; set; }
    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
    //    }
    //}
    }
