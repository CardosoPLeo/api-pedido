using FluentValidation.Results;

namespace Pedidos.Dominio.Validations.Base
{
    public static class ObtendoValidacoes
    {
        public static Response GetErros(this ValidationResult resultado)
        {
            var resposta = new Response();

            if(!resultado.IsValid)
            {
                foreach (var erro in resultado.Errors)
                {
                    resposta.Reports.Add(new Report()
                    {
                        Codigo = erro.PropertyName,
                        Mensagem = erro.ErrorMessage
                    });
                }

                return resposta;
            }
            
            return resposta;
        }
    }
}