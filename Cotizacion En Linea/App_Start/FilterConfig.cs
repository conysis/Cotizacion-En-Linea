using System.Web;
using System.Web.Mvc;

namespace Cotizacion_En_Linea
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
