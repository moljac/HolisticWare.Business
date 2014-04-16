using System.Web;
using System.Web.Mvc;

namespace HolisticWare.Business.Application
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}