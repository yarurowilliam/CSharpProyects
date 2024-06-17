using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class ConductoresServiceDB
    {
        SqlConnection Conexion;
        List<Conductor> listaConductor;
        ConductoresRepositoryDB conductorRepository;

        public ConductoresServiceDB()
        {
            Conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True");
            conductorRepository = new ConductoresRepositoryDB(Conexion);
        }

        public string Guardar(Conductor conductor)
        {
            try
            {
                Conexion.Open();
                conductorRepository.Guardar(conductor);
                Conexion.Close();
                return "Se registro el CONDUCTOR: " + conductor.Identificacion;
            }
            catch (Exception e)
            {
                Conexion.Close();
                return "Error en la base de datos: " + e.Message.ToString();
                throw;
            }
        }


        public Conductor CrearConductor()
        {
            Conductor conductor = new Conductor();
            conductor.Estado = "Activo";
            return conductor;
        }

        public List<Conductor> ConsultarTodos()
        {

            Conexion.Open();
            listaConductor = new List<Conductor>();
            listaConductor = conductorRepository.ConsultarConductor();
            Conexion.Close();
            return (listaConductor);
        }

        public Conductor BuscarConductor(string id)
        {
            Conexion.Open();
            Conductor conductor = new Conductor();
            conductor = conductorRepository.BuscarConductor(id);
            Conexion.Close();
            return conductor;
        }

        public void ModificarDeuda(Conductor conductor)
        {
            Conexion.Open();
            conductorRepository.ModificarDeuda(conductor);
            Conexion.Close();
        }
    }
}
