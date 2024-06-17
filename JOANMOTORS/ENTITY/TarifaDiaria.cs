using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class TarifaDiaria
    {
        public double Pagado { get; set; }
        public DateTime Fecha { get; set; }
        public Conductor Conductor { get; set; }
    }
}
