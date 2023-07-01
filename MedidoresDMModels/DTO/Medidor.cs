using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDMModels.DTO
{
    public class Medidor
    {
        private string numeroSerie;
        private string tipo;

        public string NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }

}
