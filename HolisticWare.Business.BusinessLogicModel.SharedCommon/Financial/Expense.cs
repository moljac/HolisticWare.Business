using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolisticWare.Business.BusinessLogicModel.Financial
{
	public partial class Expense
	{
		public decimal Amount { get; set; }
		public DateTime Timestamp { get; set; }
		public string Description { get; set; }
	}
}
