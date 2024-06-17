using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TarifaRepositoryDB
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        private SqlCommand Comando;

        IList<Tarifa> listaTarifa = new List<Tarifa>();

        public TarifaRepositoryDB(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void Guardar(Tarifa tarifa)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "insert into TarifaTabla(Tarifa) values (@Tarifa) ";
                Comando.Parameters.Add("@Tarifa", SqlDbType.Float).Value = tarifa.Valor;
                Comando.ExecuteNonQuery();
            }
        }



        public IList<Tarifa> Consultar()
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from TarifaTabla";
                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    Tarifa tarifa = new Tarifa();
                    tarifa = Map(Reader);
                    listaTarifa.Add(tarifa);
                }
            }
            return listaTarifa;
        }


        public Tarifa Map(SqlDataReader reader)
        {
            Tarifa tarifa = new Tarifa();
            tarifa.Valor = (double)reader["Tarifa"];
            return tarifa;
        }

        public void Modificar(Tarifa tarifa)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = $"Update TarifaTabla set Tarifa=@Tarifa";
                Comando.Parameters.AddWithValue("@Tarifa", tarifa.Valor);
                Comando.ExecuteNonQuery();
            }
        }


        public Tarifa BuscarTarifa()
        {
            foreach (var item in Consultar())
            {
                return item;
            }
            return null;
        }

    }
}
