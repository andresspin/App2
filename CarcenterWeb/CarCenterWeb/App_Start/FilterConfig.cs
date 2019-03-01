using System.Web;
using System.Web.Mvc;

namespace CarCenterWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //habilitar el filtro para cada submit en la aplicacion
            filters.Add(new Filters.VerificarSesion());
        }
    }
}
