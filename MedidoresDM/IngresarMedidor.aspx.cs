using MedidoresDMModels.DTO;
using MedidoresDMModels.DAL;
using System;
using System.Web.UI;

namespace MedidoresDM
{
    public partial class IngresarMedidor : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string numeroSerie = txtNumeroSerie.Text;

                Medidor medidor = new Medidor
                {
                    NumeroSerie = numeroSerie,

                };


                MedidoresDALObjetos medidoresDAL = new MedidoresDALObjetos();


                medidoresDAL.AgregarMedidor(medidor);


                Response.Redirect("MostrarMedidores.aspx");
            }
        }
    }
}