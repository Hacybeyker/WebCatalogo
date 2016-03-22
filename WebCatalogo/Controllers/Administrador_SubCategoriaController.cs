using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo.c2_aplicacion;
using Modelo.c3_dominio.entidad;

namespace WebCatalogo.Controllers
{
    public class Administrador_SubCategoriaController : Controller
    {
        GestionarSubCategoriaServicio gestionarSubCategoriaServicio = new GestionarSubCategoriaServicio();
        // GET: Administrador_SubCategoria
        public ActionResult Index()
        {
            return View(gestionarSubCategoriaServicio.listarCategorias());
        }

        public ActionResult Crear()
        {
            return View();
        }
    }
}