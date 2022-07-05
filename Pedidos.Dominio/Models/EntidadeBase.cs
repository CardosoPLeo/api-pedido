using System;

namespace Pedidos.Dominio.Models
{
    public class EntidadeBase
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao{ get; set; }
    }
}