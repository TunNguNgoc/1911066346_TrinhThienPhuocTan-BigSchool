using System.Web;
using System.Web.Mvc;

namespace _1911066346_TrinhThienPhuocTan_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
