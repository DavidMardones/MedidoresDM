using MedidoresDMModels.DAL;
using MedidoresDMModels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class MedidoresDALObjetos : IMedidoresDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();

        public static List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }

        public static void AgregarMedidor(Medidor medidor)
        {
            medidores.Add(medidor);
        }
    }