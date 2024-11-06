using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    internal class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator() 
        {
            RuleFor(c => c.Nome).NotEmpty().WithMessage("Por favor informe o nome")
                .NotNull().WithMessage("Por favor informe o nome");
        }
    }
}
