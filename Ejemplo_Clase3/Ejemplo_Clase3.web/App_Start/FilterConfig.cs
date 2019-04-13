using System.Web;
using System.Web.Mvc;

namespace Ejemplo_Clase3.web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
