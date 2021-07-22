using Esoft.Core.ApiInputModels.CoursesModels;
using Esoft.Core.BusinessLogic.Interface;
using Esoft.Core.Entity;
using Esoft.Core.Entity.Data.CourseModels;
using Esoft.Core.Framework.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.BusinessLogic.Service
{
	public class CategoryService : ICourseCategoryService
	{
		private readonly ApplicationDbContext _context;
		public CategoryService(ApplicationDbContext context)
		{
			_context = context;
		}

		// add course category
		public async Task<Tuple<bool, object, ResponseCodeData>> AddCourseCategory(CourseCategoryDto model)
		{
			try
			{
				var courseCategory = new CourseCategory();
				courseCategory.CategoryName = model.CourseCategory;

				var result = await _context.CourseCategories.AddAsync(courseCategory);
				_context.SaveChanges();

				return new Tuple<bool, object, ResponseCodeData>(true, ResponseCodes.Success.Message, ResponseCodes.Success);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		// update course category
		public async Task<Tuple<bool, object, ResponseCodeData>> UpdateCourseCategory(int id, CourseCategoryDto model) 
		{
			try
			{
				var course =  _context.CourseCategories.FirstOrDefault(c => c.Id == id);
				if (course != null) 
				{
					course.CategoryName = model.CourseCategory;

					_context.SaveChanges();
				}
				return new Tuple<bool, object, ResponseCodeData>(true,ResponseCodes.Success.Message,ResponseCodes.Success);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
