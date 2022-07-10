namespace Pedidos.Aplicacao.DataContract.Request.Ciente
{
    public sealed class CreateClienteRequest
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Enedereco { get; set; }
        
    }
}