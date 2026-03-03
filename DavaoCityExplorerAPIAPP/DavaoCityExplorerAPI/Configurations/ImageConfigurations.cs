using DavaoCityExplorerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DavaoCityExplorerAPI.Configurations;

public class ImageConfigurations : IEntityTypeConfiguration<ImageModel>
{
    public void Configure(EntityTypeBuilder<ImageModel> builder)
    {
        builder.HasData(
            new ImageModel { ImageID = 1, ImageURL = "/images/masonry-attractions.webp", Name = "Davao City Hall" },
            new ImageModel { ImageID = 2, ImageURL = "/images/masonry-shopping.webp", Name = "Davao Downtown Area" },
            new ImageModel { ImageID = 3, ImageURL = "/images/masonry-entertainment.webp", Name = "Davao Clubs" },
            new ImageModel { ImageID = 4, ImageURL = "/images/masonry-accommodations.webp", Name = "Marco Polo Building" },
            new ImageModel { ImageID = 5, ImageURL = "/images/masonry-foodscene.webp", Name = "Roxas Night Market" },
            new ImageModel { ImageID = 6, ImageURL = "/images/masonry-art&museum.webp", Name = "Davao Museum" },
            new ImageModel { ImageID = 7, ImageURL = "/images/eagle-center.webp", Name = "Philippine Eagle Center" },
            new ImageModel { ImageID = 8, ImageURL = "/images/eden-park.webp", Name = "Eden's Nature Park" },
            new ImageModel { ImageID = 9, ImageURL = "/images/peoples-park.webp", Name = "People's Park" },
            new ImageModel { ImageID = 11, ImageURL = "/images/poblacion-market.webp", Name = "Poblacion Market Central" },
            new ImageModel { ImageID = 12, ImageURL = "/images/abreeza-mall.webp", Name = "Abreeza Mall" },
            new ImageModel { ImageID = 13, ImageURL = "/images/matina-town-square.webp", Name = "Matina Town Square" },
            new ImageModel { ImageID = 14, ImageURL = "/images/jack-ridge.webp", Name = "Jack's Ridge" },
            new ImageModel { ImageID = 15, ImageURL = "/images/huckleberry-kitchen.webp", Name = "Huckleberry Southern Kitchen" },
            new ImageModel { ImageID = 16, ImageURL = "/images/pearl-farm.webp", Name = "Pearl Farm Beach Resort" },
            new ImageModel { ImageID = 17, ImageURL = "/images/abreeza-hotel.webp", Name = "Seda Abreeza Hotel" },
            new ImageModel { ImageID = 18, ImageURL = "/images/malagos-resort.webp", Name = "Malagos Garden Resort" },
            new ImageModel { ImageID = 19, ImageURL = "/images/yellowfin-restaurant.webp", Name = "Yellow Fin Seafood Restaurant" },
            new ImageModel { ImageID = 20, ImageURL = "/images/wishbone-restaurant.webp", Name = "The Wishbone Matina" },
            new ImageModel { ImageID = 21, ImageURL = "/images/penongs-restaurant.webp", Name = "Penongs Matina Branch" },
            new ImageModel { ImageID = 22, ImageURL = "/images/davao-museum.webp", Name = "Davao Museum of History" },
            new ImageModel { ImageID = 23, ImageURL = "/images/bone-museum.webp", Name = "D' Bone Collector Museum" },
            new ImageModel { ImageID = 24, ImageURL = "/images/kublai-art-garden.webp", Name = "Kublai Art Garden" }
        );
    }
}
