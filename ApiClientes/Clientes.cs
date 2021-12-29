using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiClientes
{
    class Clientes
    {
        private static string _urlBase = "http://localhost:59796/"; //url da minha API

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Razao { get; set; }
        public DateTime Inclusao { get; set; }
        public bool Ativo { get; set; }

        // -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Métodos para acessar os serviços da API -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* //

        public static List<Clientes> ObterClientes() //Listar Todos
        {
            var listaClientes = new List<Clientes>();

            var client = new RestClient(_urlBase + "api/Clientes");
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            if(response.StatusCode == HttpStatusCode.OK)
            {
                listaClientes = JsonConvert.DeserializeObject<List<Clientes>>
                    (response.Content);
            }

            return listaClientes;
        }

        public Clientes Buscar(int id) //listar cliente específico - pelo id
        {
            var cliente = new Clientes();

            var client = new RestClient(_urlBase + "api/Clientes/" + id); //cliente para acessar a API
            var request = new RestRequest(Method.GET); //tipo de requisição

            IRestResponse response = client.Execute(request); //resposta da requisição http

            if (response.StatusCode == HttpStatusCode.OK)
            {
                cliente = JsonConvert.DeserializeObject<Clientes>
                    (response.Content);
            }

            return cliente;
        }

        public void Incluir(Clientes cliente)
        {
            var client = new RestClient(_urlBase + "api/Clientes"); //cliente para acessar a API
            var request = new RestRequest(Method.POST); //tipo de requisição
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(cliente); //convertendo o objeto cliente em Json para o body

            IRestResponse response = client.Execute(request); //resposta da requisição http

            if (response.StatusCode == HttpStatusCode.OK)
            {
                cliente = JsonConvert.DeserializeObject<Clientes>
                    (response.Content);
            }
        }

        public void Editar(Clientes cliente)
        {
            var client = new RestClient(_urlBase + "api/Clientes/"+ cliente.Id); //cliente para acessar a API
            var request = new RestRequest(Method.PUT); //tipo de requisição
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(cliente); //convertendo o objeto cliente em Json para o body

            IRestResponse response = client.Execute(request); //resposta da requisição http

            if (response.StatusCode == HttpStatusCode.OK)
            {
                cliente = JsonConvert.DeserializeObject<Clientes>
                    (response.Content);
            }
        }
    }
}
