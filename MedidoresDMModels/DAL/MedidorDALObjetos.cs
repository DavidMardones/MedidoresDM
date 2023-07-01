using MedidoresDMModels.DAL;
using MedidoresDMModels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MedidorDALObjetos : IMedidorDAL
{
    private static List<Medidor> listaMedidores = new List<Medidor>();

    public List<Medidor> ObtenerMedidores()
    {
        return listaMedidores;
    }

    public void AgregarMedidor(Medidor medidor)
    {
        listaMedidores.Add(medidor);
    }
}