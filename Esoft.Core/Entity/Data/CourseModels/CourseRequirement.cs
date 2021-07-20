using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.Entity.Data.CourseModels
{
	public class CourseRequirement
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Requirement { get; set; }

		// navigation properties
		public int CourseId { get; set; }
		public Course Course { get; set; }
	}
}
