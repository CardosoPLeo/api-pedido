using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Models;

namespace Pedidos.Dominio.Interfaces.Services
{
    public interface IProdutoService
    {
        Task CreateAsync(Produtos produto);
        Task UpdateAsync(Produtos produto);
        Task DeleteAsync(string produtoId);
        Task <Produtos> GetById(string produtoId);
        Task<List<Produtos>> ListByFilterAsync(string? produtoId = null, string? produtoDescricao = null);
    }
}