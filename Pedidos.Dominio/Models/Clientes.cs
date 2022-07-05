using System.Reflection.Metadata;

namespace Pedidos.Dominio.Models
{
    public class Clientes : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Enedereco { get; set; }
        
    }
}