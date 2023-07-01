using MedidoresDMModels.DAL;
using MedidoresDMModels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresDM
{
    public partial class IngresarMedidor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTiposMedidor();
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string nombreTitular = nombreTxt.Text;
            string numeroMedidor = rutTxt.Text;
            string tipoMedidor = bebidaDdl.SelectedValue;
            int tipoUsuario = Convert.ToInt32(nivelRbl.SelectedValue);

            // Realizar las validaciones necesarias
            if (string.IsNullOrEmpty(nombreTitular) || string.IsNullOrEmpty(numeroMedidor) || string.IsNullOrEmpty(tipoMedidor))
            {
                mensajesLbl.Text = "Todos los campos son requeridos";
                mensajesLbl.CssClass = "text-danger";
                return;
            }

            // Aquí puedes agregar la lógica para guardar el medidor en la capa DAL

            // Redireccionar a la página MostrarMedidores
            Response.Redirect("MostrarMedidores.aspx");
        }

        private void CargarTiposMedidor()
        {
            // Aquí puedes agregar la lógica para obtener los tipos de medidor desde la capa DAL
            // y cargarlos en el DropDownList bebidaDdl
            List<string> tiposMedidor = new List<string>()
            {
                "PowerMonitor 1000",
                "PowerMonitor 3000",
                "Monofásico",
                "Trifásico"
            };

            bebidaDdl.DataSource = tiposMedidor;
            bebidaDdl.DataBind();
        }
    }
}