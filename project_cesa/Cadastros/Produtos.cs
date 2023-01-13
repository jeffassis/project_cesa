using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa.Cadastros
{
    public partial class FrmProdutos : Form
    {
        string foto;
        string alterou;
        string idSelecionado;
        string ProdutoAntigo;

        MySqlCommand cmd;
        DataTable dt = new DataTable();
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "NOME";
            Grid.Columns[2].HeaderText = "DESCRICAO";
            Grid.Columns[3].HeaderText = "FORNECEDOR";
            Grid.Columns[4].HeaderText = "ESTOQUE";
            Grid.Columns[5].HeaderText = "ID_FORNECEDOR";
            Grid.Columns[6].HeaderText = "VENDA";
            Grid.Columns[7].HeaderText = "COMPRA";
            Grid.Columns[8].HeaderText = "DATA";
            Grid.Columns[9].HeaderText = "IMAGEM";

            // Visibilidade das colunas no Grid
            Grid.Columns[0].Visible = false;
            Grid.Columns[5].Visible = false;
            Grid.Columns[9].Visible = false;

            //FORMATAR COLUNA PARA MOEDA
            Grid.Columns[6].DefaultCellStyle.Format = "C2";
            Grid.Columns[7].DefaultCellStyle.Format = "C2";

            // O Header so fica centralizado se desabilitar a propriedade de ordenacao
            Grid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Colocar valores centralizados na celula
            Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Define o tamanho das celulas
            Grid.Columns[1].Width = 120;
            Grid.Columns[2].Width = 120;
            Grid.Columns[3].Width = 120;
            Grid.Columns[4].Width = 75;
            Grid.Columns[6].Width = 85;
            Grid.Columns[7].Width = 80;
        }

        private void Listar()
        {
            string queryListar = @"SELECT 
	                tbp.id_produto,
                    tbp.nome_produto,
                    tbp.descricao,
                    tbf.nome_fornecedor, 
                    tbp.estoque,
                    tbp.fornecedor_id,
                    tbp.valor_venda,
                    tbp.valor_compra,
                    tbp.data,
                    tbp.imagem                       
                FROM
	                tb_produto as tbp
                INNER JOIN
	                tb_fornecedor as tbf ON tbf.id_fornecedor=tbp.fornecedor_id
                ORDER BY tbp.nome_produto";
            Grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void Buscar()
        {
            string queryPesquisar = "SELECT * FROM tb_produto WHERE nome_produto like '" + TxtBuscar.Text + "%" + "'  ORDER BY nome_produto asc";
            Grid.DataSource = Conexao.dql(queryPesquisar);

            FormatarDG();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void CarregarComboBoxFornecedor()
        {
            string fornecedor = "SELECT * FROM tb_fornecedor ORDER BY nome_fornecedor";
            cbFornecedor.Items.Clear();
            cbFornecedor.DataSource = Conexao.dql(fornecedor);
            cbFornecedor.DisplayMember = "nome_fornecedor";
            cbFornecedor.ValueMember = "id_fornecedor";
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            //txtEstoque.Enabled = true;
            txtDescricao.Enabled = true;
            cbFornecedor.Enabled = true;
            txtValor.Enabled = true;
            txtNome.Focus();
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            //txtEstoque.Enabled = false;
            txtDescricao.Enabled = false;
            cbFornecedor.Enabled = false;
            txtValor.Enabled = false;
            TxtBuscar.Focus();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEstoque.Text = "";
            txtDescricao.Text = "";
            cbFornecedor.SelectedIndex = -1;
            txtValor.Text = "";
            LimparFoto();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregarComboBoxFornecedor();
            cbFornecedor.SelectedIndex = 0;
            LimparFoto();
            Listar();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnFoto.Enabled = true;
            BtnSave.Enabled = true;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            HabilitarCampos();
            LimparCampos();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O NOME ESTA VAZIO
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            // VERIFICA SE O VALOR ESTA VAZIO
            if (txtValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Focus();
                return;
            }
            // ADICIONA A CONSULTA A STRING
            var vcon = Conexao.ConexaoBanco();
            string sql = @"INSERT INTO tb_produto (nome_produto, descricao, fornecedor_id, valor_venda, data, imagem)
                         VALUES (@nome, @descricao, @fornecedor, @venda, curDate(), @imagem)";
            cmd = new MySqlCommand(sql, vcon);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@fornecedor", cbFornecedor.SelectedValue);
            cmd.Parameters.AddWithValue("@venda", txtValor.Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@imagem", Img());
            // VERIFICA SE O ALUNO JA EXISTE
            string verificar = "SELECT nome_produto FROM tb_produto WHERE nome_produto='" + txtNome.Text + "'";
            dt = Conexao.dql(verificar);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Produto já cadastrado!!", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            // EXECUTA A STRING
            cmd.ExecuteNonQuery();
            vcon.Close();
            vcon.Dispose();
            vcon.ClearAllPoolsAsync();
            MessageBox.Show("Dados inseridos com sucesso!", "Dados Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DesabilitarCampos();
            LimparCampos();
            Listar();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
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
                    var vcon = Conexao.ConexaoBanco();
                    if (alterou == "1")
                    {
                        string sql = @"UPDATE tb_produto SET nome_produto=@nome, descricao=@descricao, fornecedor_id=@fornecedor, 
                                        valor_venda=@venda, imagem=@imagem WHERE id_produto=@id";
                        cmd = new MySqlCommand(sql, vcon);
                        cmd.Parameters.AddWithValue("@imagem", Img());
                    }
                    else
                    {
                        string sql = @"UPDATE tb_produto SET nome_produto=@nome, descricao=@descricao, fornecedor_id=@fornecedor, 
                                        valor_venda=@venda WHERE id_produto=@id";
                                    
                        cmd = new MySqlCommand(sql, vcon);
                    }
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@fornecedor", cbFornecedor.SelectedValue);
                    cmd.Parameters.AddWithValue("@venda", txtValor.Text.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@id", idSelecionado);

                    // VERIFICA SE O ALUNO JA EXISTE
                    if (txtNome.Text != ProdutoAntigo)
                    {
                        string verificar = "SELECT nome_produto FROM tb_produto WHERE nome_produto='" + txtNome.Text + "'";
                        dt = Conexao.dql(verificar);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Produto já cadastrado!!", "Erro ao editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNome.Text = "";
                            txtNome.Focus();
                            return;
                        }
                    }
                    // EXECUTA A STRING
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                    vcon.Dispose();
                    vcon.ClearAllPoolsAsync();
                    MessageBox.Show("Dados atualizados com sucesso!", "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            DesabilitarCampos();
            LimparCampos();
            Listar();
            alterou = "";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Cria um Dialogo para confirmar a exclusao de dados
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryDelete = "DELETE FROM tb_produto WHERE id_produto=" + idSelecionado;
                Conexao.dml(queryDelete);
                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Grid.Rows.Remove(Grid.CurrentRow);
            }
            DesabilitarCampos();
            LimparCampos();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.chamadaProduto == "estoque")
            {
                Program.idProduto = Grid.CurrentRow.Cells[0].Value.ToString();
                Program.nomeProduto = Grid.CurrentRow.Cells[1].Value.ToString();
                Program.estoqueProduto = Grid.CurrentRow.Cells[4].Value.ToString();
                Program.valorProduto = Grid.CurrentRow.Cells[6].Value.ToString();
                Close();
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            cbFornecedor.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            txtEstoque.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            txtValor.Text = Grid.CurrentRow.Cells[6].Value.ToString();

            if (Grid.CurrentRow.Cells[9].Value != DBNull.Value)
            {
                byte[] imagem = (byte[])Grid.CurrentRow.Cells[9].Value;
                MemoryStream ms = new MemoryStream(imagem);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = Properties.Resources.sem_foto;
            }
            BtnFoto.Enabled = true;
            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            HabilitarCampos();

            ProdutoAntigo = Grid.CurrentRow.Cells[1].Value.ToString();
        }

        private byte[] Img()
        {
            byte[] imagem_byte = null;
            if (foto == "")
            {
                return null;
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;
        }

        private void LimparFoto()
        {
            pictureBox1.Image = Properties.Resources.sem_foto;
            foto = "img/sem-foto.jpg";
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg;*.png)|*.jpg;*.png|Todos os Arquivos(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                pictureBox1.ImageLocation = foto;
                alterou = "1";
            }
        }        
    }
}
