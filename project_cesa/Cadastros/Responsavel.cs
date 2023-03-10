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
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "NOME";
            Grid.Columns[2].HeaderText = "RG";
            Grid.Columns[3].HeaderText = "CPF";
            Grid.Columns[4].HeaderText = "PARENTESCO";
            Grid.Columns[5].HeaderText = "TELEFONE";

            Grid.Columns[0].Visible = false;
            Grid.Columns[2].Visible = false;            

            Grid.Columns[1].Width = 160;
            Grid.Columns[4].Width = 90;
            Grid.Columns[5].Width = 90;
        }

        private void Listar()
        {
            string queryListar = "SELECT * FROM tb_responsavel ORDER BY nome asc";
            Grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtRg.Enabled = true;
            txtCpf.Enabled = true;
            cbParentesco.Enabled = true;
            txtTelefone.Enabled = true;
            txtNome.Focus();
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtRg.Enabled = false;
            txtCpf.Enabled = false;
            cbParentesco.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void LimparCampos()
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
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            // ADICIONA A CONSULTA A STRING
            string queryAdd = String.Format(@"
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
                    // ADICIONA A CONSULTA A STRING
                    string queryUpdate = String.Format(@"
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
            BtnSave.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
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
                string queryDelete = "DELETE FROM tb_responsavel WHERE id_responsavel=" + idSelecionado;
                Conexao.dml(queryDelete);
                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Grid.Rows.Remove(Grid.CurrentRow);
            }
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
            txtRg.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            cbParentesco.Text = Grid.CurrentRow.Cells[4].Value.ToString();         
            txtTelefone.Text = Grid.CurrentRow.Cells[5].Value.ToString();            

            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            HabilitarCampos();

            ResponsavelAntigo = Grid.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
