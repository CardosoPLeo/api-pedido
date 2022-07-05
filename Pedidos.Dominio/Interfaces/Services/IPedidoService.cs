using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Models;

namespace Pedidos.Dominio.Interfaces.Services
{
    public interface IPedidoService
    {
        Task CreateAsync(Pedido pedido);
        Task UpdateAsync(Pedido pedido);
        Task DeleteAsync(string pedidoId);
        Task <Pedido> GetById(string pedidoId);
        Task<List<Pedido>> ListByFilterAsync(string pedidoId = null, string clienteId = null, string usuariId = null);
    }
}