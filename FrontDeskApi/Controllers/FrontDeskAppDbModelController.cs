using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FrontDeskApi.Controllers
{
	public class FrontDeskAppDbModelController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
