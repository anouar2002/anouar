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
    public class Sous_Famille
    {
        [Key]
        public string ID_SFamaille { get; set; }

        public string Nom_SFamille { get; set; }
        [ForeignKey("Profile_Ga")]
        public string ID_Gamme { get; set; }
        [ForeignKey("Famille")]
        public string ID_Famille { get; set; }
        public virtual Famille Famille { get; set; }
        public virtual Profile_Ga Profile_Ga { get; set; }


        //public class GammeDBContext : DbContext
        //{
        //    public DbSet<Sous_Famille> Sous_Familles { get; set; }
        //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        //    }
        //}
    }
}