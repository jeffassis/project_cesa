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
    public partial class FrmBoletimFinal : Form
    {
        public FrmBoletimFinal()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "DISCIPLINA";
            Grid.Columns[1].HeaderText = "BIMESTRE 1";
            Grid.Columns[2].HeaderText = "BIMESTRE 2";
            Grid.Columns[3].HeaderText = "BIMESTRE 3";
            Grid.Columns[4].HeaderText = "BIMESTRE 4";
            Grid.Columns[5].HeaderText = "MEDIA";
            Grid.Columns[6].HeaderText = "ID_TURMA";

            // Visibilidade das colunas no Grid
            Grid.Columns[6].Visible = false;

            // O Header so fica centralizado se desabilitar a propriedade de ordenacao
            Grid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Valores numericos com duas casas decimais
            Grid.Columns[1].DefaultCellStyle.Format = "N2";
            Grid.Columns[2].DefaultCellStyle.Format = "N2";
            Grid.Columns[3].DefaultCellStyle.Format = "N2";
            Grid.Columns[4].DefaultCellStyle.Format = "N2";
            Grid.Columns[5].DefaultCellStyle.Format = "N2";

            // Colocar valores centralizados na celula
            Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Define o tamanho das celulas
            Grid.Columns[0].Width = 120;
            Grid.Columns[1].Width = 95;
            Grid.Columns[2].Width = 95;
            Grid.Columns[3].Width = 95;
            Grid.Columns[4].Width = 95;
            Grid.Columns[5].Width = 95;
        }
        private void Listar()
        {
            string queryListar = String.Format(@"
                   SELECT DISTINCT(tbd.nome) as 'DISCIPLINA',
                    (select AVG(nota) from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=1) as 'BIMESTRE 1',
                    (select AVG(nota) from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=2) as 'BIMESTRE 2',
                    (select AVG(nota) from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=3) as 'BIMESTRE 3',
                    (select AVG(nota) from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=4) as 'BIMESTRE 4',
                        ((select nota from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=1) +
                        (select nota from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=2) +
                        (select nota from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=3) +
                        (select nota from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=4))/4 as 'MÉDIA',
                    turma_id
                FROM
                    tb_nota as tbn
                INNER JOIN
                    tb_aluno tba ON tba.id_aluno=tbn.aluno_id 
                INNER JOIN
                    tb_disciplina as tbd ON tbd.id_disciplina=tbn.disciplina_id 
                INNER JOIN
                    tb_bimestre as tbb ON tbb.id_bimestre=tbn.bimestre_id
                INNER JOIN
                    tb_turma as tbt ON tbt.id_turma=tbn.turma_id
                WHERE
                    tbn.aluno_id={0} and tbn.turma_id={1}
                GROUP BY
                    tbd.nome, tba.id_aluno,tbd.id_disciplina,tbn.bimestre_id", CbAluno.SelectedValue, CbTurma.SelectedValue);
            Grid.DataSource = Conexao.dql(queryListar);
            FormatarDG();
        }

        private void CarregarComboBoxTurma()
        {
            string turma = "SELECT * FROM tb_turma ORDER BY nome";
            CbTurma.Items.Clear();
            CbTurma.DataSource = Conexao.dql(turma);
            CbTurma.DisplayMember = "nome";
            CbTurma.ValueMember = "id_turma";
        }       

        private void CbTurma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CbTurma.SelectedValue != null)
            {
                CarregarComboBoxAluno();
                CbAluno.Enabled = true;
            }
        }

        private void CarregarComboBoxAluno()
        {
            string aluno = String.Format(@"SELECT id_aluno, a.nome, id_turma
                        FROM tb_aluno_turma tba 
                        INNER JOIN tb_aluno a ON a.id_aluno = tba.aluno_id
                        INNER JOIN tb_turma t ON t.id_turma = tba.turma_id
                        WHERE id_turma={0}
                        ORDER BY a.nome", CbTurma.SelectedValue);
            CbAluno.SelectedIndex = -1;
            CbAluno.DataSource = Conexao.dql(aluno);
            CbAluno.DisplayMember = "nome";
            CbAluno.ValueMember = "id_aluno";
        }

        private void FrmBoletimFinal_Load(object sender, EventArgs e)
        {
            CarregarComboBoxTurma();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (CbAluno.Text == "" )
            {
                MessageBox.Show("Selecione turma e aluno!", "Erro de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CbAluno.Focus();
                return;
            }
            else
            {
                Listar();
                CbAluno.Enabled = false;
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (CbAluno.SelectedValue != null)
            {
                Program.idSerieTurma = CbTurma.SelectedValue.ToString();
                Program.idAluno = CbAluno.SelectedValue.ToString();

                Relatorios.FrmRelatorio_BoletimFinal form = new Relatorios.FrmRelatorio_BoletimFinal();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma consulta", "Erro ao consultar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
