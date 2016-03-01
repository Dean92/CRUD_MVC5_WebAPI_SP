using System.Web;
using System.Web.Mvc;

namespace CRUD_MVC5_WebAPI_SP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
