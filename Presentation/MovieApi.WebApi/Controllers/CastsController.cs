using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CastList()
        {
            var value = _mediator.Send(new GetCastQuery());
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCast(CreateCastCommand createCastCommand)
        {
            _mediator.Send(createCastCommand);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCast(int id)
        {
            _mediator.Send(new RemoveCastCommand(id));
            return Ok("Silme İşlemi Başarılı");
        }
        [HttpGet("GetCastById")]
        public async Task<IActionResult> GetCastById(int id)
        {
            var value = _mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCast(UpdateCastCommand updateCastCommand)
        {
            _mediator.Send(updateCastCommand);
            return Ok("Güncelleme İşlemi Başarılı");
        }
    }
}
