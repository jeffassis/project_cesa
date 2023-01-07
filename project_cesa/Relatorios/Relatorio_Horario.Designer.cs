
namespace project_cesa.Relatorios
{
    partial class FrmRelatorio_Horario
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.project_escolaDataSet = new project_cesa.project_escolaDataSet();
            this.relatorioHorarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorio_HorarioTableAdapter = new project_cesa.project_escolaDataSetTableAdapters.Relatorio_HorarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioHorarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSHorario";
            reportDataSource1.Value = this.relatorioHorarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "project_cesa.Relatorios.RelHorario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // project_escolaDataSet
            // 
            this.project_escolaDataSet.DataSetName = "project_escolaDataSet";
            this.project_escolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioHorarioBindingSource
            // 
            this.relatorioHorarioBindingSource.DataMember = "Relatorio_Horario";
            this.relatorioHorarioBindingSource.DataSource = this.project_escolaDataSet;
            // 
            // relatorio_HorarioTableAdapter
            // 
            this.relatorio_HorarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorio_Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorio_Horario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio_Horario";
            this.Load += new System.EventHandler(this.FrmRelatorio_Horario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioHorarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource relatorioHorarioBindingSource;
        private project_escolaDataSet project_escolaDataSet;
        private project_escolaDataSetTableAdapters.Relatorio_HorarioTableAdapter relatorio_HorarioTableAdapter;
    }
}