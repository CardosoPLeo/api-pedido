namespace Pedidos.Dominio.Models
{
    public class PedidoItem : EntidadeBase
    {
        public Pedido Pedido { get; set; }
        public Produtos Produtos { get; set; }
        public double Valor { get; set; }
        public int QtdVenda { get; set; }
        public double ValorTotal { get; set; }
    }
}