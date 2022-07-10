namespace Pedidos.Aplicacao.DataContract.Response.Cliente
{
    public sealed class ClienteResponse
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Enedereco { get; set; }
    }
}