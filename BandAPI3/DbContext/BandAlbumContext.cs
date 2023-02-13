using BandAPI3.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace BandAPI.DbContexts
{
   public class BandAlbumContext : DbContext
   {
      public BandAlbumContext(DbContextOptions<BandAlbumContext> options)
          : base(options)
      {
      }
      public DbSet<Band> Bands { get; set; }
      public DbSet<Album> Albums { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Band>().HasData(
            new Band()
            {
               Id = Guid.Parse("b8016090-dae8-4006-9662-8f6f9e454ace"),
               Name = "Metallica",
               Founded = new DateTime(1980, 1, 1),
               MainGenre = "Heavy Metal1"
            },
            new Band()
            {
               Id = Guid.Parse("b4941091-d8bf-4d46-a03a-e368e3c0cdbf"),
               Name = "name2",
               Founded = new DateTime(1981, 1, 1),
               MainGenre = "Heavy Metal2"
            },
            new Band()
            {
               Id = Guid.Parse("40964903-76b7-4ee4-991f-29c8a9f32dda"),
               Name = "name3",
               Founded = new DateTime(1982, 1, 1),
               MainGenre = "Heavy Metal3"
            },
             new Band()
             {
                Id = Guid.Parse("d57d3715-0788-44a7-acc2-1f6ec1abe5d9"),
                Name = "name4",
                Founded = new DateTime(1983, 1, 1),
                MainGenre = "Heavy Metal4"
             },
              new Band()
              {
                 Id = Guid.Parse("c76eec6b-5031-4ca9-8368-644ea37523c9"),
                 Name = "name5",
                 Founded = new DateTime(1984, 1, 1),
                 MainGenre = "Heavy Metal5"
              }
            );
         modelBuilder.Entity<Album>().HasData(
            new Album
            {
               Id = Guid.Parse("5d2efcf3-545d-4ca5-9d32-ecdcf2e05945"),
               Title = "Title22",
               Description = "Description2",
               BandId = Guid.Parse("b8016090-dae8-4006-9662-8f6f9e454ace")
            },
            new Album
            {
               Id = Guid.Parse("7dc0c19c-18ed-4f01-850d-dbbcdc8c62e2"),
               Title = "Title22",
               Description = "Description22",
               BandId = Guid.Parse("b4941091-d8bf-4d46-a03a-e368e3c0cdbf")
            },
            new Album
            {
               Id = Guid.Parse("63877e18-1a42-45fd-b207-991a9eeaa3c3"),
               Title = "Title22",
               Description = "Description222",
               BandId = Guid.Parse("40964903-76b7-4ee4-991f-29c8a9f32dda")
            },
            new Album
            {
               Id = Guid.Parse("dfc1d8ef-2064-4e8f-b916-b789b4f6a8f9"),
               Title = "Title22",
               Description = "Description2222",
               BandId = Guid.Parse("d57d3715-0788-44a7-acc2-1f6ec1abe5d9")
            },
            new Album
            {
               Id = Guid.Parse("5bf27928-d8b3-4e9a-832b-cc1d6fd6d93c"),
               Title = "Title22",
               Description = "Description22222",
               BandId = Guid.Parse("c76eec6b-5031-4ca9-8368-644ea37523c9")
            }
            );
         base.OnModelCreating(modelBuilder);
      }
   }
}
