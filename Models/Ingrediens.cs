using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Ingrediens
{
    [Column(Order = 1)]
    public int RetId { get; set; }
    
    public Ret Ret { get; set; }

    [Column(Order = 2)]
    public int ProduktId { get; set; }

    public Produkt Produkt { get; set;}

    [Column(Order = 3)]
    public string? Note { get; set; }

    [Column(Order = 4)]
    public required int Grams { get; set; }

    [Column(Order = 5)]
    public DateTime CreatedAt { get; } = DateTime.Now;

    public double Price => ((double)Grams / (double)Produkt.Grams) * Produkt.Price;
    public double Calories => (double) ((double)Grams / 100.0) * Produkt.Calories;

    public double PriceRounded => Math.Round(Price, 2);
    public double CaloriesRounded => Math.Round(Calories, 2); 
}
