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
    public class User
    {
        [Required]
        [Key]
        [Display(Name = "Matricule :")]
        public string Matricule { get; set; }

        [Required]
        [Display(Name = "Nom :")]
        public string Nom_User { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} doit avoir au minimum {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe :")]
        public string passWord { get; set; }



        [Required]
        [ForeignKey("Account")]
        [Display(Name = "Type :")]
        public string Type_User { get; set; }

        [Required]
        [ForeignKey("UF")]
        [Display(Name = "ID UF :")]
        public string ID_UF { get; set; }

        public virtual Account Account { get; set; }
        public virtual UF UF { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }

    //public class GammeDBContext : DbContext
    //{
    //    public DbSet<User> Users { get; set; }
    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
    //    }

    //}
    
}