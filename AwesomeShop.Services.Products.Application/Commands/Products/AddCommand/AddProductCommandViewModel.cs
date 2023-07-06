namespace AwesomeShop.Services.Products.Application.Commands.Products.AddCommand;

public class AddProductCommandViewModel
{
    public AddProductCommandViewModel(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}