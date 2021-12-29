using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace API_Clientes.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Razao { get; set; }
        public DateTime Inclusao { get; set; }
        public bool Ativo { get; set; }

        public Clientes() { } //construtor vazio

        public Clientes(int id, string nome, string razao, DateTime inclusao, bool ativo) //contrutor inicializando variáveis
        {
            Id = id;
            Nome = nome;
            Razao = razao;
            Inclusao = inclusao;
            Ativo = ativo;

        }

        private readonly static string _conexao = WebConfigurationManager.ConnectionStrings
            ["conexao"].ConnectionString; //conectando ao BD local com a string de conexão definida no web.config
        
        public static List<Clientes> ObterClientes()
        {
            var listaClientes = new List<Clientes>();
            var sql = "SELECT * FROM CLIENTES"; //consulta do BD trazendo registros da tabela Clientes

            try
            {
                using (var con = new SqlConnection(_conexao))
                {
                    con.Open(); //abrindo conexão
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        using (var dr = cmd.ExecuteReader()) //lendo resultado da consulta
                        {
                            if(dr.HasRows)
                            {
                                while(dr.Read())
                                {
                                    listaClientes.Add(new Clientes(
                                        Convert.ToInt32(dr["Id"]),
                                        Convert.ToString(dr["Nome"]),
                                        Convert.ToString(dr["Razao"]),
                                        Convert.ToDateTime(dr["Inclusao"]),
                                        Convert.ToBoolean(dr["Ativo"])
                                        ));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha: " + ex.Message);
            }
            return listaClientes;

        }

        public string Incluir(Clientes cliente)
        {
            var sql = "";
            if (cliente.Id == 0)
            {
                sql = "INSERT INTO CLIENTES (NOME, RAZAO, INCLUSAO, ATIVO) VALUES (@Nome, @razao, @inclusao, @ativo)";
            }
            else
            {
                sql = "UPDATE CLIENTES SET NOME = @nome, RAZAO = @razao, INCLUSAO = @inclusao, ATIVO = @ativo WHERE id=" + cliente.Id;
            }
            try
            {
                using (var con = new SqlConnection(_conexao))
                {
                    con.Open(); //abrindo conexão
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        using (var dr = cmd.ExecuteReader()) //lendo resultado da consulta
                        {
                            cmd.Parameters.AddWithValue("@Nome", cliente.Nome); //adicionando o parâmetro Nome recebido na classe ao BD
                            cmd.Parameters.AddWithValue("@razao", cliente.Razao);
                            cmd.Parameters.AddWithValue("@inclusao", cliente.Inclusao);
                            cmd.Parameters.AddWithValue("@ativo", cliente.Ativo);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    return "Incluído com sucesso!";
                }
            }
            catch (Exception ex)
            {
                return "Falha: " + ex.Message;
            }
        }

        public void Excluir(int id)
        {
            var sql = "DELETE FROM CLIENTES WHERE id="+id;
           
            try
            {
                using (var con = new SqlConnection(_conexao))
                {
                    con.Open(); //abrindo conexão
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        using (var dr = cmd.ExecuteReader()) //lendo resultado da consulta
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha: " + ex.Message);
            }
        }

        public void Buscar(int id)
        {
            var sql = "SELECT nome, razao, inclusao, ativo FROM CLIENTES WHERE id="+id;
           
            try
            {
                using (var con = new SqlConnection(_conexao))
                {
                    con.Open(); //abrindo conexão
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        using (var dr = cmd.ExecuteReader()) //lendo resultado da consulta
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    Id = id;
                                    Nome = Convert.ToString(dr["Nome"]);
                                    Razao = Convert.ToString(dr["Razao"]);
                                    Inclusao = Convert.ToDateTime(dr["Inclusao"]);
                                    Ativo = Convert.ToBoolean(dr["Ativo"]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Nome = "Falha: " + ex.Message;
                Console.WriteLine("Falha: " + ex.Message);
            }
        }
    }
}
