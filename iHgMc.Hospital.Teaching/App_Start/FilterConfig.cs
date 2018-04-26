using iHgMc.Hospital.Teaching.Filters;
using System.Web.Mvc;

namespace iHgMc.Hospital.Teaching.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new SystemErrorAttribute());
        }
    }
}