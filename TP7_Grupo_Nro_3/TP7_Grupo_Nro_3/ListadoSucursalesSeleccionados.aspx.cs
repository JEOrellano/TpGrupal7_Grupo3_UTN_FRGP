using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP7_Grupo_Nro_3
{
    public partial class ListadoSucursalesSeleccionados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TablaSucursalSeleccion"] != null)
            {
                grdSucursales.DataSource = (DataTable)Session["TablaSucursalSeleccion"];
                grdSucursales.DataBind();
            }
        }
    }
}