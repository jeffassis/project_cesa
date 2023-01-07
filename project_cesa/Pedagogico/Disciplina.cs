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
    public partial class FrmDisciplina : Form
    {
        string idSelecionado;
        string DisciplinaAntigo;
        DataTable dt = new DataTable();
        public FrmDisciplina()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "DISCIPLINA";

            grid.Columns[0].Width = 65;
            grid.Columns[1].Width = 150;
        }

        private void Listar()
        {
            string queryListar = "SELECT * FROM tb_disciplina ORDER BY nome asc";
            grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;                  
            txtNome.Focus();
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;            
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtId.Text = "";            
        }

        private void FrmDisciplina_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            habilitarCampos();
            limparCampos();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O NOME ESTA VAZIO
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha a Disciplina", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            // ADICIONA A CONSULTA A STRING
            string queryAdd = "";
            queryAdd = String.Format(@"
                       INSERT INTO tb_disciplina 
                            (nome)
                                VALUES ('{0}')
                    ", txtNome.Text);

            // VERIFICA SE JA EXISTE
            string verificar = "SELECT nome FROM tb_disciplina WHERE nome='" + txtNome.Text + "'";
            dt = Conexao.dql(verificar);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Disciplina já cadastrado!!", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            // EXECUTA A STRING    
            Conexao.dml(queryAdd);
            MessageBox.Show("Dados inseridos com sucesso!", "Dados Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            desabilitarCampos();
            limparCampos();
            Listar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O NOME ESTA VAZIO
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha a Disciplina", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Confirma Atualização de dados?", "Atualizar dados?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    // ADICIONA A CONSULTA A STRING
                    string queryUpdate = "";
                    queryUpdate = String.Format(@"
                        UPDATE tb_disciplina SET 
                            nome='{0}'
                        WHERE
                            id_disciplina={1}
                    ", txtNome.Text, idSelecionado);
                    // VERIFICA SE JA EXISTE
                    if (txtNome.Text != DisciplinaAntigo)
                    {
                        string verificar = "SELECT nome FROM tb_disciplina WHERE nome='" + txtNome.Text + "'";
                        dt = Conexao.dql(verificar);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Disciplina já cadastrado!!", "Erro ao editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNome.Text = "";
                            txtNome.Focus();
                            return;
                        }
                    }
                    // EXECUTA A STRING
                    Conexao.dml(queryUpdate);
                    MessageBox.Show("Dados atualizados com sucesso!", "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
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
                string queryDelete = "DELETE FROM tb_disciplina WHERE id_disciplina=" + idSelecionado;
                Conexao.dml(queryDelete);
                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grid.Rows.Remove(grid.CurrentRow);
            }
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            desabilitarCampos();
            limparCampos();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            habilitarCampos();

            DisciplinaAntigo = grid.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
