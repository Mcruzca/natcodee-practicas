using System.Collections.Generic; //Listas
using Demo02.Librerias.EntidadesNegocio; //beProveedor
using Demo02.Librerias.AcessoDatos; //daProveedor

namespace Demo02.Librerias.ReglasNegocio
{
    public class brProveedor
    {
        public List<beProveedor> Listar()
        {
            List<beProveedor> lbeProveedor = null;
            daProveedor odaProveedor = new daProveedor();
            lbeProveedor = odaProveedor.Listar();
            return lbeProveedor;
        }
    }
}
