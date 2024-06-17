using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Motocicleta
    {
        public string Placa { get; set; }

        public string Cilindraje { get; set; }

        public string Modelo { get; set; }

        public string Estado { get; set; }

        public bool SOAT
        {
            get
            {
                if (DateSOAT <= DateTime.Now)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public DateTime DateSOAT { get; set; }

        public bool TecnicoMecanica
        {
            get
            {
                if (DateTecnicoMecanica <= DateTime.Now)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        public DateTime DateTecnicoMecanica { get; set; }

        public Gastos Gastos { get; set; }
        public Conductor Conductor { get; set; }
    }
}
