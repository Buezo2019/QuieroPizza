using quieropizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quieropizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {

            var producto1 = new ProductoModel();
            producto1.ID = 1;
            producto1.Descripcion = "Pizza 6 quesos";

            var producto2 = new ProductoModel();
            producto2.ID = 2;
            producto2.Descripcion = "Pizza 4 estaciones";

            var producto3 = new ProductoModel();
            producto3.ID = 3;
            producto3.Descripcion = "Pizza Orilla de Queso";

            var producto4 = new ProductoModel();
            producto4.ID = 4;
            producto4.Descripcion = "Pizza Suprema";



            var listadoproductos = new List<ProductoModel>();
            listadoproductos.Add(producto1);
            listadoproductos.Add(producto2);
            listadoproductos.Add(producto3);
            listadoproductos.Add(producto4);
            return View(listadoproductos);




        }
    }
}