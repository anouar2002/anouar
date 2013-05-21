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
    public class Produit
    {
        [Key]
        public string Code_Produit { get; set; }
        public string Nom_Produit { get; set; }
        [ForeignKey("Sous_Famille")]
        public string ID_SFamille { get; set; }
        [ForeignKey("Profile_Ga")]
        public string ID_Gamme { get; set; }
        public virtual Sous_Famille Sous_Famille { get; set; }
        public virtual Profile_Ga Profile_Ga { get; set; }
        public virtual ICollection<Produit> Produits { get; set; }
    }
    //public class GammeDBContext : DbContext
    //{
    //    public DbSet<Produit> Produits { get; set; }
    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
    //    }
    //}
}