using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa.Financeiro
{
    public partial class FrmMovimentacao : Form
    {
        public FrmMovimentacao()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID_MOVIMENTACAO";
            Grid.Columns[1].HeaderText = "TIPO";
            Grid.Columns[2].HeaderText = "MOVIMENTO";
            Grid.Columns[3].HeaderText = "VALOR";
            Grid.Columns[4].HeaderText = "DATA";
            Grid.Columns[5].HeaderText = "ID_MOVIMENTO";

            //Grid.Columns[0].Visible = false;

            Grid.Columns[3].DefaultCellStyle.Format = "C2";

            //Grid.Columns[1].Width = 160;
            //Grid.Columns[3].Width = 140;
        }

        private void Listar()
        {
            string queryListar = "SELECT * FROM tb_movimentacao ORDER BY data desc";
            Grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void FrmMovimentacao_Load(object sender, EventArgs e)
        {
            CbBuscar.SelectedIndex = 0;
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            Listar();
        }
    }
}
