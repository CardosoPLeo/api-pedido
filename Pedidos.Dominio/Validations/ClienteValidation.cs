using System.Data;
using FluentValidation;
using Pedidos.Dominio.Models;

namespace Pedidos.Dominio.Validations
{
    public class ClienteValidation : AbstractValidator<Clientes>
    {
        public ClienteValidation()
        {
            RuleFor(n => n.Nome)
                .NotEmpty()
                .Length(3, 50);
            
            RuleFor(e => e.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(e => e.Enedereco)
                .NotEmpty();
        }
    }
}