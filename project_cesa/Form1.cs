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
        private void AbreForm(int nivel, Form f)
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

        private void LoginLogOn_Click(object sender, EventArgs e)
        {
            Login Login = new Login(this);
            Login.ShowDialog();
        }

        private void LoginLogOff_Click(object sender, EventArgs e)
        {
            lbl_acesso.Text = "0";
            lbl_nomeUsuario.Text = "---";
            pictureBox1.Image = Properties.Resources.led_red;

            Program.nivel = 0;
            Program.logado = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void CadastrosAlunos_Click(object sender, EventArgs e)
        {
            Program.chamadaAlunos = "NovoAluno";
            Cadastros.FrmAluno form = new Cadastros.FrmAluno();
            AbreForm(1, form);
        }

        private void CadastrosResponsavel_Click(object sender, EventArgs e)
        {
            Cadastros.FrmResponsavel form = new Cadastros.FrmResponsavel();
            AbreForm(1, form);
        }

        private void PedagogicoTurmaMont_Click(object sender, EventArgs e)
        {
            Pedagogico.FrmMontTurma form = new Pedagogico.FrmMontTurma();
            AbreForm(1, form);
        }

        private void PedagogicoHorarioProfessor_Click(object sender, EventArgs e)
        {
            Pedagogico.FrmMontHorario form = new Pedagogico.FrmMontHorario();
            AbreForm(1, form);
        }

        private void UsuariosGestao_Click(object sender, EventArgs e)
        {
            Cadastros.FrmUsuario form = new Cadastros.FrmUsuario();
            AbreForm(2, form);
        }

        private void PedagogicoNotaLanca_Click(object sender, EventArgs e)
        {
            Pedagogico.FrmNotas form = new Pedagogico.FrmNotas();
            AbreForm(0, form);
        }

        private void FerramentasBackup_Click(object sender, EventArgs e)
        {
            Ferramentas.FrmBackup form = new Ferramentas.FrmBackup();
            AbreForm(2, form);
        }    

        private void FerramentasSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Quality Engineer: Jefferson Assis "+"\n"+
                "Tel:(21) 981792-2516"+"\n"+
                "Email: jeff-assis@hotmail.com" + "\n"+
                "Github: jeffassis", "Sobre Nós", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }      

        private void RelatoriosTurmas_Click(object sender, EventArgs e)
        {
            Relatorios.Relatorio_Turma form = new Relatorios.Relatorio_Turma();
            AbreForm(0, form);
        }

        private void CadastrosProfessor_Click(object sender, EventArgs e)
        {
            Cadastros.FrmProfessor form = new Cadastros.FrmProfessor();
            AbreForm(0, form);
        }

        private void FerramentasFoto_Click(object sender, EventArgs e)
        {
            Ferramentas.FrmCapturarFoto form = new Ferramentas.FrmCapturarFoto();
            AbreForm(0, form);
        }

        private void RelHoraProf_Click(object sender, EventArgs e)
        {
            Relatorios.FrmRelatorio_Horario form = new Relatorios.FrmRelatorio_Horario();
            AbreForm(0, form);
        }

        private void PedagogicoHorarioAluno_Click(object sender, EventArgs e)
        {
            Pedagogico.FrmMontHoraAluno form = new Pedagogico.FrmMontHoraAluno();
            AbreForm(0, form);
        }

        private void PedagogicoNotaBoleAluno_Click(object sender, EventArgs e)
        {
            Pedagogico.FrmBoletimAluno form = new Pedagogico.FrmBoletimAluno();
            AbreForm(1, form);
        }

        private void PedagogicoNotaBoleFinal_Click(object sender, EventArgs e)
        {
            Pedagogico.FrmBoletimFinal form = new Pedagogico.FrmBoletimFinal();
            AbreForm(1, form);
        }

        private void CadastrosServico_Click(object sender, EventArgs e)
        {
            Cadastros.FrmServico form = new Cadastros.FrmServico();
            AbreForm(2, form);
        }

        private void CadastrosHorario_Click(object sender, EventArgs e)
        {
            Cadastros.FrmHorario form = new Cadastros.FrmHorario();
            AbreForm(2, form);
        }

        private void CadastrosTurmas_Click(object sender, EventArgs e)
        {
            Cadastros.FrmTurma form = new Cadastros.FrmTurma();
            AbreForm(2, form);
        }

        private void CadastrosDisciplinas_Click(object sender, EventArgs e)
        {
            Cadastros.FrmDisciplina form = new Cadastros.FrmDisciplina();
            AbreForm(2, form);
        }

        private void FinanceiroMovimentacao_Click(object sender, EventArgs e)
        {
            Financeiro.FrmMovimentacao form = new Financeiro.FrmMovimentacao();
            AbreForm(2, form);
        }

        private void CadastrosFornecedor_Click(object sender, EventArgs e)
        {
            Cadastros.FrmFornecedor form = new Cadastros.FrmFornecedor();
            AbreForm(2, form);
        }

        private void CadastrosProduto_Click(object sender, EventArgs e)
        {
            Cadastros.FrmProdutos form = new Cadastros.FrmProdutos();
            AbreForm(2, form);
        }
    }
}
