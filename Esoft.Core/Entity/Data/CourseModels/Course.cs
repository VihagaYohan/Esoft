using Esoft.Core.Framework.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.Entity.Data.CourseModels
{
	public class Course:BaseEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string CourseName { get; set; }
		public string Description { get; set; }
		public ICollection<CourseRequirement> CourseRequirements { get; set; }
		public ICollection<CourseStructure> CourseStructure { get; set; }
		public ICollection<Student> Students { get; set; }

		// navigation properties
		public int CourseCategoryId { get; set; }
		public virtual CourseCategory CourseCategory { get; set; }
	}
}
