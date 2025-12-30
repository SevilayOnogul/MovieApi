using MovieApi.Application.Features.CQRSDesignPattern.Queries.SeriesQueries;
using MovieApi.Application.Features.CQRSDesignPattern.Results.SeriesResults;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.SeriesHandlers
{
    public class GetSeriesByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetSeriesByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetSeriesByIdQueryResult> Handle(GetSeriesByIdQuery query)
        {
            var value=await _context.Serieses.FindAsync(query.SeriesId);
            return new GetSeriesByIdQueryResult
            {
                CoverImageUrl = value.CoverImageUrl,
                CreatedYear = value.CreatedYear,
                Description = value.Description,
                Rating = value.Rating,
                Status = value.Status,
                Title = value.Title,
                AverageEpisodeDuration = value.AverageEpisodeDuration,
                CategoryId = value.CategoryId,
                EpisodeCount = value.EpisodeCount,
                FirstAirDate = value.FirstAirDate,
                SeriesId = value.SeriesId,
                SeasonCount = value.SeasonCount,
            };
        }
        }
    }

