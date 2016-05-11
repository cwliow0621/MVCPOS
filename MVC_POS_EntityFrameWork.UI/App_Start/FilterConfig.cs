using System.Web;
using System.Web.Mvc;

namespace MVC_POS_EntityFrameWork.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
