using MedidoresDMModels.DAL;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace MedidoresDM
{
    public partial class MostrarLecturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarMedidores();
                CargarLecturas();
            }
        }

        private void CargarMedidores()
        {

            MedidoresDALObjetos medidoresDAL = new MedidoresDALObjetos();


            var medidores = medidoresDAL.ObtenerMedidores();


            ddlMedidores.DataSource = medidores;
            ddlMedidores.DataTextField = "NumeroSerie";
            ddlMedidores.DataValueField = "NumeroSerie";
            ddlMedidores.DataBind();
        }

        private void CargarLecturas()
        {

            string numeroSerie = ddlMedidores.SelectedValue;

            LecturasDALObjetos lecturasDAL = new LecturasDALObjetos();


            var lecturas = lecturasDAL.ObtenerLecturas(numeroSerie);

            // Mostrar las lecturas en el GridView
            gvLecturas.DataSource = lecturas;
            gvLecturas.DataBind();
        }

        protected void ddlMedidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarLecturas();
        }
    }
}
