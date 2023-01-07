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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Login login = new Login(this);
            login.ShowDialog();
        }

        // Funcao para abir os formularios com parametros de nivel e chamada do Form
        private void abreForm(int nivel, Form f)
        {
            if (Program.logado)
            {
                if (Program.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso nao permitido", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("E necessario ter um usuario logado", "Acesso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void logONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Login = new Login(this);
            Login.ShowDialog();
        }

        private void logOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_acesso.Text = "0";
            lbl_nomeUsuario.Text = "---";
            pictureBox1.Image = Properties.Resources.led_red;

            Program.nivel = 0;
            Program.logado = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.chamadaAlunos = "NovoAluno";
            Cadastros.FrmAluno form = new Cadastros.FrmAluno();
            abreForm(1, form);
        }

        private void responsávelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmResponsavel form = new Cadastros.FrmResponsavel();
            abreForm(1, form);
        }

        private void cadastrosDeTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedagogico.FrmTurma form = new Pedagogico.FrmTurma();
            abreForm(1, form);
        }

        private void cadastroDeHoráriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedagogico.FrmHorario form = new Pedagogico.FrmHorario();
            abreForm(1, form);
        }

        private void montagemDeTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedagogico.FrmMontTurma form = new Pedagogico.FrmMontTurma();
            abreForm(1, form);
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedagogico.FrmDisciplina form = new Pedagogico.FrmDisciplina();
            abreForm(1, form);
        }

        private void montagemDeHoráriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedagogico.FrmMontHorario form = new Pedagogico.FrmMontHorario();
            abreForm(1, form);
        }
    }
}
