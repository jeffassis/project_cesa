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
            this.CadastrosAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrosResponsavel = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrosProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.Pedagogico = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoDisciplinas = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoHorarioCad = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoHorarioProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoHorarioAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoNotaLanca = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoNotaBoleAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoNotaBoleFinal = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoTurmas = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoTurmaCad = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogicoTurmaMont = new System.Windows.Forms.ToolStripMenuItem();
            this.Financeiro = new System.Windows.Forms.ToolStripMenuItem();
            this.FinanceiroMensalidades = new System.Windows.Forms.ToolStripMenuItem();
            this.Relatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.RelDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.RelDocumentosCircular = new System.Windows.Forms.ToolStripMenuItem();
            this.RelDocumentosDeclaracao = new System.Windows.Forms.ToolStripMenuItem();
            this.RelDocumentosHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.RelatoriosTurmas = new System.Windows.Forms.ToolStripMenuItem();
            this.RelatorioHora = new System.Windows.Forms.ToolStripMenuItem();
            this.RelHoraProf = new System.Windows.Forms.ToolStripMenuItem();
            this.Eventos = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosGestao = new System.Windows.Forms.ToolStripMenuItem();
            this.Ferramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.FerramentasSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.FerramentasFoto = new System.Windows.Forms.ToolStripMenuItem();
            this.FerramentasBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.Login = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginLogOn = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginLogOff = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.Financeiro,
            this.Relatorios,
            this.Eventos,
            this.Usuarios,
            this.Ferramentas,
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
            this.CadastrosAlunos,
            this.CadastrosResponsavel,
            this.CadastrosProfessor});
            this.Cadastros.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastros.Image = global::project_cesa.Properties.Resources.menuCadastro;
            this.Cadastros.Name = "Cadastros";
            this.Cadastros.Size = new System.Drawing.Size(89, 20);
            this.Cadastros.Text = "Cadastros";
            // 
            // CadastrosAlunos
            // 
            this.CadastrosAlunos.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrosAlunos.Image = global::project_cesa.Properties.Resources.aluno;
            this.CadastrosAlunos.Name = "CadastrosAlunos";
            this.CadastrosAlunos.Size = new System.Drawing.Size(143, 22);
            this.CadastrosAlunos.Text = "Alunos";
            this.CadastrosAlunos.Click += new System.EventHandler(this.CadastrosAlunos_Click);
            // 
            // CadastrosResponsavel
            // 
            this.CadastrosResponsavel.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrosResponsavel.Image = global::project_cesa.Properties.Resources.responsavel;
            this.CadastrosResponsavel.Name = "CadastrosResponsavel";
            this.CadastrosResponsavel.Size = new System.Drawing.Size(143, 22);
            this.CadastrosResponsavel.Text = "Responsável";
            this.CadastrosResponsavel.Click += new System.EventHandler(this.CadastrosResponsavel_Click);
            // 
            // CadastrosProfessor
            // 
            this.CadastrosProfessor.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrosProfessor.Image = global::project_cesa.Properties.Resources.professor;
            this.CadastrosProfessor.Name = "CadastrosProfessor";
            this.CadastrosProfessor.Size = new System.Drawing.Size(143, 22);
            this.CadastrosProfessor.Text = "Professor";
            this.CadastrosProfessor.Click += new System.EventHandler(this.CadastrosProfessor_Click);
            // 
            // Pedagogico
            // 
            this.Pedagogico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PedagogicoDisciplinas,
            this.PedagogicoHorario,
            this.PedagogicoNotas,
            this.PedagogicoTurmas});
            this.Pedagogico.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pedagogico.Image = global::project_cesa.Properties.Resources.pedagogico;
            this.Pedagogico.Name = "Pedagogico";
            this.Pedagogico.Size = new System.Drawing.Size(98, 20);
            this.Pedagogico.Text = "Pedagógico";
            // 
            // PedagogicoDisciplinas
            // 
            this.PedagogicoDisciplinas.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedagogicoDisciplinas.Image = global::project_cesa.Properties.Resources.disciplina;
            this.PedagogicoDisciplinas.Name = "PedagogicoDisciplinas";
            this.PedagogicoDisciplinas.Size = new System.Drawing.Size(180, 22);
            this.PedagogicoDisciplinas.Text = "Disciplinas";
            this.PedagogicoDisciplinas.Click += new System.EventHandler(this.PedagogicoDisciplina_Click);
            // 
            // PedagogicoHorario
            // 
            this.PedagogicoHorario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PedagogicoHorarioCad,
            this.PedagogicoHorarioProfessor,
            this.PedagogicoHorarioAluno});
            this.PedagogicoHorario.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedagogicoHorario.Image = global::project_cesa.Properties.Resources.clock1;
            this.PedagogicoHorario.Name = "PedagogicoHorario";
            this.PedagogicoHorario.Size = new System.Drawing.Size(180, 22);
            this.PedagogicoHorario.Text = "Horários";
            // 
            // PedagogicoHorarioCad
            // 
            this.PedagogicoHorarioCad.Image = global::project_cesa.Properties.Resources.menuCadastro;
            this.PedagogicoHorarioCad.Name = "PedagogicoHorarioCad";
            this.PedagogicoHorarioCad.Size = new System.Drawing.Size(196, 22);
            this.PedagogicoHorarioCad.Text = "Cadastros de Horários";
            this.PedagogicoHorarioCad.Click += new System.EventHandler(this.PedagogicoHorarioCad_Click);
            // 
            // PedagogicoHorarioProfessor
            // 
            this.PedagogicoHorarioProfessor.Image = global::project_cesa.Properties.Resources.professor;
            this.PedagogicoHorarioProfessor.Name = "PedagogicoHorarioProfessor";
            this.PedagogicoHorarioProfessor.Size = new System.Drawing.Size(196, 22);
            this.PedagogicoHorarioProfessor.Text = "Horário Professor";
            this.PedagogicoHorarioProfessor.Click += new System.EventHandler(this.PedagogicoHorarioProfessor_Click);
            // 
            // PedagogicoHorarioAluno
            // 
            this.PedagogicoHorarioAluno.Image = global::project_cesa.Properties.Resources.aluno;
            this.PedagogicoHorarioAluno.Name = "PedagogicoHorarioAluno";
            this.PedagogicoHorarioAluno.Size = new System.Drawing.Size(196, 22);
            this.PedagogicoHorarioAluno.Text = "Horário Aluno";
            this.PedagogicoHorarioAluno.Click += new System.EventHandler(this.PedagogicoHorarioAluno_Click);
            // 
            // PedagogicoNotas
            // 
            this.PedagogicoNotas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PedagogicoNotaLanca,
            this.PedagogicoNotaBoleAluno,
            this.PedagogicoNotaBoleFinal});
            this.PedagogicoNotas.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedagogicoNotas.Image = global::project_cesa.Properties.Resources.notas;
            this.PedagogicoNotas.Name = "PedagogicoNotas";
            this.PedagogicoNotas.Size = new System.Drawing.Size(180, 22);
            this.PedagogicoNotas.Text = "Notas";
            // 
            // PedagogicoNotaLanca
            // 
            this.PedagogicoNotaLanca.Image = global::project_cesa.Properties.Resources.lancamento_de_nota_20;
            this.PedagogicoNotaLanca.Name = "PedagogicoNotaLanca";
            this.PedagogicoNotaLanca.Size = new System.Drawing.Size(195, 22);
            this.PedagogicoNotaLanca.Text = "Lançamento de Notas";
            this.PedagogicoNotaLanca.Click += new System.EventHandler(this.PedagogicoNotaLanca_Click);
            // 
            // PedagogicoNotaBoleAluno
            // 
            this.PedagogicoNotaBoleAluno.Name = "PedagogicoNotaBoleAluno";
            this.PedagogicoNotaBoleAluno.Size = new System.Drawing.Size(195, 22);
            this.PedagogicoNotaBoleAluno.Text = "Boletim Aluno";
            this.PedagogicoNotaBoleAluno.Click += new System.EventHandler(this.PedagogicoNotaBoleAluno_Click);
            // 
            // PedagogicoNotaBoleFinal
            // 
            this.PedagogicoNotaBoleFinal.Name = "PedagogicoNotaBoleFinal";
            this.PedagogicoNotaBoleFinal.Size = new System.Drawing.Size(195, 22);
            this.PedagogicoNotaBoleFinal.Text = "Boletim Final";
            // 
            // PedagogicoTurmas
            // 
            this.PedagogicoTurmas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PedagogicoTurmaCad,
            this.PedagogicoTurmaMont});
            this.PedagogicoTurmas.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedagogicoTurmas.Image = global::project_cesa.Properties.Resources.turma;
            this.PedagogicoTurmas.Name = "PedagogicoTurmas";
            this.PedagogicoTurmas.Size = new System.Drawing.Size(180, 22);
            this.PedagogicoTurmas.Text = "Turmas";
            // 
            // PedagogicoTurmaCad
            // 
            this.PedagogicoTurmaCad.Image = global::project_cesa.Properties.Resources.menuCadastro;
            this.PedagogicoTurmaCad.Name = "PedagogicoTurmaCad";
            this.PedagogicoTurmaCad.Size = new System.Drawing.Size(196, 22);
            this.PedagogicoTurmaCad.Text = "Cadastros de Turmas";
            this.PedagogicoTurmaCad.Click += new System.EventHandler(this.PedagogicoTurmaCad_Click);
            // 
            // PedagogicoTurmaMont
            // 
            this.PedagogicoTurmaMont.Image = global::project_cesa.Properties.Resources.montar_20;
            this.PedagogicoTurmaMont.Name = "PedagogicoTurmaMont";
            this.PedagogicoTurmaMont.Size = new System.Drawing.Size(196, 22);
            this.PedagogicoTurmaMont.Text = "Montagem de Turmas";
            this.PedagogicoTurmaMont.Click += new System.EventHandler(this.PedagogicoTurmaMont_Click);
            // 
            // Financeiro
            // 
            this.Financeiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FinanceiroMensalidades});
            this.Financeiro.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Financeiro.Image = global::project_cesa.Properties.Resources.financeiro_20;
            this.Financeiro.Name = "Financeiro";
            this.Financeiro.Size = new System.Drawing.Size(95, 20);
            this.Financeiro.Text = "Financeiro";
            // 
            // FinanceiroMensalidades
            // 
            this.FinanceiroMensalidades.Image = global::project_cesa.Properties.Resources.mensalidade_20;
            this.FinanceiroMensalidades.Name = "FinanceiroMensalidades";
            this.FinanceiroMensalidades.Size = new System.Drawing.Size(150, 22);
            this.FinanceiroMensalidades.Text = "Mensalidades";
            // 
            // Relatorios
            // 
            this.Relatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RelDocumentos,
            this.RelatoriosTurmas,
            this.RelatorioHora});
            this.Relatorios.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relatorios.Image = global::project_cesa.Properties.Resources.menuReports;
            this.Relatorios.Name = "Relatorios";
            this.Relatorios.Size = new System.Drawing.Size(92, 20);
            this.Relatorios.Text = "Relatórios";
            // 
            // RelDocumentos
            // 
            this.RelDocumentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RelDocumentosCircular,
            this.RelDocumentosDeclaracao,
            this.RelDocumentosHistorico});
            this.RelDocumentos.Image = global::project_cesa.Properties.Resources.documentos_20;
            this.RelDocumentos.Name = "RelDocumentos";
            this.RelDocumentos.Size = new System.Drawing.Size(145, 22);
            this.RelDocumentos.Text = "Documentos";
            // 
            // RelDocumentosCircular
            // 
            this.RelDocumentosCircular.Image = global::project_cesa.Properties.Resources.circular_20;
            this.RelDocumentosCircular.Name = "RelDocumentosCircular";
            this.RelDocumentosCircular.Size = new System.Drawing.Size(142, 22);
            this.RelDocumentosCircular.Text = "Circular";
            // 
            // RelDocumentosDeclaracao
            // 
            this.RelDocumentosDeclaracao.Image = global::project_cesa.Properties.Resources.declaracao_20;
            this.RelDocumentosDeclaracao.Name = "RelDocumentosDeclaracao";
            this.RelDocumentosDeclaracao.Size = new System.Drawing.Size(142, 22);
            this.RelDocumentosDeclaracao.Text = "Declarações";
            // 
            // RelDocumentosHistorico
            // 
            this.RelDocumentosHistorico.Image = global::project_cesa.Properties.Resources.square_poll_20;
            this.RelDocumentosHistorico.Name = "RelDocumentosHistorico";
            this.RelDocumentosHistorico.Size = new System.Drawing.Size(142, 22);
            this.RelDocumentosHistorico.Text = "Históricos";
            // 
            // RelatoriosTurmas
            // 
            this.RelatoriosTurmas.Image = global::project_cesa.Properties.Resources.turma;
            this.RelatoriosTurmas.Name = "RelatoriosTurmas";
            this.RelatoriosTurmas.Size = new System.Drawing.Size(145, 22);
            this.RelatoriosTurmas.Text = "Turmas";
            this.RelatoriosTurmas.Click += new System.EventHandler(this.RelatoriosTurmas_Click);
            // 
            // RelatorioHora
            // 
            this.RelatorioHora.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RelHoraProf});
            this.RelatorioHora.Image = global::project_cesa.Properties.Resources.clock1;
            this.RelatorioHora.Name = "RelatorioHora";
            this.RelatorioHora.Size = new System.Drawing.Size(145, 22);
            this.RelatorioHora.Text = "Horários";
            // 
            // RelHoraProf
            // 
            this.RelHoraProf.Image = global::project_cesa.Properties.Resources.professor;
            this.RelHoraProf.Name = "RelHoraProf";
            this.RelHoraProf.Size = new System.Drawing.Size(126, 22);
            this.RelHoraProf.Text = "Professor";
            this.RelHoraProf.Click += new System.EventHandler(this.RelHoraProf_Click);
            // 
            // Eventos
            // 
            this.Eventos.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eventos.Image = global::project_cesa.Properties.Resources.carrinho_compras_20;
            this.Eventos.Name = "Eventos";
            this.Eventos.Size = new System.Drawing.Size(80, 20);
            this.Eventos.Text = "Eventos";
            // 
            // Usuarios
            // 
            this.Usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosGestao});
            this.Usuarios.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.Image = global::project_cesa.Properties.Resources.menuUser;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(84, 20);
            this.Usuarios.Text = "Usuários";
            // 
            // UsuariosGestao
            // 
            this.UsuariosGestao.Image = global::project_cesa.Properties.Resources.users;
            this.UsuariosGestao.Name = "UsuariosGestao";
            this.UsuariosGestao.Size = new System.Drawing.Size(181, 22);
            this.UsuariosGestao.Text = "Gestão de Usuários";
            this.UsuariosGestao.Click += new System.EventHandler(this.UsuariosGestao_Click);
            // 
            // Ferramentas
            // 
            this.Ferramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FerramentasSobre,
            this.FerramentasFoto,
            this.FerramentasBackup});
            this.Ferramentas.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ferramentas.Image = global::project_cesa.Properties.Resources.ferramentas_20;
            this.Ferramentas.Name = "Ferramentas";
            this.Ferramentas.Size = new System.Drawing.Size(104, 20);
            this.Ferramentas.Text = "Ferramentas";
            // 
            // FerramentasSobre
            // 
            this.FerramentasSobre.Image = global::project_cesa.Properties.Resources.hand_peace_20;
            this.FerramentasSobre.Name = "FerramentasSobre";
            this.FerramentasSobre.Size = new System.Drawing.Size(166, 22);
            this.FerramentasSobre.Text = "Sobre nós";
            this.FerramentasSobre.Click += new System.EventHandler(this.FerramentasSobre_Click);
            // 
            // FerramentasFoto
            // 
            this.FerramentasFoto.Image = global::project_cesa.Properties.Resources.capturar_32;
            this.FerramentasFoto.Name = "FerramentasFoto";
            this.FerramentasFoto.Size = new System.Drawing.Size(166, 22);
            this.FerramentasFoto.Text = "Capturar Foto";
            this.FerramentasFoto.Click += new System.EventHandler(this.FerramentasFoto_Click);
            // 
            // FerramentasBackup
            // 
            this.FerramentasBackup.Image = global::project_cesa.Properties.Resources.bancoDados_20;
            this.FerramentasBackup.Name = "FerramentasBackup";
            this.FerramentasBackup.Size = new System.Drawing.Size(166, 22);
            this.FerramentasBackup.Text = "Backup de dados";
            this.FerramentasBackup.Click += new System.EventHandler(this.FerramentasBackup_Click);
            // 
            // Login
            // 
            this.Login.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginLogOn,
            this.LoginLogOff});
            this.Login.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Image = global::project_cesa.Properties.Resources.sair2;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(68, 20);
            this.Login.Text = "Login";
            // 
            // LoginLogOn
            // 
            this.LoginLogOn.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLogOn.Image = global::project_cesa.Properties.Resources.logON;
            this.LoginLogOn.Name = "LoginLogOn";
            this.LoginLogOn.Size = new System.Drawing.Size(122, 22);
            this.LoginLogOn.Text = "LogON";
            this.LoginLogOn.Click += new System.EventHandler(this.LoginLogOn_Click);
            // 
            // LoginLogOff
            // 
            this.LoginLogOff.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLogOff.Image = global::project_cesa.Properties.Resources.logOFF;
            this.LoginLogOff.Name = "LoginLogOff";
            this.LoginLogOff.Size = new System.Drawing.Size(122, 22);
            this.LoginLogOff.Text = "LogOFF";
            this.LoginLogOff.Click += new System.EventHandler(this.LoginLogOff_Click);
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
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
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
        private System.Windows.Forms.ToolStripMenuItem LoginLogOn;
        private System.Windows.Forms.ToolStripMenuItem LoginLogOff;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem CadastrosAlunos;
        private System.Windows.Forms.ToolStripMenuItem CadastrosResponsavel;
        private System.Windows.Forms.ToolStripMenuItem CadastrosProfessor;
        private System.Windows.Forms.ToolStripMenuItem Pedagogico;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoTurmas;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoHorario;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoNotas;
        private System.Windows.Forms.ToolStripMenuItem Relatorios;
        private System.Windows.Forms.ToolStripMenuItem Usuarios;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoTurmaCad;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoTurmaMont;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoHorarioCad;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoHorarioProfessor;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoNotaLanca;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoNotaBoleAluno;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoNotaBoleFinal;
        private System.Windows.Forms.ToolStripMenuItem PedagogicoHorarioAluno;
        private System.Windows.Forms.ToolStripMenuItem UsuariosGestao;
        private System.Windows.Forms.ToolStripMenuItem Eventos;
        private System.Windows.Forms.ToolStripMenuItem Ferramentas;
        private System.Windows.Forms.ToolStripMenuItem FerramentasBackup;
        private System.Windows.Forms.ToolStripMenuItem FerramentasSobre;
        private System.Windows.Forms.ToolStripMenuItem RelatoriosTurmas;
        private System.Windows.Forms.ToolStripMenuItem Financeiro;
        private System.Windows.Forms.ToolStripMenuItem FinanceiroMensalidades;
        private System.Windows.Forms.ToolStripMenuItem FerramentasFoto;
        private System.Windows.Forms.ToolStripMenuItem RelatorioHora;
        private System.Windows.Forms.ToolStripMenuItem RelHoraProf;
        private System.Windows.Forms.ToolStripMenuItem RelDocumentos;
        private System.Windows.Forms.ToolStripMenuItem RelDocumentosCircular;
        private System.Windows.Forms.ToolStripMenuItem RelDocumentosDeclaracao;
        private System.Windows.Forms.ToolStripMenuItem RelDocumentosHistorico;
    }
}

