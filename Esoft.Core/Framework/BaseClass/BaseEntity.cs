using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.Framework.BaseClass
{
	public class BaseEntity
	{
		public DateTime? DeleteAt { get; set; }

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
	}
}
