using SchoolAppForUcheApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppForUcheApi.Data
{
    public class SecSchoolContext : DbContext
    {
        public SecSchoolContext(DbContextOptions options)
    : base(options)
        {
           
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseLazyLoadingProxies();
            //    optionsBuilder.UseSqlServer(
            //@"Server=.;Database=XPlurAppDb;Trusted_Connection=True;MultipleActiveResultSets=true",
            //x => x.UseNetTopologySuite());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(f => f.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            }
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>().HasData(
              new Role() { Id = 1, Active = true, Name = "Admin" },
               new Role() { Id = 2, Active = true, Name = "Teacher" },
                  new Role() { Id = 3, Active = true, Name = "Parent" }
              );
        }


        public DbSet<Activeterm> Activeterm { get; set; }
        public DbSet<Announcements> Announcement{get;set;}
        public DbSet<Attendance> Attendance{get;set;}
        public DbSet<Chat> Chat { get; set; }
        public DbSet<Chatresponse> Chatresponse { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Classsubgroup> Classsubgroup { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Studentclass> Studentclass { get; set; }
        public DbSet<SubjectAssignment> SubjectAssignment { get; set; }
        public DbSet<Subjects> Subject { get; set; }
        public DbSet<Teacherclass> Teacherclass { get; set; }
        public DbSet<Term> Term { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<AnnouncementMedia> AnnouncementMedia { get; set; }

    }
}
