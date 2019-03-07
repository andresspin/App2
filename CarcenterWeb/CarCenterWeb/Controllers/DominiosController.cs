using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarCenterWeb.Models;
using CarCenterWeb.Models.DTOs;

namespace CarCenterWeb.Controllers
{
    public class DominiosController : Controller
    {
        // GET: Dominios
        public ActionResult Index()
        {

            List<DominiosDTO> lstDominios = null;
            using (carcenterEntities db = new carcenterEntities())
            {
                lstDominios = (from d in db.DOMINIOS
                               orderby d.ID_DOMINIO ascending
                               select new DominiosDTO
                               {
                                   IdDominio = d.ID_DOMINIO,
                                   TipoDominio = d.TIPO_DOMINIO,
                                   VlrDominio = d.VLR_DOMINIO


                               }).ToList();


            }


            
                return View(lstDominios);
            }
        }
    }
