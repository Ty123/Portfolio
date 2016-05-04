using System.Web;
using System.Web.Mvc;

namespace Portfolio4.TyLy.Co.Nz
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
