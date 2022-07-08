namespace Pedidos.Dominio.Validations.Base
{
    public class Report
    {
        public string Codigo { get; set; }
        public string Mensagem { get; set; }

        public Report()
        {
            
        }

        public Report(string mensagem)
        {
            Mensagem = mensagem;
        }
        
        public static Report Create(string mensagem) => new Report(mensagem);
        
    }
}