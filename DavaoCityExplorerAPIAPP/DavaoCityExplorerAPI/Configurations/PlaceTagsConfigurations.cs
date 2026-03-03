using DavaoCityExplorerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PlaceTagsConfigurations : IEntityTypeConfiguration<PlaceTagModel>
{
    public void Configure(EntityTypeBuilder<PlaceTagModel> builder)
    {
        builder.HasData(
            new PlaceTagModel { PlaceID = 1, TagID = 1 }, 
            new PlaceTagModel { PlaceID = 1, TagID = 2 }, 
            new PlaceTagModel { PlaceID = 1, TagID = 3 }, 

            new PlaceTagModel { PlaceID = 2, TagID = 4 }, 
            new PlaceTagModel { PlaceID = 2, TagID = 5 },
            new PlaceTagModel { PlaceID = 2, TagID = 6 }, 

            new PlaceTagModel { PlaceID = 3, TagID = 7 },
            new PlaceTagModel { PlaceID = 3, TagID = 8 }, 
            new PlaceTagModel { PlaceID = 3, TagID = 25 },

            new PlaceTagModel { PlaceID = 4, TagID = 9 }, 
            new PlaceTagModel { PlaceID = 4, TagID = 12 },
            new PlaceTagModel { PlaceID = 4, TagID = 13 }, 

            new PlaceTagModel { PlaceID = 5, TagID = 14 }, 
            new PlaceTagModel { PlaceID = 5, TagID = 15 },
            new PlaceTagModel { PlaceID = 5, TagID = 16 }, 

            new PlaceTagModel { PlaceID = 6, TagID = 17 }, 
            new PlaceTagModel { PlaceID = 6, TagID = 18 }, 
            new PlaceTagModel { PlaceID = 6, TagID = 19 },

            new PlaceTagModel { PlaceID = 7, TagID = 20 }, 
            new PlaceTagModel { PlaceID = 7, TagID = 21 },
            new PlaceTagModel { PlaceID = 7, TagID = 22 }, 

            new PlaceTagModel { PlaceID = 8, TagID = 23 },
            new PlaceTagModel { PlaceID = 8, TagID = 24 },
            new PlaceTagModel { PlaceID = 8, TagID = 25 },

            new PlaceTagModel { PlaceID = 9, TagID = 26 },
            new PlaceTagModel { PlaceID = 9, TagID = 27 },
            new PlaceTagModel { PlaceID = 9, TagID = 28 },

            new PlaceTagModel { PlaceID = 10, TagID = 19 },
            new PlaceTagModel { PlaceID = 10, TagID = 8 },

            new PlaceTagModel { PlaceID = 11, TagID = 23 }, 
            new PlaceTagModel { PlaceID = 11, TagID = 24 }, 
            new PlaceTagModel { PlaceID = 11, TagID = 19 }, 

            new PlaceTagModel { PlaceID = 12, TagID = 3 }, 
            new PlaceTagModel { PlaceID = 12, TagID = 2 },
            new PlaceTagModel { PlaceID = 12, TagID = 16 }, 

            new PlaceTagModel { PlaceID = 13, TagID = 24 }, 
            new PlaceTagModel { PlaceID = 13, TagID = 28 }, 

            new PlaceTagModel { PlaceID = 14, TagID = 24 },

            new PlaceTagModel { PlaceID = 15, TagID = 24 }, 

            new PlaceTagModel { PlaceID = 16, TagID = 25 },
            new PlaceTagModel { PlaceID = 16, TagID = 2 },
            new PlaceTagModel { PlaceID = 16, TagID = 3 },

            new PlaceTagModel { PlaceID = 17, TagID = 25 },
            new PlaceTagModel { PlaceID = 17, TagID = 2 }, 
            new PlaceTagModel { PlaceID = 17, TagID = 3 }, 

            new PlaceTagModel { PlaceID = 18, TagID = 25 }, 
            new PlaceTagModel { PlaceID = 18, TagID = 2 },
            new PlaceTagModel { PlaceID = 18, TagID = 16 } 
        );
    }
}