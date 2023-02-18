using APICQRS.Data;
using APICQRS.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
namespace APICQRS.Queries
{
    public class GetCategoriaByIdHandler : IRequestHandler<GetCategoriaByIdcs, Categorias>
    {
        private readonly AppDBContext _context;

        public GetCategoriaByIdHandler(AppDBContext context)
        {
            _context = context;
        }
        public async Task<Categorias> Handle(
            GetCategoriaByIdcs request, CancellationToken cancellationToken)
        {
            return await _context.categorias.FirstOrDefaultAsync(cateogrias => cateogrias.IdCateogoria == request.IdCategoria,
                cancellationToken
                );
        }
    }
}
