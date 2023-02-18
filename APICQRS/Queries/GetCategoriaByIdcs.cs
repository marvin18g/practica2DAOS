using APICQRS.Models;
using MediatR;
namespace APICQRS.Queries
    
{
    public class GetCategoriaByIdcs : IRequest<Models.Categorias>
    {
        public int IdCategoria { get; set; }
    }
}
