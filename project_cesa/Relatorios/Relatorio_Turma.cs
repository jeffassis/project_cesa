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
            cbCombo.Items.Clear();
            cbCombo.DataSource = Conexao.dql(turma);
            cbCombo.DisplayMember = "nome";
            cbCombo.ValueMember = "id_turma";
        }

        private void Relatorio_Turma_Load(object sender, EventArgs e)
        {
            CarregarComboBoxTurma();
            cbCombo.Focus();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            this.montTurmaTableAdapter.Fill(this.project_escolaDataSet.MontTurma, Convert.ToInt32(cbCombo.SelectedValue));
            // TODO: esta linha de código carrega dados na tabela 'project_escolaDataSet.MontTurma'. Você pode movê-la ou removê-la conforme necessário.
            this.reportViewer1.RefreshReport();            
        }
    }
}
