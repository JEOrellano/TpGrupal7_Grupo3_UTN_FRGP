using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP7_Grupo_Nro_3
{
    public class GestionSucursales
    {
        public GestionSucursales()
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
        public DataTable obtenerSucursales()
        {
            String nombreTabla = "Sucursal";
            String consultaSQL = "SELECT * FROM Sucursal";
            return obtenerTabla(nombreTabla, consultaSQL);
        }
        public DataTable obtenerSucursalesFiltradas(String consultaSql)
        {
            String nombreTabla = "Sucursal";
            return obtenerTabla(nombreTabla, consultaSql);
        }
    }
}