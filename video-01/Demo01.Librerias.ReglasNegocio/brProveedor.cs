using System.Collections.Generic; //Listas
using Demo01.Librerias.EntidadesNegocio; //beProveedor
using Demo01.Librerias.AcessoDatos; //daProveedor

namespace Demo01.Librerias.ReglasNegocio
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
