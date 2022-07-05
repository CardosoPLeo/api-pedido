using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Interfaces.Services;
using Pedidos.Dominio.Models;

namespace Pedidos.Dominio.Services
{
    public class ProdutoService : IProdutoService
    {
        public Task CreateAsync(Produtos produto)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Produtos produto)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string produtoId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Produtos> GetById(string produtoId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Produtos>> ListByFilterAsync(string? produtoId = null, string? produtoDescricao = null)
        {
            throw new System.NotImplementedException();
        }
    }
}