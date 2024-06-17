using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class GastosServiceDB
    {
        SqlConnection Conexion;
        IList<Gastos> listaGastos;
        GastosRepositoryDB gastosRepository;

        public GastosServiceDB()
        {
            Conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True");
            gastosRepository = new GastosRepositoryDB(Conexion);
        }

        public string Guardar(Gastos gastos)
        {
            try
            {
                Conexion.Open();
                gastosRepository.Guardar(gastos);
                Conexion.Close();
                return "GASTO REGISTRADO";
            }
            catch (Exception e)
            {
                Conexion.Close();
                return "Error en la base de datos: " + e.Message.ToString();
                throw;
            }
        }


        public IList<Gastos> ConsultarTodos()
        {

            Conexion.Open();
            listaGastos = new List<Gastos>();
            listaGastos = gastosRepository.Consultar();
            Conexion.Close();
            return (listaGastos);
        }

    }
}
