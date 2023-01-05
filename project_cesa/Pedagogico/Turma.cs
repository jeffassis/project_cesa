using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa.Pedagogico
{
    public partial class FrmTurma : Form
    {
        string idSelecionado;
        string TurmaAntigo;
        DataTable dt = new DataTable();
        public FrmTurma()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "SERIE";
            grid.Columns[2].HeaderText = "TURMA";
            grid.Columns[3].HeaderText = "TURNO";
            grid.Columns[4].HeaderText = "ID_ANO";
            grid.Columns[5].HeaderText = "ANO";

            grid.Columns[0].Visible = false;
            grid.Columns[3].Visible = false;
            grid.Columns[4].Visible = false;

            grid.Columns[5].Width = 88;
        }

        private void Listar()
        {
            string queryListar = @"
                    SELECT
                        tbt.id_turma, 
                        tbt.serie,
                        tbt.nome,        
                        tbt.turno,
                        tbt.ano_id,
                        tba.ano
                    FROM
                        tb_turma as tbt
                    INNER JOIN
                        tb_ano as tba ON tba.id_ano = tbt.ano_id
                    ORDER BY
                        tbt.nome";
            grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void CarregarComboBox()
        {
            string ano = "SELECT * FROM tb_ano ORDER BY ano";
            cbAno.Items.Clear();
            cbAno.DataSource = Conexao.dql(ano);
            cbAno.DisplayMember = "ano";
            cbAno.ValueMember = "id_ano";
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;           
            cbSerie.Enabled = true;
            cbTurno.Enabled = true;
            cbAno.Enabled = true;            
            txtNome.Focus();
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            cbSerie.Enabled = false;
            cbTurno.Enabled = false;
            cbAno.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            cbSerie.SelectedIndex = -1;
            cbTurno.SelectedIndex = -1;
            cbAno.SelectedIndex = -1;
        }

        private void FrmTurma_Load(object sender, EventArgs e)
        {
            Listar();
            CarregarComboBox();
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
                       INSERT INTO tb_turma 
                            (nome, serie, turno, ano_id)
                                VALUES ('{0}', '{1}', '{2}', {3})
                    ", txtNome.Text, cbSerie.Text, cbTurno.Text, cbAno.SelectedValue);

            // VERIFICA SE JA EXISTE
            string verificar = "SELECT nome, ano_id FROM tb_turma WHERE nome='" + txtNome.Text + "' and ano_id="+cbAno.SelectedValue+"";
            dt = Conexao.dql(verificar);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Turma já cadastrado!!", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        UPDATE tb_turma SET 
                            nome='{0}', serie='{1}', turno='{2}', ano_id={3}
                        WHERE
                            id_turma={4}
                    ", txtNome.Text, cbSerie.Text, cbTurno.Text, cbAno.SelectedValue, idSelecionado);
                    // VERIFICA SE JA EXISTE
                    if (txtNome.Text != TurmaAntigo)
                    {
                        string verificar = "SELECT nome, ano_id FROM tb_turma WHERE nome='"+txtNome.Text+"' and ano_id="+cbAno.SelectedValue+"";
                        dt = Conexao.dql(verificar);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Turma já cadastrado!!", "Erro ao editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string queryDelete = "DELETE FROM tb_turma WHERE id_turma=" + idSelecionado;
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
            cbSerie.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[2].Value.ToString();
            cbTurno.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cbAno.SelectedValue = grid.CurrentRow.Cells[4].Value.ToString();
            cbAno.Text = grid.CurrentRow.Cells[5].Value.ToString();
            

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            habilitarCampos();

            TurmaAntigo = grid.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
