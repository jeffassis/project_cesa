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
    public partial class FrmNotas : Form
    {
        string idSelecionado;
        DataTable dt = new DataTable();
        public FrmNotas()
        {
            InitializeComponent();
        }


        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "NOME";
            grid.Columns[2].HeaderText = "BIMESTRE";
            grid.Columns[3].HeaderText = "DISCIPLINA";
            grid.Columns[4].HeaderText = "TIPO";
            grid.Columns[5].HeaderText = "NOTA";
            grid.Columns[6].HeaderText = "TURMA";


            grid.Columns[0].Visible = false;
            //grid.Columns[3].Visible = false;

            grid.Columns[1].Width = 160;
            grid.Columns[2].Width = 110;
            grid.Columns[3].Width = 120;
            grid.Columns[4].Width = 90;
            grid.Columns[5].Width = 80;
        }

        private void Listar()
        {
            string queryListar = String.Format(@"SELECT
                    tbn.id_nota,
                    tba.nome,
                    tbb.bimestre,
                    tbd.nome,
                    tbn.tipo,
                    tbn.nota,
                    tbt.nome
                FROM
                    tb_nota as tbn
                INNER JOIN
                    tb_aluno as tba ON tba.id_aluno = tbn.aluno_id
                INNER JOIN
                    tb_bimestre as tbb ON tbb.id_bimestre = tbn.bimestre_id
                INNER JOIN
                    tb_disciplina as tbd ON tbd.id_disciplina = tbn.disciplina_id
                INNER JOIN
                    tb_turma as tbt ON tbt.id_turma = tbn.turma_id
                WHERE
                    tba.id_aluno like {0}
                ORDER BY
                    tba.nome", cbAluno.SelectedValue);
            grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void CarregarComboBoxTurma()
        {
            string turma = "SELECT * FROM tb_turma ORDER BY nome";
            cbTurma.Items.Clear();
            cbTurma.DataSource = Conexao.dql(turma);
            cbTurma.DisplayMember = "nome";
            cbTurma.ValueMember = "id_turma";
        }

        private void cbTurma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTurma.SelectedValue != null)
            {
                CarregarComboBoxAluno();
            }
        }

        private void CarregarComboBoxAluno()
        {
            string aluno = String.Format(@"SELECT id_aluno, a.nome, id_turma
                        FROM tb_aluno_turma tba 
                        INNER JOIN tb_aluno a ON a.id_aluno = tba.aluno_id
                        INNER JOIN tb_turma t ON t.id_turma = tba.turma_id
                        WHERE id_turma={0}
                        ORDER BY a.nome", cbTurma.SelectedValue);
            cbAluno.SelectedIndex = -1;
            cbAluno.DataSource = Conexao.dql(aluno);
            cbAluno.DisplayMember = "nome";
            cbAluno.ValueMember = "id_aluno";
        }

        private void cbAluno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Listar();
        }

        private void CarregarComboBoxDisciplina()
        {
            string disciplina = "SELECT * FROM tb_disciplina ORDER BY nome";
            cbDisciplina.Items.Clear();
            cbDisciplina.DataSource = Conexao.dql(disciplina);
            cbDisciplina.DisplayMember = "nome";
            cbDisciplina.ValueMember = "id_disciplina";
        }

        private void CarregarComboBoxBimestre()
        {
            string bimestre = "SELECT * FROM tb_bimestre ORDER BY bimestre";
            cbBimestre.Items.Clear();
            cbBimestre.DataSource = Conexao.dql(bimestre);
            cbBimestre.DisplayMember = "bimestre";
            cbBimestre.ValueMember = "id_bimestre";
        }

        private void habilitarCampos()
        {
            cbAluno.Enabled = true;
            cbDisciplina.Enabled = true;
            cbBimestre.Enabled = true;
            cbTipo.Enabled = true;
            txtNota.Enabled = true;            
        }

        private void desabilitarCampos()
        {
            //cbAluno.Enabled = false;
            cbDisciplina.Enabled = false;
            cbBimestre.Enabled = false;
            cbTipo.Enabled = false;
            txtNota.Enabled = false;
        }

        private void limparCampos()
        {
            //cbAluno.SelectedIndex = -1;
            cbDisciplina.SelectedIndex = -1;
            cbBimestre.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;
            txtNota.Text = "";
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
            CarregarComboBoxTurma();
            CarregarComboBoxDisciplina();
            CarregarComboBoxBimestre();
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
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Verifica se está vazio
            if (cbAluno.Text == "" || txtNota.Text == "" || cbDisciplina.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAluno.Focus();
                return;
            }
            // ADICIONA A CONSULTA A STRING
            string queryAdd = "";
            queryAdd = String.Format(@"INSERT INTO tb_nota 
                            (aluno_id, bimestre_id, disciplina_id, tipo, nota, turma_id)
                                VALUES ({0}, {1}, {2}, '{3}', {4}, {5})
            ", cbAluno.SelectedValue, cbBimestre.SelectedValue, cbDisciplina.SelectedValue, cbTipo.Text, txtNota.Text.Replace(",", "."), cbTurma.SelectedValue);
            // VERIFICA SE DADO JA EXISTE
            string verificar = @"SELECT aluno_id 
                FROM tb_nota WHERE
                aluno_id='" + cbAluno.SelectedValue + "'" +
                " and disciplina_id="+cbDisciplina.SelectedValue+" and bimestre_id="+cbBimestre.SelectedValue+"";
            dt = Conexao.dql(verificar);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Nota já Lançada!!", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Conexao.dml(queryAdd);
            MessageBox.Show("Nota lançada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            desabilitarCampos();
            limparCampos();
            Listar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Verifica se está vazio
            if (cbAluno.Text == "" || txtNota.Text == "" || cbDisciplina.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAluno.Focus();
                return;
            }
            string queryAdd = "";
            queryAdd = String.Format(@"UPDATE tb_nota SET 
                            aluno_id={0}, bimestre_id={1}, disciplina_id={2}, tipo='{3}', nota={4}, turma_id={5} WHERE id_nota={6}
            ", cbAluno.SelectedValue, cbBimestre.SelectedValue, cbDisciplina.SelectedValue, cbTipo.Text, txtNota.Text.Replace(",", "."), cbTurma.SelectedValue, idSelecionado);

            Conexao.dml(queryAdd);
            MessageBox.Show("Dados atualizados com sucesso!", "Dados Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                string queryDelete = "DELETE FROM tb_nota WHERE id_nota=" + idSelecionado;
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
            cbAluno.Text = grid.CurrentRow.Cells[1].Value.ToString();
            cbBimestre.Text = grid.CurrentRow.Cells[2].Value.ToString();
            cbDisciplina.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cbTipo.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtNota.Text = grid.CurrentRow.Cells[5].Value.ToString();
            cbTurma.Text = grid.CurrentRow.Cells[6].Value.ToString();

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            habilitarCampos();
        }        
    } 
}
