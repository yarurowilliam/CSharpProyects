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
    public class ConductoresRepositoryDB
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        private SqlCommand Comando;

        List<Conductor> listaConductores = new List<Conductor>();

        public ConductoresRepositoryDB(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void Guardar(Conductor conductor)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "insert into ConductoresTabla values (@Identificacion,@Nombre,@Direccion,@Telefono,@Estado,@Deuda) ";
                Comando.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = conductor.Identificacion;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = conductor.Nombre;
                Comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = conductor.Direccion;
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = conductor.Telefono;
                Comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = conductor.Estado;
                Comando.Parameters.Add("@Deuda", SqlDbType.Float).Value = conductor.Deuda;

                Comando.ExecuteNonQuery();
            }
        }


        //////////////////////////////////////////////////////////////////////

        public List<Conductor> ConsultarConductor()
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from ConductoresTabla";
                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    Conductor empleado = new Conductor();
                    empleado = Map(Reader);
                    listaConductores.Add(empleado);
                }
            }
            return listaConductores;
        }

        public Conductor Map(SqlDataReader reader)
        {
            Conductor conductor = new Conductor();
            conductor.Identificacion = (string)reader["Identificacion"];
            conductor.Nombre = (string)reader["Nombre"];
            conductor.Direccion = (string)reader["Direccion"];
            conductor.Telefono = (string)reader["Telefono"];
            conductor.Estado = (string)reader["Estado"];
            conductor.Deuda = Convert.ToDouble(reader["Deuda"]);
            return conductor;
        }

        public Conductor BuscarConductor(string id)
        {
            foreach (var item in ConsultarConductor())
            {
                if (item.Identificacion.Equals(id))
                {

                    return item;
                }
            }
            return null;
        }

        public void ModificarDeuda(Conductor conductor)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = $"Update ConductoresTabla set Deuda=@Deuda where Identificacion = @Identificacion";
                Comando.Parameters.AddWithValue("@Deuda", conductor.Deuda);
                Comando.Parameters.AddWithValue("@Identificacion", conductor.Identificacion);
                Comando.ExecuteNonQuery();
            }
        }




    }
}
