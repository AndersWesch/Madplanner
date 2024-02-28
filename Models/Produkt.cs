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
    public int Grams { get; set; }

    [Column(Order = 6)]
    public int Calories { get; set; } // Per 100 grams

    [Column(Order = 7)]
    public Butik? Butik { get; set; }

    [Column(Order = 8)]
    public int? Varenummer { get; set; }

    [Column(Order = 9)]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Column(Order = 10)]
    public double? TilbudPrice { get; set; }

    [Column(Order = 11)]
    public DateTime? TilbudStartingAt { get; set; }

    [Column(Order = 12)]
    public DateTime? TilbudEndingAt { get; set; }

    [Column(Order = 13)]
    public DateTime? TilbudDataUpdatedAt { get; set; }

    [Column(Order = 14)]
    public string? ImageUrl { get; set; }

    public string? SeedKey { get; set; }

    public List<Ingrediens>? Ingredienser { get; set; }
}
