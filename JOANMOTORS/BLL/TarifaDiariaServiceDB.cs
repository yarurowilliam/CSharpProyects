using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TarifaDiariaServiceDB
    {
        SqlConnection Conexion;
        List<TarifaDiaria> listaTarifa;
        TarifaDiariaRepositoryDB tarifaDiariaRepository;

        public TarifaDiariaServiceDB()
        {
            Conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True");
            tarifaDiariaRepository = new TarifaDiariaRepositoryDB(Conexion);
        }

        public string Guardar(TarifaDiaria tarifaDiaria)
        {
            try
            {
                Conexion.Open();
                tarifaDiariaRepository.Guardar(tarifaDiaria);
                Conexion.Close();
                return "TARIFA REGISTRADA";
            }
            catch (Exception e)
            {
                Conexion.Close();
                return "Error en la base de datos: " + e.Message.ToString();
                throw;
            }
        }

        public List<TarifaDiaria> ConsultarTodos()
        {
            Conexion.Open();
            listaTarifa = new List<TarifaDiaria>();
            listaTarifa = tarifaDiariaRepository.ConsultarAsignada();
            Conexion.Close();
            return (listaTarifa);
        }

    }
}
