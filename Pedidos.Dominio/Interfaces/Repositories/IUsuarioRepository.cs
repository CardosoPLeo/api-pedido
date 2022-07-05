using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Models;

namespace Pedidos.Dominio.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task CreateAsync(Usuarios usuario);
        Task UpdateAsync(Usuarios usuario);
        Task DeleteAsync(string usuarioId);
        Task <Usuarios> GetById(string usuarioId);
        Task<List<Usuarios>> ListByFilterAsync(string? usuarioId = null, string? usuarioNome = null);
        Task<bool> ExistByIdAsync(string usuarioId);
        Task<bool> ExistByLoginAsync(string login);
    }
}