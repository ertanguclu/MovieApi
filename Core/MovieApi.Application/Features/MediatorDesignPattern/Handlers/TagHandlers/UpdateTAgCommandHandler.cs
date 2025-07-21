using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class UpdateTAgCommandHandler : IRequestHandler<UpdateTagCommand>
    {
        private readonly MovieContext _context;

        public UpdateTAgCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.FindAsync(request.TagId);
            values.Title = request.Title;
            await _context.SaveChangesAsync();
        }
    }
}
