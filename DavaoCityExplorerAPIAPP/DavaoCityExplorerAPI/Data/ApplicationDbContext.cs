using DavaoCityExplorerAPI.Configurations;
using DavaoCityExplorerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DavaoCityExplorerAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<ImageModel> Images { get; set; }
    public DbSet<TagModel> Tags { get; set; }
    public DbSet<CategoryModel> Categories { get; set; }
    public DbSet<PlaceModel> Places { get; set; }
    public DbSet<PlaceTagModel> PlaceTags { get; set; }
    public DbSet<UserModel> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PlaceModel>()
            .HasOne(p => p.Image)
            .WithMany()
            .HasForeignKey(p => p.ImageID)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PlaceTagModel>().HasKey(pt => new { pt.PlaceID, pt.TagID });
        modelBuilder.Entity<PlaceTagModel>()
            .HasOne(pt => pt.Place)
            .WithMany(pt => pt.PlaceTags)
            .HasForeignKey(pt => pt.PlaceID);
        modelBuilder.Entity<PlaceTagModel>()
            .HasOne(pt => pt.Tag)
            .WithMany()
            .HasForeignKey(pt => pt.TagID);

        modelBuilder.ApplyConfiguration(new ImageConfigurations());
        modelBuilder.ApplyConfiguration(new CategoryConfigurations());
        modelBuilder.ApplyConfiguration(new TagsConfigurations());
        modelBuilder.ApplyConfiguration(new PlacesConfigurations());
        modelBuilder.ApplyConfiguration(new PlaceTagsConfigurations());
    }
    
}
