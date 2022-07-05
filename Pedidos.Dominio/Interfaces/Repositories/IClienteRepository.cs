using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Models;

namespace Pedidos.Dominio.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Task CreateAsync(Clientes cliente);
        Task UpdateAsync(Clientes cliente);
        Task DeleteAsync(string clienteId);
        Task <Clientes> GetById(string clienteId);
        Task<List<Clientes>> ListByFilterAsync(string? clienteId = null, string? clienteNome = null);
        Task<bool> ExistByIdAsync(string clienteId);
    }
}