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

        private void Relatorio_Turma_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'project_escolaDataSet.MontTurma'. Você pode movê-la ou removê-la conforme necessário.
            this.montTurmaTableAdapter.Fill(this.project_escolaDataSet.MontTurma, Convert.ToInt32(Program.idSerieTurma));

            this.reportViewer1.RefreshReport();
        }
    }
}
