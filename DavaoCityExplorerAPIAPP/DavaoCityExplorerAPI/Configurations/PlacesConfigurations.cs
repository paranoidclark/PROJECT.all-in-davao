using DavaoCityExplorerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PlacesConfigurations : IEntityTypeConfiguration<PlaceModel>
{
    public void Configure(EntityTypeBuilder<PlaceModel> builder)
    {
        builder.HasData(
            new PlaceModel { PlaceID = 1, Name = "Philippine Eagle Center", Location = "Malagos, Baguio District", Rating = 4.8, CategoryID = 1, ImageID = 7 },
            new PlaceModel { PlaceID = 2, Name = "Eden Nature Park", Location = "Toril, Davao City", Rating = 4.7, CategoryID = 1, ImageID = 8 },
            new PlaceModel { PlaceID = 3, Name = "People's Park", Location = "Palma Gil St, Poblacion", Rating = 4.5, CategoryID = 1, ImageID = 9 },

            new PlaceModel { PlaceID = 4, Name = "Roxas Night Market", Location = "Roxas Avenue", Rating = 4.8, CategoryID = 2, ImageID = 5 },
            new PlaceModel { PlaceID = 5, Name = "Poblacion Market Central", Location = "C. Bangoy St, Poblacion", Rating = 4.6, CategoryID = 2, ImageID = 11 },
            new PlaceModel { PlaceID = 6, Name = "Abreeza Mall", Location = "J.P. Laurel Ave, Poblacion District", Rating = 4.7, CategoryID = 2, ImageID = 12},
           
            new PlaceModel { PlaceID = 7, Name = "Matina Town Square (MTS)", Location = "McArthur Highway, Matina", Rating = 4.5, CategoryID = 3, ImageID = 13 },
            new PlaceModel { PlaceID = 8, Name = "Jack's Ridge", Location = "Shrine Hills, Matina", Rating = 4.6, CategoryID = 3, ImageID = 14 },
            new PlaceModel { PlaceID = 9, Name = "Huckleberry Southern Kitchen", Location = "Oboza Compound, Rizal St", Rating = 4.4, CategoryID = 3, ImageID = 15 },

            new PlaceModel { PlaceID = 10, Name = "Pearl Farm Beach Resort", Location = "Samal Island", Rating = 4.9, CategoryID = 4, ImageID = 16 },
            new PlaceModel { PlaceID = 11, Name = "Seda Abreeza Hotel", Location = "J.P. Laurel Ave, Bajada", Rating = 4.7, CategoryID = 4, ImageID = 17 },
            new PlaceModel { PlaceID = 12, Name = "Malagos Garden Resort", Location = "Malagos, Calinan", Rating = 4.6, CategoryID = 4, ImageID = 18 },

            new PlaceModel { PlaceID = 13, Name = "Yellow Fin Seafood Restaurant", Location = "Quimpo Blvd, Ecoland", Rating = 4.7, CategoryID = 5, ImageID = 19 },
            new PlaceModel { PlaceID = 14, Name = "The Wishbone", Location = "Water District Matina, Along Gen. Douglas MacArthur Hwy,", Rating = 4.8, CategoryID = 5, ImageID = 20 },
            new PlaceModel { PlaceID = 15, Name = "Penong's Matina Aplaya", Location = "Erya Bldg, Pag-Asa Village", Rating = 4.5, CategoryID = 5, ImageID = 21 },

            new PlaceModel { PlaceID = 16, Name = "Davao Museum of History", Location = "Insular Village, Lanang", Rating = 4.6, CategoryID = 6, ImageID = 22 },
            new PlaceModel { PlaceID = 17, Name = "D' Bone Collector Museum", Location = "San Pedro St, Poblacion", Rating = 4.8, CategoryID = 6, ImageID = 23 },
            new PlaceModel { PlaceID = 18, Name = "Kublai Art Garden", Location = "Kapatagan, Digos (Nearby)", Rating = 4.7, CategoryID = 6, ImageID = 24 }
        );
    }
}