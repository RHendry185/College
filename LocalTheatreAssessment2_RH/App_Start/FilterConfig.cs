using System.Web;
using System.Web.Mvc;

namespace LocalTheatreAssessment2_RH
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
