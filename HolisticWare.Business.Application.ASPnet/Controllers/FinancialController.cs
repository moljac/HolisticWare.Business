using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using global::HolisticWare.Business.BusinessLogicModel.Financial;

namespace HolisticWare.Business.Application.ASPnet.Controllers
{
	public class FinancialController : Controller
	{
		//
		// GET: /Financial/

		public Expenses Expenses { get; set; }

		public FinancialController()
		{
			this.Expenses = new Expenses();

			return;
		}

		public ActionResult Index()
		{
			return View(Expenses);
		}

		public ActionResult ExpensesTravelLocal()
		{
			return View(Expenses);
		}
	}
}
