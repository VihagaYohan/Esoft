using Esoft.Core.Entity.Data.CourseModels;
using Esoft.Core.Framework.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.Entity.Data
{
	public class Student:BaseEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int StudentId { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }

		// navigation properties
		public ICollection<Course> Courses { get; set; }
	}
}
