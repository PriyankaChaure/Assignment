using System.Web;
using System.Web.Mvc;

namespace ViewBag_ViewData_TempData_Exam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
