using MediatR;

namespace ECommerce.Application.Features.Queries.GetOrderById
{
    public class GetOrderByIdQueryRequest : IRequest<GetOrderByIdQueryResponse>
    {
        public string Id { get; set; }
    }
}