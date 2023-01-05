using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa.Cadastros
{
    public partial class FrmResponsavel : Form
    {
        string idSelecionado;
        string ResponsavelAntigo;
        DataTable dt = new DataTable();
        public FrmResponsavel()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "NOME";
            grid.Columns[2].HeaderText = "RG";
            grid.Columns[3].HeaderText = "CPF";
            grid.Columns[4].HeaderText = "PARENTESCO";
            grid.Columns[5].HeaderText = "TELEFONE";

            grid.Columns[0].Visible = false;
            grid.Columns[2].Visible = false;            

            //grid.Columns[1].Width = 200;
        }

        private void Listar()
        {
            string queryListar = "SELECT * FROM tb_responsavel ORDER BY nome asc";
            grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtRg.Enabled = true;
            txtCpf.Enabled = true;
            cbParentesco.Enabled = true;
            txtTelefone.Enabled = true;
            txtNome.Focus();
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtRg.Enabled = false;
            txtCpf.Enabled = false;
            cbParentesco.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";            
            cbParentesco.SelectedIndex = -1;
            txtTelefone.Text = "";
        }

        private void FrmResponsavel_Load(object sender, EventArgs e)
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
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            // ADICIONA A CONSULTA A STRING
            string queryAdd = "";
            queryAdd = String.Format(@"
                       INSERT INTO tb_responsavel 
                            (nome, rg, cpf, parentesco, telefone)
                                VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')
                    ", txtNome.Text, txtRg.Text, txtCpf.Text, cbParentesco.Text, txtTelefone.Text);

            // VERIFICA SE JA EXISTE
            string verificar = "SELECT nome FROM tb_responsavel WHERE nome='" + txtNome.Text + "'";
            dt = Conexao.dql(verificar);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Responsável já cadastrado!!", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        UPDATE tb_responsavel SET 
                            nome='{0}', rg='{1}', cpf='{2}', parentesco='{3}', telefone='{4}'
                        WHERE
                            id_responsavel={5}
                    ", txtNome.Text, txtRg.Text, txtCpf.Text, cbParentesco.Text, txtTelefone.Text, idSelecionado);
                    // VERIFICA SE JA EXISTE
                    if (txtNome.Text != ResponsavelAntigo)
                    {
                        string verificar = "SELECT nome FROM tb_responsavel WHERE nome='" + txtNome.Text + "'";
                        dt = Conexao.dql(verificar);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Responsável já cadastrado!!", "Erro ao editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string queryDelete = "DELETE FROM tb_responsavel WHERE id_responsavel=" + idSelecionado;
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
            txtRg.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cbParentesco.Text = grid.CurrentRow.Cells[4].Value.ToString();         
            txtTelefone.Text = grid.CurrentRow.Cells[5].Value.ToString();            

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            habilitarCampos();

            ResponsavelAntigo = grid.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
