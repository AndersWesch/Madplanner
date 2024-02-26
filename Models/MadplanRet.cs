using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class MadplanRet
{

    [Key, Column(Order = 0)]
    public int MadplanId { get; set; }

    public Madplan Madplan { get; set; }

    [Key, Column(Order = 1)]
    public int? RetId { get; set; }
    
    public Ret Ret { get; set; }

    [Column(Order = 2)]
    public int Order { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
