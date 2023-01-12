using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa
{
    internal static class Program
    {
        // Variavel global de Conexao de dados
        public static string caminhoBanco = "SERVER=localhost; DATABASE=project_escola; UID=root; PWD=; PORT=;";
        //public static string caminhoBanco = "SERVER=mysql835.umbler.com; DATABASE=project_escola; UID=jeffassis; PWD=jean1420; PORT=41890;";

        // Variaveis globais de controle de usuario
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0; // 0= Basico, 1= Gerente. 2= Master

        // Variaveis globais cadastro Aluno
        public static string chamadaAlunos;
        public static string nomeAluno;
        public static string idAluno;

        public static string idSerieTurma;
        public static string idBimestre;

        // Variaveis para chamar tela horario
        public static string chamadaHorario;
        public static string idHorario;
        public static string nomeHorario;
        public static string diaHorario;

        // Variaveis globais Produtos
        public static string chamadaProduto;
        public static string idProduto;
        public static string nomeProduto;
        public static string estoqueProduto;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
