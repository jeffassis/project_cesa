
namespace project_cesa.Relatorios
{
    partial class FrmRelatorio_BoletimAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio_BoletimAluno));
            this.relatorioBoletimAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_escolaDataSet = new project_cesa.project_escolaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relatorio_BoletimAlunoTableAdapter = new project_cesa.project_escolaDataSetTableAdapters.Relatorio_BoletimAlunoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBoletimAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // relatorioBoletimAlunoBindingSource
            // 
            this.relatorioBoletimAlunoBindingSource.DataMember = "Relatorio_BoletimAluno";
            this.relatorioBoletimAlunoBindingSource.DataSource = this.project_escolaDataSet;
            // 
            // project_escolaDataSet
            // 
            this.project_escolaDataSet.DataSetName = "project_escolaDataSet";
            this.project_escolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_BoletimAluno";
            reportDataSource1.Value = this.relatorioBoletimAlunoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "project_cesa.Relatorios.RelBoletimAluno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // relatorio_BoletimAlunoTableAdapter
            // 
            this.relatorio_BoletimAlunoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorio_BoletimAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorio_BoletimAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio_BoletimAluno";
            this.Load += new System.EventHandler(this.Relatorio_BoletimAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBoletimAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource relatorioBoletimAlunoBindingSource;
        private project_escolaDataSet project_escolaDataSet;
        private project_escolaDataSetTableAdapters.Relatorio_BoletimAlunoTableAdapter relatorio_BoletimAlunoTableAdapter;
    }
}