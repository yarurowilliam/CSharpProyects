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
    public class MotocicletaRepositoryDB
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        private SqlCommand Comando;

        List<Motocicleta> listaMotocicleta = new List<Motocicleta>();

        public MotocicletaRepositoryDB(SqlConnection conexion)
        {
            Conexion = conexion;
        }


        ///////////////////////////////////////////////////////////////////////

        public void Guardar(Motocicleta motocicleta)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "insert into MotocicletaTabla(Placa,Modelo,Cilindraje,SOAT,TecnicoMecanica,Estado) values (@Placa,@Modelo,@Cilindraje,@SOAT,@TecnicoMecanica,@Estado) ";
                Comando.Parameters.Add("@Placa", SqlDbType.VarChar).Value = motocicleta.Placa;
                Comando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = motocicleta.Modelo;
                Comando.Parameters.Add("@Cilindraje", SqlDbType.VarChar).Value = motocicleta.Cilindraje;
                Comando.Parameters.Add("@SOAT", SqlDbType.DateTime).Value = motocicleta.DateSOAT;
                Comando.Parameters.Add("@TecnicoMecanica", SqlDbType.DateTime).Value = motocicleta.DateTecnicoMecanica;
                Comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = motocicleta.Estado;
                Comando.ExecuteNonQuery();
            }
        }
        public void GuardarMotoAsignada(Motocicleta motocicleta)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "insert into AsignadoTabla(Identificacion,Nombre,Direccion,Telefono,Estado,Placa,Cilindraje,Modelo,SOAT,TecnicoMecanica,EstadoMoto) values (@Identificacion,@Nombre,@Direccion,@Telefono,@Estado,@Placa,@Cilindraje,@Modelo,@SOAT,@TecnicoMecanica,@EstadoMoto) ";
                Comando.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = motocicleta.Conductor.Identificacion;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = motocicleta.Conductor.Nombre;
                Comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = motocicleta.Conductor.Direccion;
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = motocicleta.Conductor.Telefono;
                Comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = motocicleta.Conductor.Estado;
                Comando.Parameters.Add("@Placa", SqlDbType.VarChar).Value = motocicleta.Placa;
                Comando.Parameters.Add("@Cilindraje", SqlDbType.VarChar).Value = motocicleta.Cilindraje;
                Comando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = motocicleta.Modelo;
                Comando.Parameters.Add("@SOAT", SqlDbType.DateTime).Value = motocicleta.DateSOAT;
                Comando.Parameters.Add("@TecnicoMecanica", SqlDbType.DateTime).Value = motocicleta.DateTecnicoMecanica;
                Comando.Parameters.Add("@EstadoMoto", SqlDbType.VarChar).Value = motocicleta.Estado;
                Comando.ExecuteNonQuery();
            }
        }


        public void Modificar(Motocicleta motocicleta)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = $"Update MotocicletaTabla set Estado=@Estado where (Placa = @Placa)";
                Comando.Parameters.AddWithValue("@Placa", motocicleta.Placa);
                Comando.Parameters.AddWithValue("@Estado", motocicleta.Estado);
                Comando.ExecuteNonQuery();
            }

            //Comando.Parameters.Clear();
        }
        //////////////////////////////////////////////////////////////////////
        public List<Motocicleta> ConsultarMotocicleta()
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from MotocicletaTabla";
                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    Motocicleta motocicleta = new Motocicleta();
                    motocicleta = Map(Reader);
                    listaMotocicleta.Add(motocicleta);
                }
            }
            return listaMotocicleta;
        }

        public Motocicleta Map(SqlDataReader reader)
        {
            Motocicleta motocicleta = new Motocicleta();
            motocicleta.Placa = (string)reader["Placa"];
            motocicleta.Cilindraje = (string)reader["Cilindraje"];
            motocicleta.Modelo = (string)reader["Modelo"];
            motocicleta.DateSOAT = (DateTime)reader["SOAT"];
            motocicleta.DateTecnicoMecanica = (DateTime)reader["TecnicoMecanica"];
            motocicleta.Estado = (string)reader["Estado"];
            return motocicleta;
        }

        public Motocicleta BuscarMoto(string placa)
        {
            foreach (var item in ConsultarMotocicleta())
            {
                if (item.Placa.Equals(placa))
                {

                    return item;

                }
            }
            return null;
        }

        public List<Motocicleta> ConsultarAsignada()
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from AsignadoTabla";
                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    Motocicleta moto = new Motocicleta();
                    moto = MapearAsig(Reader);
                    listaMotocicleta.Add(moto);
                }
            }
            return listaMotocicleta;
        }

        public Motocicleta MapearAsig(SqlDataReader reader)
        {
            Motocicleta moto = new Motocicleta();

            Conductor con = new Conductor();
            con.Identificacion = (string)reader["Identificacion"];
            con.Nombre = (string)reader["Nombre"];
            con.Telefono = (string)reader["Telefono"];
            con.Direccion = (string)reader["Direccion"];
            con.Estado = (string)reader["Estado"];
            moto.Conductor = con;
            moto.Placa = (string)reader["Placa"];
            moto.Cilindraje = (string)reader["Cilindraje"];
            moto.Modelo = (string)reader["Modelo"];
            moto.Estado = (string)reader["Estado"];

            return moto;

        }

    }
}
