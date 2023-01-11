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
    public partial class FrmMontHoraAluno : Form
    {
        string idSelecionado;
        public FrmMontHoraAluno()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID MHORA";
            Grid.Columns[1].HeaderText = "DESCRICAO";
            Grid.Columns[2].HeaderText = "SEGUNDA";
            Grid.Columns[3].HeaderText = "TERÇA";
            Grid.Columns[4].HeaderText = "QUARTA";
            Grid.Columns[5].HeaderText = "QUINTA";
            Grid.Columns[6].HeaderText = "SEXTA";
            Grid.Columns[7].HeaderText = "SERIE";
            Grid.Columns[8].HeaderText = "ANO";
            Grid.Columns[9].HeaderText = "ID_TURMA";

            Grid.Columns[0].Visible = false;
            //Grid.Columns[6].Visible = false;

            Grid.Columns[1].Width = 90;
            Grid.Columns[2].Width = 85;
            //Grid.Columns[4].Width = 73;
            //Grid.Columns[5].Width = 50;
        }

        private void Listar()
        {
            string queryListar = @"select id_horaAluno, descricao ,
                (select nome from tb_disciplina d where d.id_disciplina = r.Segunda) AS Segunda,
                (select nome from tb_disciplina d where d.id_disciplina = r.Terca) AS Terca,
                (select nome from tb_disciplina d where d.id_disciplina = r.Quarta) AS Quarta,
                (select nome from tb_disciplina d where d.id_disciplina = r.Quinta) AS Quinta,
                (select nome from tb_disciplina d where d.id_disciplina = r.Sexta) AS Sexta,
                serie AS SERIE,
                ano AS ANO,
                id_turma
            from(
                select
                    id_horaAluno,
                    descricao,
                    SUM(case when tbs.id_dia = 1 then disciplina_id else 0 end) AS SEGUNDA, 
                    SUM(case when tbs.id_dia = 2 then disciplina_id else 0 end) AS TERCA, 
                    SUM(case when tbs.id_dia = 3 then disciplina_id else 0 end) AS QUARTA, 
                    SUM(case when tbs.id_dia = 4 then disciplina_id else 0 end) AS QUINTA, 
                    SUM(case when tbs.id_dia = 5 then disciplina_id else 0 end) AS SEXTA, 
                    tbt.serie, 
                    tba.ano,
                    id_turma
            from tb_horaaluno as tbm 
            inner join tb_horario as tbh ON tbh.id_horario = tbm.horario_id 
            inner join tb_diasemana as tbs ON tbs.id_dia = tbm.dia_id 
            inner join tb_disciplina as tbd ON tbd.id_disciplina = tbm.disciplina_id 
            inner join tb_turma as tbt ON tbt.id_turma = tbm.turma_id 
            inner join tb_ano as tba ON tba.id_ano = tbm.ano_id 
            GROUP BY descricao 
            ) r
            WHERE
                id_turma="+CbSerie.SelectedValue;
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
            txtHora.Text = "";
            txtDia.Text = "";
            //cbSerie.SelectedIndex = -1;
            cbAno.SelectedIndex = -1;
            cbDisciplina.SelectedIndex = -1;
        }

        private void FrmMontHoraAluno_Load(object sender, EventArgs e)
        {
            CarregarComboBoxSerie();
            CarregarComboBoxDisciplina();
            CarregarComboBoxAno();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            Program.chamadaHorario = "hora";
            Pedagogico.FrmHorario form = new Pedagogico.FrmHorario();
            form.Show();
        }

        private void FrmMontHoraAluno_Activated(object sender, EventArgs e)
        {
            txtHora.Text = Program.nomeHorario;
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
                Program.idHorario = CbSerie.SelectedValue.ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O NOME ESTA VAZIO
            if (txtHora.Text.ToString().Trim() == "")
            {
                txtHora.Text = "";
                MessageBox.Show("Preencha a Hora", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHora.Focus();
                return;
            }
            string queryAdd = String.Format(@"INSERT INTO tb_mHora (horario_id, disciplina_id, turma_id, ano_id)
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O NOME ESTA VAZIO
            if (txtHora.Text.ToString().Trim() == "")
            {
                txtHora.Text = "";
                MessageBox.Show("Preencha a Hora", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHora.Focus();
                return;
            }
            string queryAdd = String.Format(@"UPDATE tb_mHora SET horario_id={0}, disciplina_id={1}, turma_id={2}, ano_id={3} WHERE id_mHora={4}
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Cria um Dialogo para confirmar a exclusao de dados
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryDelete = "DELETE FROM tb_horaaluno WHERE id_horaAluno=" + idSelecionado;
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
            txtHora.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtDia.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txtDia.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            CbSerie.Text = Grid.CurrentRow.Cells[7].Value.ToString();
            cbAno.Text = Grid.CurrentRow.Cells[8].Value.ToString();
            // = Grid.CurrentRow.Cells[9].Value.ToString();

            BtnDelete.Enabled = true;
            BtnUpdate.Enabled = true;
            BtnSave.Enabled = false;
            HabilitarCampos();
        }
    }
}
