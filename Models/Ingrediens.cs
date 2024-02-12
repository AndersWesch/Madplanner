using System.ComponentModel.DataAnnotations;

namespace Models;

public class Ingrediens
{
    [Key]
    public int Id { get; set; }

    public int RetId { get; set; }
    
    public required Ret Ret { get; set; }

    public int ProduktId { get; set; }

    public required Produkt Produkt { get; set;}

    public string? Note { get; set; }

    public required int Grams { get; set; }
}
