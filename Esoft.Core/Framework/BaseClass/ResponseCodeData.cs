using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.Framework.BaseClass
{
	public class ResponseCodeData
	{
		public string Message { get; set; }
		public int Status { get; set; }
		public int HttpStatusCode { get; set; } = StatusCodes.Status200OK;
	}
}
