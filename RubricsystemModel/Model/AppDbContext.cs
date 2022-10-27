using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<TestClass> testClasses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<MarksClass> marksClasses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Rubric> Rubrics { get; set; }
        public DbSet<EvaluatieTask> EvaluatieTasks { get; set; }
        public DbSet<Paper> Papers { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    //modelBuilder.seed();
        //}
    }
    
}
