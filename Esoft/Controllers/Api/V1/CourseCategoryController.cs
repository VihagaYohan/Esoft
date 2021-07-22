using Esoft.Core.ApiInputModels.CoursesModels;
using Esoft.Core.BusinessLogic.Interface;
using Esoft.Core.Framework.BaseClass;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esoft.Controllers.Api.V1
{
	[Route("api/[controller]")]
	[ApiController]
	public class CourseCategoryController : BaseController
	{
		private readonly ICourseCategoryService _service;

		public CourseCategoryController(ICourseCategoryService service)
		{
			_service = service;
		}

		[HttpPost("create-category")]
		public async Task<IActionResult> NewCourseCategory([FromBody] CourseCategoryDto model) 
		{
			var result = await _service.AddCourseCategory(model);
			return SendResponse(result.Item2, result.Item3);
		}
	}
}
