using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa.Ferramentas
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {

        }

        // Funcao para gerar o backup do banco de dados
        private void BackupBanco()
        {
            DialogResult res = MessageBox.Show("Confirma backup de dados?", "Fazer Backup?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                // Informa a localizacao do banco de dados
                string constring = Program.caminhoBanco;

                constring += "charset=utf8;convertzerodatetime=true;";

                string data = DateTime.Now.ToString("dd-MM-yyyy-HH-mm");

                string file = @"C:\cesa\dados\backup-" + data + ".sql";
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            conn.Close();
                            MessageBox.Show("Backup efetuado data: " + data, "Informação backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void BtnBackup_Click(object sender, EventArgs e)
        {
            BackupBanco();
        }
    }
}
