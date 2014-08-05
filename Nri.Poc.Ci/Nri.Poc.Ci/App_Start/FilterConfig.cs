using System.Web;
using System.Web.Mvc;

namespace Nri.Poc.Ci
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
