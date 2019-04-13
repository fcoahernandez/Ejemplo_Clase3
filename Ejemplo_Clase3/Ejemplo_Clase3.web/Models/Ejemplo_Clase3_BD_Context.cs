namespace Ejemplo_Clase3.web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Ejemplo_Clase3_BD_Context : DbContext
    {
        public Ejemplo_Clase3_BD_Context()
            : base("name=cnx_Ejemplo_Clase3_BD_Context")
        {
        }

        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<Proyectos> Proyectos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Personas>()
                .HasMany(e => e.Proyectos)
                .WithRequired(e => e.Personas)
                .HasForeignKey(e => e.GerenteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Personas>()
                .HasMany(e => e.Proyectos1)
                .WithRequired(e => e.Personas1)
                .HasForeignKey(e => e.SupervisorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proyectos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
