using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ArtChart2.Models;

namespace ArtChart2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Artwork> Artwork { get; set; }
        public DbSet<Artist> Artists { get; set; }
       

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<Artwork>().HasData(
        //         new Artwork()
        //         {
        //             ArtworkId = 1,
        //             Title = "We Cross the Sky",
        //             Price = 1500.00,
        //             Medium = "Oil on Canvas",
        //             ArtTypeId = 1,
        //             ArtistId = Artist.Id

        //         },
        //         new Artwork()
        //         {
        //             ArtworkId = 2,
        //             Title = "When Words Complicate",
        //             Price = 900.00,
        //             Medium = "Oil on Canvas",
        //             ArtTypeId = 1,
        //             //ArtistId = Artist.Id

        //         },
        //          new Artwork()
        //          {
        //              ArtworkId = 2,
        //              Title = "Awakening",
        //              Price = 1500.00,
        //              Medium = "Oil on Canvas",
        //              ArtTypeId = 1,
        //              //ArtistId = Artist.Id
        //          }
        //      );
        //        modelBuilder.Entity<ArtType>().HasData(
        //         new ArtType()
        //         {
        //             ArtTypeId = 1,
        //             Category = "Painting"
        //         },
        //         new ArtType()
        //         {
        //             ArtTypeId = 2,
        //             Category = "Drawing"
        //         },
        //         new ArtType()
        //         {
        //             ArtTypeId = 3,
        //             Category = "Sculpture"
        //         }
        //         );


        //        modelBuilder.Entity<Artist>().HasData(
        //        new Artist()
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            FirstName = "Emily",
        //            LastName = "Venturino",
        //            StreetAddress = "100 street"

        //        },
        //        new Artist()
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            FirstName = "Lauren",
        //            LastName = "Jones",
        //            StreetAddress = "101 street"
        //        },

        //        new Artist()
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            FirstName = "Ashley",
        //            LastName = "Smith",
        //            StreetAddress = "120 street"

        //        }
        //      );
        //        base.OnModelCreating(modelBuilder);

        //    }
        //}
    }
}