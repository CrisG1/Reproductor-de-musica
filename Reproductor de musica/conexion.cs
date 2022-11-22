using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_musica
{
   public class conexion
    {
        static MySqlConnection cnx;
        static string cadena = "Server = 192.168.1.72; Database = rutas; User = user; Password = user;";

        public static void conectar()
        {
            cnx = new MySqlConnection(cadena);
            cnx.Open();
        }
        public static void desconectar()
        {
            cnx.Close();
            cnx = null;
        }
        public static int ConsultaFilasAfectadas(string consulta)
        {
            int filasAfectadas;
            conectar();
            MySqlCommand cmd = new MySqlCommand(consulta, cnx);
            filasAfectadas = cmd.ExecuteNonQuery();
            desconectar();
            return filasAfectadas;
        }
        public static int ConsultaLogin(string consulta)
        {
            DataTable dt = new DataTable();
            conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, cnx);
            da.Fill(dt);
            desconectar();
            return dt.Rows.Count;
        }
        public static DataTable Consulta(String consulta)
        {
            conectar();
            MySqlCommand cmd = new MySqlCommand(consulta, cnx);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            desconectar();
            return dt;
        }
    }
}
