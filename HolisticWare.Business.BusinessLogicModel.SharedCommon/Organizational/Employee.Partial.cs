﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolisticWare.Business.BusinessLogicModel.Organizational
{
	public partial class Employee<TypeIdentifier>
	{
		public Financial.Expenses Expenses { get; set; }
	}
}