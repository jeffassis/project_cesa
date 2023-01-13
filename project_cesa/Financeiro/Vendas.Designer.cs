
namespace project_cesa.Financeiro
{
    partial class FrmVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            this.BtnProduto = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.DtBuscar = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.GridDetalhes = new System.Windows.Forms.DataGridView();
            this.BtnFecharGrid = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalhes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnProduto
            // 
            this.BtnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProduto.Enabled = false;
            this.BtnProduto.Image = global::project_cesa.Properties.Resources.source_20;
            this.BtnProduto.Location = new System.Drawing.Point(261, 21);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.Size = new System.Drawing.Size(28, 28);
            this.BtnProduto.TabIndex = 46;
            this.BtnProduto.UseVisualStyleBackColor = true;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(73, 23);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(182, 23);
            this.txtProduto.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Produto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstoque);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 98);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venda de Produtos";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Location = new System.Drawing.Point(20, 46);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(58, 23);
            this.txtEstoque.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(98, 46);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(68, 23);
            this.txtQuantidade.TabIndex = 40;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(189, 46);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(57, 23);
            this.txtValor.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Buscar Venda:";
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
            this.Grid.Location = new System.Drawing.Point(12, 168);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(569, 217);
            this.Grid.TabIndex = 50;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // DtBuscar
            // 
            this.DtBuscar.CalendarFont = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtBuscar.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtBuscar.Location = new System.Drawing.Point(401, 136);
            this.DtBuscar.Name = "DtBuscar";
            this.DtBuscar.Size = new System.Drawing.Size(97, 23);
            this.DtBuscar.TabIndex = 51;
            this.DtBuscar.ValueChanged += new System.EventHandler(this.DtBuscar_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 47);
            this.panel1.TabIndex = 52;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(49, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 15);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Total:";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.Image = global::project_cesa.Properties.Resources.bt_fechar_24;
            this.BtnFechar.Location = new System.Drawing.Point(545, 2);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(36, 36);
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = global::project_cesa.Properties.Resources.bt_delete;
            this.BtnDelete.Location = new System.Drawing.Point(300, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(36, 36);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Enabled = false;
            this.BtnSave.Image = global::project_cesa.Properties.Resources.bt_save_24;
            this.BtnSave.Location = new System.Drawing.Point(258, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(36, 36);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.Image = global::project_cesa.Properties.Resources.bt_novo_24;
            this.BtnNovo.Location = new System.Drawing.Point(216, 3);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(36, 36);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Image = global::project_cesa.Properties.Resources.btn_plus_20;
            this.BtnAdd.Location = new System.Drawing.Point(516, 134);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(28, 28);
            this.BtnAdd.TabIndex = 53;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.Enabled = false;
            this.BtnRemove.Image = global::project_cesa.Properties.Resources.btn_minus_20;
            this.BtnRemove.Location = new System.Drawing.Point(550, 134);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(28, 28);
            this.BtnRemove.TabIndex = 54;
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // GridDetalhes
            // 
            this.GridDetalhes.AllowUserToAddRows = false;
            this.GridDetalhes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDetalhes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDetalhes.EnableHeadersVisualStyles = false;
            this.GridDetalhes.Location = new System.Drawing.Point(20, 232);
            this.GridDetalhes.MultiSelect = false;
            this.GridDetalhes.Name = "GridDetalhes";
            this.GridDetalhes.ReadOnly = true;
            this.GridDetalhes.RowHeadersVisible = false;
            this.GridDetalhes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDetalhes.Size = new System.Drawing.Size(531, 148);
            this.GridDetalhes.TabIndex = 55;
            this.GridDetalhes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDetalhes_CellClick);
            // 
            // BtnFecharGrid
            // 
            this.BtnFecharGrid.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnFecharGrid.BackgroundImage = global::project_cesa.Properties.Resources.bt_fechar_24;
            this.BtnFecharGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFecharGrid.FlatAppearance.BorderSize = 0;
            this.BtnFecharGrid.Location = new System.Drawing.Point(554, 230);
            this.BtnFecharGrid.Name = "BtnFecharGrid";
            this.BtnFecharGrid.Size = new System.Drawing.Size(23, 23);
            this.BtnFecharGrid.TabIndex = 56;
            this.BtnFecharGrid.UseVisualStyleBackColor = false;
            this.BtnFecharGrid.Visible = false;
            this.BtnFecharGrid.Click += new System.EventHandler(this.BtnFecharGrid_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::project_cesa.Properties.Resources.cesa;
            this.pictureBox2.Location = new System.Drawing.Point(387, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 436);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnFecharGrid);
            this.Controls.Add(this.GridDetalhes);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DtBuscar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Activated += new System.EventHandler(this.FrmVendas_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVendas_FormClosing);
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalhes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DateTimePicker DtBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.DataGridView GridDetalhes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnFecharGrid;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}