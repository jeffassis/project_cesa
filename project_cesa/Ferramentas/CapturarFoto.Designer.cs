
namespace project_cesa.Ferramentas
{
    partial class FrmCapturarFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCapturarFoto));
            this.cb_combo = new System.Windows.Forms.ComboBox();
            this.BtnCapturar = new System.Windows.Forms.Button();
            this.BtnEncerrar = new System.Windows.Forms.Button();
            this.pictureCaptura = new System.Windows.Forms.PictureBox();
            this.pictureStream = new System.Windows.Forms.PictureBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaptura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_combo
            // 
            this.cb_combo.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_combo.FormattingEnabled = true;
            this.cb_combo.Location = new System.Drawing.Point(74, 327);
            this.cb_combo.Name = "cb_combo";
            this.cb_combo.Size = new System.Drawing.Size(240, 30);
            this.cb_combo.TabIndex = 1;
            // 
            // BtnCapturar
            // 
            this.BtnCapturar.Image = global::project_cesa.Properties.Resources.capturar_32;
            this.BtnCapturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCapturar.Location = new System.Drawing.Point(605, 363);
            this.BtnCapturar.Name = "BtnCapturar";
            this.BtnCapturar.Size = new System.Drawing.Size(100, 45);
            this.BtnCapturar.TabIndex = 5;
            this.BtnCapturar.Text = "  Capturar";
            this.BtnCapturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCapturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.BtnCapturar, "Tirar foto");
            this.BtnCapturar.UseVisualStyleBackColor = true;
            this.BtnCapturar.Click += new System.EventHandler(this.BtnCapturar_Click);
            // 
            // BtnEncerrar
            // 
            this.BtnEncerrar.Image = global::project_cesa.Properties.Resources.encerrar_gravar_32;
            this.BtnEncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEncerrar.Location = new System.Drawing.Point(193, 363);
            this.BtnEncerrar.Name = "BtnEncerrar";
            this.BtnEncerrar.Size = new System.Drawing.Size(100, 45);
            this.BtnEncerrar.TabIndex = 4;
            this.BtnEncerrar.Text = "  Encerrar";
            this.BtnEncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.BtnEncerrar, "Encerrar Vídeo");
            this.BtnEncerrar.UseVisualStyleBackColor = true;
            this.BtnEncerrar.Click += new System.EventHandler(this.BtnEncerrar_Click);
            // 
            // pictureCaptura
            // 
            this.pictureCaptura.Location = new System.Drawing.Point(452, 12);
            this.pictureCaptura.Name = "pictureCaptura";
            this.pictureCaptura.Size = new System.Drawing.Size(400, 300);
            this.pictureCaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCaptura.TabIndex = 3;
            this.pictureCaptura.TabStop = false;
            // 
            // pictureStream
            // 
            this.pictureStream.Location = new System.Drawing.Point(12, 12);
            this.pictureStream.Name = "pictureStream";
            this.pictureStream.Size = new System.Drawing.Size(400, 300);
            this.pictureStream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureStream.TabIndex = 2;
            this.pictureStream.TabStop = false;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Image = global::project_cesa.Properties.Resources.play_gravar_32;
            this.BtnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIniciar.Location = new System.Drawing.Point(87, 363);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(100, 45);
            this.BtnIniciar.TabIndex = 0;
            this.BtnIniciar.Text = "   Iniciar";
            this.BtnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.BtnIniciar, "Iniciar Vídeo");
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(515, 328);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(286, 29);
            this.txtNome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o nome do Aluno!!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project_cesa.Properties.Resources.cesa;
            this.pictureBox1.Location = new System.Drawing.Point(366, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCapturarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.BtnCapturar);
            this.Controls.Add(this.BtnEncerrar);
            this.Controls.Add(this.pictureCaptura);
            this.Controls.Add(this.pictureStream);
            this.Controls.Add(this.cb_combo);
            this.Controls.Add(this.BtnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCapturarFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapturarFoto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapturarFoto_FormClosing);
            this.Load += new System.EventHandler(this.FrmCapturarFoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaptura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.ComboBox cb_combo;
        private System.Windows.Forms.PictureBox pictureStream;
        private System.Windows.Forms.PictureBox pictureCaptura;
        private System.Windows.Forms.Button BtnEncerrar;
        private System.Windows.Forms.Button BtnCapturar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}