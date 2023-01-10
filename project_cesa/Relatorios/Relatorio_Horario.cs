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
    public partial class FrmRelatorio_Horario : Form
    {
        public FrmRelatorio_Horario()
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

        private void FrmRelatorio_Horario_Load(object sender, EventArgs e)
        {
            CarregarComboBoxTurma();
            cbCombo.Focus();

        }

        private void BtnPqsquisar_Click(object sender, EventArgs e)
        {
            this.relatorio_HorarioTableAdapter.Fill(this.project_escolaDataSet.Relatorio_Horario, Convert.ToInt32(cbCombo.SelectedValue));

            this.reportViewer1.RefreshReport();

        }
    }
}
