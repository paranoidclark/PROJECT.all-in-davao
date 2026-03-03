using DavaoCityExplorerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DavaoCityExplorerAPI.Configurations;

public class CategoryConfigurations : IEntityTypeConfiguration<CategoryModel> 
{
    public void Configure(EntityTypeBuilder<CategoryModel> builder)
    {
        builder.HasData(
            new CategoryModel { CategoryID = 1, Path = "/attractions", Title = "Discover Nature’s Grandest Stage", Description = "From the majestic peaks of Mt. Apo to the sanctuary of the Philippine Eagle, witness the icons that define the South.", ImageID = 1},
            new CategoryModel { CategoryID = 2, Path = "/shopping", Title = "Malls, Markets & Memories", Description = "Hunt for authentic pearls, weave through bustling night markets, or enjoy world-class retail therapy in the heart of the city.", ImageID = 2},
            new CategoryModel { CategoryID = 3, Path = "/entertainment", Title = "The Pulse of the City", Description = "Experience the vibrant nightlife, live local music, and the festive spirit that comes alive when the sun goes down.", ImageID = 3},
            new CategoryModel { CategoryID = 4, Path = "/accommodation", Title = "Your Home in the South", Description = "Whether you seek 5-star luxury by the sea or a cozy backpacker’s haven, find your perfect sanctuary here.", ImageID = 4},
            new CategoryModel { CategoryID = 5, Path = "/foodscene", Title = "A Feast of Flavors", Description = "Dare to taste the King of Fruits, savor the freshest Tuna, and dive into a culinary landscape you won’t find anywhere else.", ImageID = 5},
            new CategoryModel { CategoryID = 6, Path = "/art&museum", Title = "The Soul of Davao", Description = "Walk through time at the museums, meet the 11 tribes, and discover the rich heritage that weaves the city together.", ImageID = 6}
        );
    }
}
