using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa.Pedagogico
{
    public partial class FrmMontTurma : Form
    {
        string idSelecionado;
        public FrmMontTurma()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "ALUNO";
            Grid.Columns[2].HeaderText = "SERIE";
            Grid.Columns[3].HeaderText = "TURMA";
            Grid.Columns[4].HeaderText = "ID_TURMA";

            Grid.Columns[0].Visible = false;
            Grid.Columns[4].Visible = false;

            Grid.Columns[1].Width = 170;
            Grid.Columns[3].Width = 88;
        }

        private void Listar()
        {
            string queryListar = @"
                    SELECT
	                    tbd.id,
	                    tba.nome,
                        tbt.serie,
                        tbt.nome,
                        tbt.id_turma
                    FROM
	                    tb_aluno_turma as tbd
                    INNER JOIN
	                    tb_aluno as tba ON tba.id_aluno=tbd.aluno_id
                    INNER JOIN
	                    tb_turma as tbt ON tbt.id_turma=tbd.turma_id
                    WHERE
	                    tbt.id_turma=" + CbTurma.SelectedValue;
            Grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void CarregarComboBox()
        {
            string ano = "SELECT * FROM tb_turma ORDER BY nome";
            CbTurma.Items.Clear();
            CbTurma.DataSource = Conexao.dql(ano);
            CbTurma.DisplayMember = "nome";
            CbTurma.ValueMember = "id_turma";
        }      

        private void HabilitarCampos()
        {
            //txtAluno.Enabled = true;
            CbTurma.Enabled = true;
            BtnAluno.Enabled = true;
            txtAluno.Focus();
        }

        private void DesabilitarCampos()
        {
            txtAluno.Enabled = false;
            //cbTurma.Enabled = false;
            BtnAluno.Enabled = false;
        }

        private void LimparCampos()
        {
            txtAluno.Text = "";         
        }

        private void FrmMontTurma_Load(object sender, EventArgs e)
        {
            CarregarComboBox();     
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            BtnSave.Enabled = true;
            BtnDelete.Enabled = false;
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            Program.chamadaAlunos = "aluno";
            Cadastros.FrmAluno form = new Cadastros.FrmAluno();
            form.Show();
        }

        private void FrmMontTurma_Activated(object sender, EventArgs e)
        {
            txtAluno.Text = Program.nomeAluno;
            // Passo o id da turma para o relatorio
            Program.idSerieTurma = CbTurma.SelectedValue.ToString();
        }

        private void CbTurma_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            if (CbTurma.SelectedValue != null)
            {                
                Listar();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O NOME ESTA VAZIO
            if (txtAluno.Text.ToString().Trim() == "")
            {
                txtAluno.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAluno.Focus();
                return;
            }
            string queryAdd = String.Format(@"INSERT INTO tb_aluno_turma 
                            (aluno_id, turma_id)
                                VALUES ({0}, {1})
                    ", Program.idAluno, CbTurma.SelectedValue);

            Conexao.dml(queryAdd);
            MessageBox.Show("Dados inseridos com sucesso!", "Dados Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnSave.Enabled = false;
            BtnDelete.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            Listar();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Cria um Dialogo para confirmar a exclusao de dados
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryDelete = "DELETE FROM tb_aluno_turma WHERE id=" + idSelecionado;
                Conexao.dml(queryDelete);
                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Grid.Rows.Remove(Grid.CurrentRow);
            }
            BtnSave.Enabled = false;
            BtnDelete.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();

            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            HabilitarCampos();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            Relatorios.Relatorio_Turma form = new Relatorios.Relatorio_Turma();
            form.ShowDialog();
        }
    }
}
