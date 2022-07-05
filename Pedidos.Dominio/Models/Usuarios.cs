using System.Reflection.Metadata;

namespace Pedidos.Dominio.Models
{
    public class Usuarios : EntidadeBase
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}