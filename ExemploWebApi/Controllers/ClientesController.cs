using ExemploWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebApi.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Get() /*vai retorna uma lista de cliente*/
        {
            return clientes; /*vai retornar os itens que tem dentro da lista a cima*/
        }

        public void Post(string nome)
        {
            if(!string.IsNullOrEmpty(nome))//se nao for vazio e null vai entrar na lista
            clientes.Add(new Cliente(nome));
        }

        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }


    }
}
