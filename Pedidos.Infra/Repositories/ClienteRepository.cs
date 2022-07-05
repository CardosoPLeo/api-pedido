using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Interfaces.Repositories;
using Pedidos.Dominio.Models;

namespace Pedidos.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public Task CreateAsync(Clientes cliente)
        {
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

        public Task<List<Clientes>> ListByFilterAsync(string? clienteId = null, string? clienteNome = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ExistByIdAsync(string clienteId)
        {
            throw new System.NotImplementedException();
        }
    }
}