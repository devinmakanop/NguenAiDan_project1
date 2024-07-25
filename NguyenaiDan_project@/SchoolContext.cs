using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NguyenaiDan_project2
{
    public  class SchoolContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCore-SchoolDB1;Trusted_Connection=True");
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NguyenaiDan_project2.Student>()
                        
                        .HasOne<StudentAddress>(s => s.Address)
                        .WithOne(sa => sa.Student)
                        .HasForeignKey<StudentAddress>(sa=>sa.StudentAddressId);

            modelBuilder.Entity<StudentAddress>()
                .ToTable("Grades");

            modelBuilder.Entity<Student>()
                .ToTable("Students");
        }

    }
}
