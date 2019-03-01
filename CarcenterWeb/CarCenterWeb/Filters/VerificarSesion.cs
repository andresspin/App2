using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarCenterWeb.Controllers;
using CarCenterWeb.Models;
using System.Web.Mvc;

namespace CarCenterWeb.Filters
{
    public class VerificarSesion : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //obtener de la sesion los datos de la persona logueada
            var oPersona = (PERSONAS)HttpContext.Current.Session["User"];
            // Si la sesion no existe o no se ha iniciado ........
            if (oPersona == null)
            {
                //si la peticion viene de un controlador diferente a AccesoController, regresamos al usuario
                // a la pantalla de Login
                if(filterContext.Controller is AccesoController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Acceso/Index");

                }



            }
            base.OnActionExecuting(filterContext);
        }
    }
}