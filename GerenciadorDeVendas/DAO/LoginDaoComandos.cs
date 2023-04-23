using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeVendas.DAO
{
    public class LoginDaoComandos
    {
        public bool tem = false; // Variável para armazenar se o login foi encontrado
        public string mensagem = ""; // Mensagem de erro ou sucesso
        SqlCommand cmd = new SqlCommand(); // Objeto de comando SQL
        Conexao con = new Conexao(); // Objeto de conexão com o banco de dados
        SqlDataReader dr; // Objeto para leitura dos resultados da consulta


        //recuperar id do usuario

        public int getIDUsuario(string usuario, string senha)
        {
            int idUsuario = 0;
            cmd.CommandText = "select IdLogin from Login where Usuario = @login and Senha = @senha";
            cmd.Parameters.AddWithValue("@login", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    idUsuario = Convert.ToInt32(dr["IdLogin"]); // atribui o valor do IdLogin à variável idUsuario
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }

            return idUsuario;
        }
        // Método para verificar o login
        public bool verificarLogin(string usuario, string senha)
        {
            // Comandos SQL para verificar o login
            cmd.CommandText = "select * from Login where Usuario = @login and Senha = @senha";
            cmd.Parameters.AddWithValue("@login", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar(); // Abrir conexão com o banco de dados
                dr = cmd.ExecuteReader(); // Executar a consulta
                if (dr.HasRows) // Se encontrar um resultado na consulta
                {
                    tem = true; // Altera o valor da variável "tem" para true
                }
                con.desconectar(); // Fechar a conexão com o banco de dados
                dr.Close(); // Fechar o objeto de leitura dos resultados
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados"; // Atribuir mensagem de erro
            }

            return tem; // Retorna o valor da variável "tem"
        }

        // Método para cadastrar um novo login
        public string cadastrar(string email, string senha, string confSenha)
        {
            tem = false; // Reinicia o valor da variável "tem"
            // Comandos SQL para inserir um novo login
            if (senha.Equals(confSenha)) // Se as senhas coincidirem
            {
                cmd.CommandText = "insert into Login values (@e, @s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar(); // Abrir conexão com o banco de dados
                    cmd.ExecuteNonQuery(); // Executar o comando SQL
                    con.desconectar(); // Fechar a conexão com o banco de dados
                    this.mensagem = "Cadastrado com sucesso"; // Atribuir mensagem de sucesso
                    tem = true; // Altera o valor da variável "tem" para true
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com o banco de dados."; // Atribuir mensagem de erro
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem"; // Atribuir mensagem de erro
            }
            return mensagem; // Retorna a mensagem de erro ou sucesso
        }
    }
}
