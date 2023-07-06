using AwesomeShop.Services.Products.Application.Queries.Products.GetByIdQuery;
using MediatR;

namespace AwesomeShop.Services.Products.Application.Queries.Products.GetAllQuery;

public class GetAllProductsQueryInputModel : IRequest<List<GetAllProductsQueryViewModel>>
{
}