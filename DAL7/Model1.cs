using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL7
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=organisation")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<contract> contracts { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<participation> participations { get; set; }
        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<specialty> specialties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<contract>()
                .Property(e => e.cost)
                .HasPrecision(12, 2);

            modelBuilder.Entity<contract>()
                .HasMany(e => e.projects)
                .WithRequired(e => e.contract)
                .HasForeignKey(e => e.contract_code_FK);

            modelBuilder.Entity<department>()
                .HasMany(e => e.employees)
                .WithRequired(e => e.department)
                .HasForeignKey(e => e.department_code_FK2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.contracts)
                .WithRequired(e => e.employee)
                .HasForeignKey(e => e.leader_code_FK);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.participations)
                .WithRequired(e => e.employee)
                .HasForeignKey(e => e.employee_id_FK1);

            modelBuilder.Entity<project>()
                .Property(e => e.cost)
                .HasPrecision(12, 2);

            modelBuilder.Entity<project>()
                .HasMany(e => e.participations)
                .WithRequired(e => e.project)
                .HasForeignKey(e => e.project_code_FK2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<specialty>()
                .HasMany(e => e.employees)
                .WithRequired(e => e.specialty)
                .HasForeignKey(e => e.specialty_code_FK1);
        }
    }
}
