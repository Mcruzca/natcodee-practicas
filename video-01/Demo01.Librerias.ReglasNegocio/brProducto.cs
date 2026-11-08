using System.Collections.Generic; //Listas
using Demo01.Librerias.EntidadesNegocio; //beProducto
using Demo01.Librerias.AcessoDatos; //daProducto

namespace Demo01.Librerias.ReglasNegocio
{
    public class brProducto
    {
        public List<beProducto> Listar()
        {
            List<beProducto> lbeProducto = null;
            daProducto odaProducto=new daProducto   ();
            lbeProducto=odaProducto.Listar();
            return lbeProducto;
        }
    }
}
