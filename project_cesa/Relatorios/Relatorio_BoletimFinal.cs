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
    public partial class FrmRelatorio_BoletimFinal : Form
    {
        public FrmRelatorio_BoletimFinal()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_BoletimFinal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
