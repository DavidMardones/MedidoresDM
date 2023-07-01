using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDMModels.DTO
{
    public class Lectura
    {
        private string medidorNumeroSerie;
        private DateTime fechaLectura;
        private int hora;
        private int minutos;
        private double valorConsumo;
        private Medidor medidor;

        public string MedidorNumeroSerie { get => medidorNumeroSerie; set => medidorNumeroSerie = value; }
        public DateTime FechaLectura { get => fechaLectura; set => fechaLectura = value; }
        public int Hora { get => hora; set => hora = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public double ValorConsumo { get => valorConsumo; set => valorConsumo = value; }
        public Medidor Medidor { get => medidor; set => medidor = value; }
    }
}
