using System.ComponentModel.DataAnnotations;

namespace Models;

public class Produkt
{
    [Key]
    public int Id { get; set; }
    
    public required string Name { get; set; }

    public string? Note { get; set; }

    public required PackingType PackingType { get; set; }

    public required double Price { get; set; } = 0;

    public int? Grams { get; set; }

    public int? Calories { get; set; } // Per 100 grams

    public Butik? Butik { get; set; }

    public List<Ingrediens>? Ingredienser { get; set; }
}
