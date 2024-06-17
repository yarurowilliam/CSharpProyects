using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Gastos
    {
        public string Tipo { get; set; }

        public string Objeto { get; set; }

        public double Pago { get; set; }

        public DateTime Fecha { get; set; }

        public Motocicleta Motocicleta { get; set; }
    }
}
