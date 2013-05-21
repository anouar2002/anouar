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
    public class Gamme
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Profile_Ga")]
        public string ID_Gamme { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Poste")]
        public string ID_Poste { get; set; }
        public int Position { get; set; }
        //[Range(1, 100,
        //    ErrorMessage = "Price must be between 0.01 and 100.00")]
        
        public int Nbr_Passage { get; set; }
        public string Last_Posts { get; set; }
        public string Next_Posts { get; set; }
        
        public virtual Poste Poste { get; set; }
        public virtual Profile_Ga Profile_Ga { get; set; }
        
    }
    //public class GammeDBContext : DbContext
    //{
    //    public DbSet<Gamme> Gammes { get; set; }
    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
    //    }
    //}
    }
    
