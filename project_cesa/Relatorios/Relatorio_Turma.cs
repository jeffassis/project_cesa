using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa.Relatorios
{
    public partial class Relatorio_Turma : Form
    {
        public Relatorio_Turma()
        {
            InitializeComponent();
        }

        private void CarregarComboBoxTurma()
        {
            string turma = "SELECT * FROM tb_turma ORDER BY nome";
            cbTurma.Items.Clear();
            cbTurma.DataSource = Conexao.dql(turma);
            cbTurma.DisplayMember = "nome";
            cbTurma.ValueMember = "id_turma";
        }

        private void Relatorio_Turma_Load(object sender, EventArgs e)
        {
            CarregarComboBoxTurma();
            // TODO: esta linha de código carrega dados na tabela 'project_escolaDataSet.MontTurma'. Você pode movê-la ou removê-la conforme necessário.
            cbTurma.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.montTurmaTableAdapter.Fill(this.project_escolaDataSet.MontTurma, cbTurma.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
