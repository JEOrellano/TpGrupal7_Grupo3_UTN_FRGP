using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP7_Grupo_Nro_3
{
    public class GestionProvincias
    {
        public GestionProvincias()
        {

        }
        private DataTable obtenerTabla(String nombre, String consultaSql)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adp = datos.obtenerAdaptador(consultaSql);
            adp.Fill(ds, nombre);
            return ds.Tables[nombre];
        }
        public DataTable obtenerProvincias()
        {
            String nombreTabla = "Provincia";
            String consultaSQL = "SELECT * FROM Provincia";
            return obtenerTabla(nombreTabla, consultaSQL);
        }
    }
}