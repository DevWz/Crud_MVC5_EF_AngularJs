using System.Web;
using System.Web.Mvc;

namespace Crud_MVC5_EF_AngularJs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
