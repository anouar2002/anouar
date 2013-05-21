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
    public class UF
    {
        [Key]
        public string ID_UF { get; set; }




        //    public class GammeDBContext : DbContext
        //    {
        //        public DbSet<UF> UFs { get; set; }
        //        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //        {
        //            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        //        }
        //}
    }
}