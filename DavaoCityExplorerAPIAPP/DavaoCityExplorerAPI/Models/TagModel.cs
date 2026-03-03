using System.ComponentModel.DataAnnotations;

namespace DavaoCityExplorerAPI.Models;

public class TagModel
{
    [Key]
    public int TagID { get; set; }
    public string TagName { get; set; } = string.Empty;
}
