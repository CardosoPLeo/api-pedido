using Pedidos.Aplicacao.DataContract.Request.Ciente;
using Pedidos.Aplicacao.DataContract.Response.Cliente;
using Pedidos.Dominio.Validations.Base;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Pedidos.Aplicacao.Interfaces
{
    public interface IClienteAplicacao
    {
        
        Task<Response> CreateAsync(CreateClienteRequest cliente);
        Task<Response> UpdateAsync(CreateClienteRequest cliente);
        Task<Response> DeleteAsync(string clienteId);
        Task<Response<ClienteResponse>> GetById(string clienteId);
        Task<Response<List<ClienteResponse>>> ListByFilterAsync(string clienteId = null, string clienteNome = null);
    }
}