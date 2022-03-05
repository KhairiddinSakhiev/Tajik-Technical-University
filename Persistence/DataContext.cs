using System;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.SeedVersion;

namespace Persistence
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            Database.Migrate();
            this.SeedV1();
        }

      
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; } 
        public DbSet<Load> Loads { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Many to many relation teacher with course
            modelBuilder.Entity<LoadCourseRelation>()
                .HasKey(tcr => new {tcr.CourseId, tcr.LoadId});
            modelBuilder.Entity<LoadCourseRelation>()
                .HasOne(l => l.Load)
                .WithMany(l => l.LoadCourseRelations)
                .HasForeignKey(l => l.CourseId);
            modelBuilder.Entity<LoadCourseRelation>()
                .HasOne(c => c.Course)
                .WithMany(c => c.LoadCourseRelations)
                .HasForeignKey(c => c.LoadId);
            //Many to Many Relation Table Teacher with Load
            modelBuilder.Entity<TeacherLoadRelation>()
                .HasKey(tlr => new { tlr.LoadId, tlr.TeacherId });
            modelBuilder.Entity<TeacherLoadRelation>()
                .HasOne(tl => tl.Load)
                .WithMany(tlr => tlr.TeacherLoadRelations)
                .HasForeignKey(t => t.TeacherId);
            modelBuilder.Entity<TeacherLoadRelation>()
                .HasOne(tl => tl.Teacher)
                .WithMany(tlr=>tlr.TeacherLoadRelations)
                .HasForeignKey(tl=>tl.LoadId);
        }
    }
}