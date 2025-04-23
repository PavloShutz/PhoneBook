using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

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

    public byte[] Bytes { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public static byte[] PhotoToBytes(Icon photo)
    {
        var ms = new MemoryStream();
        photo.Save(ms);
        return ms.ToArray();
    }

    public static Icon BytesArrayToPhoto(byte[] byteArray)
    {
        var ms = new MemoryStream(byteArray);
        var photo = new Icon(ms);
        return photo;
    }
}
