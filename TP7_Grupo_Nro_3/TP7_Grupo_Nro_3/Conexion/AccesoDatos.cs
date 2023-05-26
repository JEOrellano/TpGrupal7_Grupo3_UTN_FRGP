using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TP7_Grupo_Nro_3
{
    public class AccesoDatos
    {
        private static String rutaBDSucursales = "Data Source=localhost\\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";
        public AccesoDatos()
        {

        }
        public SqlConnection obtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDSucursales);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public SqlDataAdapter obtenerAdaptador(String consultaSql)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, obtenerConexion());
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}