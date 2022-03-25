using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterfazWeb
{
    public partial class FrmCatalogoProgramas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridCatalogo();
        }
        private void cargarGridCatalogo()
        {
            Bd_POODataContext dataContext = new Bd_POODataContext();//Se crea una sentencia simple para sacar los datos de materia
            var consulta = from materia in dataContext.MATERIAS
                           select materia;
            GridCatalogo.DataSource = consulta;
            GridCatalogo.DataBind();
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            Bd_POODataContext dataContext = new Bd_POODataContext();//Se crea una sentencia simple para sacar los datos de materia pero esta vez con un where
            var consulta = from materia in dataContext.MATERIAS
                           where materia.NOMBRE_MATERIA == txtBuscar.Text                           
                           select materia ;
            GridCatalogo.DataSource = consulta;
            GridCatalogo.DataBind();
        }

        protected void LnkSelect_Command(object sender, CommandEventArgs e)
        {
            Session["COD_MATERIA"] = e.CommandArgument.ToString();//Le asignamos un valor a la variable de session COD_MATERIA y lo enviamos a FrmAbrirMaterias.aspx
            Session["NUM"] = 1;
            Response.Redirect("FrmAbrirMateria.aspx");
        }
    }
}