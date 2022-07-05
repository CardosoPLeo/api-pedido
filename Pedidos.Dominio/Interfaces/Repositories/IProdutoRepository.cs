using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Models;

namespace Pedidos.Dominio.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        Task CreateAsync(Produtos produto);
        Task UpdateAsync(Produtos produto);
        Task DeleteAsync(string produtoId);
        Task <Produtos> GetById(string produtoId);
        Task<List<Produtos>> ListByFilterAsync(string? produtoId = null, string? produtoDescricao = null);
        Task<bool> ExistByIdAsync(string produtoId);
    }
}