using System.Web;
using System.Web.Mvc;

namespace P2_2019AM606_2019LD601
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
