using MediatR;

namespace MovieApi.Application.Features.MediatorDesignPattern.Queries.TagQueries
{
    public class GetTagByIdQueryResult : IRequest<GetTagByIdQueryResult>
    {
        public int TagId { get; set; }
        public GetTagByIdQueryResult(int tagId)
        {
            TagId = tagId;
        }

    }
}
