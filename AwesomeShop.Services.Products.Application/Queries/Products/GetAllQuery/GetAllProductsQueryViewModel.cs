namespace AwesomeShop.Services.Products.Application.Queries.Products.GetAllQuery;

public class GetAllProductsQueryViewModel
{
    public GetAllProductsQueryViewModel(Guid id, string title)
    {
        Id = id;
        Title = title;
    }

    public Guid Id { get; private set; }
    public string Title { get; private set; }
}