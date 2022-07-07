using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Interfaces.Repositories;
using Pedidos.Dominio.Interfaces.Services;
using Pedidos.Dominio.Models;
using Pedidos.Dominio.Validations;

namespace Pedidos.Dominio.Services
{
    public class ClienteService : IClientService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task CreateAsync(Clientes cliente)
        {
            var validacao = new ClienteValidation();
            var resultado = validacao.Validate(cliente);
            if(!resultado.IsValid)
            {
                foreach (var erro in resultado.Errors)
                {
                    //erro.ErrorMessage
                }
            }
             throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Clientes cliente)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string clienteId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Clientes> GetById(string clienteId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Clientes>> ListByFilterAsync(string clienteId = null, string clienteNome = null)
        {
            throw new System.NotImplementedException();
        }
    }
}