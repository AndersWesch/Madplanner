using System.ComponentModel.DataAnnotations;

namespace Models;

public class Madplan
{
    [Key]
    public int Id { get; set; }

    public int Week { get; set; }

    // public int UserId { get; set; }

    public List<MadplanRet>? MadplanRetter { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
