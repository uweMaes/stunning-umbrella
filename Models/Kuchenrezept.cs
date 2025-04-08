using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class CakeRecipe
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string Ingredients { get; set; }

    public string Instructions { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public double AverageRating { get; set; }

    public List<Comment> Comments { get; set; } = new();
}
