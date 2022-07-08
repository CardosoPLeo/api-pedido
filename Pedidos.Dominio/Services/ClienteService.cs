using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Interfaces.Repositories;
using Pedidos.Dominio.Interfaces.Services;
using Pedidos.Dominio.Models;
using Pedidos.Dominio.Validations;
using Pedidos.Dominio.Validations.Base;

namespace Pedidos.Dominio.Services
{
    public class ClienteService : IClientService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Response> CreateAsync(Clientes cliente)
        {
            var resposta = new Response();
            var validacao = new ClienteValidation();
            var resultado = validacao.Validate(cliente);
            if(!resultado.IsValid)
            {
                foreach (var erro in resultado.Errors)
                {
                  resposta.Reports.Add(new Report()
                  {
                     Codigo = erro.PropertyName,
                     Mensagem = erro.ErrorMessage
                  });
                }

                return resposta;
            }

            await _clienteRepository.CreateAsync(cliente);

            return resposta;
        }

        public Task<Response> DeleteAsync(string clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Clientes>> GetById(string clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<Clientes>>> ListByFilterAsync(string clienteId = null, string clienteNome = null)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(Clientes cliente)
        {
            throw new NotImplementedException();
        }
    }
}