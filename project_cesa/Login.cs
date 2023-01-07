using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa
{
    public partial class Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnEntrar.Focus();
        }

        // Funcao de validacao da entrada de user no sistema 
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Logar()
        {
            string username = txtUser.Text;
            string senha = txtSenha.Text;

            // Verifica se os campos estão vazios
            if (username == "" || senha == "")
            {
                MessageBox.Show("Campos não podem ser vazios!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                return;
            }
            // Criação da query e passagem de parametros para os widgets do Menu Principal
            string sql = String.Format("SELECT * FROM tb_user WHERE username='{0}' AND senha='{1}'", txtUser.Text, txtSenha.Text);
            dt = Conexao.dql(sql);
            if (dt.Rows.Count == 1)
            {
                form1.lbl_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lbl_nomeUsuario.Text = dt.Rows[0].Field<string>("username");
                form1.pictureBox1.Image = Properties.Resources.led_green;

                Program.nivel = int.Parse(dt.Rows[0].Field<Int64>("nivel").ToString());
                Program.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }
    }
}
