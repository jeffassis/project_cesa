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
    public partial class Relatorio_VendaPeriodo : Form
    {
        public Relatorio_VendaPeriodo()
        {
            InitializeComponent();
        }

        private void Relatorio_VendaPeriodo_Load(object sender, EventArgs e)
        {         
            DtInicial.Value = DateTime.Today;
            DtFinal.Value = DateTime.Today;
            CbStatus.SelectedIndex = 0;
            BuscarData();
        }

        private void BuscarData()
        {
            this.vendaPorDataTableAdapter.Fill(this.project_escolaDataSet.vendaPorData, Convert.ToDateTime(DtInicial.Text), Convert.ToDateTime(DtFinal.Text), CbStatus.Text);
            // Buscar o parametro
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", DtInicial.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", DtFinal.Text));

            this.reportViewer1.RefreshReport();
        }

        private void DtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void DtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarData();
        }
    }
}
