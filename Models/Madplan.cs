using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Madplan
{
    [Key, Column(Order = 0)]
    public int Id { get; set; }

    // public int UserId { get; set; }

    [Column(Order = 1)]
    public int Week { get; set; }

    [Column(Order = 2)]
    public int Year { get; set; }

    [Column(Order = 3)]
    public double Price { get; set; } = 0;

    [Column(Order = 4)]
    public double Calories { get; set; } = 0;

    public List<MadplanRet> MadplanRetter { get; set; } // Navigation property for the join table
    

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
