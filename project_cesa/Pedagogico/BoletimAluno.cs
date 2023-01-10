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
    public partial class FrmBoletimAluno : Form
    {
        public FrmBoletimAluno()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "DISCIPLINA";
            Grid.Columns[1].HeaderText = "BIMESTRE";
            Grid.Columns[2].HeaderText = "NOTA";

            Grid.Columns[0].Width = 160;
            Grid.Columns[1].Width = 110;
            Grid.Columns[2].Width = 90;

        }
        private void Listar()
        {
            string queryListar = String.Format(@"
                   SELECT
                        tbd.nome as 'diciplina',
                        tbb.bimestre as 'bimestre',
                    (select nota from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=tbb.id_bimestre) as 'NOTA'
            from
            	tb_nota as tbn
            INNER JOIN tb_aluno as tba ON tba.id_aluno=aluno_id
            INNER JOIN tb_disciplina as tbd ON tbd.id_disciplina=disciplina_id
            INNER JOIN tb_bimestre as tbb ON tbb.id_bimestre=bimestre_id
            WHERE
            	tbn.aluno_id={0} and tbn.bimestre_id={1}
            Group by
            	tbd.nome,
                tba.id_aluno,
                tbd.id_disciplina,
                tbn.bimestre_id,
                tbb.bimestre", CbAluno.SelectedValue, cbBimestre.SelectedValue);
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
                cbBimestre.Enabled = true;
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

        private void CarregarComboBoxBimestre()
        {
            string bimestre = "SELECT * FROM tb_bimestre ORDER BY id_bimestre";
            cbBimestre.Items.Clear();
            cbBimestre.DataSource = Conexao.dql(bimestre);
            cbBimestre.DisplayMember = "bimestre";
            cbBimestre.ValueMember = "id_bimestre";
        }

        private void FrmBoletimAluno_Load(object sender, EventArgs e)
        {
            CarregarComboBoxTurma();
            CarregarComboBoxBimestre();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (CbAluno.Text == "" || cbBimestre.Text == "")
            {
                MessageBox.Show("Selecione aluno e bimestre!", "Erro de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CbAluno.Focus();
                return;
            }
            else
            {
                Listar();
                CbAluno.Enabled = false;
                cbBimestre.Enabled = false;
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (CbAluno.SelectedValue != null)
            {                
                Program.idSerieTurma = CbTurma.SelectedValue.ToString();
                Program.idAluno = CbAluno.SelectedValue.ToString();
                Program.idBimestre = cbBimestre.SelectedValue.ToString();

                Relatorios.FrmRelatorio_BoletimAluno form = new Relatorios.FrmRelatorio_BoletimAluno();
                form.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Selecione uma consulta", "Erro ao consultar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
