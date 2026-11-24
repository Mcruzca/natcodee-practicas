using System.Collections.Generic; //Listas
using Demo02.Librerias.EntidadesNegocio; //beCliente
using Demo02.Librerias.AcessoDatos; //daCliente

namespace Demo02.Librerias.ReglasNegocio
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
