using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class AttendanceDbContext : DbContext
    {
        private readonly string _connectionString;

        public AttendanceDbContext()
        {
            _connectionString = "Server=ASUSEXPARTBOOK\\SQLEXPRESS;Database=CSharpB17;User Id=csharpb17;Password=123456;Trust Server Certificate=True";
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Schedule>().ToTable("Schedules");
            modelBuilder.Entity<Attendance>().ToTable("Attendances");

            modelBuilder.Entity<Admin>().HasData(
                new Admin { Id = 1, Name = "Admin", Username = "admin", Password = "admin" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
