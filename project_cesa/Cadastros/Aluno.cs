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
    public partial class FrmAluno : Form
    {
        string idSelecionado;
        string AlunoAntigo;
        DataTable dt = new DataTable();
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "NOME";
            grid.Columns[2].HeaderText = "EMAIL";
            grid.Columns[3].HeaderText = "ENDERECO";
            grid.Columns[4].HeaderText = "BAIRRO";
            grid.Columns[5].HeaderText = "CEP";
            grid.Columns[6].HeaderText = "NASCIMENTO";
            grid.Columns[7].HeaderText = "TELEFONE";
            grid.Columns[8].HeaderText = "SANGUE";
            grid.Columns[9].HeaderText = "IMAGEM";

            grid.Columns[0].Visible = false;
            grid.Columns[2].Visible = false;
            grid.Columns[4].Visible = false;
            grid.Columns[5].Visible = false;
            grid.Columns[7].Visible = false;
            grid.Columns[8].Visible = false;
            grid.Columns[9].Visible = false;

            grid.Columns[1].Width = 160;
            grid.Columns[3].Width = 140;
        }

        private void Listar()
        {
            string queryListar = "SELECT * FROM tb_aluno ORDER BY nome asc";
            grid.DataSource = Conexao.dql(queryListar);      

            FormatarDG();
        }

        private void BuscarNome()
        {           
            string queryPesquisar = "SELECT * FROM tb_aluno WHERE nome like '" + txtBuscarNome.Text +"%"+"'  ORDER BY nome asc";
            grid.DataSource = Conexao.dql(queryPesquisar);

            FormatarDG();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            txtData.Enabled = true;
            txtTelefone.Enabled = true;
            cbSangue.Enabled = true;
            txtNome.Focus();
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtData.Enabled = false;
            txtTelefone.Enabled = false;
            cbSangue.Enabled = false;
            txtBuscarNome.Focus();
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            //txtData.Text = "";
            txtTelefone.Text = "";
            cbSangue.SelectedIndex = -1;
        }        

            private void FrmAluno_Load(object sender, EventArgs e)
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
                       INSERT INTO tb_aluno 
                            (nome, email, endereco, bairro, cep, nascimento, telefone, sangue)
                                VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')
                    ", txtNome.Text, txtEmail.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtData.Text, txtTelefone.Text, cbSangue.Text);
            
            // VERIFICA SE O ALUNO JA EXISTE
            string verificar = "SELECT nome FROM tb_aluno WHERE nome='"+txtNome.Text+"'";
            dt = Conexao.dql(verificar);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Aluno já cadastrado!!", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        UPDATE tb_aluno SET 
                            nome='{0}', email='{1}', endereco='{2}', bairro='{3}', cep='{4}', nascimento='{5}', telefone='{6}', sangue='{7}'
                        WHERE
                            id_aluno={8}
                    ", txtNome.Text, txtEmail.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtData.Text, txtTelefone.Text, cbSangue.Text, idSelecionado);
                    // VERIFICA SE O ALUNO JA EXISTE
                    if (txtNome.Text != AlunoAntigo)
                    {
                        string verificar = "SELECT nome FROM tb_aluno WHERE nome='" + txtNome.Text + "'";
                        dt = Conexao.dql(verificar);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Aluno já cadastrado!!", "Erro ao editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string queryDelete = "DELETE FROM tb_aluno WHERE id_aluno=" + idSelecionado;
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
            txtEmail.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtBairro.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtCep.Text = grid.CurrentRow.Cells[5].Value.ToString();
            txtData.Text= grid.CurrentRow.Cells[6].Value.ToString();
            txtTelefone.Text = grid.CurrentRow.Cells[7].Value.ToString();
            cbSangue.Text = grid.CurrentRow.Cells[8].Value.ToString();
            pictureBox1.Text = grid.CurrentRow.Cells[9].Value.ToString();

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            habilitarCampos();

            AlunoAntigo = grid.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.chamadaAlunos == "aluno")
            {
                Program.idAluno = grid.CurrentRow.Cells[0].Value.ToString();
                Program.nomeAluno = grid.CurrentRow.Cells[1].Value.ToString();
                Close();
            }
        }
    }
}
