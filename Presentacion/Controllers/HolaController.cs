using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class HolaController : Controller
    {
        //
        // GET: /Hola/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult mundo(string hola)
        {
            

            try
            {
                negoHola obj = new negoHola();


                string b = obj.holamundo(hola);


   
                    return Json(new
                    {
                        hola = b


                    });

            }
            catch
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { mensaje = "Ocurrió un error ." });
            }

        }

        
	}
}