﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.Framework.BaseClass
{
	public class BaseController : ControllerBase
	{
		public const string APIPath = "api/v{version:apiVersion}/[controller]";
		public const string APIV1Number = "1.0";
		public const string APIV2Number = "2.0";
		[NonAction]

		public IActionResult SendResponse(dynamic data, ResponseCodeData code = null)
		{
			if (code == null)
			{
				code = new ResponseCodeData { Message = "Success", Status = 0, HttpStatusCode = StatusCodes.Status200OK };
			}
			return null;
		}


	}
}
