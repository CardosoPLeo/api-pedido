using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Pedidos.Aplicacao.DataContract.Request.Ciente;
using Pedidos.Aplicacao.DataContract.Response.Cliente;
using Pedidos.Aplicacao.Interfaces;
using Pedidos.Dominio.Interfaces.Services;
using Pedidos.Dominio.Models;
using Pedidos.Dominio.Validations.Base;


namespace Pedidos.Aplicacao.Aplicacao
{
    public class ClienteAplicacao : IClienteAplicacao
    {
        private readonly IClientService _clienteService;
        private readonly IMapper _mapper; 
        public ClienteAplicacao(IClientService clientService, IMapper mapper)
        {
            _clienteService = clientService;
            _mapper = mapper;
        }

        
        public async Task<Response> CreateAsync(CreateClienteRequest cliente)
        {
            var clienteModel = _mapper.Map<Clientes>(cliente);
            return await _clienteService.CreateAsync(clienteModel);
        }

        public Task<Response> DeleteAsync(string clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<ClienteResponse>> GetById(string clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ClienteResponse>>> ListByFilterAsync(string clienteId = null, string clienteNome = null)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(CreateClienteRequest cliente)
        {
            throw new NotImplementedException();
        }
    }
}