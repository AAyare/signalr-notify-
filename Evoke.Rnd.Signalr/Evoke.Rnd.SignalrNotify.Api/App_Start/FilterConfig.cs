using System.Web;
using System.Web.Mvc;

namespace Evoke.Rnd.SignalrNotify.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}