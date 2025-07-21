using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Results.TagResult;

namespace MovieApi.Application.Features.MediatorDesignPattern.Queries.TagQueries
{
    public class GetTagQuery : IRequest<List<GetTagQueryResult>>
    {

    }
}
