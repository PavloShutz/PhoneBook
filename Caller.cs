using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Phone_Book;

public class Caller
{
    public int CallerId { get; set; }
    
    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Number { get; set; }

    [Required]
    public string? Email { get; set; }

    [Required]
    public string? Address { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}
