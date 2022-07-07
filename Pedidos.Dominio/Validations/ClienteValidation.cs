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
                .NotNull()
                .NotEmpty()
                .Length(3, 50);
            
            RuleFor(e => e.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);

            RuleFor(e => e.Enedereco)
                .NotNull()
                .NotEmpty();
        }
    }
}