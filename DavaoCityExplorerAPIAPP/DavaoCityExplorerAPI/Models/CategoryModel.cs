using System.ComponentModel.DataAnnotations;

namespace DavaoCityExplorerAPI.Models;

public class CategoryModel
{
    [Key]
    public int CategoryID { get; set; }
    public string Path { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public int ImageID { get; set; }
    public ImageModel? Image { get; set; }
}
