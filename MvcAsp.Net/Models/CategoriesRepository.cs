namespace MvcAsp.Net.Models;

public static class CategoriesRepository
{
    private static List<Category> _categories = new List<Category>()
    {
        new Category
        {
            CategoryId = 1, 
            Name = "Beverage",
            Description = "Beverage"
        },
        new Category
        {
            CategoryId = 2, 
            Name = "Bakery",
            Description = "Bakery"
        },
        new Category
        {
            CategoryId = 3, 
            Name = "Meat",
            Description = "Beverage"
        },

    };

    public static void AddCategory(Category category)
    {
        var maxId = _categories.Max(x => x.CategoryId);
        category.CategoryId = maxId + 1;
        _categories.Add(category);
    }

    public static List<Category> GetCategories() => _categories;

    public static Category? GetCategoryById(int categoryId)
    {
        
    }

}