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
    public partial class FrmAluno : Form
    {
        string foto;
        string alterou;
        string idSelecionado;
        string AlunoAntigo;
        
        MySqlCommand cmd;
        DataTable dt = new DataTable();
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "NOME";
            Grid.Columns[2].HeaderText = "EMAIL";
            Grid.Columns[3].HeaderText = "ENDERECO";
            Grid.Columns[4].HeaderText = "BAIRRO";
            Grid.Columns[5].HeaderText = "CEP";
            Grid.Columns[6].HeaderText = "NASCIMENTO";
            Grid.Columns[7].HeaderText = "TELEFONE";
            Grid.Columns[8].HeaderText = "SANGUE";
            Grid.Columns[9].HeaderText = "IMAGEM";

            Grid.Columns[0].Visible = false;
            Grid.Columns[2].Visible = false;
            Grid.Columns[4].Visible = false;
            Grid.Columns[5].Visible = false;
            Grid.Columns[7].Visible = false;
            Grid.Columns[8].Visible = false;
            Grid.Columns[9].Visible = false;

            Grid.Columns[1].Width = 160;
            Grid.Columns[3].Width = 140;
        }

        private void Listar()
        {
            string queryListar = "SELECT * FROM tb_aluno ORDER BY nome asc";
            Grid.DataSource = Conexao.dql(queryListar);      

            FormatarDG();
        }

        private void BuscarNome()
        {           
            string queryPesquisar = "SELECT * FROM tb_aluno WHERE nome like '" + TxtBuscarNome.Text +"%"+"'  ORDER BY nome asc";
            Grid.DataSource = Conexao.dql(queryPesquisar);

            FormatarDG();
        }

        private void HabilitarCampos()
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

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtData.Enabled = false;
            txtTelefone.Enabled = false;
            cbSangue.Enabled = false;
            TxtBuscarNome.Focus();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            txtData.Value = DateTime.Today;
            txtTelefone.Text = "";
            cbSangue.SelectedIndex = -1;
            LimparFoto();
        }        

        private void FrmAluno_Load(object sender, EventArgs e)
        {
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
            // ADICIONA A CONSULTA A STRING
            var vcon = Conexao.ConexaoBanco();
            string sql = @"INSERT INTO tb_aluno (nome, email, endereco, bairro, cep, nascimento, telefone, sangue, imagem)
                         VALUES (@nome, @email, @endereco, @bairro, @cep, @nascimento, @telefone, @sangue, @imagem)";
            cmd = new MySqlCommand(sql, vcon);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@cep", txtCep.Text);
            cmd.Parameters.AddWithValue("@nascimento", txtData.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@sangue", cbSangue.Text);
            cmd.Parameters.AddWithValue("@imagem", Img());            
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
            cmd.ExecuteNonQuery();
            vcon.Close();
            vcon.Dispose();
            vcon.ClearAllPoolsAsync();
            MessageBox.Show("Dados inseridos com sucesso!", "Dados Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnFoto.Enabled = false;
            BtnSave.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
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
                        string sql = @"UPDATE tb_aluno SET nome=@nome, email=@email, endereco=@endereco, bairro=@bairro, cep=@cep, nascimento=@nascimento,
                                    telefone=@telefone, sangue=@sangue, imagem=@imagem WHERE id_aluno=@id";
                        cmd = new MySqlCommand(sql, vcon);
                        cmd.Parameters.AddWithValue("@imagem", Img());
                    }
                    else
                    {
                        string sql = @"UPDATE tb_aluno SET nome=@nome, email=@email, endereco=@endereco, bairro=@bairro, cep=@cep, nascimento=@nascimento,
                                    telefone=@telefone, sangue=@sangue WHERE id_aluno=@id";
                        cmd = new MySqlCommand(sql, vcon);
                    }
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@cep", txtCep.Text);
                    cmd.Parameters.AddWithValue("@nascimento", txtData.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@sangue", cbSangue.Text);
                    cmd.Parameters.AddWithValue("@id", idSelecionado);

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
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                    vcon.Dispose();
                    vcon.ClearAllPoolsAsync();
                    MessageBox.Show("Dados atualizados com sucesso!", "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            BtnFoto.Enabled = false;
            BtnSave.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;            
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
                string queryDelete = "DELETE FROM tb_aluno WHERE id_aluno=" + idSelecionado;
                Conexao.dml(queryDelete);
                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Grid.Rows.Remove(Grid.CurrentRow);
            }
            BtnFoto.Enabled = false;
            BtnSave.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            txtBairro.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            txtCep.Text = Grid.CurrentRow.Cells[5].Value.ToString();
            txtData.Text= Grid.CurrentRow.Cells[6].Value.ToString();
            txtTelefone.Text = Grid.CurrentRow.Cells[7].Value.ToString();
            cbSangue.Text = Grid.CurrentRow.Cells[8].Value.ToString();
            
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

            AlunoAntigo = Grid.CurrentRow.Cells[1].Value.ToString();
        }

        private void TxtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.chamadaAlunos == "aluno")
            {
                Program.idAluno = Grid.CurrentRow.Cells[0].Value.ToString();
                Program.nomeAluno = Grid.CurrentRow.Cells[1].Value.ToString();
                Close();
            }
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

        private void LimparFoto()
        {
            pictureBox1.Image = Properties.Resources.sem_foto;
            foto = "img/sem-foto.jpg";
        }
    }
}
