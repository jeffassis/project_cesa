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
    public partial class FrmRelatorio_BoletimAluno : Form
    {
        public FrmRelatorio_BoletimAluno()
        {
            InitializeComponent();
        }

        private void Relatorio_BoletimAluno_Load(object sender, EventArgs e)
        {
            this.relatorio_BoletimAlunoTableAdapter.Fill(this.project_escolaDataSet.Relatorio_BoletimAluno, Convert.ToInt32(Program.idAluno), Convert.ToInt32(Program.idBimestre));
            this.reportViewer1.RefreshReport();
        }
    }
}
