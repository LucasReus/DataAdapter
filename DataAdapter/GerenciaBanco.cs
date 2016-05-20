using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace DataAdapter
{
    class GerenciaBanco
    {
        static string strConexao = "Data Source=.\\MSSQLSERVER2012; Initial Catalog=Banco; Integrated Security=SSPI;";

        public static bool CadastrarUsuario(int id, string nome)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "INSERT INTO Usuario(id, nome) VALUES (@id, @nome)";
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.Add(new SqlParameter("@nome", nome));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
            return true;
        }

        public static bool CadastrarCompra(int id, string item, int quantidade, int id_usuario)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "INSERT INTO Compras(id, item, quantidade, id_usuario) VALUES (@id, @item, @quantidade, @id_usuario)";
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.Add(new SqlParameter("@item", item));
                cmd.Parameters.Add(new SqlParameter("@quantidade", quantidade));
                cmd.Parameters.Add(new SqlParameter("@id_usuario", id_usuario));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Compra efetuada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
            return true;
        }

        public static DataTable getUsuarios()
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT id as [Código], nome as [Nome] FROM Usuario";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
            return dt;
        }

        public static DataTable getCompras()
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT Usuario.nome, Compras.item, Compras.quantidade FROM Usuario INNER JOIN Compras on Usuario.id = Compras.id_usuario";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
            return dt;
        }

        public static List<string> getListaUsuario(string parte_nome)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT TOP 5 nome FROM Usuario WHERE nome LIKE @nome";
                cmd.Parameters.Add(new SqlParameter("@nome", parte_nome + "%"));

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    lista.Add(dr.GetString(0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return lista;
        }

        public static string getNomePorCodigo(string id)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            string nome = "";
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT nome FROM Usuario WHERE id = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", id));

                SqlDataReader linha = cmd.ExecuteReader();
                if (linha.Read())
                    nome = linha.GetString(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return nome;
        }

        public static void adicionarImagem(string caminhoImagem)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "INSERT INTO Fotos(img) SELECT * FROM OPENROWSET (BULK '" + caminhoImagem + "', SINGLE_BLOB) A";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static MemoryStream[] getImagens()
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            MemoryStream[] ms = new MemoryStream[2];
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT img FROM Fotos";
                cmd.CommandType = CommandType.Text;

                SqlDataReader tabela = cmd.ExecuteReader();
                int i = 0;
                while (tabela.Read())
                {
                    Byte[] bytes = new Byte[0];
                    bytes = (Byte[])tabela.GetSqlBinary(0);
                    ms[i] = new MemoryStream(bytes);

                    ++i;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return ms;
        }

        public static void CadastrarAluno(string nomeAluno, int id_resp, string nomeResp)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "INSERT INTO Alunos(nome) VALUES (@nome)";
                cmd.Parameters.Add(new SqlParameter("@nome", nomeAluno));
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT TOP 1 id FROM Alunos ORDER BY id DESC";
                int id = (int) (cmd.ExecuteScalar());

                cmd.CommandText = "INSERT INTO Responsavel(id, nome, id_aluno) VALUES (@id, @nome, @id_aluno)";
                cmd.Parameters.Add(new SqlParameter("@id", id_resp));
                cmd.Parameters.Add(new SqlParameter("@nome", nomeResp));
                cmd.Parameters.Add(new SqlParameter("@id_aluno", id));
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
