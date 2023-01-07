using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa
{
    internal class Conexao
    {
        private static MySqlConnection conn;

        // Abre a conexao com banco de dados
        public static MySqlConnection ConexaoBanco()
        {
            conn = new MySqlConnection(Program.caminhoBanco);
            conn.Open();
            return conn;
        }

        // Metodos Genericos

        public static DataTable dql(string sql)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void dml(string q, string msgOK = null, string msgError = null)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if (msgError != null)
                {
                    MessageBox.Show(msgError + "\n" + ex.Message);
                }
                throw ex;
            }
        }
    }
}
