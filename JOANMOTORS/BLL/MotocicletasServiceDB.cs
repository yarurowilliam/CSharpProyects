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
    public class MotocicletasServiceDB
    {
        SqlConnection Conexion;
        List<Motocicleta> listaMotocicleta;
        MotocicletaRepositoryDB motocicletaRepository;

        public MotocicletasServiceDB()
        {
            Conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True");
            motocicletaRepository = new MotocicletaRepositoryDB(Conexion);
        }
        public string Guardar(Motocicleta motocicleta)
        {
            try
            {
                Conexion.Open();
                motocicletaRepository.Guardar(motocicleta);
                Conexion.Close();
                return "Se registro la motocicleta: " + motocicleta.Placa;
            }
            catch (Exception e)
            {
                Conexion.Close();
                return "Error en la base de datos: " + e.Message.ToString();
                throw;
            }
        }
        public Motocicleta Crear()
        {
            Motocicleta motocicleta = new Motocicleta();

            if (motocicleta.Conductor == null) 
            {
                motocicleta.Estado = "Disponible";
                return motocicleta;
            }
            else
            {
                motocicleta.Estado = "Ocupada";
                return motocicleta;
            }
        }

        public List<Motocicleta> ConsultarTodos()
        {

            Conexion.Open();
            listaMotocicleta = new List<Motocicleta>();
            listaMotocicleta = motocicletaRepository.ConsultarMotocicleta();
            Conexion.Close();
            return (listaMotocicleta);
        }
        public Motocicleta BuscarMoto(string placa)
        {
            Conexion.Open();
            Motocicleta moto = new Motocicleta();
            moto = motocicletaRepository.BuscarMoto(placa);
            Conexion.Close();
            return moto;
        }

        public string GuardarMotoAsignada(Motocicleta moto)
        {
            try
            {
                Conexion.Open();
                motocicletaRepository.GuardarMotoAsignada(moto);
                Conexion.Close();

                return "ASIGNACION COMPLETA";
            }
            catch (Exception e)
            {
                Conexion.Close();
                return "ERROR AL GUARDAR" + e.Message.ToString();

            }
        }

        public string Modificar(Motocicleta moto)
        {

            if (BuscarMoto(moto.Placa) == null)
            {
                return ($"LA MOTO {moto.Placa} NO ENCONTRADA");
            }
            else
            {
                Conexion.Open();
                motocicletaRepository.Modificar(moto);
                Conexion.Close();
                return ($"LA MOTO {moto.Placa} CAMBIO DE ESTADO!!!");
            }
        }

        public List<Motocicleta> ConsultarAsignado()
        {
            Conexion.Open();
            listaMotocicleta = new List<Motocicleta>();
            listaMotocicleta = motocicletaRepository.ConsultarAsignada();
            Conexion.Close();
            return listaMotocicleta;

        }


    }
}
