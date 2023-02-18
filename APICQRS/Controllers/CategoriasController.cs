using APICQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;

        public CategoriasController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IResult> GetCategoriaById(int id)
        {
            var command = new GetCategoriaByIdcs()
            {
                IdCategoria = id
            };
            var response = await _mediator.Send(command);

            return response is not null ? Results.Ok(response) : Results.NotFound();
        } 
    }
}
