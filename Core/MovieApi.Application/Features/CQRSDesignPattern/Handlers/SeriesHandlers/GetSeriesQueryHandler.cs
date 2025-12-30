using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPattern.Result.MovieResult;
using MovieApi.Application.Features.CQRSDesignPattern.Result.SeriesResult;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.SeriesHandlers
{
    public class GetSeriesQueryHandler
    {
        private readonly MovieContext _context;

        public GetSeriesQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetSeriesQueryResult>> Handle()
        {
            var values = await _context.Serieses.ToListAsync();
            return values.Select(x => new GetSeriesQueryResult
            {
                SeriesId = x.SeriesId,
                Title = x.Title,
                CoverImageUrl = x.CoverImageUrl,
                Rating = x.Rating,
                Description = x.Description,
                FirstAirDate = x.FirstAirDate,
                CreatedYear = x.CreatedYear,
                AverageEpisodeDuration = x.AverageEpisodeDuration,
                SeasonCount = x.SeasonCount,
                EpisodeCount = x.EpisodeCount,
                Status = x.Status,
                CategoryId = x.CategoryId
            }).ToList();

        }
    }
}
