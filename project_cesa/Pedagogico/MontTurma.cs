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
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "ALUNO";
            grid.Columns[2].HeaderText = "SERIE";
            grid.Columns[3].HeaderText = "TURMA";
            grid.Columns[4].HeaderText = "ID_TURMA";

            grid.Columns[0].Visible = false;
            grid.Columns[4].Visible = false;

            grid.Columns[1].Width = 170;
            grid.Columns[3].Width = 88;
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
	                    tbt.id_turma=" + cbTurma.SelectedValue;
            grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void CarregarComboBox()
        {
            string ano = "SELECT * FROM tb_turma ORDER BY nome";
            cbTurma.Items.Clear();
            cbTurma.DataSource = Conexao.dql(ano);
            cbTurma.DisplayMember = "nome";
            cbTurma.ValueMember = "id_turma";
        }      

        private void habilitarCampos()
        {
            //txtAluno.Enabled = true;
            cbTurma.Enabled = true;
            btnAluno.Enabled = true;
            txtAluno.Focus();
        }

        private void desabilitarCampos()
        {
            txtAluno.Enabled = false;
            cbTurma.Enabled = false;
            btnAluno.Enabled = false;
        }

        private void limparCampos()
        {
            txtAluno.Text = "";         
        }

        private void FrmMontTurma_Load(object sender, EventArgs e)
        {
            CarregarComboBox();     
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            Program.chamadaAlunos = "aluno";
            Cadastros.FrmAluno form = new Cadastros.FrmAluno();
            form.Show();
        }

        private void FrmMontTurma_Activated(object sender, EventArgs e)
        {
            txtAluno.Text = Program.nomeAluno;            
        }

        private void cbTurma_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            if (cbTurma.SelectedValue != null)
            {                
                Listar();
                // Passo o id da turma para o relatorio
                Program.idSerieTurma = cbTurma.SelectedValue.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O NOME ESTA VAZIO
            if (txtAluno.Text.ToString().Trim() == "")
            {
                txtAluno.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAluno.Focus();
                return;
            }
            string queryAdd = "";
            queryAdd = String.Format(@"INSERT INTO tb_aluno_turma 
                            (aluno_id, turma_id)
                                VALUES ({0}, {1})
                    ", Program.idAluno, cbTurma.SelectedValue);

            Conexao.dml(queryAdd);
            MessageBox.Show("Dados inseridos com sucesso!", "Dados Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            desabilitarCampos();
            limparCampos();
            Listar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Cria um Dialogo para confirmar a exclusao de dados
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryDelete = "DELETE FROM tb_aluno_turma WHERE id=" + idSelecionado;
                Conexao.dml(queryDelete);
                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grid.Rows.Remove(grid.CurrentRow);
            }
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            desabilitarCampos();
            limparCampos();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = grid.CurrentRow.Cells[0].Value.ToString();

            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            habilitarCampos();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Relatorios.Relatorio_Turma form = new Relatorios.Relatorio_Turma();
            form.ShowDialog();
        }
    }
}
