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

        private void FrmRelatorio_Horario_Load(object sender, EventArgs e)
        {
            
            this.relatorio_HorarioTableAdapter.Fill(this.project_escolaDataSet.Relatorio_Horario, Convert.ToInt32(Program.idHorario));

            this.reportViewer1.RefreshReport();
        }
    }
}
