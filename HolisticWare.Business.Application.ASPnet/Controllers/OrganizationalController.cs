using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using global::HolisticWare.Business.BusinessLogicModel.Organizational;

namespace HolisticWare.Business.Application.ASPnet.Controllers
{
	public class OrganizationalController : Controller
	{
		//
		// GET: /Organizational/

		public Employees<int> Employees { get; set; }

		public OrganizationalController()
		{
			this.Employees = new Employees<int>()
			{
				new Employee<int>()
				{
				  NameLast	= "Cvjetko"
				, NameFirst = "Miljenko"
				}
			};

			return;
		}

		public ActionResult Index()
		{
			return View(Employees);
		}

	}
}
