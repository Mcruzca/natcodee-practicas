using System.Collections.Generic; //Listas
using Demo02.Librerias.EntidadesNegocio; //beProducto
using Demo02.Librerias.AcessoDatos; //daProducto

namespace Demo02.Librerias.ReglasNegocio
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
