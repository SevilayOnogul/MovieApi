using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Queries.SeriesQueries
{
    public class GetSeriesByIdQuery
    {
        public GetSeriesByIdQuery(int seriesId)
        {
            SeriesId = seriesId;
        }

        public int SeriesId { get; set; }
    }
}
