using System.Collections.Generic;

namespace Pedidos.Dominio.Models
{
    public class Pedido : EntidadeBase
    {
        public Clientes Clientes { get; set; }
        public Usuarios Usuarios { get; set; }
        public List<PedidoItem> PedidoItems { get; set; }
        
    }
}