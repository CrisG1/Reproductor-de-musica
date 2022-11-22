using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Reproductor_de_musica
{
    class AccionesComunes
    {
        public static int ConsultaLogin(string consulta)
        {
            return conexion.ConsultaLogin(consulta);
        }
        public static void llenargrid(string consulta, DataGridView datagrid)
        {
            DataTable dt;
            dt = conexion.Consulta(consulta);        
            if (dt == null)
            {
                return;
            }
            datagrid.DataSource = dt;
        }
        public static string Encripta(string pass)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(pass));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
