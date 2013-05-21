using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using MvcApplication2.ViewModels;

namespace MvcApplication2.Models
{
    public class GammeContext : DbContext
    {
        public GammeContext()
        {

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<GammeContext>());

        }

        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Ns_AFaire> Ns_AFaires { get; set; }
        public DbSet<Famille> Familles { get; set; }
        public DbSet<Fonction> Fonctions { get; set; }
        public DbSet<Fonction_Poste> Fonction_Postes { get; set; }
        public DbSet<Gamme> Gammes { get; set; }
        public DbSet<Historique> Historiques { get; set; }
        public DbSet<Ligne> Lignes { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Poste> Postes { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Profile_Ga> Profil_Gas { get; set; }
        public DbSet<Sous_Famille> Sous_Familles { get; set; }
        public DbSet<UF> UFs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Num_Serie> Num_Series { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }

        public DbSet<FlowViewModel> FlowViewModels { get; set; }

        
    }
}