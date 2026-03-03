using System.ComponentModel.DataAnnotations;

namespace DavaoCityExplorerAPI.Models;

public class ImageModel
{
    [Key]
    public int ImageID { get; set; }
    public string ImageURL { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
