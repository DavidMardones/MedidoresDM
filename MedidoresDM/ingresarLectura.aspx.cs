using MedidoresDMModels.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresDM
{
    public partial class IngresarLectura : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarMedidores();
            }
        }

        protected void ddlMedidor_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                string medidorSeleccionado = ddlMedidor.SelectedValue;
                DateTime fechaLectura = calFecha.SelectedDate;
                int hora = Convert.ToInt32(txtHora.Text);
                int minutos = Convert.ToInt32(txtMinutos.Text);
                int consumo = Convert.ToInt32(txtConsumo.Text);

                LecturasDALObjetos.AgregarLectura(medidorSeleccionado, fechaLectura, hora, minutos, consumo);

                Response.Redirect("MostrarLecturas.aspx");
            }
        }

        private void CargarMedidores()
        {

            var medidores = MedidoresDALObjetos.ObtenerMedidores();


            ddlMedidor.DataSource = medidores;
            ddlMedidor.DataTextField = "NumeroSerie";
            ddlMedidor.DataValueField = "NumeroSerie";
            ddlMedidor.DataBind();
        }
    }
}