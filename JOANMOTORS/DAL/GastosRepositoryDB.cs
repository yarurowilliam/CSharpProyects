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
    public class GastosRepositoryDB
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        private SqlCommand Comando;

        IList<Gastos> listaGastos = new List<Gastos>();

        public GastosRepositoryDB(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void Guardar(Gastos gastos)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "insert into GastosTabla values (@Placa,@Tipo,@Objeto,@Pagado,@Fecha) ";
                Comando.Parameters.Add("@Placa", SqlDbType.VarChar).Value = gastos.Motocicleta.Placa;
                Comando.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = gastos.Tipo;
                Comando.Parameters.Add("@Objeto", SqlDbType.VarChar).Value = gastos.Objeto;
                Comando.Parameters.Add("@Pagado", SqlDbType.Float).Value = gastos.Pago;
                Comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = gastos.Fecha;

                Comando.ExecuteNonQuery();
            }
        }


        public IList<Gastos> Consultar()
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from GastosTabla";
                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    Gastos gastos = new Gastos();
                    gastos = Map(Reader);
                    listaGastos.Add(gastos);
                }
            }
            return listaGastos;
        }

        public Gastos Map(SqlDataReader reader)
        {
            Gastos gastos = new Gastos();
            Motocicleta motocicleta = new Motocicleta();
            motocicleta.Placa = (string)reader["Placa"];
            gastos.Motocicleta = motocicleta;
            gastos.Tipo = (string)reader["Tipo"];
            gastos.Objeto = (string)reader["Objeto"];
            gastos.Pago = Convert.ToDouble(reader["Pagado"]);
            gastos.Fecha = Convert.ToDateTime(reader["Fecha"]);
            return gastos;
        }


    }
}
