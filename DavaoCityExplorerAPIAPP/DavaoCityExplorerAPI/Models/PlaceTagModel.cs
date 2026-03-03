namespace DavaoCityExplorerAPI.Models;

public class PlaceTagModel
{
    public int PlaceID { get; set; }
    public PlaceModel? Place { get; set; }
    public int TagID { get; set; }
    public TagModel? Tag { get; set; }
}
