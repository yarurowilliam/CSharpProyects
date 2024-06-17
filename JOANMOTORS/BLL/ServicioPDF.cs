using ENTITY;
using INFRAESTRUCTURA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioPDF
    {

        string RuteProject;
        PDF PDF;

        public ServicioPDF(string ruteProject)
        {
            RuteProject = ruteProject;
            PDF = new PDF(ruteProject);
        }

        public void Save(IList<Conductor> conductores)
        {
            PDF pdf = new PDF(RuteProject);
            pdf.GuardarPdf(conductores);
        }
    }
}
