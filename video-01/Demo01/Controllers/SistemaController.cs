using System;
using System.Collections.Generic; //List
using System.Web.Mvc; // Controller , JSON
using Demo01.Librerias.EntidadesNegocio; //beProducto, beCliente, beProveedor
using Demo01.Librerias.ReglasNegocio; // brProducto, brcliente, brProveedor

namespace Demo01.Controllers
{
    public class SistemaController : Controller
    {
        // GET: Sistema
        public ActionResult Consultas()
        {
            brProducto obrProducto = new brProducto();
            List<beProducto> lbeProducto = obrProducto.Listar();
            brCliente obrCliente = new brCliente();
            List<beCliente> lbeCliente = obrCliente.Listar();
            brProveedor obrProveedor = new brProveedor();
            List<beProveedor> lbeProveedor = obrProveedor.Listar();
            ViewBag.ListaProducto = lbeProducto;
            ViewBag.ListaCliente = lbeCliente;
            ViewBag.ListaProveedor = lbeProveedor;
            return View();
            
        }
 
    }
    
}