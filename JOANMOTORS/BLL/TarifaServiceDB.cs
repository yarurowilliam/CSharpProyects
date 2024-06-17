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
    public class TarifaServiceDB
    {
        SqlConnection Conexion;
        IList<Tarifa> listaTarifa;
        TarifaRepositoryDB tarifaRepository;

        public TarifaServiceDB()
        {
            Conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True");
            tarifaRepository = new TarifaRepositoryDB(Conexion);
        }
        public string Guardar(Tarifa tarifa)
        {
            try
            {
                Conexion.Open();
                tarifaRepository.Guardar(tarifa);
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



        public Tarifa Buscar()
        {
            Conexion.Open();
            Tarifa tarifa = new Tarifa();
            tarifa = tarifaRepository.BuscarTarifa();
            Conexion.Close();
            return tarifa;
        }

        public string Modificar(Tarifa tarifa)
        {

            if (Buscar() == null)
            {
                return ($"LA TARIFA {tarifa.Valor} NO FUE ENCONTRADA");
            }
            else
            {   
                Conexion.Open();
                tarifaRepository.Modificar(tarifa);
                Conexion.Close();
                return ($"LA TARIFA GLOBAL FUE MODIFICADA A {tarifa.Valor}!");
            }
        }


    }
}
