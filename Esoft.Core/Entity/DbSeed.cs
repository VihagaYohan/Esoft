using Esoft.Core.Entity.Data.CourseModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.Entity
{
	public class DbSeed
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
				if (!context.CourseRequirements.Any())
				{
					var courses = new List<Course>()
					{
						new Course()
						{
							//CourseId=1,
							CourseName="Course 1",
							Description = "Description 1",
							CourseCategoryId=1
						},
						new Course()
						{
							//CourseId=2,
							CourseName="Course 2",
							Description = "Description 2",
							CourseCategoryId=2
						},
						new Course()
						{
							//CourseId=3,
							CourseName="Course 3",
							Description = "Description 3",
							CourseCategoryId=3
						},
					};
					//context.Courses.AddRange(courses);
					// course requriement list
					//var requirementList = new List<CourseRequirement>()
					//{
					//	new CourseRequirement()
					//	{
					//		//Id=1,
					//		Requirement="Requirement 1",
					//		CourseId = 1
					//	},
					//	new CourseRequirement()
					//	{
					//		//Id=2,
					//		Requirement = "Requirement 2",
					//		CourseId = 1
					//	},
					//	new CourseRequirement()
					//	{
					//		//Id=3,
					//		Requirement="Requirement 1",
					//		CourseId = 2
					//	},
					//	new CourseRequirement()
					//	{
					//		//Id=4,
					//		Requirement = "Requirement 2",
					//		CourseId = 2
					//	}
					//};

					//context.CourseRequirements.AddRange(requirementList);

					// course content list
					//var courseContent = new List<CourseStructure>()
					//{
					//	new CourseStructure()
					//	{
					//		//Id=1,
					//		Lesson = "Lesson 1",
					//		CourseId = 1
					//	},
					//	new CourseStructure()
					//	{
					//		//Id=2,
					//		Lesson = "Lesson 2",
					//		CourseId = 1
					//	},
					//	new CourseStructure()
					//	{
					//		//Id=3,
					//		Lesson = "Lesson 3",
					//		CourseId = 1
					//	},
					//	new CourseStructure()
					//	{
					//		//Id=4,
					//		Lesson = "Lesson 1",
					//		CourseId = 2
					//	},
					//	new CourseStructure()
					//	{
					//		//Id=5,
					//		Lesson = "Lesson 2",
					//		CourseId = 2
					//	},
					//};
					//context.CourseStructures.AddRange(courseContent);

					// course list


					// course category list
					//var courseCategory = new List<CourseCategory>()
					//{
					//	new CourseCategory()
					//	{
					//		Id=1,
					//		CategoryName = "Category 1"
					//	},
					//	new CourseCategory()
					//	{
					//		Id=2,
					//		CategoryName = "Category 2"
					//	},
					//	new CourseCategory()
					//	{
					//		Id=3,
					//		CategoryName = "Category 3"
					//	}
					//};
					//context.CourseCategories.AddRange(courseCategory);

					context.SaveChanges();
				}
			}
		}
	}
}
