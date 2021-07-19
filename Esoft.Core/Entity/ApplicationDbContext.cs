using Esoft.Core.Entity.Data;
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

		public DbSet<CourseCategory> CourseCategories { get; set; }

	}
}
