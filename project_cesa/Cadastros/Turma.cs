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
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "SERIE";
            Grid.Columns[2].HeaderText = "TURMA";
            Grid.Columns[3].HeaderText = "TURNO";
            Grid.Columns[4].HeaderText = "ID_ANO";
            Grid.Columns[5].HeaderText = "ANO";

            Grid.Columns[0].Visible = false;
            Grid.Columns[3].Visible = false;
            Grid.Columns[4].Visible = false;

            Grid.Columns[5].Width = 88;
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
            Grid.DataSource = Conexao.dql(queryListar);

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

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;           
            cbSerie.Enabled = true;
            cbTurno.Enabled = true;
            cbAno.Enabled = true;            
            txtNome.Focus();
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            cbSerie.Enabled = false;
            cbTurno.Enabled = false;
            cbAno.Enabled = false;
        }

        private void LimparCampos()
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
                string queryDelete = "DELETE FROM tb_turma WHERE id_turma=" + idSelecionado;
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
            cbSerie.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            cbTurno.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            cbAno.SelectedValue = Grid.CurrentRow.Cells[4].Value.ToString();
            cbAno.Text = Grid.CurrentRow.Cells[5].Value.ToString();
            

            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            HabilitarCampos();

            TurmaAntigo = Grid.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
