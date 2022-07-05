using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Interfaces.Services;
using Pedidos.Dominio.Models;

namespace Pedidos.Dominio.Services
{
    public class UsuarioService : IUsuarioService
    {
        public Task<bool> AuthenticationAsync(Usuarios usuario)
        {
            throw new System.NotImplementedException();
        }

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
    }
}