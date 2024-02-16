using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;

public class Ret 
{
    [Key, Column(Order = 0)]
    public int Id { get; set; }

    [Required, Column(Order = 1)]
    public required string Name { get; set; }

    [Required, Column(Order = 2)]
    public required string Description { get; set; }

    [Required, Column(Order = 3)]
    public required Category Category { get; set; }

    [Column(Order = 4)]
    public bool Vegetarian { get; set; } = false;

    [Column(Order = 5)]
    public bool PorkBased { get; set; } = false;

    [Column(Order = 6)]
    public bool Leftovers { get; set; } = false;

    [Column(Order = 7)]
    public bool Takeaway { get; set; } = false;

    [Column(Order = 8)]
    public bool IsPublic { get; set; } = true;

    [Column(Order = 9)]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public List<Ingrediens>? Ingredienser { get; set; }

    public List<MadplanRet>? MadplanRetter { get; set; }

    public double Price 
    {
        get
        {
            if (Ingredienser == null)
                return 0;

            double totalPrice = 0;
            foreach (var ingrediens in Ingredienser)
            {
                totalPrice += ingrediens.Price;
            }

            return Math.Round(totalPrice, 2);
        }
    }

    public double Calories 
    {
        get
        {
            if (Ingredienser == null)
                return 0;

            double totalCalories = 0;
            foreach (var ingrediens in Ingredienser)
            {
                totalCalories += ingrediens.Calories;
            }

            return Math.Round(totalCalories, 2);
        }
    }

    // Årstids specfikt

    // User
}
