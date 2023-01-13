using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa.Financeiro
{
    public partial class FrmVendas : Form
    {
        string idVenda;
        string idDetVenda;
        string idProduto;
        string totalVenda;
        string ultimoIdVenda;
        string exclusaoVenda;
        string statusVenda;

        MySqlCommand cmd;
        DataTable dt = new DataTable();
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void FormatarDGVendas()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "VALOR TOTAL.:";
            Grid.Columns[2].HeaderText = "USUARIO.:";
            Grid.Columns[3].HeaderText = "STATUS.:";
            Grid.Columns[4].HeaderText = "DATA.:";

            // Visibilidade das colunas no Grid
            Grid.Columns[0].Visible = false;

            //FORMATAR COLUNA PARA MOEDA
            Grid.Columns[1].DefaultCellStyle.Format = "C2";

            // O Header so fica centralizado se desabilitar a propriedade de ordenacao
            Grid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Colocar valores centralizados na celula
            Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;           

            // Define o tamanho das celulas
            Grid.Columns[1].Width = 160;
            Grid.Columns[2].Width = 130;
            Grid.Columns[3].Width = 130;
            Grid.Columns[4].Width = 105;
        }

        private void ListarVendas()
        {
            string queryListar = @"SELECT * FROM tb_venda ORDER BY data asc";
            Grid.DataSource = Conexao.dql(queryListar);

            FormatarDGVendas();
            GridDetalhes.Visible = false;
        }

        private void FormatarDGDetalhes()
        {
            GridDetalhes.Columns[0].HeaderText = "ID";
            GridDetalhes.Columns[1].HeaderText = "ID_VENDA";
            GridDetalhes.Columns[2].HeaderText = "PRODUTO";
            GridDetalhes.Columns[3].HeaderText = "QUANTIDADE";
            GridDetalhes.Columns[4].HeaderText = "VLR UNITARIO";
            GridDetalhes.Columns[5].HeaderText = "TOTAL";
            GridDetalhes.Columns[6].HeaderText = "USUARIO";
            GridDetalhes.Columns[7].HeaderText = "ID_PRODUTO";

            // Visibilidade das colunas no Grid
            GridDetalhes.Columns[0].Visible = false;
            GridDetalhes.Columns[1].Visible = false;
            GridDetalhes.Columns[7].Visible = false;

            //FORMATAR COLUNA PARA MOEDA
            GridDetalhes.Columns[4].DefaultCellStyle.Format = "C2";
            GridDetalhes.Columns[5].DefaultCellStyle.Format = "C2";

            // O Header so fica centralizado se desabilitar a propriedade de ordenacao
            GridDetalhes.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridDetalhes.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            GridDetalhes.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridDetalhes.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            GridDetalhes.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridDetalhes.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            GridDetalhes.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridDetalhes.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            GridDetalhes.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridDetalhes.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Colocar valores centralizados na celula
            GridDetalhes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridDetalhes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridDetalhes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridDetalhes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridDetalhes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Define o tamanho das celulas
            GridDetalhes.Columns[2].Width = 130;
            GridDetalhes.Columns[3].Width = 90;
            GridDetalhes.Columns[4].Width = 100;
            GridDetalhes.Columns[5].Width = 107;
        }

        private void ListarDetalhesVenda()
        {
            string sql = "SELECT * FROM tb_detalhe_venda WHERE venda_id=" + "0" + " and funcionario='"+Program.nomeUsuario+"'";
            dt = Conexao.dql(sql);
            GridDetalhes.DataSource = dt;

            FormatarDGDetalhes();
            GridDetalhes.Visible = true;
        }

        private void HabilitarCampos()
        {
            BtnRemove.Enabled = true;
            BtnAdd.Enabled = true;
            BtnProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtQuantidade.Focus();
        }

        private void DesabilitarCampos()
        {
            BtnRemove.Enabled = false;
            BtnAdd.Enabled = false;
            BtnProduto.Enabled = false;
            txtQuantidade.Enabled = false;
        }

        private void LimparCampos()
        {
            txtProduto.Text = "";
            txtEstoque.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            lblTotal.Text = "0";
        }

        private void BuscarData()
        {
            var vcon = Conexao.ConexaoBanco();
            string sql = "SELECT * FROM tb_venda where data = @data order by data desc";
            cmd = new MySqlCommand(sql, vcon);
            cmd.Parameters.AddWithValue("@data", Convert.ToDateTime(DtBuscar.Text));
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            vcon.Close();
            vcon.Dispose();
            vcon.ClearAllPoolsAsync();

            FormatarDGVendas();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {            
            ListarVendas();
            totalVenda = "0";
            DtBuscar.Value = DateTime.Today;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            BtnDelete.Enabled = false;
            HabilitarCampos();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "0")
            {
                MessageBox.Show("É preciso inserir produtos para venda", "Venda Sem Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // SALVAR VENDA
            var vcon = Conexao.ConexaoBanco();
            string add = @"INSERT INTO tb_venda (valor_total, funcionario, status, data) VALUES (@valor_total, @funcionario, @status, curDate())";
            cmd = new MySqlCommand(add, vcon);
            cmd.Parameters.AddWithValue("@valor_total", Convert.ToDouble(totalVenda));
            cmd.Parameters.AddWithValue("@funcionario", Program.nomeUsuario);
            cmd.Parameters.AddWithValue("@status", "Efetuada");            
            cmd.ExecuteNonQuery(); // EXECUTA ADD
            vcon.Close();

            //RECUPERAR A ULTIMA ID DA VENDA
            MySqlCommand cmdVerificar;
            MySqlDataReader reader;
            var verificaCon = Conexao.ConexaoBanco();
            cmdVerificar = new MySqlCommand("SELECT id_venda FROM tb_venda ORDER BY id_venda desc LIMIT 1", verificaCon);
            reader = cmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                //EXTRAINDO INFORMAÇÕES DA CONSULTA
                while (reader.Read())
                {
                    ultimoIdVenda = Convert.ToString(reader["id_venda"]);
                }
            }

            //RELACIONAR OS ITENS COM A VENDA
            var upcon = Conexao.ConexaoBanco();
            string update = @"UPDATE tb_detalhe_venda SET venda_id=@venda_id WHERE  venda_id=@id";
            cmd = new MySqlCommand(update, upcon);
            cmd.Parameters.AddWithValue("@id", "0");
            cmd.Parameters.AddWithValue("@venda_id", ultimoIdVenda);
            cmd.ExecuteNonQuery();
            vcon.Close();
            vcon.Dispose();
            vcon.ClearAllPoolsAsync();

            MessageBox.Show("Venda Salva com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            DesabilitarCampos();
            ListarVendas();
            totalVenda = "0";
            BtnFecharGrid.Visible = false;
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            Program.chamadaProduto = "estoque";
            Cadastros.FrmProdutos form = new Cadastros.FrmProdutos();
            form.Show();
        }

        private void FrmVendas_Activated(object sender, EventArgs e)
        {
            txtEstoque.Text = Program.estoqueProduto;
            txtProduto.Text = Program.nomeProduto;
            txtValor.Text = Program.valorProduto;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha a Quantidade", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.Focus();
                return;
            }
            // Verifica se o estoque atende a quantidade de venda
            if (Convert.ToInt32(txtEstoque.Text) < Convert.ToInt32(txtQuantidade.Text))
            {
                MessageBox.Show("Não possui produtos suficiente em estoque", "Estoque Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.Focus();
                return;
            }

            var vcon = Conexao.ConexaoBanco();
            string add = @"INSERT INTO tb_detalhe_venda (venda_id, produto, quantidade, valor_unitario, valor_total, funcionario, produto_id)
                         VALUES (@venda_id, @produto, @quantidade, @valor_unitario, @valor_total, @funcionario, @produto_id)";
            cmd = new MySqlCommand(add, vcon);
            cmd.Parameters.AddWithValue("@venda_id", "0");
            cmd.Parameters.AddWithValue("@produto", txtProduto.Text);
            cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
            cmd.Parameters.AddWithValue("@valor_unitario", Convert.ToDouble(txtValor.Text));
            cmd.Parameters.AddWithValue("@valor_total", Convert.ToDouble(txtValor.Text) * Convert.ToDouble(txtQuantidade.Text));
            cmd.Parameters.AddWithValue("@funcionario", Program.nomeUsuario);
            cmd.Parameters.AddWithValue("@produto_id", Program.idProduto);            
            cmd.ExecuteNonQuery(); // EXECUTA ADD
            vcon.Close();

            //ABATER QUANTIDADE DO ESTOQUE
            var upcon = Conexao.ConexaoBanco();
            string update = @"UPDATE tb_produto SET estoque=@estoque where id_produto=@id";
            cmd = new MySqlCommand(update, upcon);
            cmd.Parameters.AddWithValue("@estoque", Convert.ToInt32(txtEstoque.Text) - Convert.ToInt32(txtQuantidade.Text));
            cmd.Parameters.AddWithValue("@id", Program.idProduto);
            // EXECUTA UPDATE
            cmd.ExecuteNonQuery();
            upcon.Close();
            upcon.Dispose();
            upcon.ClearAllPoolsAsync();

            //TOTALIZAR A VENDA
            double total;
            total = Convert.ToDouble(totalVenda) + Convert.ToDouble(txtValor.Text) * Convert.ToDouble(txtQuantidade.Text);
            totalVenda = total.ToString();
            lblTotal.Text = string.Format("{0:c2}", total);

            txtQuantidade.Text = "";
            txtProduto.Text = "";
            txtEstoque.Text = "0";
            txtValor.Text = "";
            idDetVenda = "";
            ListarDetalhesVenda();
        }

        private void GridDetalhes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idDetVenda = GridDetalhes.CurrentRow.Cells[0].Value.ToString();
            txtProduto.Text = GridDetalhes.CurrentRow.Cells[2].Value.ToString();
            txtQuantidade.Text = GridDetalhes.CurrentRow.Cells[3].Value.ToString();
            txtValor.Text = GridDetalhes.CurrentRow.Cells[4].Value.ToString();
            idProduto = GridDetalhes.CurrentRow.Cells[7].Value.ToString();

            //RECUPERAR O TOTAL DO ESTOQUE DO PRODUTO
            MySqlCommand cmdVerificar;
            MySqlDataReader reader;

            var vcon = Conexao.ConexaoBanco();
            cmdVerificar = new MySqlCommand("SELECT * FROM tb_produto where id_produto=@id", vcon);
            cmdVerificar.Parameters.AddWithValue("@id", idProduto);

            reader = cmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                //EXTRAINDO INFORMAÇÕES DA CONSULTA
                while (reader.Read())
                {
                    txtEstoque.Text = Convert.ToString(reader["estoque"]);
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (idDetVenda == "")
            {
                MessageBox.Show("Selecione um Produto para Remover", "Removendo Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // DELETAR ITEM DA VENDA
            var delCon = Conexao.ConexaoBanco();
            string delete = "DELETE FROM tb_detalhe_venda WHERE id_detalhe=@id_detalhe";
            cmd = new MySqlCommand(delete, delCon);
            cmd.Parameters.AddWithValue("@id_detalhe", idDetVenda);
            cmd.ExecuteNonQuery();
            delCon.Close();

            // DEVOLVER QUANTIDADE AO ESTOQUE
            var upcon = Conexao.ConexaoBanco();
            string update = @"UPDATE tb_produto SET estoque=@estoque where id_produto=@id";
            cmd = new MySqlCommand(update, upcon);
            cmd.Parameters.AddWithValue("@estoque", Convert.ToInt32(txtEstoque.Text) + Convert.ToInt32(txtQuantidade.Text));
            cmd.Parameters.AddWithValue("@id", idProduto);
            cmd.ExecuteNonQuery();
            upcon.Close();
            upcon.Dispose();
            upcon.ClearAllPoolsAsync();

            //TOTALIZAR A VENDA
            double total;
            total = Convert.ToDouble(totalVenda) - Convert.ToDouble(txtValor.Text) * Convert.ToDouble(txtQuantidade.Text);
            totalVenda = total.ToString();
            lblTotal.Text = string.Format("{0:c2}", total);

            txtQuantidade.Text = "";
            txtProduto.Text = "";
            txtEstoque.Text = "0";
            txtValor.Text = "";
            idDetVenda = "";

            if (exclusaoVenda == "1")
            {
                BuscarDetalhesVenda();
            }
            else
            {
                ListarDetalhesVenda();
            }
        }

        private void FrmVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (totalVenda != "0")
            {
                MessageBox.Show("A venda possui itens, favor remover antes de sair!");
                e.Cancel = true;
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Passa o id_venda para o relatorio
            Program.idVenda = Grid.CurrentRow.Cells[0].Value.ToString();

            statusVenda = Grid.CurrentRow.Cells[3].Value.ToString();            
            if (statusVenda == "Efetuada")
            {
                idVenda = Grid.CurrentRow.Cells[0].Value.ToString();
                totalVenda = Grid.CurrentRow.Cells[1].Value.ToString();
                lblTotal.Text = string.Format("{0:c2}", totalVenda);
                BuscarDetalhesVenda();
                BtnFecharGrid.Visible = true;
                BtnAdd.Enabled = true;
                BtnRemove.Enabled = true;
                BtnDelete.Enabled = true;
                exclusaoVenda = "1";
                BtnImprimir.Enabled = true;
            }
            else
            {
                MessageBox.Show("Venda já foi cancelada!", "Venda cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarDetalhesVenda()
        {
            string sql = "SELECT * FROM tb_detalhe_venda WHERE venda_id="+ idVenda;
            dt = Conexao.dql(sql);
            GridDetalhes.DataSource = dt;
            

            FormatarDGDetalhes();
            GridDetalhes.Visible = true;
        }

        private void BtnFecharGrid_Click(object sender, EventArgs e)
        {
            GridDetalhes.Visible = false;
            BtnFecharGrid.Visible = false;
            totalVenda = "0";
            lblTotal.Text = "0";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (totalVenda == "0")
            {
                var resultado = MessageBox.Show("Deseja realmente cancelar a venda?", "Cancelar venda?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    //CÓDIGO DO BOTÃO PARA EXCLUIR
                    var vcon = Conexao.ConexaoBanco();
                    string delete = "UPDATE tb_venda SET status=@status where id_venda= @id_venda";
                    cmd = new MySqlCommand(delete, vcon);
                    cmd.Parameters.AddWithValue("@status", "Cancelada");
                    cmd.Parameters.AddWithValue("@id_venda", idVenda);
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                    vcon.Dispose();
                    vcon.ClearAllPoolsAsync();

                    MessageBox.Show("Venda cancelada com sucesso!", "Venda cancelada!", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    BtnDelete.Enabled = false;
                    LimparCampos();
                    DesabilitarCampos();
                    ListarVendas();
                    totalVenda = "0";
                    exclusaoVenda = "";
                    BtnFecharGrid.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Você precisa excluir todos os itens da venda!!","Atenção ao cancelar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DtBuscar_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

            Relatorios.FrmRelatorio_Venda form = new Relatorios.FrmRelatorio_Venda();
            form.Show();
        }
    }
}
