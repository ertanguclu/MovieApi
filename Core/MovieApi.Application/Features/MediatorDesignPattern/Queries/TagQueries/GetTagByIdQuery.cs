using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Results.TagResult;

namespace MovieApi.Application.Features.MediatorDesignPattern.Queries.TagQueries
{
    public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
    {
        public int TagId { get; set; }
        public GetTagByIdQuery(int tagId)
        {
            TagId = tagId;
        }

    }
}
