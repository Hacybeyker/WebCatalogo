using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo.c2_aplicacion;
using Modelo.c3_dominio.entidad;

namespace WebCatalogo.Controllers
{
    public class Administrador_CategoriaController : Controller
    {
        GestionarCategoriaServicio gestionarCategoriaServicio = new GestionarCategoriaServicio();
        // GET: Categoria
        public ActionResult Index()
        {
            return View(gestionarCategoriaServicio.listarCategorias());
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear([Bind(Include = "nombrecategoria")] Categoria categoria)
        {
            gestionarCategoriaServicio.crearCategoria(categoria);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int codigo)
        {
            return View(gestionarCategoriaServicio.buscarCategoria(codigo));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "codigocategoria,nombrecategoria")] Categoria categoria)
        {
            gestionarCategoriaServicio.editarCategoria(categoria);
            return RedirectToAction("Index");
        }

        public ActionResult Eliminar(int codigo)
        {
            gestionarCategoriaServicio.eliminarCategoria(new Categoria(codigo));
            return RedirectToAction("Index");
        }
    }
}