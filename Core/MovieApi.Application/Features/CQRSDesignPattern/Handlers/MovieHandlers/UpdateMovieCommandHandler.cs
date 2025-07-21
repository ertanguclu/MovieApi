using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateMovieCommand command)
        {
            var movie = await _context.Movies.FindAsync(command.MovieId);
            movie.Rating = command.Rating;
            movie.Status = command.Status;
            movie.Duration = command.Duration;
            movie.CoverImageUrl = command.CoverImageUrl;
            movie.CreatedYear = command.CreatedYear;
            movie.Description = command.Description;
            movie.ReleaseDate = command.ReleaseDate;
            movie.Title = command.Title;
            await _context.SaveChangesAsync();
        }
    }
}
