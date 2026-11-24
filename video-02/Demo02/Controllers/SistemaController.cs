
using System.Collections.Generic;
using System.Web.Mvc;
using Demo02.Librerias.EntidadesNegocio;
using Demo02.Librerias.ReglasNegocio;

namespace Demo02.Controllers
{
    public class SistemaController : Controller
    {
        // GET: Sistema
        public ActionResult Consultas()
        {
            return View();
        }

        public JsonResult ListarProductos()
        {
            JsonResult jsonProducto = null;
            brProducto obrProducto = new brProducto();
            List<beProducto> lbeProducto = obrProducto.Listar();
            if (lbeProducto != null)
            {
                jsonProducto = Json(lbeProducto, JsonRequestBehavior.AllowGet);
            }

            return jsonProducto;

        }
        public JsonResult ListarClientes()
        {
            JsonResult jsonCliente = null;
            brCliente obrCliente = new brCliente();
            List<beCliente> lbeCliente = obrCliente.Listar();
            if (lbeCliente != null)
            {
                jsonCliente = Json(lbeCliente, JsonRequestBehavior.AllowGet);
            }

            return jsonCliente;

        }
        public JsonResult ListarProveedores()
        {
            JsonResult jsonProveedor = null;
            brProveedor obrProveedor = new brProveedor();
            List<beProveedor> lbeProveedor = obrProveedor.Listar();
            if (lbeProveedor != null)
            {
                jsonProveedor = Json(lbeProveedor, JsonRequestBehavior.AllowGet);
            }

            return jsonProveedor;

        }
    }
}