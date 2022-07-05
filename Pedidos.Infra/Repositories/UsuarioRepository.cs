using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Interfaces.Repositories;
using Pedidos.Dominio.Models;

namespace Pedidos.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Task CreateAsync(Usuarios usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Usuarios usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string usuarioId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Usuarios> GetById(string usuarioId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Usuarios>> ListByFilterAsync(string? usuarioId = null, string? usuarioNome = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ExistByIdAsync(string usuarioId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ExistByLoginAsync(string login)
        {
            throw new System.NotImplementedException();
        }
    }
}