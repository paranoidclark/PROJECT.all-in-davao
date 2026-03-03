using System.ComponentModel.DataAnnotations;

namespace DavaoCityExplorerAPI.Models;

public class PlaceModel
{
    [Key]
    public int PlaceID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public double Rating { get; set; }

    public int CategoryID { get; set; }
    public CategoryModel? Category { get; set; }

    public int ImageID { get; set; }
    public ImageModel? Image { get; set; }

    public List<PlaceTagModel> PlaceTags { get; set; } = new List<PlaceTagModel>();
}
