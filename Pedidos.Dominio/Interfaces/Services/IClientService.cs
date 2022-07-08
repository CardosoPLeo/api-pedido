using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Models;
using Pedidos.Dominio.Validations.Base;


namespace Pedidos.Dominio.Interfaces.Services
{
    public interface IClientService
    {
        Task<Response> CreateAsync(Clientes cliente);
        Task<Response> UpdateAsync(Clientes cliente);
        Task<Response> DeleteAsync(string clienteId);
        Task<Response<Clientes>> GetById(string clienteId);
        Task<Response<List<Clientes>>> ListByFilterAsync(string clienteId = null, string clienteNome = null);
    }
}