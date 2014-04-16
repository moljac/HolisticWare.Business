using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HolisticWare.Business.BusinessLogicModel
{
	using HolisticWare.Business.BusinessLogicModel;

	public partial class ApplicationData
	{
		public Organizational.Employees<int>	Employees { get; set; }
		public Financial.Expenses				Expenses { get; set; }


		static ApplicationData()
		{
			Data.Employees =  new Organizational.Employees<int>();
			Data.Expenses	= new Financial.Expenses();
		}

		public static ApplicationData Data = null;
	}
}
