using MedidoresDMModels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDMModels.DAL
{
    public class LecturasDALObjetos : ILecturasDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();

        public List<Lectura> ObtenerLecturas(string numeroSerie)
        {

            var lecturasFiltradas = new List<Lectura>();


            var todasLasLecturas = LecturasDALObjetos.lecturas;


            foreach (var lectura in todasLasLecturas)
            {
                if (lectura.Medidor != null && lectura.Medidor.NumeroSerie == numeroSerie)
                {
                    lecturasFiltradas.Add(lectura);
                }
            }

            return lecturasFiltradas;
        }

        public List<Lectura> ObtenerLecturasPorMedidor(string numeroSerie)
        {
            return lecturas.FindAll(l => l.MedidorNumeroSerie == numeroSerie);
        }


        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);
        }
    }
}
