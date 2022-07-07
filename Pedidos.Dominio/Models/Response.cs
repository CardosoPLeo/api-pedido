namespace Pedidos.Dominio.Models
{
    public class Response
    {
        public List<Report> Reports{get;}
        public Response()
        {
            Reports = new List<Report>();
        }

        public Response(List<Report> reports)
        {
            Reports = reports;
        }

        //Construtor recebendo o objeto sem lista e transferindo para o construtor acima que é uma lista.
        public Response(Report report) : this(new List<Report>(){report})
        {

        }
    }

    public class Response<T> : Response
    {
        public T Data { get; set; }

        public Response()
        {
        }

        //Aqui uso a base para poder ir para o construtor da classe que estou herdando que neesse caso é a classe Response
        public Response(T data, List<Report> reports = null) : base(reports)
        {
            Data = data;
        }

    }
}