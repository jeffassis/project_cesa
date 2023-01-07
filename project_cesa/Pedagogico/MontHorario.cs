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
    public partial class FrmMontHorario : Form
    {
        string idSelecionado;
        public FrmMontHorario()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "ID MHORA";
            grid.Columns[1].HeaderText = "HORA";
            grid.Columns[2].HeaderText = "DIA SEMANA";
            grid.Columns[3].HeaderText = "DISCIPLINA";
            grid.Columns[4].HeaderText = "SERIE";
            grid.Columns[5].HeaderText = "ANO";
            grid.Columns[6].HeaderText = "ID TURMA";

            grid.Columns[0].Visible = false;
            grid.Columns[6].Visible = false;

            grid.Columns[1].Width = 90;
            grid.Columns[3].Width = 85;
            grid.Columns[4].Width = 73;
            grid.Columns[5].Width = 50;
        }

        private void Listar()
        {
            string queryListar = String.Format(@"
                    SELECT
	                    tbm.id_mhora,
	                    tbh.descricao, 
                        (SELECT d.dia from tb_diasemana d WHERE d.id_dia = tbh.dia_id) as dia,
                        tbd.nome,
                        tbt.serie,
                        tba.ano,
                        tbt.id_turma
                    FROM
	                    tb_mhora as tbm
                    INNER JOIN
	                    tb_horario as tbh ON tbh.id_horario=tbm.horario_id
                    INNER JOIN
	                    tb_disciplina as tbd ON tbd.id_disciplina=tbm.disciplina_id
                    INNER JOIN
	                    tb_turma as tbt ON tbt.id_turma=tbm.turma_id
                    INNER JOIN
	                    tb_ano as tba ON tba.id_ano=tbm.ano_id
                    WHERE
	                    tbt.id_turma={0}
                    ORDER BY
                        tbh.descricao
                    ", cbSerie.SelectedValue);
            grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void CarregarComboBoxSerie()
        {
            string ano = "SELECT * FROM tb_turma ORDER BY nome";
            cbSerie.Items.Clear();
            cbSerie.DataSource = Conexao.dql(ano);
            cbSerie.DisplayMember = "serie";
            cbSerie.ValueMember = "id_turma";
        }

        private void CarregarComboBoxDisciplina()
        {
            string ano = "SELECT * FROM tb_disciplina ORDER BY nome";
            cbDisciplina.Items.Clear();
            cbDisciplina.DataSource = Conexao.dql(ano);
            cbDisciplina.DisplayMember = "nome";
            cbDisciplina.ValueMember = "id_disciplina";
        }

        private void CarregarComboBoxAno()
        {
            string ano = "SELECT * FROM tb_ano ORDER BY ano";
            cbAno.Items.Clear();
            cbAno.DataSource = Conexao.dql(ano);
            cbAno.DisplayMember = "ano";
            cbAno.ValueMember = "id_ano";
        }

        private void habilitarCampos()
        {
            cbSerie.Enabled = true;
            cbAno.Enabled = true;
            cbDisciplina.Enabled = true;
            btnAluno.Enabled = true;
        }

        private void desabilitarCampos()
        {
            //cbSerie.Enabled = false;
            cbAno.Enabled = false;
            cbDisciplina.Enabled = false;
            btnAluno.Enabled = false;
        }

        private void limparCampos()
        {
            txtHora.Text = "";
            txtDia.Text = "";
            //cbSerie.SelectedIndex = -1;
            cbAno.SelectedIndex = -1;
            cbDisciplina.SelectedIndex = -1;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMontHorario_Load(object sender, EventArgs e)
        {
            CarregarComboBoxSerie();
            CarregarComboBoxDisciplina();
            CarregarComboBoxAno();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            Program.chamadaHorario = "mHora";
            Pedagogico.FrmHorario form = new Pedagogico.FrmHorario();
            form.Show();
        }

        private void FrmMontHorario_Activated(object sender, EventArgs e)
        {
            txtHora.Text = Program.nomeHorario;
            txtDia.Text = Program.diaHorario;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void cbSerie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbSerie.SelectedValue != null)
            {
                Listar();
                // Passo o id da turma para o relatorio
                Program.idHorario = cbSerie.SelectedValue.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O NOME ESTA VAZIO
            if (txtHora.Text.ToString().Trim() == "")
            {
                txtHora.Text = "";
                MessageBox.Show("Preencha a Hora", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHora.Focus();
                return;
            }
            string queryAdd = "";
            queryAdd = String.Format(@"INSERT INTO tb_mHora (horario_id, disciplina_id, turma_id, ano_id)
                                VALUES ({0}, {1}, {2}, {3})
                    ", Program.idHorario, cbDisciplina.SelectedValue, cbSerie.SelectedValue, cbAno.SelectedValue);

            Conexao.dml(queryAdd);
            MessageBox.Show("Dados inseridos com sucesso!", "Dados Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                string queryDelete = "DELETE FROM tb_mHora WHERE id_mHora=" + idSelecionado;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O NOME ESTA VAZIO
            if (txtHora.Text.ToString().Trim() == "")
            {
                txtHora.Text = "";
                MessageBox.Show("Preencha a Hora", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHora.Focus();
                return;
            }
            string queryAdd = "";
            queryAdd = String.Format(@"UPDATE tb_mHora SET horario_id={0}, disciplina_id={1}, turma_id={2}, ano_id={3} WHERE id_mHora={4}
                    ", Program.idHorario, cbDisciplina.SelectedValue, cbSerie.SelectedValue, cbAno.SelectedValue, idSelecionado);

            Conexao.dml(queryAdd);
            MessageBox.Show("Dados atualizados com sucesso!", "Dados Atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            desabilitarCampos();
            limparCampos();
            Listar();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = grid.CurrentRow.Cells[0].Value.ToString();
            txtHora.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtDia.Text = grid.CurrentRow.Cells[2].Value.ToString();
            cbDisciplina.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cbSerie.Text = grid.CurrentRow.Cells[4].Value.ToString();
            cbAno.Text = grid.CurrentRow.Cells[5].Value.ToString();

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            habilitarCampos();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Relatorios.FrmRelatorio_Horario form = new Relatorios.FrmRelatorio_Horario();
            form.ShowDialog();
        }
    }
}
