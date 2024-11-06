
using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    internal class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator() 
        { 

        }
    }
}
