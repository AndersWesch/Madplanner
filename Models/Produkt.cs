using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Produkt
{
    [Key, Column(Order = 0)]
    public int Id { get; set; }
    
    [Column(Order = 1)]
    public required string Name { get; set; }

    [Column(Order = 2)]
    public string? Note { get; set; }

    [Column(Order = 3)]
    public required PackingType PackingType { get; set; }

    [Column(Order = 4)]
    public required double Price { get; set; } = 0;

    [Column(Order = 5)]
    public int? Grams { get; set; }

    [Column(Order = 6)]
    public int? Calories { get; set; } // Per 100 grams

    [Column(Order = 7)]
    public Butik? Butik { get; set; }

    [Column(Order = 8)]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public List<Ingrediens>? Ingredienser { get; set; }
}
