using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class User
{
    [Key, Column(Order = 0)]
    public int Id { get; set; }

    [Column(Order = 1)]
    public required string Name { get; set; }

    [Column(Order = 2)]
    public required string Email { get; set; }

    [Column(Order = 3)]
    public string? Password { get; set; }

    [Column(Order = 4)]
    public Guid? Token { get; set; }

    [Column(Order = 5)]
    public DateTime? TokenExpiration { get; set; }

    [Column(Order = 6)]
    public DateTime? LastLogin { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
