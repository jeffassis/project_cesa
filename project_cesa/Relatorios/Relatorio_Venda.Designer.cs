
namespace project_cesa.Relatorios
{
    partial class FrmRelatorio_Venda
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio_Venda));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.project_escolaDataSet = new project_cesa.project_escolaDataSet();
            this.detalheVendaPorIddetalheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalheVendaPorId_detalheTableAdapter = new project_cesa.project_escolaDataSetTableAdapters.detalheVendaPorId_detalheTableAdapter();
            this.vendaPorIdvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaPorId_vendaTableAdapter = new project_cesa.project_escolaDataSetTableAdapters.vendaPorId_vendaTableAdapter();
            this.detalheVendaPorId_detalheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaPorId_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheVendaPorIddetalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaPorIdvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheVendaPorId_detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaPorId_vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSDetalhe";
            reportDataSource1.Value = this.detalheVendaPorIddetalheBindingSource;
            reportDataSource2.Name = "DSVenda";
            reportDataSource2.Value = this.vendaPorId_vendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "project_cesa.Relatorios.RelVenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(733, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // project_escolaDataSet
            // 
            this.project_escolaDataSet.DataSetName = "project_escolaDataSet";
            this.project_escolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalheVendaPorIddetalheBindingSource
            // 
            this.detalheVendaPorIddetalheBindingSource.DataMember = "detalheVendaPorId_detalhe";
            this.detalheVendaPorIddetalheBindingSource.DataSource = this.project_escolaDataSet;
            // 
            // detalheVendaPorId_detalheTableAdapter
            // 
            this.detalheVendaPorId_detalheTableAdapter.ClearBeforeFill = true;
            // 
            // vendaPorIdvendaBindingSource
            // 
            this.vendaPorIdvendaBindingSource.DataMember = "vendaPorId_venda";
            this.vendaPorIdvendaBindingSource.DataSource = this.project_escolaDataSet;
            // 
            // vendaPorId_vendaTableAdapter
            // 
            this.vendaPorId_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // detalheVendaPorId_detalheBindingSource
            // 
            this.detalheVendaPorId_detalheBindingSource.DataMember = "detalheVendaPorId_detalhe";
            this.detalheVendaPorId_detalheBindingSource.DataSource = this.project_escolaDataSet;
            // 
            // vendaPorId_vendaBindingSource
            // 
            this.vendaPorId_vendaBindingSource.DataMember = "vendaPorId_venda";
            this.vendaPorId_vendaBindingSource.DataSource = this.project_escolaDataSet;
            // 
            // FrmRelatorio_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorio_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio_Venda";
            this.Load += new System.EventHandler(this.FrmRelatorio_Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheVendaPorIddetalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaPorIdvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheVendaPorId_detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaPorId_vendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource detalheVendaPorIddetalheBindingSource;
        private project_escolaDataSet project_escolaDataSet;
        private System.Windows.Forms.BindingSource vendaPorIdvendaBindingSource;
        private project_escolaDataSetTableAdapters.detalheVendaPorId_detalheTableAdapter detalheVendaPorId_detalheTableAdapter;
        private project_escolaDataSetTableAdapters.vendaPorId_vendaTableAdapter vendaPorId_vendaTableAdapter;
        private System.Windows.Forms.BindingSource detalheVendaPorId_detalheBindingSource;
        private System.Windows.Forms.BindingSource vendaPorId_vendaBindingSource;
    }
}