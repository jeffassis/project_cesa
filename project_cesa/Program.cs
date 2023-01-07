﻿using System;
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

        // Variaveis globais de controle de usuario
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0; // 0= Basico, 1= Gerente. 2= Master

        // Variaveis globais cadastro Aluno
        public static string chamadaAlunos;
        public static string nomeAluno;
        public static string idAluno;

        // Variavel global cadastro Turma
        public static string idSerieTurma;

        // Variaveis para chamar tela horario
        public static string chamadaHorario;
        public static string idHorario;
        public static string nomeHorario;
        public static string diaHorario;

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
