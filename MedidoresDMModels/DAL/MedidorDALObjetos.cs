using MedidoresDMModels.DAL;
using MedidoresDMModels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MedidoresDALObjetos : IMedidorDAL
{
    private List<Medidor> medidores = new List<Medidor>();

    public List<Medidor> ObtenerMedidores()
    {
        return medidores;
    }

    public void AgregarMedidor(Medidor medidor)
    {
        medidores.Add(medidor);
    }

    public bool ExisteMedidor(string numeroSerie)
    {
        return medidores.Exists(m => m.NumeroSerie == numeroSerie);
    }
}
