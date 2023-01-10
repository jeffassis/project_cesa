
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
            this.relatorioHorarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_escolaDataSet = new project_cesa.project_escolaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relatorio_HorarioTableAdapter = new project_cesa.project_escolaDataSetTableAdapters.Relatorio_HorarioTableAdapter();
            this.cbCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPqsquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioHorarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // relatorioHorarioBindingSource
            // 
            this.relatorioHorarioBindingSource.DataMember = "Relatorio_Horario";
            this.relatorioHorarioBindingSource.DataSource = this.project_escolaDataSet;
            // 
            // project_escolaDataSet
            // 
            this.project_escolaDataSet.DataSetName = "project_escolaDataSet";
            this.project_escolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // relatorio_HorarioTableAdapter
            // 
            this.relatorio_HorarioTableAdapter.ClearBeforeFill = true;
            // 
            // cbCombo
            // 
            this.cbCombo.FormattingEnabled = true;
            this.cbCombo.Location = new System.Drawing.Point(529, 2);
            this.cbCombo.Name = "cbCombo";
            this.cbCombo.Size = new System.Drawing.Size(121, 21);
            this.cbCombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turma:";
            // 
            // BtnPqsquisar
            // 
            this.BtnPqsquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPqsquisar.Image = global::project_cesa.Properties.Resources.pesquisa_16;
            this.BtnPqsquisar.Location = new System.Drawing.Point(656, 1);
            this.BtnPqsquisar.Name = "BtnPqsquisar";
            this.BtnPqsquisar.Size = new System.Drawing.Size(23, 23);
            this.BtnPqsquisar.TabIndex = 3;
            this.BtnPqsquisar.UseVisualStyleBackColor = true;
            this.BtnPqsquisar.Click += new System.EventHandler(this.BtnPqsquisar_Click);
            // 
            // FrmRelatorio_Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPqsquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCombo);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorio_Horario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio_Horario";
            this.Load += new System.EventHandler(this.FrmRelatorio_Horario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioHorarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource relatorioHorarioBindingSource;
        private project_escolaDataSet project_escolaDataSet;
        private project_escolaDataSetTableAdapters.Relatorio_HorarioTableAdapter relatorio_HorarioTableAdapter;
        private System.Windows.Forms.ComboBox cbCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPqsquisar;
    }
}