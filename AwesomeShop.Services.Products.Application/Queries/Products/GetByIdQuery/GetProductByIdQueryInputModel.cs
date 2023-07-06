using MediatR;

namespace AwesomeShop.Services.Products.Application.Queries.Products.GetByIdQuery;

public class GetProductByIdQueryInputModel : IRequest<GetProductByIdQueryViewModel>
{
    public GetProductByIdQueryInputModel(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; private set; }
}