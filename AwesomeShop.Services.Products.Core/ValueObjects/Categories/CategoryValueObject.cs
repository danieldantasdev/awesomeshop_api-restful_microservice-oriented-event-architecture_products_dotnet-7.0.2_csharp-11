namespace AwesomeShop.Services.Products.Core.ValueObjects.Categories;

public class CategoryValueObject
{
    public CategoryValueObject(string description, string subcategory)
    {
        Description = description;
        Subcategory = subcategory;
    }

    public string Description { get; private set; }
    public string Subcategory { get; private set; }

    public override bool Equals(object obj)
    {
        return obj is CategoryValueObject category &&
               Description == category.Description &&
               Subcategory == category.Subcategory;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Description, Subcategory);
    }
}