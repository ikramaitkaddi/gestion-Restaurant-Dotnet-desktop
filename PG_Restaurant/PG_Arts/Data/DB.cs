using PG_Arts.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG_Arts.Data
{
    internal class DB: DbContext
    {
        public DB ():base("name=myCnx"){ }
      
        public virtual DbSet<Serveur> Serveurs{ get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Plat> Plats { get; set; }
        public virtual DbSet<Affecter> Affectation { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Contient> Contenu { get; set; }
        public virtual DbSet<FactureInter> FactureInter { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
           
            modelBuilder.Entity<Serveur>().ToTable("serveur");
            modelBuilder.Entity<Table>().ToTable("tabl");
            modelBuilder.Entity<Plat>().ToTable("plat");
            modelBuilder.Entity<Affecter>().ToTable("affecter");
            modelBuilder.Entity<Commande>().ToTable("commande");
            modelBuilder.Entity<Contient>().ToTable("contient");
            //modelBuilder.Entity<Affecter>().HasKey(sc => new { sc.num_srv, sc.num_tab });
            //modelBuilder.Entity<Contient>().HasKey(sc => new { sc.num_cmd, sc.code_plat });

           // modelBuilder.Entity<Affecter>().HasKey(sc => new { sc.SId, sc.CId });

            //modelBuilder.Entity<Affecter>().HasOne<Serveur>(sc => sc.Serveur)
            //    .WithMany(s => s.Affecter)
            //    .HasForeignKey(sc => sc.SId);


            //modelBuilder.Entity<StudentCourse>()
            //    .HasOne<Course>(sc => sc.Course)
            //    .WithMany(s => s.StudentCourses)
            //    .HasForeignKey(sc => sc.CId);
        }
    }
}
