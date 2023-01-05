
namespace project_cesa.Relatorios
{
    partial class Relatorio_Turma
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
            this.project_escolaDataSet = new project_cesa.project_escolaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.montTurmaTableAdapter = new project_cesa.project_escolaDataSetTableAdapters.MontTurmaTableAdapter();
            this.montTurmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montTurmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // project_escolaDataSet
            // 
            this.project_escolaDataSet.DataSetName = "project_escolaDataSet";
            this.project_escolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_MontTurma";
            reportDataSource1.Value = this.montTurmaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "project_cesa.Relatorios.RelTurma1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // montTurmaTableAdapter
            // 
            this.montTurmaTableAdapter.ClearBeforeFill = true;
            // 
            // montTurmaBindingSource
            // 
            this.montTurmaBindingSource.DataMember = "MontTurma";
            this.montTurmaBindingSource.DataSource = this.project_escolaDataSet;
            // 
            // Relatorio_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Relatorio_Turma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio_Turma";
            this.Load += new System.EventHandler(this.Relatorio_Turma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montTurmaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private project_escolaDataSet project_escolaDataSet;
        private project_escolaDataSetTableAdapters.MontTurmaTableAdapter montTurmaTableAdapter;
        private System.Windows.Forms.BindingSource montTurmaBindingSource;
    }
}