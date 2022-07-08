namespace Pedidos.Dominio.Validations.Base
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

        //Retorna a classe reponse abaixo
        public static Response<T> OK<T>(T data) => new Response<T>(data);

        //Retorna o construtor dessa classe, que não precisa de nada.
        public static Response OK() => new Response();
        
        //Retorna o construtor com uma lista de reports
        public static Response NaoFoiProcessado(List<Report> reports) => new Response(reports);

        //Retorna o construtor com somente um report. Assim ele levará para o construtor queretorna uma lista.
        public static Response NaoFoiProcessado(Report report) => new Response(report);

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