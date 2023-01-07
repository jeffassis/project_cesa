﻿using System;
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
    public partial class FrmUsuario : Form
    {
        string idSelecionado;
        string UsuarioAntigo;
        DataTable dt = new DataTable();
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "NOME";
            grid.Columns[2].HeaderText = "USERNAME";
            grid.Columns[3].HeaderText = "SENHA";
            grid.Columns[4].HeaderText = "STATUS";
            grid.Columns[5].HeaderText = "NIVEL";
            

            grid.Columns[0].Visible = false;
            grid.Columns[3].Visible = false;
            
            grid.Columns[1].Width = 150;
            grid.Columns[4].Width = 75;
            grid.Columns[5].Width = 75;
        }

        private void Listar()
        {
            string queryListar = "SELECT * FROM tb_user ORDER BY nome asc";
            grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtUsername.Enabled = true;
            txtSenha.Enabled = true;
            txtNivel.Enabled = true;
            cbStatus.Enabled = true;
            txtNome.Focus();
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtUsername.Enabled = false;
            txtSenha.Enabled = false;
            txtNivel.Enabled = false;
            cbStatus.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtUsername.Text = "";
            txtSenha.Text = "";            
            cbStatus.SelectedIndex = -1;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
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
            // VERIFICA SE O CAMPO ESTA VAZIO
            if (txtNome.Text.ToString().Trim() == "" || txtUsername.ToString().Trim() == "" || cbStatus.Text == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha os campos!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            // ADICIONA A CONSULTA A STRING
            string queryAdd = "";
            queryAdd = String.Format(@"
                       INSERT INTO tb_user 
                            (nome, username, senha, status, nivel)
                                VALUES ('{0}', '{1}', '{2}', '{3}', {4})
                    ", txtNome.Text, txtUsername.Text, txtSenha.Text, cbStatus.Text, txtNivel.Value);

            // VERIFICA SE DADO JA EXISTE
            string verificar = "SELECT username FROM tb_user WHERE username='" + txtUsername.Text + "'";
            dt = Conexao.dql(verificar);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username já cadastrado!!", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // VERIFICA SE O CAMPO ESTA VAZIO
            if (txtNome.Text.ToString().Trim() == "" || txtUsername.ToString().Trim() == "" || cbStatus.Text == "")
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
                    string queryUpdate = "";
                    queryUpdate = String.Format(@"
                        UPDATE tb_user SET 
                            nome='{0}', username='{1}', senha='{2}', status='{3}', nivel={4}
                        WHERE
                            id_user={5}
                    ", txtNome.Text, txtUsername.Text, txtSenha.Text, cbStatus.Text,txtNivel.Value, idSelecionado);
                    // VERIFICA SE O DADO JA EXISTE
                    if (txtUsername.Text != UsuarioAntigo)
                    {
                        string verificar = "SELECT username FROM tb_user WHERE username='" + txtUsername.Text + "'";
                        dt = Conexao.dql(verificar);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Usuário já cadastrado!!", "Erro ao editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string queryDelete = "DELETE FROM tb_user WHERE id_user=" + idSelecionado;
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
            txtUsername.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtSenha.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cbStatus.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtNivel.Value = Convert.ToInt32(grid.CurrentRow.Cells[5].Value.ToString());

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            habilitarCampos();

            UsuarioAntigo = grid.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
