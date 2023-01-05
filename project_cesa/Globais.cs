using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cesa
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0; // 0= Basico, 1= Gerente. 2= Master

        public static string caminhoBanco = "SERVER=localhost; DATABASE=project_escola; UID=root; PWD=; PORT=;";

        // Adiciona o caminho para Fotos
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string caminhoFotos = caminho + @"\fotos\";
    }
}
