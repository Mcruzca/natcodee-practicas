using System.Collections.Generic; //Listas
using Demo01.Librerias.EntidadesNegocio; //beCliente
using Demo01.Librerias.AcessoDatos; //daCliente

namespace Demo01.Librerias.ReglasNegocio
{
    public class brCliente
    {
        public List<beCliente> Listar()
        {
            List<beCliente> lbeCliente = null;
            daCliente odaCliente = new daCliente();
            lbeCliente = odaCliente.Listar();
            return lbeCliente;
        }
    }
}
