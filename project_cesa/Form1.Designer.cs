namespace project_cesa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.Cadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsávelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pedagogico = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeHoráriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montagemDeHoráriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletimAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletimFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosDeTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montagemDeTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Relatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Login = new System.Windows.Forms.ToolStripMenuItem();
            this.logONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_nomeUsuario = new System.Windows.Forms.Label();
            this.lbl_acesso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastros,
            this.Pedagogico,
            this.Relatorios,
            this.Usuarios,
            this.Login});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuBar.Size = new System.Drawing.Size(1031, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // Cadastros
            // 
            this.Cadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.responsávelToolStripMenuItem,
            this.professorToolStripMenuItem});
            this.Cadastros.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastros.Image = global::project_cesa.Properties.Resources.menuCadastro;
            this.Cadastros.Name = "Cadastros";
            this.Cadastros.Size = new System.Drawing.Size(89, 20);
            this.Cadastros.Text = "Cadastros";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alunoToolStripMenuItem.Image = global::project_cesa.Properties.Resources.aluno;
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alunoToolStripMenuItem.Text = "Alunos";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // responsávelToolStripMenuItem
            // 
            this.responsávelToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsávelToolStripMenuItem.Image = global::project_cesa.Properties.Resources.responsavel;
            this.responsávelToolStripMenuItem.Name = "responsávelToolStripMenuItem";
            this.responsávelToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.responsávelToolStripMenuItem.Text = "Responsável";
            this.responsávelToolStripMenuItem.Click += new System.EventHandler(this.responsávelToolStripMenuItem_Click);
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professorToolStripMenuItem.Image = global::project_cesa.Properties.Resources.professor;
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.professorToolStripMenuItem.Text = "Professor";
            // 
            // Pedagogico
            // 
            this.Pedagogico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasToolStripMenuItem,
            this.horáriosToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.Pedagogico.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pedagogico.Image = global::project_cesa.Properties.Resources.pedagogico;
            this.Pedagogico.Name = "Pedagogico";
            this.Pedagogico.Size = new System.Drawing.Size(98, 20);
            this.Pedagogico.Text = "Pedagógico";
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinasToolStripMenuItem.Image = global::project_cesa.Properties.Resources.disciplina;
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas";
            // 
            // horáriosToolStripMenuItem
            // 
            this.horáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeHoráriosToolStripMenuItem,
            this.montagemDeHoráriosToolStripMenuItem});
            this.horáriosToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horáriosToolStripMenuItem.Image = global::project_cesa.Properties.Resources.clock1;
            this.horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            this.horáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horáriosToolStripMenuItem.Text = "Horários";
            // 
            // cadastroDeHoráriosToolStripMenuItem
            // 
            this.cadastroDeHoráriosToolStripMenuItem.Image = global::project_cesa.Properties.Resources.menuCadastro;
            this.cadastroDeHoráriosToolStripMenuItem.Name = "cadastroDeHoráriosToolStripMenuItem";
            this.cadastroDeHoráriosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cadastroDeHoráriosToolStripMenuItem.Text = "Cadastros de Horários";
            this.cadastroDeHoráriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeHoráriosToolStripMenuItem_Click);
            // 
            // montagemDeHoráriosToolStripMenuItem
            // 
            this.montagemDeHoráriosToolStripMenuItem.Image = global::project_cesa.Properties.Resources.montar_20;
            this.montagemDeHoráriosToolStripMenuItem.Name = "montagemDeHoráriosToolStripMenuItem";
            this.montagemDeHoráriosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.montagemDeHoráriosToolStripMenuItem.Text = "Montagem de Horários";
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançamentoDeNotasToolStripMenuItem,
            this.boletimAlunoToolStripMenuItem,
            this.boletimFinalToolStripMenuItem});
            this.notasToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasToolStripMenuItem.Image = global::project_cesa.Properties.Resources.notas;
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // lançamentoDeNotasToolStripMenuItem
            // 
            this.lançamentoDeNotasToolStripMenuItem.Name = "lançamentoDeNotasToolStripMenuItem";
            this.lançamentoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.lançamentoDeNotasToolStripMenuItem.Text = "Lançamento de Notas";
            // 
            // boletimAlunoToolStripMenuItem
            // 
            this.boletimAlunoToolStripMenuItem.Name = "boletimAlunoToolStripMenuItem";
            this.boletimAlunoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.boletimAlunoToolStripMenuItem.Text = "Boletim Aluno";
            // 
            // boletimFinalToolStripMenuItem
            // 
            this.boletimFinalToolStripMenuItem.Name = "boletimFinalToolStripMenuItem";
            this.boletimFinalToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.boletimFinalToolStripMenuItem.Text = "Boletim Final";
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosDeTurmasToolStripMenuItem,
            this.montagemDeTurmasToolStripMenuItem});
            this.turmasToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turmasToolStripMenuItem.Image = global::project_cesa.Properties.Resources.turma;
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            // 
            // cadastrosDeTurmasToolStripMenuItem
            // 
            this.cadastrosDeTurmasToolStripMenuItem.Image = global::project_cesa.Properties.Resources.menuCadastro;
            this.cadastrosDeTurmasToolStripMenuItem.Name = "cadastrosDeTurmasToolStripMenuItem";
            this.cadastrosDeTurmasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cadastrosDeTurmasToolStripMenuItem.Text = "Cadastros de Turmas";
            this.cadastrosDeTurmasToolStripMenuItem.Click += new System.EventHandler(this.cadastrosDeTurmasToolStripMenuItem_Click);
            // 
            // montagemDeTurmasToolStripMenuItem
            // 
            this.montagemDeTurmasToolStripMenuItem.Image = global::project_cesa.Properties.Resources.montar_20;
            this.montagemDeTurmasToolStripMenuItem.Name = "montagemDeTurmasToolStripMenuItem";
            this.montagemDeTurmasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.montagemDeTurmasToolStripMenuItem.Text = "Montagem de Turmas";
            this.montagemDeTurmasToolStripMenuItem.Click += new System.EventHandler(this.montagemDeTurmasToolStripMenuItem_Click);
            // 
            // Relatorios
            // 
            this.Relatorios.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relatorios.Image = global::project_cesa.Properties.Resources.menuReports;
            this.Relatorios.Name = "Relatorios";
            this.Relatorios.Size = new System.Drawing.Size(92, 20);
            this.Relatorios.Text = "Relatórios";
            // 
            // Usuarios
            // 
            this.Usuarios.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.Image = global::project_cesa.Properties.Resources.menuUser;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(84, 20);
            this.Usuarios.Text = "Usuários";
            // 
            // Login
            // 
            this.Login.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logONToolStripMenuItem,
            this.logOFFToolStripMenuItem});
            this.Login.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Image = global::project_cesa.Properties.Resources.sair2;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(68, 20);
            this.Login.Text = "Login";
            // 
            // logONToolStripMenuItem
            // 
            this.logONToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logONToolStripMenuItem.Image = global::project_cesa.Properties.Resources.logON;
            this.logONToolStripMenuItem.Name = "logONToolStripMenuItem";
            this.logONToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.logONToolStripMenuItem.Text = "LogON";
            this.logONToolStripMenuItem.Click += new System.EventHandler(this.logONToolStripMenuItem_Click);
            // 
            // logOFFToolStripMenuItem
            // 
            this.logOFFToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOFFToolStripMenuItem.Image = global::project_cesa.Properties.Resources.logOFF;
            this.logOFFToolStripMenuItem.Name = "logOFFToolStripMenuItem";
            this.logOFFToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.logOFFToolStripMenuItem.Text = "LogOFF";
            this.logOFFToolStripMenuItem.Click += new System.EventHandler(this.logOFFToolStripMenuItem_Click);
            // 
            // lbl_nomeUsuario
            // 
            this.lbl_nomeUsuario.AutoSize = true;
            this.lbl_nomeUsuario.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeUsuario.Location = new System.Drawing.Point(71, 168);
            this.lbl_nomeUsuario.Name = "lbl_nomeUsuario";
            this.lbl_nomeUsuario.Size = new System.Drawing.Size(20, 17);
            this.lbl_nomeUsuario.TabIndex = 1;
            this.lbl_nomeUsuario.Text = "---";
            // 
            // lbl_acesso
            // 
            this.lbl_acesso.AutoSize = true;
            this.lbl_acesso.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acesso.Location = new System.Drawing.Point(69, 195);
            this.lbl_acesso.Name = "lbl_acesso";
            this.lbl_acesso.Size = new System.Drawing.Size(16, 17);
            this.lbl_acesso.TabIndex = 2;
            this.lbl_acesso.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_nomeUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_acesso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(851, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 537);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "--------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "--------------------------------------------------------";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::project_cesa.Properties.Resources.menuUser1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 111);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(70, 62);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(88, 17);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "01/01/2023";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "DATA:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(75, 23);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(80, 22);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "13:00:00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::project_cesa.Properties.Resources.clock;
            this.pictureBox2.Location = new System.Drawing.Point(9, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nivel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project_cesa.Properties.Resources.led_red;
            this.pictureBox1.Location = new System.Drawing.Point(104, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1031, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem Cadastros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_nomeUsuario;
        public System.Windows.Forms.Label lbl_acesso;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem Login;
        private System.Windows.Forms.ToolStripMenuItem logONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOFFToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsávelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Pedagogico;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Relatorios;
        private System.Windows.Forms.ToolStripMenuItem Usuarios;
        private System.Windows.Forms.ToolStripMenuItem cadastrosDeTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem montagemDeTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeHoráriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem montagemDeHoráriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançamentoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletimAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletimFinalToolStripMenuItem;
    }
}

