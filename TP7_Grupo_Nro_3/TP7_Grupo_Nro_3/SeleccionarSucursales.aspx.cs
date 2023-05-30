using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TP7_Grupo_Nro_3
{
    public partial class SeleccionarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {             
                cargarListViewSucursales();
                cargarDataListProvincias();
            }
        }

        public void cargarListViewSucursales()
        {
            GestionSucursales gestionSucursales = new GestionSucursales();
            lvSucursales.DataSource = gestionSucursales.obtenerSucursales();
            lvSucursales.DataBind();
        }

        public void cargarDataListProvincias()
        {
            GestionProvincias gestionProvincias = new GestionProvincias();
            dlProvincias.DataSource = gestionProvincias.obtenerProvincias();
            dlProvincias.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String consultaSql;
            consultaSql = "SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal] FROM [Sucursal] WHERE NombreSucursal LIKE '" + txtNombreSucursal.Text + "%'";
            GestionSucursales gestionSucursales = new GestionSucursales();
            lvSucursales.DataSource = gestionSucursales.obtenerSucursalesFiltradas(consultaSql);
            lvSucursales.DataBind();
        }

        protected void btnProvincia_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "EventoProvincia")
            {
                String consultaSql;
                consultaSql = "SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal] FROM [Sucursal] WHERE Id_ProvinciaSucursal = " + e.CommandArgument;
                GestionSucursales gestionSucursales = new GestionSucursales();
                lvSucursales.DataSource = gestionSucursales.obtenerSucursalesFiltradas(consultaSql);
                lvSucursales.DataBind();
            }
        }

        public DataTable crearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn columna = new DataColumn();

            columna = new DataColumn("ID_SUCURSAL", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("NOMBRE", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("DESCRIPCION".ToUpper(), System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            return dt;
        }

        public void agregarFila(DataTable TablaSucursalSeleccion, String s_IdSucusal, String s_Nombre, String s_DescricpionSucursal)
        {
            DataRow dr = TablaSucursalSeleccion.NewRow();
            dr["ID_SUCURSAL".ToUpper()] = s_IdSucusal;
            dr["NOMBRE".ToUpper()] = s_Nombre;
            dr["DESCRIPCION".ToUpper()] = s_DescricpionSucursal;
            TablaSucursalSeleccion.Rows.Add(dr);
        }

        protected void btnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "eventoSeleccionar")
            {
                String s_IdSucusal = e.CommandArgument.ToString().Split('-')[0];
                String s_Nombre = e.CommandArgument.ToString().Split('-')[1];
                String s_DescricpionSucursal = e.CommandArgument.ToString().Split('-')[2];
                if (Session["TablaSucursalSeleccion"] == null)
                {
                    Session["TablaSucursalSeleccion"] = crearTabla();
                }
                agregarFila((DataTable)Session["TablaSucursalSeleccion"], s_IdSucusal, s_Nombre, s_DescricpionSucursal);
            }
        }
    }
}