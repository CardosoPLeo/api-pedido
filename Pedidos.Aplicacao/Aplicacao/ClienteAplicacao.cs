using Pedidos.Aplicacao.DataContract.Request.Ciente;
using Pedidos.Aplicacao.DataContract.Response.Cliente;
using Pedidos.Aplicacao.Interfaces;
using Pedidos.Aplicacao.Interfaces.Services;


namespace Pedidos.Aplicacao.Aplicacao
{
    public class ClienteAplicacao : IClienteAplicacao
    {
        private readonly IClientService _clienteService;
        public ClienteAplicacao(IClientService clientService)
        {
            _clienteService = clientService;
        }

        public async Task<Response> CreateAsync(CreateClienteRequest cliente)
        {
            throw new NotImplementedException();
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