using System;
using System.ComponentModel.DataAnnotations;

public class Comment
{
    [Key]
    public int Id { get; set; }

    public string Author { get; set; }

    public string Text { get; set; }

    public int Rating { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public int CakeRecipeId { get; set; }

    public CakeRecipe CakeRecipe { get; set; }
}
