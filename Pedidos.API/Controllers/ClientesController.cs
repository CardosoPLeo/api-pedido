using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using Pedidos.Aplicacao.Aplicacao;
using Pedidos.Aplicacao.DataContract.Request.Ciente;
using Pedidos.Aplicacao.Interfaces;
using Pedidos.Dominio.Models;
using Pedidos.Dominio.Validations.Base;

namespace Pedidos.API.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteAplicacao _clienteAplicacao;
        // GET: api/Clientes
        public ClientesController(IClienteAplicacao clienteAplicacao)
        {
            _clienteAplicacao = clienteAplicacao;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Clientes/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Clientes
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateClienteRequest request)
        {
            var response  = await _clienteAplicacao.CreateAsync(request);
            
            if (response.Reports.Any())
                return UnprocessableEntity(response.Reports);

            return response;
        }

        // PUT: api/Clientes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
