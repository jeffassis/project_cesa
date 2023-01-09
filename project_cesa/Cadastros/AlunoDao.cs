using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace project_cesa.Cadastros
{
    internal class AlunoDao
    {

        public static void NovoAluno(AlunoModel aluno)
        {
            if (ExisteAluno(aluno))
            {
                MessageBox.Show("Aluno já existe", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var vcon = Conexao.AbrirCon();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"INSERT INTO tb_aluno(nome, email, endereco, bairro, cep, nascimento, telefone, sangue, imagem) 
                                VALUES (@nome, @email, @endereco, @bairro, @cep, @nascimento, @telefone, @sangue, @imagem)";
                cmd.Parameters.AddWithValue("@nome", aluno.nome);
                cmd.Parameters.AddWithValue("@email", aluno.email);
                cmd.Parameters.AddWithValue("@endereco", aluno.endereco);
                cmd.Parameters.AddWithValue("@bairro", aluno.bairro);
                cmd.Parameters.AddWithValue("@cep", aluno.cep);
                cmd.Parameters.AddWithValue("@nascimento", aluno.nascimento);
                cmd.Parameters.AddWithValue("@telefone", aluno.telefone);
                cmd.Parameters.AddWithValue("@sangue", aluno.sangue);
                cmd.Parameters.AddWithValue("@imagem", aluno.imagem);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno inserido com sucesso", "Salvar aluno!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarAluno(AlunoModel aluno)
        {
            if (ExisteAluno(aluno))
            {
                MessageBox.Show("Aluno já existe", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var vcon = Conexao.AbrirCon();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"UPDATE tb_aluno SET (nome=@nome, email=@email, endereco=@endereco, bairro=@bairro, cep=@cep, nascimento=@nascimento,
                                telefone=@telefone, sangue=@sangue, imagem=@imagem WHERE id_aluno=@id";
                cmd.Parameters.AddWithValue("@nome", aluno.nome);
                cmd.Parameters.AddWithValue("@email", aluno.email);
                cmd.Parameters.AddWithValue("@endereco", aluno.endereco);
                cmd.Parameters.AddWithValue("@bairro", aluno.bairro);
                cmd.Parameters.AddWithValue("@cep", aluno.cep);
                cmd.Parameters.AddWithValue("@nascimento", aluno.nascimento);
                cmd.Parameters.AddWithValue("@telefone", aluno.telefone);
                cmd.Parameters.AddWithValue("@sangue", aluno.sangue);
                cmd.Parameters.AddWithValue("@imagem", aluno.imagem);
                cmd.Parameters.AddWithValue("@id", aluno.id_aluno);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno atualizado com sucesso", "Salvar aluno!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Método para verificar no banco se existe usuário.
        public static bool ExisteAluno(AlunoModel aluno)
        {
            bool res;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var vcon = Conexao.AbrirCon();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT nome FROM tb_aluno WHERE nome='" + aluno.nome + "'";
            da = new MySqlDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            vcon.Dispose();
            vcon.ClearAllPoolsAsync();
            return res;
        }
    }
}
