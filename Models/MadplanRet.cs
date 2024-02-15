using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class MadplanRet
{
    [Key]
    public int Id { get; set; }

    [Key, Column(Order = 0)]
    public int MadplanId { get; set; }

    public required Madplan Madplan { get; set; }

    [Key, Column(Order = 1)]
    public int RetId { get; set; }
    
    public required Ret Ret { get; set; }
}
