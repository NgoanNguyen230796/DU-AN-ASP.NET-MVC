using System.Web;
using System.Web.Mvc;

namespace Truyen_du_lieu_băng_model
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
