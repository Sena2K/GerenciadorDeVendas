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



        public int recuperarId(string usuario)
        {
            int id = -1; // Valor padrão para quando não encontrar o usuário
                         // Comando SQL para recuperar o ID do usuário
            cmd.CommandText = "select IdLogin from Login where Usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", usuario);

            try
            {
                cmd.Connection = con.conectar(); // Abrir conexão com o banco de dados
                dr = cmd.ExecuteReader(); // Executar a consulta
                if (dr.Read()) // Se encontrar um resultado na consulta
                {
                    id = (int)dr["IdLogin"]; // Recupera o valor da coluna "IdLogin"
                }
                con.desconectar(); // Fechar a conexão com o banco de dados
                dr.Close(); // Fechar o objeto de leitura dos resultados
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados"; // Atribuir mensagem de erro
            }

            return id; // Retorna o ID do usuário ou o valor padrão se não encontrar
        }

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
        public string cadastrarCliente(string nome, string endereco, string cidade, string estado, string cep, string telefone, string email, DateTime dataNascimento, string cpf, string cnpj)
        {
            bool tem = false;
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco) || string.IsNullOrEmpty(cidade) || string.IsNullOrEmpty(estado) || string.IsNullOrEmpty(cep) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(email) || dataNascimento == null) 
            {
                this.mensagem = "Por favor, preencha todos os campos obrigatórios."; // Verifica se algum campo obrigatório está vazio ou nulo
            }
            else
            {
                // Comandos SQL para inserir um novo cliente
                cmd.CommandText = "insert into Clientes values (@nome, @endereco, @cidade, @estado, @cep, @telefone, @email, @dataNascimento, @cpf, @cnpj)";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);

                try
                {
                    cmd.Connection = con.conectar(); // Abrir conexão com o banco de dados
                    cmd.ExecuteNonQuery(); // Executar o comando SQL
                    con.desconectar(); // Fechar a conexão com o banco de dados
                    this.mensagem = "Cliente cadastrado com sucesso."; // Atribuir mensagem de sucesso
                    tem = true; // Altera o valor da variável "tem" para true
                }
                catch (SqlException ex)
                {
                    this.mensagem = "Erro ao cadastrar cliente. Detalhes: " + ex.Message;
                }


            }
            return mensagem; // Retorna a mensagem de erro ou sucesso
        }


    }
}
