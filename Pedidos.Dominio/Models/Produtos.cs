namespace Pedidos.Dominio.Models
{
    public class Produtos : EntidadeBase
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int QtdEstoque { get; set; }
        
    }
}