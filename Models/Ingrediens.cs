using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Ingrediens
{
    [Key, Column(Order = 0)]
    public int Id { get; set; }

    public int RetId { get; set; }
    
    public Ret Ret { get; set; }

    public int ProduktId { get; set; }

    public Produkt Produkt { get; set;}

    public string? Note { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public required int Grams { get; set; }
}
