using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.Framework.BaseClass
{
	public class ResponseCodes
	{
		public static ResponseCodeData Success { get; } = new ResponseCodeData
		{
			Message = "Success",
			Status = 0
		};

		public static ResponseCodeData BadData { get; } = new ResponseCodeData
		{
			Message = "Bad Data",
			Status = 1,
			HttpStatusCode = StatusCodes.Status400BadRequest
		};

		public static ResponseCodeData InternalServerError { get; } = new ResponseCodeData
		{
			Message = "Ineternal Server Error",
			Status = 2,
			HttpStatusCode = StatusCodes.Status500InternalServerError
		};

		public static ResponseCodeData NotFound { get; } = new ResponseCodeData
		{
			Message = "Record not found",
			Status = 3,
			HttpStatusCode = StatusCodes.Status404NotFound
		};
	}
}
