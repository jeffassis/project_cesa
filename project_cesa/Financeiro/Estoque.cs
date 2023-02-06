﻿using MySql.Data.MySqlClient;
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
    public partial class FrmEstoque : Form
    {
        string ultimoIdGasto;
        MySqlCommand cmd;
        public FrmEstoque()
        {
            InitializeComponent();
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
            BtnSave.Enabled = true;
            cbFornecedor.Enabled = true;            
            txtQuantidade.Enabled = true;
            txtCompra.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            BtnSave.Enabled = false;
            cbFornecedor.Enabled = false;            
            txtQuantidade.Enabled = false;
            txtCompra.Enabled = false;
            BtnPesquisa.Focus();
        }

        private void LimparCampos()
        {
            txtProduto.Text = "";
            cbFornecedor.SelectedIndex = -1;
            txtEstoque.Text = "";
            txtQuantidade.Text = "";
            txtCompra.Text = "";
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            CarregarComboBoxFornecedor();
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            HabilitarCampos();

            Program.chamadaProduto = "estoque";
            Cadastros.FrmProdutos form = new Cadastros.FrmProdutos();
            form.ShowDialog();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O PRODUTO ESTA VAZIO
            if (txtProduto.Text.ToString().Trim() == "")
            {
                txtProduto.Text = "";
                MessageBox.Show("Selecione um produto", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduto.Focus();
                return;
            }
            // VERIFICA SE O QUANTIDADE ESTA VAZIO
            if (txtQuantidade.Text.ToString().Trim() == "")
            {
                txtQuantidade.Text = "";
                MessageBox.Show("Informe uma quantidade", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.Focus();
                return;
            }
            // CODIGO PARA ATUALIZAR O ESTOQUE
            var vcon = Conexao.ConexaoBanco();
            string sql = @"UPDATE tb_produto SET estoque=@estoque, fornecedor_id=@fornecedor, valor_compra=@compra WHERE id_produto=@id";
            cmd = new MySqlCommand(sql, vcon);
            cmd.Parameters.AddWithValue("@estoque", Convert.ToDouble(txtQuantidade.Text) + Convert.ToDouble(txtEstoque.Text));
            cmd.Parameters.AddWithValue("@fornecedor", cbFornecedor.SelectedValue);
            cmd.Parameters.AddWithValue("@compra", txtCompra.Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@id", Program.idProduto);
            cmd.ExecuteNonQuery();
            vcon.Close();
            vcon.Dispose();
            vcon.ClearAllPoolsAsync();
            MessageBox.Show("Lançamento feito com sucesso!", "Estoque atualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //LANCAR O VALOR DO PEDIDO NOS GASTOS
            var Gcon = Conexao.ConexaoBanco();
            string gasto = @"INSERT INTO tb_gasto (descricao, valor, funcionario, data) VALUES (@descricao, @valor, @funcionario, curDate())";
            cmd = new MySqlCommand(gasto, Gcon);
            cmd.Parameters.AddWithValue("@descricao", "Compra de Produtos");
            cmd.Parameters.AddWithValue("@valor", Convert.ToDouble(txtCompra.Text) * Convert.ToDouble(txtQuantidade.Text));
            cmd.Parameters.AddWithValue("@funcionario", Program.nomeUsuario);
            cmd.ExecuteNonQuery();
            Gcon.Close();
            Gcon.Dispose();
            Gcon.ClearAllPoolsAsync();

            //RECUPERAR O ULTIMO ID DO GASTO
            MySqlCommand cmdVerificar;
            MySqlDataReader reader;
            var verificaCon = Conexao.ConexaoBanco();
            cmdVerificar = new MySqlCommand("SELECT id_gasto FROM tb_gasto order by id_gasto desc LIMIT 1", verificaCon);
            reader = cmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                //EXTRAINDO INFORMAÇÕES DA CONSULTA DO LOGIN
                while (reader.Read())
                {
                    ultimoIdGasto = Convert.ToString(reader["id_gasto"]);
                }
            }
            verificaCon.Close();

            //LANCAR O VALOR DO PEDIDO NAS MOVIMENTACAO
            var movCon = Conexao.ConexaoBanco();
            string movimento = @"INSERT INTO tb_movimentacao (tipo, movimento, valor, funcionario, data, id_movimento) 
                                VALUES (@tipo, @movimento, @valor, @funcionario, curDate(), @id_movimento)";
            cmd = new MySqlCommand(movimento, movCon);
            cmd.Parameters.AddWithValue("@tipo", "Saida");
            cmd.Parameters.AddWithValue("@movimento", "Gasto");
            cmd.Parameters.AddWithValue("@valor", Convert.ToDouble(txtCompra.Text) * Convert.ToDouble(txtQuantidade.Text));
            cmd.Parameters.AddWithValue("@funcionario", Program.nomeUsuario);
            cmd.Parameters.AddWithValue("@id_movimento", ultimoIdGasto);
            cmd.ExecuteNonQuery();
            movCon.Close();
            movCon.Dispose();
            movCon.ClearAllPoolsAsync();
            DesabilitarCampos();
            LimparCampos();
        }

        private void FrmEstoque_Activated(object sender, EventArgs e)
        {
            txtProduto.Text = Program.nomeProduto;
            txtEstoque.Text = Program.estoqueProduto;
        }
    }
}
