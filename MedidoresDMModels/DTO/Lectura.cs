using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDMModels.DTO
{
    public class Lectura
    {
        private string medidor;
        private DateTime fechaLectura;
        private int horaLectura;
        private int minutosLectura;
        private int valorConsumo;

        public string Medidor { get => medidor; set => medidor = value; }
        public DateTime FechaLectura { get => fechaLectura; set => fechaLectura = value; }
        public int HoraLectura { get => horaLectura; set => horaLectura = value; }
        public int MinutosLectura { get => minutosLectura; set => minutosLectura = value; }
        public int ValorConsumo { get => valorConsumo; set => valorConsumo = value; }
    }
}