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
    public class Account
    {
       
        [Key]
        
        public string Type_User { get; set; }

        
    //public class GammeDBContext : DbContext
    //{
    //    public DbSet<Account> Accounts { get; set; }
    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
    //    }

    //}
    }
}