using MedidoresDMModels.DAL;
using MedidoresDMModels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresDM
{
    public partial class MostrarLecturas : Page
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

            string medidorSeleccionado = ddlMedidor.SelectedValue;

            List<Lectura> lecturas = LecturasDAL.ObtenerLecturasPorMedidor(medidorSeleccionado);

            gvLecturas.DataSource = lecturas;
            gvLecturas.DataBind();
        }

        private void CargarMedidores()
        {
            List<Medidor> medidores = MedidoresDAL.ObtenerMedidores();

            // Cargar los medidores en el DropDownList
            ddlMedidor.DataSource = medidores;
            ddlMedidor.DataTextField = "NumeroSerie";
            ddlMedidor.DataValueField = "NumeroSerie";
            ddlMedidor.DataBind();
        }
    }
}