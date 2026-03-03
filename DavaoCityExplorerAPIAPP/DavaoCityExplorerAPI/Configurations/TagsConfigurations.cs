using DavaoCityExplorerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TagsConfigurations : IEntityTypeConfiguration<TagModel>
{
    public void Configure(EntityTypeBuilder<TagModel> builder)
    {
        builder.HasData(
            new TagModel { TagID = 1, TagName = "Wildlife"},
            new TagModel { TagID = 2, TagName = "Conservation"},
            new TagModel { TagID = 3, TagName = "Nature"},
            new TagModel { TagID = 4, TagName = "Mountain Resort"},
            new TagModel { TagID = 5, TagName = "Adventure"},
            new TagModel { TagID = 6, TagName = "Hiking"},
            new TagModel { TagID = 7, TagName = "Public Park"},
            new TagModel { TagID = 8, TagName = "Family"},

            new TagModel { TagID = 9, TagName = "Street Food"},
            new TagModel { TagID = 12, TagName = "Thrifting"},
            new TagModel { TagID = 13, TagName = "Night Market"},
            new TagModel { TagID = 14, TagName = "Souvenirs"},
            new TagModel { TagID = 15, TagName = "Pearls"},
            new TagModel { TagID = 16, TagName = "Handicrafts"},
            new TagModel { TagID = 17, TagName = "Shopping Mall"},
            new TagModel { TagID = 18, TagName = "Convention"},
            new TagModel { TagID = 19, TagName = "Luxury"},

            new TagModel { TagID = 20, TagName = "Live Bands"},
            new TagModel { TagID = 21, TagName = "Food Park"},
            new TagModel { TagID = 22, TagName = "Nightlife"},
            new TagModel { TagID = 23, TagName = "City View"},
            new TagModel { TagID = 24, TagName = "Dining"},
            new TagModel { TagID = 25, TagName = "History"},
            new TagModel { TagID = 26, TagName = "Cocktails"},
            new TagModel { TagID = 27, TagName = "Heritage House"},
            new TagModel { TagID = 28, TagName = "Bar"}
        );
    }
}
