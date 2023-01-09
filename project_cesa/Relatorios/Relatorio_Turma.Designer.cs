
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
            System.Windows.Forms.Label nomeLabel;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.montTurmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_escolaDataSet = new project_cesa.project_escolaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.montTurmaTableAdapter = new project_cesa.project_escolaDataSetTableAdapters.MontTurmaTableAdapter();
            this.tableAdapterManager = new project_cesa.project_escolaDataSetTableAdapters.TableAdapterManager();
            this.cbTurma = new System.Windows.Forms.ComboBox();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.montTurmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.SystemColors.Control;
            nomeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            nomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            nomeLabel.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(448, 7);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(58, 14);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "TURMA:";
            // 
            // montTurmaBindingSource
            // 
            this.montTurmaBindingSource.DataMember = "MontTurma";
            this.montTurmaBindingSource.DataSource = this.project_escolaDataSet;
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
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(712, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::project_cesa.Properties.Resources.pesquisa_16;
            this.button1.Location = new System.Drawing.Point(635, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // montTurmaTableAdapter
            // 
            this.montTurmaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tb_aluno_turmaTableAdapter = null;
            this.tableAdapterManager.tb_alunoTableAdapter = null;
            this.tableAdapterManager.tb_anoTableAdapter = null;
            this.tableAdapterManager.tb_diasemanaTableAdapter = null;
            this.tableAdapterManager.tb_disciplinaTableAdapter = null;
            this.tableAdapterManager.tb_horaalunoTableAdapter = null;
            this.tableAdapterManager.tb_horarioTableAdapter = null;
            this.tableAdapterManager.tb_mhoraTableAdapter = null;
            this.tableAdapterManager.tb_responsavelTableAdapter = null;
            this.tableAdapterManager.tb_turmaTableAdapter = null;
            this.tableAdapterManager.tb_userTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project_cesa.project_escolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbTurma
            // 
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Location = new System.Drawing.Point(508, 2);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(121, 21);
            this.cbTurma.TabIndex = 4;
            // 
            // Relatorio_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 467);
            this.Controls.Add(this.cbTurma);
            this.Controls.Add(this.button1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Relatorio_Turma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio_Turma";
            this.Load += new System.EventHandler(this.Relatorio_Turma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.montTurmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_escolaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private project_escolaDataSet project_escolaDataSet;
        private project_escolaDataSetTableAdapters.MontTurmaTableAdapter montTurmaTableAdapter;
        private System.Windows.Forms.BindingSource montTurmaBindingSource;
        private project_escolaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTurma;
    }
}