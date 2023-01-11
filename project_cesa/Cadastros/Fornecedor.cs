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
    public partial class FrmFornecedor : Form
    {
        string idSelecionado;
        string FornecedorAntigo;
        DataTable dt = new DataTable();
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID_FORNECEDOR";
            Grid.Columns[1].HeaderText = "NOME";
            Grid.Columns[2].HeaderText = "ENDERECO";
            Grid.Columns[3].HeaderText = "TELEFONE";

            // Visibilidade das colunas no Grid
            Grid.Columns[0].Visible = false;

            // O Header so fica centralizado se desabilitar a propriedade de ordenacao
            Grid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Colocar valores centralizados na celula
            Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Define o tamanho das celulas
            Grid.Columns[1].Width = 185;
            Grid.Columns[2].Width = 170;
        }

        private void Listar()
        {
            string queryListar = @"SELECT * FROM tb_fornecedor ORDER BY nome_fornecedor";
            Grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtNome.Focus();
        }

        private void DesabilitarCampos()
        {
            // Desabilta botoes
            BtnSave.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            // Desabilta campos
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            HabilitarCampos();
            LimparCampos();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // VERIFICA SE OS CAMPOS ESTAO VAZIOS
            if (txtNome.Text.ToString().Trim() == "" || txtEndereco.Text == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha os campos!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            // ADICIONA A CONSULTA A STRING
            string queryAdd = String.Format(@"INSERT INTO tb_fornecedor (nome_fornecedor, endereco, telefone) VALUES ('{0}', '{1}', '{2}')
                    ", txtNome.Text, txtEndereco.Text, txtTelefone.Text);

            // VERIFICA SE JA EXISTE
            string verificar = "SELECT * FROM tb_fornecedor WHERE nome_fornecedor='" + txtNome.Text+"'";
            dt = Conexao.dql(verificar);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Fornecedor já cadastrado!!", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            // EXECUTA A STRING    
            Conexao.dml(queryAdd);
            MessageBox.Show("Dados inseridos com sucesso!", "Dados Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DesabilitarCampos();
            LimparCampos();
            Listar();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // VERIFICA SE OS CAMPOS ESTAO VAZIOS
            if (txtNome.Text.ToString().Trim() == "" || txtEndereco.Text == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha os campos!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Confirma Atualização de dados?", "Atualizar dados?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    // ADICIONA A CONSULTA A STRING
                    string queryUpdate = String.Format(@"UPDATE tb_fornecedor SET nome_fornecedor='{0}', endereco='{1}', telefone='{2}' WHERE id_fornecedor={3}
                    ", txtNome.Text, txtEndereco.Text, txtTelefone.Text, idSelecionado);
                    // VERIFICA SE JA EXISTE
                    if (txtNome.Text != FornecedorAntigo)
                    {
                        string verificar = "SELECT * FROM tb_fornecedor WHERE nome_fornecedor='" + txtNome.Text + "'";
                        dt = Conexao.dql(verificar);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Fornecedor já cadastrado!!", "Erro ao editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string queryDelete = "DELETE FROM tb_fornecedor WHERE id_fornecedor=" + idSelecionado;
                Conexao.dml(queryDelete);
                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Grid.Rows.Remove(Grid.CurrentRow);
            }
            DesabilitarCampos();
            LimparCampos();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtEndereco.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txtTelefone.Text = Grid.CurrentRow.Cells[3].Value.ToString();

            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            HabilitarCampos();

            FornecedorAntigo = Grid.CurrentRow.Cells[1].Value.ToString();
        }

        private void BuscarNome()
        {
            string queryPesquisar = "SELECT * FROM tb_fornecedor WHERE nome_fornecedor like '" + TxtBuscar.Text + "%" + "'  ORDER BY nome_fornecedor asc";
            Grid.DataSource = Conexao.dql(queryPesquisar);

            FormatarDG();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }
    }
}
