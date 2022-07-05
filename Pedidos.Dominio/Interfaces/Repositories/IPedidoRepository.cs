using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Models;

namespace Pedidos.Dominio.Interfaces.Repositories
{
    public interface IPedidoRepository
    {
        Task CreateAsync(Pedido pedido);
        Task CreateItemAsync(PedidoItem item);
        Task UpdateAsync(Pedido pedido);
        Task UpdateItemAsync(PedidoItem item);
        Task DeleteAsync(string pedidoId);
        Task DeleteItemAsync(string itemId);
        Task <Pedido> GetById(string pedidoId);
        Task<List<Pedido>> ListByFilterAsync(string? pedidoId = null, string? clienteId = null, string? usuariId = null);
        Task<List<PedidoItem>> ListItemByPedidoIdAsync(string pedidoId = null);
        Task<bool> ExistByIdAsync(string pedidoId);
    }
    
}