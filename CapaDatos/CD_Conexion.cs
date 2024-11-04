using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection conection;
        private SqlCommand comand;
        private SqlDataReader lector;
        private SqlTransaction transaccion;

        public SqlDataReader Lector
        {
            get { return lector; }
        }


        public CD_Conexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conexion_DB"].ConnectionString;
            conection = new SqlConnection(connectionString);
            comand = new SqlCommand();
        }

        public void setConsutar(string consulta)
        {
            comand.CommandType = System.Data.CommandType.Text;
            comand.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comand.Connection = conection;
            try
            {
                conection.Open();

                lector = comand.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            comand.Connection = conection;

            try
            {
                conection.Open();
                comand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void setearParametro(string nombre, object valor)
        {
            comand.Parameters.AddWithValue(nombre, valor);
        }
        public void CerrarConection()
        {
            if (lector != null)
            {
                lector.Close();
                conection.Close();
            }

        }
    }
}
