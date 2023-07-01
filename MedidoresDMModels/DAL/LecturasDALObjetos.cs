using MedidoresDMModels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDMModels.DAL
{
    public class LecturaDALObjetos : ILecturasDAL
    {
        private static List<Lectura> listaLecturas = new List<Lectura>();

        public List<Lectura> ObtenerLecturas()
        {
            return listaLecturas;
        }

        public void AgregarLectura(Lectura lectura)
        {
            listaLecturas.Add(lectura);
        }
    }

