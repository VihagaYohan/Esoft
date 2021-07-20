using Esoft.Core.Entity.Data;
using Esoft.Core.Entity.Data.CourseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.Entity
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
		{
			
		}

		public DbSet<Course> Courses { get; set; }
		public DbSet<CourseCategory> CourseCategories { get; set; }
		public DbSet<CourseRequirement> CourseRequirements { get; set; }
		public DbSet<CourseStructure> CourseStructures { get; set; }

		public DbSet<Student> Students { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// course entity
			modelBuilder.Entity<Course>()
				.HasOne<CourseCategory>(cc => cc.CourseCategory)
				.WithMany(c => c.Courses)
				.HasForeignKey(c => c.CourseCategoryId);

			// course requirement entity
			modelBuilder.Entity<CourseRequirement>()
				.HasOne<Course>(c => c.Course)
				.WithMany(c => c.CourseRequirements)
				.HasForeignKey(c => c.CourseId);

			// course structure entity
			modelBuilder.Entity<CourseStructure>()
				.HasOne<Course>(c => c.Course)
				.WithMany(c => c.CourseStructure)
				.HasForeignKey(c => c.CourseId);

			// student entity
			//modelBuilder.Entity<Student>()
			//	.HasMany(s => s.Courses)
			//	.WithMany(c => c.Students)
			//	.Map(sc =>
			//	{
			//		sc.MapLeftKey("StudentId");
			//		sc.MapRightKey("CourseId");
			//		sc.ToTable("Student_Course");
			//	});
				
				
		}

	}
}
