public class CakeCategory
{
    public string Name { get; set; }
    public List<CakeRecipe> Recipes { get; set; } = new();
}