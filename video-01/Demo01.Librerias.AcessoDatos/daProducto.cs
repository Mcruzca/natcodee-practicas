using System; //Exception
using System.Collections.Generic; //List
using System.Data; //CommandBehavior CommandType
using System.Data.SqlClient; // SqlCommand, SqlConnection , SqlDataReader 
using System.Configuration; //ConfigurationManager
using Demo01.Librerias.EntidadesNegocio; //beProducto
namespace Demo01.Librerias.AcessoDatos

{
    public class daProducto
    {
        public List <beProducto>  Listar() 
        
        {
            List<beProducto> lbeProducto = null;
        String cadenaConexion= ConfigurationManager.ConnectionStrings["conProvias"].ConnectionString;
        using (SqlConnection con = new SqlConnection(cadenaConexion)) 
        {
                try
                {
                con.Open();
                  SqlCommand cmd = new SqlCommand("uspProductsListar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                  SqlDataReader drd =cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (drd != null) 
                {
                        lbeProducto = new List<beProducto>();
                        beProducto obeProducto;
                        while (drd.Read())
                        {
                            obeProducto = new beProducto();
                            obeProducto.Codigo = drd.GetInt32(0);
                            obeProducto.Nombre = drd.GetString(1);
                            obeProducto.Precio = drd.GetDecimal(2);
                            obeProducto.Stock = Convert.ToInt16(drd.GetValue(3));
                            lbeProducto.Add(obeProducto);

                        }
                        drd.Close();
                    }
                }
                catch (Exception ex)
                {
                Console.WriteLine("Error: " + ex.Message);
                    
                }
        }//con.close(); con.dispose();
        return lbeProducto;
        }
    }
}
