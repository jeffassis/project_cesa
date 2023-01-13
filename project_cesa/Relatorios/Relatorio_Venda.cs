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
    public partial class FrmRelatorio_Venda : Form
    {
        public FrmRelatorio_Venda()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Venda_Load(object sender, EventArgs e)
        {
            this.vendaPorId_vendaTableAdapter.Fill(this.project_escolaDataSet.vendaPorId_venda, Convert.ToInt32(Program.idVenda));
            this.detalheVendaPorId_detalheTableAdapter.Fill(this.project_escolaDataSet.detalheVendaPorId_detalhe, Convert.ToInt32(Program.idVenda));

            this.reportViewer1.RefreshReport();
        }
    }
}
