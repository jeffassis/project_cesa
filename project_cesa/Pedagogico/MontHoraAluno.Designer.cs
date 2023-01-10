
namespace project_cesa.Pedagogico
{
    partial class FrmMontHoraAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMontHoraAluno));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbSerie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Location = new System.Drawing.Point(274, 34);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid.Size = new System.Drawing.Size(494, 221);
            this.Grid.TabIndex = 41;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Horário do Aluno";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.BtnImprimir);
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 47);
            this.panel1.TabIndex = 42;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Image = global::project_cesa.Properties.Resources.bt_update_24;
            this.BtnUpdate.Location = new System.Drawing.Point(96, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(36, 36);
            this.BtnUpdate.TabIndex = 6;
            this.toolTip1.SetToolTip(this.BtnUpdate, "Atualizar dados");
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimir.Image = global::project_cesa.Properties.Resources.imprimir_24;
            this.BtnImprimir.Location = new System.Drawing.Point(274, 3);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(36, 36);
            this.BtnImprimir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BtnImprimir, "Imprimir dados");
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.Image = global::project_cesa.Properties.Resources.bt_fechar_24;
            this.BtnFechar.Location = new System.Drawing.Point(732, 3);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(36, 36);
            this.BtnFechar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.BtnFechar, "Fechar");
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = global::project_cesa.Properties.Resources.bt_delete;
            this.BtnDelete.Location = new System.Drawing.Point(138, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(36, 36);
            this.BtnDelete.TabIndex = 3;
            this.toolTip1.SetToolTip(this.BtnDelete, "Remover dados");
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Enabled = false;
            this.BtnSave.Image = global::project_cesa.Properties.Resources.bt_save_24;
            this.BtnSave.Location = new System.Drawing.Point(54, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(36, 36);
            this.BtnSave.TabIndex = 1;
            this.toolTip1.SetToolTip(this.BtnSave, "Salvar dados");
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.Image = global::project_cesa.Properties.Resources.bt_novo_24;
            this.BtnNovo.Location = new System.Drawing.Point(12, 3);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(36, 36);
            this.BtnNovo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BtnNovo, "Novo registro");
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(12, 93);
            this.txtHora.Mask = "00:00 - 00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(110, 23);
            this.txtHora.TabIndex = 51;
            // 
            // txtDia
            // 
            this.txtDia.Enabled = false;
            this.txtDia.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.Location = new System.Drawing.Point(130, 148);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(132, 23);
            this.txtDia.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Dia da Semana.:";
            // 
            // BtnAluno
            // 
            this.BtnAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAluno.Enabled = false;
            this.BtnAluno.Image = global::project_cesa.Properties.Resources.source_20;
            this.BtnAluno.Location = new System.Drawing.Point(136, 88);
            this.BtnAluno.Name = "BtnAluno";
            this.BtnAluno.Size = new System.Drawing.Size(30, 30);
            this.BtnAluno.TabIndex = 48;
            this.BtnAluno.UseVisualStyleBackColor = true;
            this.BtnAluno.Click += new System.EventHandler(this.BtnAluno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Hora.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "Ano.:";
            // 
            // cbAno
            // 
            this.cbAno.Enabled = false;
            this.cbAno.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(12, 202);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(110, 23);
            this.cbAno.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "Serie.:";
            // 
            // CbSerie
            // 
            this.CbSerie.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSerie.FormattingEnabled = true;
            this.CbSerie.Location = new System.Drawing.Point(12, 147);
            this.CbSerie.Name = "CbSerie";
            this.CbSerie.Size = new System.Drawing.Size(110, 23);
            this.CbSerie.TabIndex = 54;
            this.CbSerie.SelectionChangeCommitted += new System.EventHandler(this.CbSerie_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "Disciplina.:";
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.Enabled = false;
            this.cbDisciplina.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(130, 202);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(132, 23);
            this.cbDisciplina.TabIndex = 52;
            // 
            // FrmMontHoraAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 317);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbSerie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDisciplina);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMontHoraAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horário Aluno";
            this.Activated += new System.EventHandler(this.FrmMontHoraAluno_Activated);
            this.Load += new System.EventHandler(this.FrmMontHoraAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDisciplina;
    }
}