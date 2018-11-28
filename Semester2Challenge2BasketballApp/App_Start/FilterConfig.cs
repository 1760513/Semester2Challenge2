using System.Web;
using System.Web.Mvc;

namespace Semester2Challenge2BasketballApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
