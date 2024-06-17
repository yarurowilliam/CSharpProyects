using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class TarifaDiariaRepositoryDB
    {

        private SqlConnection Conexion;
        private SqlDataReader Reader;
        private SqlCommand Comando;
        List<TarifaDiaria> listaTarifa = new List<TarifaDiaria>();

        public TarifaDiariaRepositoryDB(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void Guardar(TarifaDiaria tarifaDiaria)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "insert into TarifaDiariaTabla values (@Identificacion,@Nombre,@Pagado,@Fecha) ";
                Comando.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = tarifaDiaria.Conductor.Identificacion;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = tarifaDiaria.Conductor.Nombre;
                Comando.Parameters.Add("@Pagado", SqlDbType.Float).Value = tarifaDiaria.Pagado;
                Comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = tarifaDiaria.Fecha;

                Comando.ExecuteNonQuery();
            }
        }

        public List<TarifaDiaria> ConsultarAsignada()
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from TarifaDiariaTabla";
                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    TarifaDiaria tarifa = new TarifaDiaria();
                    tarifa = MapearAsig(Reader);
                    listaTarifa.Add(tarifa);
                }
            }
            return listaTarifa;
        }

        public TarifaDiaria MapearAsig(SqlDataReader reader)
        {
            TarifaDiaria tarifa = new TarifaDiaria();

            Conductor con = new Conductor();
            con.Identificacion = (string)reader["Identificacion"];
            con.Nombre = (string)reader["Nombre"];
            tarifa.Conductor = con;
            tarifa.Pagado = (double)reader["Pagado"];
            tarifa.Fecha = Convert.ToDateTime(reader["Fecha"]);

            return tarifa;

        }
/////



    }
}
