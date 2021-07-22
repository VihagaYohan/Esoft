using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.ApiInputModels.CoursesModels
{
	public class CourseRequirementDto
	{
		[Required(AllowEmptyStrings =false)]
		public string Requirement { get; set; }
		[Required]
		public int  CourseId { get; set; }
	}
}
