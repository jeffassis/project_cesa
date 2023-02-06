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
    public partial class FrmGastos : Form
    {
        string idGasto;
        string ultimoIdGasto;

        MySqlCommand cmd;
        DataTable dt = new DataTable();
        public FrmGastos()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID_GASTO";
            Grid.Columns[1].HeaderText = "DESCRICAO";
            Grid.Columns[2].HeaderText = "VALOR";
            Grid.Columns[3].HeaderText = "FUNCIONARIO";
            Grid.Columns[4].HeaderText = "DATA";

            // Visibilidade das colunas no Grid
            Grid.Columns[0].Visible = false;

            // O Header so fica centralizado se desabilitar a propriedade de ordenacao
            Grid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Valores numericos com duas casas decimais
            Grid.Columns[2].DefaultCellStyle.Format = "C2";

            // Colocar valores centralizados na celula
            Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Define o tamanho das celulas
            Grid.Columns[1].Width = 164;

            // Função para atualizar o total
            Totalizar();
        }

        private void Listar()
        {
            string queryListar = @"SELECT * FROM tb_gasto ORDER BY data desc";
            Grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            txtDescricao.Focus();
        }

        private void DesabilitarCampos()
        {
            // Desabilta botoes
            BtnSave.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            // Desabilta campos
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
        }

        private void LimparCampos()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
        }

        private void BuscarData()
        {
            var vcon = Conexao.ConexaoBanco();
            string sql = "SELECT * FROM tb_gasto where data = @data order by data desc";
            cmd = new MySqlCommand(sql, vcon);
            cmd.Parameters.AddWithValue("@data", Convert.ToDateTime(DtBuscar.Text));
            MySqlDataAdapter da = new MySqlDataAdapter
            {
                SelectCommand = cmd
            };
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            vcon.Close();

            FormatarDG();
        }

        private void FrmGastos_Load(object sender, EventArgs e)
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
            // VERIFICA SE O NOME ESTA VAZIO
            if (txtDescricao.Text.ToString().Trim() == "")
            {
                txtDescricao.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Focus();
                return;
            }
            // VERIFICA SE O VALOR ESTA VAZIO
            if (txtValor.Text.ToString().Trim() == "")
            {
                txtValor.Text = "";
                MessageBox.Show("Preencha o Valor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Focus();
                return;
            }
            // CODIGO DO BOTAO PARA ADD
            var vcon = Conexao.ConexaoBanco();
            string add = @"INSERT INTO tb_gasto (descricao, valor, funcionario, data) VALUES (@descricao, @valor, @funcionario, curDate())";
            cmd = new MySqlCommand(add, vcon);
            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@valor", txtValor.Text);
            cmd.Parameters.AddWithValue("@funcionario", Program.nomeUsuario);
            // VERIFICA SE JA EXISTE
            string verificar = "SELECT * FROM tb_gasto WHERE descricao='" + txtDescricao.Text + "' and valor=" + txtValor.Text.Replace(",", ".");
            dt = Conexao.dql(verificar);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Gasto já cadastrado!!", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Text = "";
                txtDescricao.Focus();
                return;
            }
            // EXECUTA A STRING
            cmd.ExecuteNonQuery();
            vcon.Close();
            vcon.Dispose();
            vcon.ClearAllPoolsAsync();

            //RECUPERAR O ULTIMO ID DO GASTO
            MySqlCommand cmdVerificar;
            MySqlDataReader reader;
            var verificaCon = Conexao.ConexaoBanco();
            cmdVerificar = new MySqlCommand("SELECT id_gasto FROM tb_gasto order by id_gasto desc LIMIT 1", verificaCon);
            reader = cmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ultimoIdGasto = Convert.ToString(reader["id_gasto"]);
                }
            }
            verificaCon.Close();

            //LANÇAR O GASTO NAS MOVIMENTAÇÕES
            var movCon = Conexao.ConexaoBanco();
            string movi = @"INSERT INTO tb_movimentacao (tipo, movimento, valor, funcionario, data, id_movimento) 
                            VALUES (@tipo, @movimento, @valor, @funcionario, curDate(), @id_movimento)";
            cmd = new MySqlCommand(movi, movCon);
            cmd.Parameters.AddWithValue("@tipo", "Saida");
            cmd.Parameters.AddWithValue("@movimento", "Gasto");
            cmd.Parameters.AddWithValue("@valor", txtValor.Text);
            cmd.Parameters.AddWithValue("@funcionario", Program.nomeUsuario);
            cmd.Parameters.AddWithValue("@id_movimento", ultimoIdGasto);
            cmd.ExecuteNonQuery();
            movCon.Close();
            movCon.Dispose();
            movCon.ClearAllPoolsAsync();

            MessageBox.Show("Dados inseridos com sucesso!", "Dados Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DesabilitarCampos();
            LimparCampos();
            Listar();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.ToString().Trim() == "")
            {
                txtDescricao.Text = "";
                MessageBox.Show("Preencha a Descrição", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Focus();
                return;
            }
            //CÓDIGO DO BOTÃO PARA EDITAR
            var vcon = Conexao.ConexaoBanco();
            string update = "UPDATE tb_gasto SET descricao = @descricao, valor = @valor, funcionario = @funcionario, data = curDate() where id_gasto=@id";
            cmd = new MySqlCommand(update, vcon);
            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@valor", txtValor.Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@funcionario", Program.nomeUsuario);
            cmd.Parameters.AddWithValue("@id", idGasto);
            cmd.ExecuteNonQuery();
            vcon.Close();

            //ATUALIZAR O VALOR NA MOVIMENTAÇÃO
            var movCon = Conexao.ConexaoBanco();
            string movi = "UPDATE tb_movimentacao SET valor=@valor, funcionario=@funcionario, data=curDate() where id_movimento=@id and movimento=@movimento";
            cmd = new MySqlCommand(movi, movCon);
            cmd.Parameters.AddWithValue("@valor", txtValor.Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@funcionario", Program.nomeUsuario);
            cmd.Parameters.AddWithValue("@id", idGasto);
            cmd.Parameters.AddWithValue("@movimento", "Gasto");
            cmd.ExecuteNonQuery();
            movCon.Close();
            movCon.Dispose();
            movCon.ClearAllPoolsAsync();

            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
            Listar();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CÓDIGO DO BOTÃO PARA EXCLUIR
                var vcon = Conexao.ConexaoBanco();
                string delete = "DELETE FROM tb_gasto WHERE id_gasto=@id";
                cmd = new MySqlCommand(delete, vcon);
                cmd.Parameters.AddWithValue("@id", idGasto);
                cmd.ExecuteNonQuery();
                vcon.Close();

                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
                LimparCampos();
                DesabilitarCampos();
                Listar();

                //EXCLUSAO DO MOVIMENTO DO GASTO
                var movCon = Conexao.ConexaoBanco();
                string movimento = "DELETE FROM tb_movimentacao where id_movimento=@id and movimento=@movimento";
                cmd = new MySqlCommand(movimento, movCon);
                cmd.Parameters.AddWithValue("@id", idGasto);
                cmd.Parameters.AddWithValue("@movimento", "Gasto");
                cmd.ExecuteNonQuery();
                movCon.Close();
                movCon.Dispose();
                movCon.ClearAllPoolsAsync();
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            HabilitarCampos();

            idGasto = Grid.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtValor.Text = Grid.CurrentRow.Cells[2].Value.ToString();
        }

        private void DtBuscar_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void Totalizar()
        {
            double total = 0;
            foreach (DataGridViewRow linha in Grid.Rows)
            {
                total += Convert.ToDouble(linha.Cells["valor"].Value);
            }
            lblTotal.Text = Convert.ToDouble(total).ToString("C2");
        }
    }
}
