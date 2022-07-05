using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Interfaces.Repositories;
using Pedidos.Dominio.Models;

namespace Pedidos.Infra.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        public Task CreateAsync(Pedido pedido)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateItemAsync(PedidoItem item)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Pedido pedido)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateItemAsync(PedidoItem item)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string pedidoId)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteItemAsync(string itemId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Pedido> GetById(string pedidoId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Pedido>> ListByFilterAsync(string? pedidoId = null, string? clienteId = null, string? usuariId = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<PedidoItem>> ListItemByPedidoIdAsync(string pedidoId = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ExistByIdAsync(string pedidoId)
        {
            throw new System.NotImplementedException();
        }
    }
}