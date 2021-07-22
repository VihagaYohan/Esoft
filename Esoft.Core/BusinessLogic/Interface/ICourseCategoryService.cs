using Esoft.Core.ApiInputModels.CoursesModels;
using Esoft.Core.Framework.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.BusinessLogic.Interface
{
	public interface ICourseCategoryService
	{
		Task<Tuple<bool, object, ResponseCodeData>> AddCourseCategory(CourseCategoryDto model);

		Task<Tuple<bool, object, ResponseCodeData>> UpdateCourseCategory(int id, CourseCategoryDto model);
	}
}
