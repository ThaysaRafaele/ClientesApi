using API_Clientes.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Clientes.Controllers
{
    public class ClientesController : ApiController
    {
        // testando API - Preenchendo a lista manualmente
        public static List<Clientes> listaClientes = new List<Clientes>();
        //[HttpGet]
        //[Route("api/Clientes/PreencherLista")]
        //public JObject PreencherLista()
        //{
        //    listaClientes.Add(new Clientes(1, "Thaysa", "Thaysa Lacerda", DateTime.Now, true));
        //    listaClientes.Add(new Clientes(2, "Anna", "Anna Gomes", DateTime.Now, true));
        //    listaClientes.Add(new Clientes(3, "Joana", "Joana Vasco", DateTime.Now, false));
        //    listaClientes.Add(new Clientes(13, "Testando", "Testando 123", DateTime.Now, true));
        //    listaClientes.Add(new Clientes(7, "Teste Exclusão", "Testando 123", DateTime.Now, true));

        //    var resultado = JObject.Parse("{resultado: \"preenchido\"}");
        //    return resultado;
        //}

        // GET api/Cliente - testando API
        //public string Get()
        //{
        //    return JsonConvert.SerializeObject(listaClientes); //retornando toda a lista de clientes de uma vez
        //}

        // GET api/Cliente
        public List<Clientes> Get()
        {
            var listaClientes = Clientes.ObterClientes(); //retornando toda a lista de clientes de uma vez
            return listaClientes;
        }

        //Testando API
        // GET api/Cliente/{buscar liente pelo id}
        //public string Get(int id)
        //{
        //    return JsonConvert.SerializeObject(listaClientes.Find(x => x.Id.Equals(id))); //buscando na lista de clientes a propriedade Id da classe clientes = id passado / recebido como parâmetro
        //}

        // GET api/Cliente/{buscar liente pelo id}
        public Clientes Get(int id)
        {
            var cliente = new Clientes(); //usando construtor vazio
            cliente.Buscar(id);
            return cliente;
        }

        // POST api/Cliente
        public JObject Post([FromBody] Clientes cliente)
        {
            var resultado = "";

            if(cliente == null)
                resultado = "{Resultado: \"Está faltando parâmetro no body\"}";
            else if (cliente.Id != 0)
                resultado = "{Resultado: \"Id deve ser zero!\"}";
            else if (String.IsNullOrEmpty(cliente.Nome))
                resultado += "{Resultado: \"O Nome deve ser informado!\"}";
            else if (String.IsNullOrEmpty(cliente.Razao))
                resultado += "{Resultado: \"A Razão Social deve ser informada!\"}";

            if (String.IsNullOrEmpty(resultado))
            {
                //listaClientes.Add(new Clientes(cliente.Id, cliente.Nome, cliente.Razao, cliente.Inclusao, cliente.Ativo));

                var clienteNew = new Clientes();
                resultado = cliente.Incluir(cliente);
                resultado += "{Resultado: \""+ resultado +"\"}";
            }

            return JObject.Parse(resultado);
        }

        // PUT api/Cliente/5
        public JObject Put(int id, [FromBody] Clientes cliente)
        {
            //var c = listaClientes.Single(x => x.Id.Equals(id));
            //c.Nome = cliente.Nome;
            //c.Nome = cliente.Razao;
            //c.Ativo = cliente.Ativo;

            var resultado = "";

            var c = new Clientes();
            cliente.Id = id;
            resultado = c.Incluir(cliente);
            resultado = "{Resultado: \"" + resultado + "\"}";

            return JObject.Parse(resultado);
        }

        //Testando API
        [HttpGet]
        [Route("api/Clientes/Excluir/{id}")]
        public JObject Excluir(int id)
        {
            //Single() = traz apenas um resultado, ao contrário do Equals().
            var cliente = listaClientes.Single(x => x.Id.Equals(id)); // Buscando na lista de clientes onde o Id da tabela é igual ao id passado pelo usuário p/ exclusão
            listaClientes.Remove(cliente); //removendo da lista o cliente cujo id correspondeu à consulta
            var resultado = JObject.Parse("{Resultado: \"Removido com sucesso!\"}");
            return resultado;
        }
    }
}
