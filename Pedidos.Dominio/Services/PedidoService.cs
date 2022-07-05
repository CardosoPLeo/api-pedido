using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Interfaces.Services;
using Pedidos.Dominio.Models;

namespace Pedidos.Dominio.Services
{
    public class PedidoService : IPedidoService
    {
        public Task CreateAsync(Pedido pedido)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Pedido pedido)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string pedidoId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Pedido> GetById(string pedidoId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Pedido>> ListByFilterAsync(string pedidoId = null, string clienteId = null, string usuariId = null)
        {
            throw new System.NotImplementedException();
        }
    }
}