using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Models;

public class Ret 
{
    [Key]
    public int Id { get; set; }

    [Required]
    public required string Name { get; set; }

    [Required]
    public required string Description { get; set; }

    [Required]
    public required Category Category { get; set; }

    public bool Vegetarian { get; set; } = false;

    public bool PorkBased { get; set; } = false;

    public bool Leftovers { get; set; } = false;

    public bool Takeway { get; set; } = false;

    public List<Ingrediens>? Ingredienser { get; set; }

    // Årstids specfikt

    // User
}
