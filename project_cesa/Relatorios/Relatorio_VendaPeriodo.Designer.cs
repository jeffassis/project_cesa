
namespace project_cesa.Relatorios
{
    partial class Relatorio_VendaPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio_VendaPeriodo));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DtInicial = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DtFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbStatus = new System.Windows.Forms.ComboBox();
            this.vendaPorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_escolaDataSet = new project_cesa.project_escolaDataSet();
            this.vendaPorDataTableAdapter = new project_cesa.project_escolaDataSetTableAdapters.vendaPorDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vendaPorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DSdataPeriodo";
            reportDataSource1.Value = this.vendaPorDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "project_cesa.Relatorios.RelVendaPeriodo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(660, 397);
            this.reportViewer1.TabIndex = 0;
            // 
            // DtInicial
            // 
            this.DtInicial.CalendarFont = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtInicial.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtInicial.Location = new System.Drawing.Point(381, 12);
            this.DtInicial.Name = "DtInicial";
            this.DtInicial.Size = new System.Drawing.Size(97, 23);
            this.DtInicial.TabIndex = 53;
            this.DtInicial.ValueChanged += new System.EventHandler(this.DtInicial_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "Data Inicial.:";
            // 
            // DtFinal
            // 
            this.DtFinal.CalendarFont = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFinal.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFinal.Location = new System.Drawing.Point(575, 12);
            this.DtFinal.Name = "DtFinal";
            this.DtFinal.Size = new System.Drawing.Size(97, 23);
            this.DtFinal.TabIndex = 55;
            this.DtFinal.ValueChanged += new System.EventHandler(this.DtFinal_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Data Final.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Status:";
            // 
            // CbStatus
            // 
            this.CbStatus.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbStatus.FormattingEnabled = true;
            this.CbStatus.Items.AddRange(new object[] {
            "Efetuada",
            "Cancelada"});
            this.CbStatus.Location = new System.Drawing.Point(63, 13);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(96, 23);
            this.CbStatus.TabIndex = 57;
            this.CbStatus.SelectedIndexChanged += new System.EventHandler(this.CbStatus_SelectedIndexChanged);
            // 
            // vendaPorDataBindingSource
            // 
            this.vendaPorDataBindingSource.DataMember = "vendaPorData";
            this.vendaPorDataBindingSource.DataSource = this.project_escolaDataSet;
            // 
            // project_escolaDataSet
            // 
            this.project_escolaDataSet.DataSetName = "project_escolaDataSet";
            this.project_escolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaPorDataTableAdapter
            // 
            this.vendaPorDataTableAdapter.ClearBeforeFill = true;
            // 
            // Relatorio_VendaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.CbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio_VendaPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Venda por Periodo";
            this.Load += new System.EventHandler(this.Relatorio_VendaPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaPorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker DtInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vendaPorDataBindingSource;
        private project_escolaDataSet project_escolaDataSet;
        private project_escolaDataSetTableAdapters.vendaPorDataTableAdapter vendaPorDataTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbStatus;
    }
}