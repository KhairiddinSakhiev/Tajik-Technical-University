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

      
        public DbSet<Order> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TeacherCourseRelation>()
                .HasKey(tcr => new {tcr.CourseId, tcr.TeacherId});
            modelBuilder.Entity<TeacherCourseRelation>()
                .HasOne(t => t.Teacher)
                .WithMany(t => t.TeacherCourseRelations)
                .HasForeignKey(t => t.TeacherId);
            modelBuilder.Entity<TeacherCourseRelation>()
                .HasOne(c => c.Course)
                .WithMany(c => c.TeacherCourseRelations)
                .HasForeignKey(c => c.CourseId);
        }
    }
}