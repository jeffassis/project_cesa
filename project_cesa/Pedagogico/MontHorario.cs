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
            Grid.Columns[0].HeaderText = "ID MHORA";
            Grid.Columns[1].HeaderText = "HORA";
            Grid.Columns[2].HeaderText = "DIA SEMANA";
            Grid.Columns[3].HeaderText = "DISCIPLINA";
            Grid.Columns[4].HeaderText = "SERIE";
            Grid.Columns[5].HeaderText = "ANO";
            Grid.Columns[6].HeaderText = "ID TURMA";

            Grid.Columns[0].Visible = false;
            Grid.Columns[6].Visible = false;

            Grid.Columns[1].Width = 90;
            Grid.Columns[3].Width = 95;
            Grid.Columns[4].Width = 65;
            Grid.Columns[5].Width = 50;
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
                        tbh.dia_id,tbh.descricao
                    ", CbSerie.SelectedValue);
            Grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void CarregarComboBoxSerie()
        {
            string ano = "SELECT * FROM tb_turma ORDER BY nome";
            CbSerie.Items.Clear();
            CbSerie.DataSource = Conexao.dql(ano);
            CbSerie.DisplayMember = "serie";
            CbSerie.ValueMember = "id_turma";
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

        private void HabilitarCampos()
        {
            CbSerie.Enabled = true;
            cbAno.Enabled = true;
            cbDisciplina.Enabled = true;
            BtnAluno.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            //cbSerie.Enabled = false;
            cbAno.Enabled = false;
            cbDisciplina.Enabled = false;
            BtnAluno.Enabled = false;
        }

        private void LimparCampos()
        {
            cbHora.SelectedIndex = -1;
            txtDia.Text = "";
            //cbSerie.SelectedIndex = -1;
            cbAno.SelectedIndex = -1;
            cbDisciplina.SelectedIndex = -1;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMontHorario_Load(object sender, EventArgs e)
        {
            CarregarComboBoxSerie();
            CarregarComboBoxDisciplina();
            CarregarComboBoxAno();
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            Program.chamadaHorario = "hora";
            Pedagogico.FrmHorario form = new Pedagogico.FrmHorario();
            form.Show();
        }

        private void FrmMontHorario_Activated(object sender, EventArgs e)
        {
            cbHora.Text = Program.nomeHorario;
            txtDia.Text = Program.diaHorario;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            BtnSave.Enabled = true;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void CbSerie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CbSerie.SelectedValue != null)
            {
                Listar();
                // Passo o id da turma para o relatorio
                Program.idSerieTurma = CbSerie.SelectedValue.ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O NOME ESTA VAZIO
            if (cbHora.Text.ToString().Trim() == "")
            {
                cbHora.SelectedIndex = -1;
                MessageBox.Show("Preencha a Hora", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbHora.Focus();
                return;
            }
            string queryAdd = String.Format(@"INSERT INTO tb_mhora (horario_id, disciplina_id, turma_id, ano_id)
                                VALUES ({0}, {1}, {2}, {3})
                    ", Program.idHorario, cbDisciplina.SelectedValue, CbSerie.SelectedValue, cbAno.SelectedValue);

            Conexao.dml(queryAdd);
            MessageBox.Show("Dados inseridos com sucesso!", "Dados Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                string queryDelete = "DELETE FROM tb_mhora WHERE id_mhora=" + idSelecionado;
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O NOME ESTA VAZIO
            if (cbHora.Text.ToString().Trim() == "")
            {
                cbHora.SelectedIndex = -1;
                MessageBox.Show("Preencha a Hora", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbHora.Focus();
                return;
            }
            string queryAdd = String.Format(@"UPDATE tb_mhora SET horario_id={0}, disciplina_id={1}, turma_id={2}, ano_id={3} WHERE id_mhora={4}
                    ", Program.idHorario, cbDisciplina.SelectedValue, CbSerie.SelectedValue, cbAno.SelectedValue, idSelecionado);

            Conexao.dml(queryAdd);
            MessageBox.Show("Dados atualizados com sucesso!", "Dados Atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnSave.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            Listar();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();
            cbHora.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtDia.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            cbDisciplina.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            CbSerie.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            cbAno.Text = Grid.CurrentRow.Cells[5].Value.ToString();

            BtnDelete.Enabled = true;
            BtnUpdate.Enabled = true;
            BtnSave.Enabled = false;
            HabilitarCampos();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            Relatorios.FrmRelatorio_Horario form = new Relatorios.FrmRelatorio_Horario();
            form.ShowDialog();
        }
    }
}
