using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Models;

namespace Pedidos.Dominio.Interfaces.Services
{
    public interface IClientService
    {
        Task CreateAsync(Clientes cliente);
        Task UpdateAsync(Clientes cliente);
        Task DeleteAsync(string clienteId);
        Task <Clientes> GetById(string clienteId);
        Task<List<Clientes>> ListByFilterAsync(string clienteId = null, string clienteNome = null);
    }
}